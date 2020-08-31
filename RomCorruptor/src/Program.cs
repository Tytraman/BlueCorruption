using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using RomCorruptor.src;
using System.Diagnostics;

namespace RomCorruptor {
    public static class Program {

        [STAThread]
        static void Main(string[] arg) {
            Console.Title = "RomCorruptor - Aucune rom sélectionnée...";
            try {
                Util.CreateFolders();
            }catch(Exception) {
                Helper.InstallError();
                Console.ReadLine();
                Environment.Exit(-1);
            }
            char separator = Path.DirectorySeparatorChar;
            Console.WriteLine("Bienvenue dans ROM corruptor!\n\n");
            Helper.Help();
            Console.WriteLine("\n");
            Options options = new Options();
            Corruptor corruptor = new Corruptor();
            while(true) {
                string line = Console.ReadLine();
                if(line.Trim().Length > 0) {
                    string[] args = line.Split(' ');
                    string command = args[0];
                    // J'fais ça pour enlever le nom de la commande des arguments
                    List<string> tempA = new List<string>(args);
                    tempA.RemoveAt(0);
                    args = tempA.ToArray();
                    switch(command) {
                        case "emulator-path":
                            using(OpenFileDialog dialog = new OpenFileDialog() { 
                                Title = "Sélectionner un émulateur",
                                Filter = "Exécutable (*.exe)|*.exe",
                                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                            }) {
                                if(dialog.ShowDialog() == DialogResult.OK) {
                                    options.Changes.Add("emulator-path", dialog.FileName);
                                    options.Save();
                                }
                            }
                                break;
                        case "select":
                            using(OpenFileDialog dialog = new OpenFileDialog() {
                                Title = "Sélectionner une ROM",
                                Filter = "Fichiers SNES (*.smc)|*.smc",
                                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                            }) {
                                if(dialog.ShowDialog() == DialogResult.OK) {
                                    corruptor.Path = dialog.FileName;
                                    Console.WriteLine("Rom sélectionée!");
                                    Console.Title = "RomCorruptor - " + dialog.FileName.Substring(dialog.FileName.LastIndexOf(separator) + 1);
                                }
                            };
                            break;
                        case "setpreset":
                            if(args.Length > 0) {
                                if(Enum.TryParse(args[0].ToUpper(), out Presets preset)) {
                                    options.Changes.Add("preset", preset.ToString());
                                    options.Save();
                                    Console.WriteLine($"Preset changé en {preset}.");
                                }else {
                                    Console.WriteLine("[!] Argument invalide.");
                                }
                            }else {
                                Console.WriteLine("[?] Argument manquant.");
                            }
                            break;
                        case "start":
                            if(args.Length > 2) {
                                if(int.TryParse(args[0], out int starting) && int.TryParse(args[1], out int ending) && int.TryParse(args[2], out int every)) {
                                    try {
                                        switch(corruptor.Start(options, starting, ending, every)) {
                                            case -2:
                                                Console.WriteLine("[!] Le preset sélectionné n'a pas encore été configuré. (-2)");
                                                break;
                                            case -1:
                                                Console.WriteLine("[!] La valeur \"ending\" ne peut pas dépasser le nombre max de bytes dans la ROM. (-1)");
                                                break;
                                            case 0:
                                                Console.WriteLine("[!] Annulé. (0)");
                                                break;
                                            case 1:
                                                string emulatorPath = options.GetValue("emulator-path")
                                                    .Replace('\\', Path.DirectorySeparatorChar)
                                                    .Replace('/', Path.DirectorySeparatorChar).Trim();
                                                if(File.Exists(emulatorPath)) {
                                                    Console.WriteLine("Lancement de la ROM.");
                                                    ProcessStartInfo startInfo = new ProcessStartInfo(emulatorPath) {
                                                        WindowStyle = ProcessWindowStyle.Normal,
                                                        Arguments = "\"" + corruptor.TempRom + "\""
                                                    };
                                                    Process process = Process.Start(startInfo);
                                                    long now = Util.Now();
                                                    Console.WriteLine("En attente de la fermeture de l'émulateur...");
                                                    process.WaitForExit();
                                                    Console.WriteLine("L'émulateur est resté ouvert " + (Util.Now() - now) + " ms.");
                                                }
                                                if(Util.WantToSave()) {
                                                    corruptor.Save();
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("[!] Erreur inconnue.");
                                                break;
                                        }
                                    }catch(NullReferenceException e) {
                                        Console.WriteLine($"{e.Message}");
                                    }
                                }else {
                                    Console.WriteLine("[!] Un ou plusieurs arguments sont invalides.");
                                }
                            }else {
                                Console.WriteLine("[?] Arguments manquants.");
                            }
                            break;
                        case "help":
                            Helper.Help();
                            break;
                        case "presets":
                            Helper.ShowPresets();
                            break;
                        case "clear": case "clr":
                            Console.Clear();
                            break;
                        case "quit": case "exit": case "q":
                            Environment.Exit(0);
                            break;
                        default:
                            Helper.NoCommand();
                            break;
                    }
                }
            }
        }


    }
}
