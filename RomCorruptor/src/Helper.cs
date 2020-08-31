using System;
using RomCorruptor.Resources;

namespace RomCorruptor.src {
    public static class Helper {
        

        public static void Help() {
            Console.WriteLine(Resource.Help);
        }

        public static void ShowPresets() {
            Console.WriteLine("Liste des presets:");
            foreach(string pre in Enum.GetNames(typeof(Presets))) {
                Console.WriteLine("> " + pre);
            }
        }

        public static void NoCommand() {
            Console.WriteLine("[?] Cette commande n'existe pas.");
        }

        public static void InstallError() {
            Console.WriteLine("[!] Impossible de créer les dossiers d'installation.\nAppuyez sur entrée pour quitter...");
        }
    }
}
