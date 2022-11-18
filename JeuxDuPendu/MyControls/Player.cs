using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxDuPendu.MyControls
{
    public class Player
    {
        private string pseudo;
        private int score;
        private Color couleur;
        public static List<Player> joueurs = new List<Player>();
        
        public Player(string pseudo, int score, Color couleur)
        {
            this.pseudo = pseudo;
            this.score = score;
            this.couleur = couleur;
        }


        /// <summary>
        /// Getter & Setter attribut pseudo.
        /// </summary>
        public string Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }

        /// <summary>
        /// Getter & Setter attribut score.
        /// </summary>
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        /// <summary>
        /// Getter & Setter attribut couleur.
        /// </summary>
        public Color Couleur
        {
            get
            {
                return couleur;
            }
            set
            {
                couleur = value;
            }
        }

        /// <summary>
        /// Méthode permettant d'afficher les joueurs dans la liste.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return pseudo + " : " + score;
        }


        // Méthodes Statiques.


        /// <summary>
        /// Méthode permettant de  retourner un joueur grâce à son pseudo.
        /// </summary>
        /// <param name="pseudo"></param>
        /// <returns></returns>
        public static Player getJoueur(string pseudo)
        {
            foreach (Player j in joueurs)
            {
                if (j.pseudo == pseudo)
                {
                    return j;
                }
            }
            return null;
        }

        /// <summary>
        /// Méthode permettant de retourner le nombre de joueurs.
        /// </summary>
        /// <returns></returns>
        public static int getNbJoueurs()
        {
            return joueurs.Count;
        }

        /// <summary>
        /// Méthode permettant de retourner le joueur ayant le meilleur score.
        /// </summary>
        /// <returns></returns>
        public static Player getMeilleurScore()
        {
            Player meilleur = joueurs[0];
            foreach (Player j in joueurs)
            {
                if (j.score > meilleur.score)
                {
                    meilleur = j;
                }
            }
            return meilleur;
        }

        /// <summary>
        /// Méthode permettant de retourner le joueur ayant le pire score.
        /// </summary>
        /// <returns></returns>
        public static Player getPireScore()
        {
            Player pire = joueurs[0];
            foreach (Player j in joueurs)
            {
                if (j.score < pire.score)
                {
                    pire = j;
                }
            }
            return pire;
        }


        /// <summary>
        /// Méthode permettant d'enregistrer les scores des joueurs dans un fichier texte.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        public static void enregistrerScore(Player j1, Player j2)
        {
            string nomFichier = "..\\..\\Resources\\logs.txt";
            try
            {
                if (!System.IO.File.Exists(nomFichier))
                {
                    System.IO.File.Create(nomFichier);
                }
                System.IO.File.AppendAllText(nomFichier, j1.ToString() + " " + DateTime.Now.ToString() + Environment.NewLine);
                System.IO.File.AppendAllText(nomFichier, j2.ToString() + " " + DateTime.Now.ToString() + Environment.NewLine);
                System.IO.File.AppendAllText(nomFichier, Environment.NewLine);
            }
            catch (IOException e)
            {
                MessageBox.Show("Erreur durant la lecture du fichier : " + e.Message);
            }
        }

    }
}
