using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RomCorruptor.src;

namespace RomCorruptor {
    public class Corruptor {
        public string Path { get; set; }
        public string TempRom { get; set; }
        private byte[] bytes;

        public int Start(Options options, int starting, int ending, int every) {
            Presets preset = (Presets) Enum.Parse(typeof(Presets), options.GetValue("preset").ToUpper());
            if(String.IsNullOrEmpty(Path)) {
                throw new NullReferenceException("[!] Le chemin vers la rom ne peut pas être vide.");
            }
            bytes = File.ReadAllBytes(Path);
            if(preset == Presets.NO_CHANGE) {
                Console.WriteLine("Aucun changement ne va être appliqué.");
                TempSave();
                Save();
                return 1;
            }
            int length = bytes.Length;
            if(ending > length) {
                return -1;
            }
            Console.WriteLine("Démarrage du processus...");
            Console.WriteLine(length + " bytes en tout.");
            List<byte> list = new List<byte>(bytes);
            byte old;
            byte next = 0;
            long now = Util.Now();
            switch(preset) {
                case Presets.MOVE_RIGHT:
                    for(int i = starting; i < ending; i += every) {
                        old = list[i];
                        list[i] = next;
                        next = old;
                    }
                    bytes = list.ToArray();
                    TempSave();
                    Console.WriteLine("Fini en " + (Util.Now() - now) + "ms.");
                    return 1;
                default:
                    return -2;
            }
        }

        public bool Save() {
            using(SaveFileDialog save = new SaveFileDialog() {
                Title = "Choisissez l'emplacement de sauvegarde",
                Filter = ".Fichiers SNES (*.smc)|*.smc",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                DefaultExt = "*.smc"
            }) {
                if(save.ShowDialog() != DialogResult.OK) {
                    return false;
                }
                File.WriteAllBytes(save.FileName, bytes);
                return true;
            };
        }

        public void TempSave() {
            string output = Util.RomsFolder() + System.IO.Path.DirectorySeparatorChar + new Random().Next(0, int.MaxValue) + ".smc";
            TempRom = output;
            File.WriteAllBytes(output, bytes);
        }
    }
}
