using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BlueCorruption.src {
    
    public class Options {
        public Dictionary<string, string> Changes { get; }
        public byte ByteToChange { get; set; }
        public byte ChangingByte { get; set; }
        public int MoveAway { get; set; }
        public bool RandomExtraValues { get; set; }
        public int MinRandomExtra1 { get; set; }
        public int MaxRandomExtra1 { get; set; }
        public int MinRandomExtra2 { get; set; }
        public int MaxRandomExtra2 { get; set; }

        private string path = Util.AppData() + Path.DirectorySeparatorChar + "options.ini";

        //Dictionnaire par défaut
        private Dictionary<string, Dictionary<string, string>> map = new Dictionary<string, Dictionary<string, string>> {
            {"[general]", new Dictionary<string, string>{ 
                    { "process-path", "-1" },
                    { "preset",  "NO_CHANGE" },
                    { "default-save-path", "-1" },
                    { "auto-save", "False" },
                    { "auto-open-file", "False" }
                }
            }
        };

        public Options() {
            Changes = new Dictionary<string, string>();
            VerifOptions();
        }

        public void Save() {
            string content = VerifOptions();
            foreach(var pair in Changes) {
                var regex = new Regex(@"^.*\b" + pair.Key + @"\b.*$", RegexOptions.Multiline);
                content = regex.Replace(content, $"{pair.Key}={pair.Value}");
            }
            Changes.Clear();
            File.WriteAllText(path, content);
        }

        public string GetValue(string key) {
            var regex = new Regex(@"^.*\b" + key + @"\b.*$", RegexOptions.Multiline);
            return regex.Match(File.ReadAllText(path)).Value.Split('=')[1];
        }

        /// <summary>
        /// Vérifie si le fichier d'options existe et est complet, si non, le (re)créer.
        /// </summary>
        private string VerifOptions() {
            if(!File.Exists(path)) {
                return CreateDefault();
            }else {
                string content = File.ReadAllText(path);
                foreach(var valMap in map) {
                    int index1 = content.IndexOf(valMap.Key, StringComparison.OrdinalIgnoreCase);
                    if(index1 != -1) {
                        List<int> index = new List<int>();
                        foreach(var valSubMap in valMap.Value) {
                            int indexx = content.IndexOf(valSubMap.Key, StringComparison.OrdinalIgnoreCase);
                            if(indexx != -1) {
                                index.Add(indexx);
                            }else {
                                return CreateDefault();
                            }
                        }
                        index.Sort();
                        if(index1 > index[0]) {
                            return CreateDefault();
                        }
                    }else {
                        return CreateDefault();
                    }
                }
                return content;
            }
        }


        private string CreateDefault() {
            StringBuilder builder = new StringBuilder();
            foreach(var valMap in map) {
                builder.AppendLine(valMap.Key);
                foreach(var valSubMap in valMap.Value) {
                    builder.AppendLine($"{valSubMap.Key}={valSubMap.Value}");
                }
            }
            string result = builder.ToString();
            File.WriteAllText(path, result);
            MessageBox.Show("Les options ont été réinitialisées!");
            return result;
        }
    }
}
