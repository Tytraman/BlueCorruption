using System;
using System.Windows.Forms;
using RomCorruptor.Forms;

namespace RomCorruptor {
    public static class Program {

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


    }
}
