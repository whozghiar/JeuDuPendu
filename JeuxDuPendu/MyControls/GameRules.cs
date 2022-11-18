using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxDuPendu.MyControls
{
    public class GameRules
    {
        /// <summary>
        /// Génère un mot aléatoire depuis un fichier texte.
        /// </summary>
        /// <returns name = "motAleatoire"> Un mot aléatoire</returns>
        public static string genererMotAleatoire()
        {
            string motAleatoire = "";
            string nomFichier = "..\\..\\Resources\\Dictionnaire.txt";
            try
            {
                string[] data = System.IO.File.ReadAllLines(nomFichier);
                int lastRow = data.Count();
                int randomLine = new Random().Next(lastRow);

                StreamReader sr = new StreamReader(nomFichier);

                for (int i = 0; i < lastRow; i++)
                {
                    if (i == randomLine)
                    {
                        motAleatoire = sr.ReadLine();
                    }
                    sr.ReadLine();
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Erreur durant la lecture du fichier : " + e.Message);
            }

            return motAleatoire;
        }

        /// <summary>
        /// Crypte une chaîne de caractère passée en paramètre.s
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public static string crypterMot(string mot)
        {
            string motCache = "";
            for (int i = 0; i < mot.Length; i++)
            {
                motCache += "_";
            }
            return motCache;
        }

        /// <summary>
        /// Remplace les lettre situées.
        /// </summary>
        /// <param name="mot"></param>
        /// <param name="motCache"></param>
        /// <param name="lettre"></param>
        /// <returns></returns>
        public static string decrypterMot(string mot, string motCache, char lettre)
        {
            string motCache2 = motCache;
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == lettre)
                {
                    motCache2 = motCache2.Remove(i, 1);
                    motCache2 = motCache2.Insert(i, lettre.ToString());
                }
            }
            return motCache2;
        }
    
        /// <summary>
        /// Ajoute une lettre à un mot.
        /// </summary>
        /// <param name="mot"></param>
        /// <param name="lettre"></param>
        /// <returns></returns>
        public static string mauvaisesLettres(string mot, char lettre)
        {
            return mot += lettre;
            
        }
        
        /// <summary>
        /// Si la lettre appartient à l'alphabet CAPITALISE 
        /// La fonction retourne vrai.
        /// Sinon retourne faux.
        /// </summary>
        /// <param name="lettre"></param>
        /// <returns></returns>
        public static bool isLetter(char lettre)
        {
            if (lettre >= 'A' && lettre <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Si le mot est complet on retour true.
        /// Sinon on retour false.
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public static bool motComplet(string mot)
        {
            if (mot.Contains("_"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
