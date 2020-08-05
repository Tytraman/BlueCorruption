using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace RomCorruptor {
    class Program {

        [STAThread]     //Obligatoire pour pouvoir ouvrir un dialog (popup pour choisir un fichier)
        static void Main(string[] arg) {
            Console.WriteLine("Bienvenue dans ROM corruptor!\n\n");
            Help();
            Console.WriteLine("\n");
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choisissez une ROM";
            dialog.Filter = "Fichiers SNES (*.smc)|*.smc";
            dialog.InitialDirectory = "C:\\";

            string file = string.Empty;

            string line = string.Empty;
            while(true) {
                line = Console.ReadLine();
                if(line.Trim().Length > 0) {
                    string[] args = line.Split(' ');
                    string command = args[0];
                    // J'fais ça pour enlever le nom de la commande des arguments
                    List<string> tempA = new List<string>(args);
                    tempA.RemoveAt(0);
                    args = tempA.ToArray();
                    switch(command) {
                        case "select":
                            if(dialog.ShowDialog() == DialogResult.OK) {
                                file = dialog.FileName;
                                Console.WriteLine(file + "\n" + File.ReadAllBytes(file).Length + " bytes en tout.");
                            }
                            break;
                        case "start":
                            if(file.Length > 0) {
                                if(args.Length > 3) {
                                    if(Enum.TryParse(args[0].ToUpper(), out Presets preset) && int.TryParse(args[1], out int starting) && int.TryParse(args[2], out int ending) && int.TryParse(args[3], out int every)) {
                                        switch(Start(preset, starting, ending, every, File.ReadAllBytes(file))) {
                                            case 1:
                                                // Une action est faite selon le preset sélectionné
                                                break;
                                            case -1:
                                                Console.WriteLine("[-1] La valeur \"ending\" ne peut pas dépasser le nombre max de bytes dans la ROM.");
                                                break;
                                            case -2:
                                                Console.WriteLine("[-2] Annulé.");
                                                break;
                                            case -3:
                                                Console.WriteLine("[-3] Le preset sélectionné n'a pas encore été configuré.");
                                                break;
                                            default:
                                                Console.WriteLine("Erreur inconnue.");
                                                break;
                                        }
                                    }else {
                                        Console.WriteLine("Erreur.");
                                    }
                                }else {
                                    Console.WriteLine("Arguments manquants.");
                                }
                            }else {
                                Console.WriteLine("Veuillez sélectionner une ROM.");
                            }
                            break;
                        case "help":
                            Help();
                            break;
                        case "presets":
                            ShowPresets();
                            break;
                        case "clear": case "clr":
                            Clear();
                            break;
                        case "quit": case "exit": case "q":
                            Environment.Exit(0);
                            break;
                        default:
                            NoCommand();
                            break;
                    }
                }
            }
        }


        #region Commandes
        private static void NoCommand() {
            Console.WriteLine("Cette commande n'existe pas.");
        }

        private static void Help() {
            Console.WriteLine(Resource.Help);
        }

        private static void ShowPresets() {
            Console.WriteLine("Liste des presets:");
            foreach(string pre in Enum.GetNames(typeof(Presets))) {
                Console.WriteLine("> " + pre);
            }
        }

        private static void Clear() {
            Console.Clear();
        }
        #endregion



        private static int Start(Presets preset, int starting, int ending, int every, byte[] bytes) {
            int length = bytes.Length;
            if(ending > length) {
                return -1;
            }
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Choisissez l'emplacement de sauvegarde";
            save.Filter = "Fichiers SNES (*.smc)|*.smc";
            save.InitialDirectory = "C:\\";
            save.DefaultExt = "*.smc";
            if(save.ShowDialog() != DialogResult.OK) {
                return -2;
            }
            string output = save.FileName;
            Console.WriteLine(output + "\n");
            Console.WriteLine("Démarrage du processus...");
            Console.WriteLine(length + " bytes en tout.");
            if(preset == Presets.NO_CHANGES) {
                File.WriteAllBytes(output, bytes);
                return 1;
            }
            List<byte> list = new List<byte>(bytes);
            byte old;
            byte next = 0;
            long now = Now();
            switch(preset) {
                case Presets.MOVE_RIGHT:
                    for(int i = starting; i < ending; i += every) {
                        old = list[i];
                        list[i] = next;
                        next = old;
                    }
                    File.WriteAllBytes(output, list.ToArray());
                    Console.WriteLine("Fini en " + (Now() - now) + "ms.");
                    return 1;
                default:
                    return -3;
            }
        }

        

        private static long Now() {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

    }
}
