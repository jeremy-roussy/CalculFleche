using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CalculFleche
{
    public class Logger
    {
        private string filepath;

        /// <summary>
        /// Constructeur qui permet de spécifier dès l'initialisation,
        /// le chemin du fichier qui recevra les logs
        /// </summary>
        /// <param name="filepath">L'adrese du fichier de Log</param>
        public Logger(string filepath)
        {
            this.Filepath = filepath;
        }

        public string Filepath { get => filepath; set => filepath = value; }

        /// <summary>
        /// Méthode d'écriture du fichier de log ligne par ligne
        /// </summary>
        /// <param name="message">la chaîne de caractère à écrire dans le fichier de log</param>
        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(Filepath, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}