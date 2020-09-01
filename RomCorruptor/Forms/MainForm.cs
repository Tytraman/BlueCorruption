using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using RomCorruptor.src;

namespace RomCorruptor.Forms {
    public partial class MainForm : Form {
        private Options options = new Options();
        private Corruptor corruptor = new Corruptor();


        public MainForm() {
            InitializeComponent();
            starting_byte_menu.Maximum = int.MaxValue;
            ending_byte_menu.Maximum = int.MaxValue;
            corrupt_every_menu.Maximum = int.MaxValue;
            presets_menu.Items.AddRange(Enum.GetNames(typeof(Presets)));
            presets_menu.SelectedIndex = (int) Enum.Parse(typeof(Presets), options.GetValue("preset"));
            try {
                Util.CreateFolders();
            } catch(Exception) {
                rom_selector_label.Text = "Impossible de créer les dossiers d'installation.";
                rom_selector_button.Enabled = false;
                // Tous les autres boutons
            }
            string emulatorPath = options.GetValue("emulator-path");
            emulator_label.Text = $"Émulateur: {(File.Exists(emulatorPath) ? emulatorPath.Substring(emulatorPath.LastIndexOf(Path.DirectorySeparatorChar) + 1) : "Aucun")}";
            Static.Result = result_label.Text;
        }


        private void rom_selector_button_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog() {
                Title = "Sélectionner une ROM",
                Filter = "Fichiers SNES (*.smc)|*.smc",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            }) {
                if(dialog.ShowDialog() == DialogResult.OK) {
                    corruptor.Path = dialog.FileName;
                    rom_selector_label.Text = "ROM: " + dialog.FileName.Substring(dialog.FileName.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                }
            };
        }

        private void presets_menu_SelectedIndexChanged(object sender, EventArgs e) {
            options.Changes.Add("preset", ((Presets) presets_menu.SelectedIndex).ToString());
            options.Save();
        }

        private void emulator_button_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog() {
                Title = "Sélectionner un émulateur",
                Filter = "Exécutable (*.exe)|*.exe",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            }) {
                if(dialog.ShowDialog() == DialogResult.OK) {
                    options.Changes.Add("emulator-path", dialog.FileName);
                    options.Save();
                    string emulatorPath = options.GetValue("emulator-path");
                    emulator_label.Text = $"Émulateur: {(File.Exists(emulatorPath) ? emulatorPath.Substring(emulatorPath.LastIndexOf(Path.DirectorySeparatorChar) + 1) : "Aucun")}";
                }
            }
        }

        private void corrupt_button_Click(object sender, EventArgs e) {
            try {
                switch(corruptor.Start(options, Decimal.ToInt32(starting_byte_menu.Value), Decimal.ToInt32(ending_byte_menu.Value), Decimal.ToInt32(corrupt_every_menu.Value))) {
                    case -2:
                        result_label.Text = "[!] Le preset sélectionné n'a pas encore été configuré. (-2)";
                        break;
                    case -1:
                        result_label.Text = "[!] La valeur \"ending\" ne peut pas dépasser le nombre max de bytes dans la ROM. (-1)";
                        break;
                    case 0:
                        result_label.Text = "[!] Annulé. (0)";
                        break;
                    case 1:
                        time_label.Text = Static.Result;
                        string emulatorPath = options.GetValue("emulator-path")
                            .Replace('\\', Path.DirectorySeparatorChar)
                            .Replace('/', Path.DirectorySeparatorChar).Trim();
                        if(File.Exists(emulatorPath)) {
                            result_label.Text = "Lancement de la ROM.";
                            ProcessStartInfo startInfo = new ProcessStartInfo(emulatorPath) {
                                WindowStyle = ProcessWindowStyle.Normal,
                                Arguments = "\"" + corruptor.TempRom + "\""
                            };
                            Process process = Process.Start(startInfo);
                            long now = Util.Now();
                            result_label.Text = "En attente de la fermeture de l'émulateur...";
                            process.WaitForExit();
                            result_label.Text = "L'émulateur est resté ouvert " + (Util.Now() - now) + " ms.";
                        }
                        if(Util.WantToSave()) {
                            corruptor.Save();
                        }
                        break;
                    default:
                        result_label.Text = "[!] Erreur inconnue.";
                        break;
                }
            }catch(NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



    public static class Static {
        public static string Result { get; set; }
    }
}
