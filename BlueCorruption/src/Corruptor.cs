using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BlueCorruption.Forms;
using BlueCorruption.src;

namespace BlueCorruption {
    public class Corruptor {
        private string path;
        public string Path { get { return path; } set { path = value; Name = value.Substring(value.LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1); OriginalBytes = File.ReadAllBytes(value); } }
        public string Name { get; private set; }
        public string TempFile { get; set; }

        public byte[] OriginalBytes;
        public byte[] Bytes { get; private set; }

        private long now;

        public int Start(Options options, int starting, int ending, int every) {
            Presets preset = (Presets) Enum.Parse(typeof(Presets), options.GetValue("preset").ToUpper());
            if(string.IsNullOrEmpty(Path)) {
                throw new NullReferenceException("Le chemin vers le fichier ne peut pas être vide.");
            }
            Bytes = Copy();
            if(preset == Presets.NO_CHANGE) {
                TempSave();
                return 1;
            }
            if(starting >= ending) {
                return -3;
            }
            if(ending > Bytes.Length) {
                return -1;
            }
            if(every <= 0) {
                return -4;
            }
            if(options.RandomExtraValues) {
                if(options.MinRandomExtra1 >= options.MaxRandomExtra1 || options.MinRandomExtra2 >= options.MaxRandomExtra2) {
                    return -5;
                }
            }
            now = Util.Now();
            switch(preset) {
                case Presets.DEBUG:
                    MessageBox.Show($"{Path.Substring(Path.LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1)}\n" +
                                    $"{OriginalBytes.Length} bytes.",
                                    "Debug mode");
                    return 2;
                case Presets.MOVE_RIGHT:
                    byte old;
                    byte next = 0;
                    if(!options.RandomExtraValues) {
                        for(int i = starting; i < ending; i += every) {
                            old = Bytes[i];
                            try {
                                Bytes[i + options.MoveAway] = next;
                            } catch(IndexOutOfRangeException) {
                                continue;
                            }
                            next = old;
                        }
                    }else {
                        for(int i = starting; i < ending; i += every) {
                            int moveAway = new Random().Next(options.MinRandomExtra1, options.MaxRandomExtra1);
                            old = Bytes[i];
                            try {
                                Bytes[i + moveAway] = next;
                            } catch(IndexOutOfRangeException) {
                                continue;
                            }
                            next = old;
                        }
                    }
                    TempSave();
                    UpdateFinishLabel();
                    return 1;
                case Presets.CHANGE_BYTE_BY:
                    if(!options.RandomExtraValues) {
                        for(int i = starting; i < ending; i += every) {
                            if(Bytes[i] == options.ByteToChange) {
                                Bytes[i] = options.ChangingByte;
                            }
                        }
                    }else {
                        for(int i = starting; i < ending; i += every) {
                            byte byteToChange = (byte) new Random().Next(options.MinRandomExtra1, options.MaxRandomExtra1);
                            byte changingByte = (byte) new Random().Next(options.MinRandomExtra2, options.MaxRandomExtra2);
                            if(Bytes[i] == byteToChange) {
                                Bytes[i] = changingByte;
                            }
                        }
                    }
                    TempSave();
                    UpdateFinishLabel();
                    return 1;
                default:
                    return -2;
            }
        }

        public bool Save() {
            using(SaveFileDialog save = new SaveFileDialog() {
                Title = "Choisissez l'emplacement de sauvegarde",
                DefaultExt = $"*{Util.GetExtension(Path)}",
                Filter = $"Tous les fichiers (*.*)|*.*|Fichier {Util.GetExtension(Path).Replace(".", string.Empty).ToUpper()}|*{Util.GetExtension(Path)}",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            }) {
                Util.SetDefaultExt(save);
                if(save.ShowDialog() != DialogResult.OK) {
                    return false;
                }
                File.WriteAllBytes(save.FileName, Bytes);
                return true;
            };
        }

        public void DefaultSave(Options options) {
            string ppath = options.GetValue("default-save-path");
            if(!ppath.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString())) {
                ppath += System.IO.Path.DirectorySeparatorChar;
            }
            Directory.CreateDirectory(ppath);
            ppath += Util.RemoveExtension(Name) + " " + Directory.GetFiles(ppath, Util.RemoveExtension(Name) + " *" + Util.GetExtension(Name)).Length + Util.GetExtension(Name);
            File.WriteAllBytes(ppath, Bytes);
        }

        public void TempSave() {
            TempFile = Util.TempFilesFolder() + System.IO.Path.DirectorySeparatorChar + new Random().Next(0, int.MaxValue) + Util.GetExtension(Path);
            File.WriteAllBytes(TempFile, Bytes);
        }

        private byte[] Copy() {
            List<byte> list = new List<byte>(OriginalBytes);
            return list.ToArray();
        }

        private void UpdateFinishLabel() {
            Static.Result = $"Fini en {Util.Now() - now} ms.";
        }
    }
}
