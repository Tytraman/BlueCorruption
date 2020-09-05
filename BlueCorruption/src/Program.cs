using System;
using System.Windows.Forms;
using BlueCorruption.Forms;
using BlueCorruption.src;

namespace BlueCorruption {
    public static class Program {

        [STAThread]
        public static void Main() {
            try {
                Util.CreateFolders();
            } catch(Exception) {
                MessageBox.Show("Impossible de créer les dossiers d'installation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RedForm());
        }


    }
}
