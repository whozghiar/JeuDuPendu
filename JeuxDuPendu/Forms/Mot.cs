using JeuxDuPendu.MyControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxDuPendu.Forms
{
    public partial class Mot : Form
    {
        private Form parent;
        private bool wordReady;
        private string mot;

        public Mot()
        {
            InitializeComponent();
        }

        public Mot(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.wordReady = false;
        }

        /*
        public Mot(Form parent, string pseudo, string ip, string port)
        {
            
        }*/
        
        /// <summary>
        /// Retourne si le mot est prêt.
        /// </summary>
        /// <returns></returns>
        public bool getWordReady()
        {
            Console.WriteLine("Pitié");
            return this.wordReady;
        }

        /// <summary>
        /// Retourne le mot.
        /// </summary>
        /// <returns></returns>
        public string getMot()
        {
            return this.mot;
        }

        #region Gestion d'évènements

        #region Gestion du bouton Retour.

        /// <summary>
        /// Méthode appelée lors du clic du bouton Retour.
        /// - Raffiche le formulaire parent
        /// - Ferme le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRetour_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
            
            // Serveur.Close
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Retour.
        /// - Change le curseur en main.
        /// - Change la couleur du bouton en rouge.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRetour_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bRetour.BackColor = Color.Red;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Retour.
        /// - Change le curseur en flèche.
        /// - Change la couleur du bouton en vert clair.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRetour_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            bRetour.BackColor = Color.LightGreen;
        }
        #endregion

        #endregion

        #region Gestion de la pictureBox.

        /// <summary>
        /// Méthode appelée lors du clic de la pictureBox.
        /// - Ferme le programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode appelée lors du survol de la pictureBox.
        /// - Change le curseur en "MainHand".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol de la pictureBox.
        /// - Change le curseur en "Default".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        #endregion


        #region Gestion du Chargement du formulaire.

        /// <summary>
        /// Méthode appelée lors du chargement du formulaire.
        /// - Désactive le bouton "Choisir ce mot".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mot_Load(object sender, EventArgs e)
        {
            this.bChoix.Enabled = false;
        }
        #endregion

        #region Gestion de la textBox.

        /// <summary>
        /// Méthode appelée lors de la modification de la textBox.
        /// - Active le bouton "Choisir ce mot" si la textBox n'est pas vide.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBoxMot_TextChanged(object sender, EventArgs e)
        {
            if (tBoxMot.Text.Length > 0)
            {
                bChoix.Enabled = true;
            }
            else
            {
                bChoix.Enabled = false;
            }
        }
        #endregion

        #region Gestion du bouton "Choisir ce mot".

        /// <summary>
        /// Méthode appelée lors du clic du bouton "Choisir ce mot".
        /// - Récupère le mot entré par l'utilisateur.
        /// - Affiche un message différent si le mot existe ou non dans le dictionnaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bChoix_Click(object sender, EventArgs e)
        {
            if(GameRules.motExiste(this.tBoxMot.Text.ToUpper()))
            {
                this.wordReady = true;
                this.mot = this.tBoxMot.Text.ToUpper();
                MessageBox.Show("Le mot existe dans le fichier.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Le mot n'existe pas dans le fichier.");
            }
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton "Choisir ce mot".
        /// - Change le curseur en "MainHand".
        /// - Change la couleur du bouton en orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bChoix_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bChoix.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton "Choisir ce mot".
        /// - Change le curseur en "Default".
        /// - Change la couleur du bouton en jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bChoix_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            bChoix.BackColor = Color.Yellow;
        }
        #endregion


    }
}
