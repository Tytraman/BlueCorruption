using System;
using System.IO;
using System.Windows.Forms;

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

        [STAThread]
        public static bool WantToSave() {
            DialogResult result = MessageBox.Show("Voulez-vous sauvegarder la ROM ?", "Sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
