using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CalculFleche
{
    public class DataImport
    {
        private string fileToImport;

        public string FileToImport { get => fileToImport; set => fileToImport = value; }

        /// <summary>
        /// Méthode de lecture du fichier de abaque ligne par ligne
        /// </summary>
        /// <return>Un dictionnaire avec les matériaux et la valeur de leurs module de Young</return>
        public Dictionary<string, string> ImportDataFromFile()
        {
            Dictionary<string, string> ImportDictionary = new Dictionary<string, string>();

            try
            {
                using (StreamReader sr = new StreamReader(fileToImport))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(':');
                        ImportDictionary.Add(data[0], data[1]);
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            return ImportDictionary;
        }
    }
}