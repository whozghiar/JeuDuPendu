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

        public override string ToString()
        {
            return pseudo + " : " + score;
        }


    // Méthodes Statiques.
        

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

        
        public static int getNbJoueurs()
        {
            return joueurs.Count;
        }

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

        // Créer une fonction
        // Qui prend 2 joueurs en paramètres
        // Si un fichier texte "logs.txt" n'existe pas dans le dossier Ressources, le créer et y inscrire le score des joueurs avec leur pseudo et la date
        // Si le fichier existe, ajouter le score du joueur avec son pseudo et la date à la fin du fichier

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
