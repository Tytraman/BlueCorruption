using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BlueCorruption.src {
    public static class Util {


        public static int[] IntToArray(int number) {
            if(number == 0) {
                return new int[1] { 0 };
            }
            List<int> list = new List<int>();
            while(number != 0) {
                list.Add(number % 10);
                number /= 10;
            }
            int[] array = list.ToArray();
            Array.Reverse(array);
            return array;
        }

        public static string NumberWithSpaces(int number) {
            int[] array = IntToArray(number);
            Array.Reverse(array);
            StringBuilder builder = new StringBuilder();
            List<int> list = new List<int>();
            foreach(int i in array) {
                if(list.Count == 3) {
                    list.Clear();
                    builder.Append($" {i}");
                    list.Add(i);
                }else {
                    builder.Append(i);
                    list.Add(i);
                }
            }
            char[] letters = builder.ToString().ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }


        public static void SetDefaultExt(SaveFileDialog dialog) {
            var filters = dialog.Filter.Split('|');
            for(int i = 1; i < filters.Length; i += 2) {
                if(filters[i] == dialog.DefaultExt) {
                    dialog.FilterIndex = 1 + (i - 1) / 2;
                    return;
                }
            }
        }

        public static string RemoveExtension(string str) {
            return str.Substring(0, str.LastIndexOf('.'));
        }
        public static long Now() {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public static void CreateFolders() {
            Directory.CreateDirectory(TempFilesFolder());
        }

        public static string AppData() {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "BlueCorruption";
        }

        public static string TempFilesFolder() {
            return AppData() + Path.DirectorySeparatorChar + "TempFiles";
        }

        
        public static bool WantToSave() {
            DialogResult result = MessageBox.Show("Voulez-vous sauvegarder le fichier corrompu ?", "Sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static string GetExtension(string path) {
            if(!path.Contains(".")) {
                return null;
            }
            return path.Substring(path.LastIndexOf('.'));
        }

        public static void DeleteTempFiles() {
            foreach(string rom in Directory.GetFiles(TempFilesFolder())) {
                File.Delete(rom);
            }
        }
    }
}
