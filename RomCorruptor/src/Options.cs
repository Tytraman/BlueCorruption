using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RomCorruptor.src {
    
    public class Options {
        public Dictionary<string, string> Changes { get; }

        private string path = Util.AppData() + Path.DirectorySeparatorChar + "options.ini";
        private Dictionary<string, Dictionary<string, string>> map = new Dictionary<string, Dictionary<string, string>> {
            {"[general]", new Dictionary<string, string>{ 
                    { "emulator-path", "-1" },
                    { "preset",  "NO_CHANGE" }
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

        [STAThread]
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
