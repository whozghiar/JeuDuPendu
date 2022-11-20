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
    public partial class Connexion : Form
    {

        private Form parent;
        private string ipServeur;
        private int port;
        private string pseudo;
        
        public Connexion()
        {
            InitializeComponent();
        }

        public Connexion(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }


        /// <summary>
        /// Retourne l'IP du serveur.
        /// </summary>
        /// <returns></returns>
        public string getIpServeur()
        {
            return this.ipServeur;
        }

        /// <summary>
        /// Retourne le port.
        /// </summary>
        /// <returns></returns>
        public int getIpPort()
        {
            return this.port;
        }

        /// <summary>
        /// Retourne le sport.
        /// </summary>
        /// <returns></returns>
        public string getPseudo()
        {
            return this.pseudo;
        }


        #region Gestion des évènements

        #region Gestion du bouton Créer.

        /// <summary>
        /// Méthode appelée lors du clic du bouton Créer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreer_Click(object sender, EventArgs e)
        {
            this.ipServeur = this.tBoxPseudo.Text;
            this.port = int.Parse(this.tBoxPort.Text);
            MessageBox.Show(this.port.ToString());
            this.pseudo = this.tBoxPseudo.Text;

            new GameForm(parent, this.ipServeur, this.port, new Player(this.pseudo, Color.Red)).Show();
            
            this.Close();
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Créer.
        /// - Change le curseur en main.
        /// - Change la couleur du bouton en orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreer_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bCreer.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Créer.
        /// - Change le curseur en flèche.
        /// - Change la couleur du bouton en jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreer_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            bCreer.BackColor = Color.Yellow;
        }
        #endregion

        #region Gestion du bouton Retour.

        /// <summary>
        /// Méthode appelée lors du clic du bouton Retour.
        /// - Affiche le formulaire parent.
        /// - Cache le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRetour_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
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
        /// - Change le curseur en default.
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

        #region Gestion du bouton Quitter

        /// <summary>
        /// Méthode appelée lors du clic du bouton Quitter.
        /// - Ferme le programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Quitter.
        /// - Change le curseur en "Main".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Quitter.
        /// - Change le curseur en "Default".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #endregion
    }
}
