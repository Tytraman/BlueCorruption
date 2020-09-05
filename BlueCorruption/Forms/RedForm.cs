using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using BlueCorruption.src;

namespace BlueCorruption.Forms {
    public partial class RedForm : Form {
        private Options options = new Options();
        private Corruptor corruptor = new Corruptor();


        // Initialisation de la form
        public RedForm() {
            Util.DeleteTempFiles();
            InitializeComponent();
            starting_byte_menu.Maximum = int.MaxValue;
            ending_byte_menu.Maximum = int.MaxValue;
            corrupt_every_menu.Maximum = int.MaxValue;
            byte_to_change_menu.Maximum = byte.MaxValue;
            changing_byte_menu.Maximum = byte.MaxValue;
            move_away_menu.Maximum = int.MaxValue;
            options.ByteToChange = decimal.ToByte(byte_to_change_menu.Value);
            options.ChangingByte = decimal.ToByte(changing_byte_menu.Value);
            options.MoveAway = decimal.ToInt32(move_away_menu.Value);
            options.RandomExtraValues = false;
            min_random_extra_menu_1.Maximum = int.MaxValue;
            max_random_extra_menu_1.Maximum = int.MaxValue;
            min_random_extra_menu_2.Maximum = int.MaxValue;
            max_random_extra_menu_2.Maximum = int.MaxValue;
            options.MinRandomExtra1 = decimal.ToInt32(min_random_extra_menu_1.Value);
            options.MaxRandomExtra1 = decimal.ToInt32(max_random_extra_menu_1.Value);
            options.MinRandomExtra2 = decimal.ToInt32(min_random_extra_menu_2.Value);
            options.MaxRandomExtra2 = decimal.ToInt32(max_random_extra_menu_2.Value);
            foreach(Presets pre in Enum.GetValues(typeof(Presets))) {
                switch(pre) {
                    case Presets.DEBUG:
                        presets_menu.Items.Add("Debug");
                        break;
                    case Presets.NO_CHANGE:
                        presets_menu.Items.Add("Aucun changement");
                        break;
                    case Presets.MOVE_RIGHT:
                        presets_menu.Items.Add("Déplacer vers la droite");
                        break;
                    case Presets.CHANGE_BYTE_BY:
                        presets_menu.Items.Add("Changer une valeur par une autre");
                        break;
                }
            }
            Presets preset = (Presets) Enum.Parse(typeof(Presets), options.GetValue("preset"));
            presets_menu.SelectedIndex = (int) preset;
            UpdateExtraMenu(preset);
            options.RandomExtraValues = randoms_extra_values_checkbox.Checked;
            default_save_path_menu.Text = options.GetValue("default-save-path");
            auto_save_checkbox.Checked = options.GetValue("auto-save").Equals("true", StringComparison.OrdinalIgnoreCase);
            auto_open_checkbox.Checked = options.GetValue("auto-open-file").Equals("true", StringComparison.OrdinalIgnoreCase);
            string processPath = options.GetValue("process-path");
            process_label.Text = $"Programme: {(File.Exists(processPath) ? processPath.Substring(processPath.LastIndexOf(Path.DirectorySeparatorChar) + 1) : "Aucun")}";
            Static.Result = result_label.Text;
        }


        // Bouton pour sélectionner un fichier
        private void rom_selector_button_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog() {
                Title = "Sélectionner un fichier",
                Filter = "Tous les fichiers|*.*|Images PNG|*.png|Images JPG|*.jpg;*.jpeg|Images GIF|*.gif|Sons MP3|*.mp3|Vidéos MP4|*.mp4|Fichiers SNES|*.smc|Fichiers NDS|*.nds",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            }) {
                if(dialog.ShowDialog() == DialogResult.OK) {
                    UpdateFileSelection(dialog.FileName);
                }
            };
        }

        // Preset changé
        private void presets_menu_SelectedIndexChanged(object sender, EventArgs e) {
            Presets preset = (Presets) presets_menu.SelectedIndex;
            UpdateExtraMenu(preset);
            options.Changes.Add("preset", preset.ToString());
            options.Save();
            UpdateRandomExtra();
        }

        private void process_button_Click(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog() {
                Title = "Sélectionner un programme",
                Filter = "Exécutable (*.exe)|*.exe",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            }) {
                if(dialog.ShowDialog() == DialogResult.OK) {
                    options.Changes.Add("process-path", dialog.FileName);
                    options.Save();
                    string processPath = options.GetValue("process-path");
                    process_label.Text = $"Programme: {(File.Exists(processPath) ? processPath.Substring(processPath.LastIndexOf(Path.DirectorySeparatorChar) + 1) : "Aucun")}";
                }
            }
        }

        // Bouton pour corrompre
        private void corrupt_button_Click(object sender, EventArgs e) {
            try {
                switch(corruptor.Start(options, decimal.ToInt32(starting_byte_menu.Value), decimal.ToInt32(ending_byte_menu.Value), decimal.ToInt32(corrupt_every_menu.Value))) {
                    case -5:
                        MessageBox.Show("Le minimum de la plage de valeurs aléatoires doit être inférieur au maximum. (-5)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -4:
                        MessageBox.Show("La valeur \"every\" doit être supérieur à 0. (-4)");
                        break;
                    case -3:
                        MessageBox.Show("La valeur \"starting\" doit être inférieur à \"ending\". (-3)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -2:
                        MessageBox.Show("Le preset sélectionné n'a pas encore été configuré. (-2)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -1:
                        MessageBox.Show("La valeur \"ending\" ne peut pas dépasser le nombre max de bytes dans la ROM. (-1)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 0:
                        MessageBox.Show("Annulé. (0)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        time_label.Text = Static.Result;
                        string processPath = options.GetValue("process-path")
                            .Replace('\\', Path.DirectorySeparatorChar)
                            .Replace('/', Path.DirectorySeparatorChar).Trim();
                        if(options.GetValue("auto-open-file").Equals("true", StringComparison.OrdinalIgnoreCase)) {
                            result_label.Text = "Lancement du processus...";
                            if(File.Exists(processPath)) {
                                ProcessStartInfo startInfo = new ProcessStartInfo(processPath, $"\"{corruptor.TempFile}\"") {
                                    WindowStyle = ProcessWindowStyle.Normal
                                };
                                Process process = Process.Start(startInfo);
                                long now = Util.Now();
                                result_label.Text = "En attente de la fermeture du processus...";
                                process.WaitForExit();
                                result_label.Text = "Le processus est resté ouvert " + (Util.Now() - now) + " ms.";
                            }else {
                                Process.Start(corruptor.TempFile);
                            }
                        }
                        if(options.GetValue("auto-save").Equals("true", StringComparison.OrdinalIgnoreCase)) {
                            corruptor.DefaultSave(options);
                        }else {
                            if(Util.WantToSave()) {
                                corruptor.Save();
                            }
                        }
                        break;
                    case 2:
                        break;
                    default:
                        MessageBox.Show("Erreur inconnue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            } catch(NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Valeur du byte à modifier changée
        private void byte_to_change_menu_ValueChanged(object sender, EventArgs e) {
            options.ByteToChange = decimal.ToByte(byte_to_change_menu.Value);
        }

        // Valeur du byte à mettre changée
        private void changing_byte_menu_ValueChanged(object sender, EventArgs e) {
            options.ChangingByte = decimal.ToByte(changing_byte_menu.Value);
        }

        // Bouton pour enlever le processus à lancer après la corruption
        private void reset_process_button_Click(object sender, EventArgs e) {
            options.Changes.Add("process-path", "-1");
            options.Save();
            process_label.Text = "Programme: Aucun";
        }


        // Quand le logiciel est fermé
        private void RedForm_FormClosing(object sender, FormClosingEventArgs e) {
            Util.DeleteTempFiles();
        }

        // Quand l'emplacement de sauvegarde par défaut est modifié
        private void default_save_menu_TextChanged(object sender, EventArgs e) {
            string ppath = default_save_path_menu.Text;
            if(!ppath.EndsWith(Path.DirectorySeparatorChar.ToString())) {
                ppath += Path.DirectorySeparatorChar;
            }
            options.Changes.Add("default-save-path", ppath);
            options.Save();
        }

        // Bouton pour sélectionner un emplacement de sauvegarde par défaut
        private void default_save_selector_Click(object sender, EventArgs e) {
            using(FolderBrowserDialog dialog = new FolderBrowserDialog() {
                Description = "Sélectionner un emplacement de sauvegarde par défaut:",
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = true
            }) {
                if(dialog.ShowDialog() == DialogResult.OK) {
                    string ppath = dialog.SelectedPath + Path.DirectorySeparatorChar;
                    default_save_path_menu.Text = ppath;
                }
            }
        }

        // Valeur de la distance en bytes changée
        private void move_away_menu_ValueChanged(object sender, EventArgs e) {
            options.MoveAway = decimal.ToInt32(move_away_menu.Value);
        }


        // Rendre invisible tous les menus extras
        private void DisableAllExtraMenu() {
            byte_to_change_menu.Visible = false;
            changing_byte_menu.Visible = false;
            by_label.Visible = false;
            move_away_menu.Visible = false;
            distance_label.Visible = false;
        }


        // Mettre à jour la visibilité des menus extras
        private void UpdateExtraMenu(Presets preset) {
            DisableAllExtraMenu();
            switch(preset) {
                case Presets.MOVE_RIGHT:
                    move_away_menu.Visible = true;
                    distance_label.Visible = true;
                    break;
                case Presets.CHANGE_BYTE_BY:
                    byte_to_change_menu.Visible = true;
                    changing_byte_menu.Visible = true;
                    by_label.Visible = true;
                    break;
            }
        }

        // Checkbox pour auto-save
        private void auto_save_checkbox_CheckedChanged(object sender, EventArgs e) {
            options.Changes.Add("auto-save", auto_save_checkbox.Checked.ToString());
            options.Save();
        }

        // Checkbox pour ouvrir automatiquement le fichier corrompu
        private void auto_open_checkbox_CheckedChanged(object sender, EventArgs e) {
            options.Changes.Add("auto-open-file", auto_open_checkbox.Checked.ToString());
            options.Save();
        }

        // Checkbox pour activer ou non les valeurs aléatoires pour les options extras
        private void randoms_extra_values_checkbox_CheckedChanged(object sender, EventArgs e) {
            options.RandomExtraValues = randoms_extra_values_checkbox.Checked;
            UpdateRandomExtra();
        }

        // Valeur aléatoire minimale pour les options extras 1
        private void min_random_extra_menu_ValueChanged(object sender, EventArgs e) {
            options.MinRandomExtra1 = decimal.ToInt32(min_random_extra_menu_1.Value);
        }

        // Valeur aléatoire maximale pour les options extras 1
        private void max_random_extra_menu_ValueChanged(object sender, EventArgs e) {
            options.MaxRandomExtra1 = decimal.ToInt32(max_random_extra_menu_1.Value);
        }

        // Valeur aléatoire minimale pour les options extras 2
        private void min_random_extra_menu_2_ValueChanged(object sender, EventArgs e) {
            options.MinRandomExtra2 = decimal.ToInt32(min_random_extra_menu_2.Value);
        }

        // Valeur aléatoire maximale pour les options extras 2
        private void max_random_extra_menu_2_ValueChanged(object sender, EventArgs e) {
            options.MaxRandomExtra2 = decimal.ToInt32(max_random_extra_menu_2.Value);
        }

        // Mettre à jour la visibilité des components aléatoires des options extras
        private void UpdateRandomExtra() {
            bool enabled = options.RandomExtraValues;
            Presets preset = (Presets) Enum.Parse(typeof(Presets), options.GetValue("preset"));
            random_extra_label1_1.Visible = enabled;
            random_extra_label2_1.Visible = enabled;
            min_random_extra_menu_1.Visible = enabled;
            max_random_extra_menu_1.Visible = enabled;

            bool enabled2 = preset == Presets.CHANGE_BYTE_BY;
            random_extra_label1_2.Visible = enabled && enabled2;
            random_extra_label2_2.Visible = enabled && enabled2;
            min_random_extra_menu_2.Visible = enabled && enabled2;
            max_random_extra_menu_2.Visible = enabled && enabled2;
        }

        // Quand un fichier passe par dessus le bouton de sélection de fichier
        private void file_selector_button_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
                if(files.Length == 1) {
                    e.Effect = DragDropEffects.Copy;
                }else {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        // Quand on drop un fichier sur le bouton de sélection d'un fichier
        private void file_selector_button_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            if(files.Length == 1) {
                UpdateFileSelection(files[0]);
            }
        }

        private void UpdateFileSelection(string path) {
            corruptor.Path = path;
            file_selector_label.Text = "Fichier: " + path.Substring(path.LastIndexOf(Path.DirectorySeparatorChar) + 1);
            bytes_number_label.Text = $"{Util.NumberWithSpaces(corruptor.OriginalBytes.Length)} bytes";
        }
    }



    public static class Static {
        public static string Result { get; set; }
    }
}
