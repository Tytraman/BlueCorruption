using System;
using System.IO;

namespace RomCorruptor.src {
    public static class Util {
        public static long Now() {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public static void CreateFolders() {
            Directory.CreateDirectory(Util.RomsFolder());
        }

        public static string AppData() {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "RomCorruptor";
        }

        public static string RomsFolder() {
            return AppData() + Path.DirectorySeparatorChar + "ROMs";
        }

        public static bool WantToSave() {
            while(true) {
                Console.Write("Voulez-vous sauvegarder la ROM ? (y/n): ");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch(key) {
                    case ConsoleKey.Y:
                        return true;
                    case ConsoleKey.N:
                        return false;
                    default:
                        break;
                }
            }
        }
    }
}
