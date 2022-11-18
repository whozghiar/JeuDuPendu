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
    public partial class Creation : Form
    {

        private Form parent;
        
        public Creation()
        {
            InitializeComponent();
        }

        public Creation(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
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
            MessageBox.Show("Indisponible");
            //new GameForm(true, true, this).Show();
            //this.Close();
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

        #region Gestion du bouton retour.

        /// <summary>
        /// Méthode appelée lors du clic du bouton retour.
        /// - Affiche le formulaire parent.
        /// - Ferme le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRetour_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton retour.
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
        /// Méthode appelée lors de la sortie du survol du bouton retour.
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

        #region Gestion du bouton quitter.
        
        /// <summary>
        /// Méthode appelée lors du clic sur la pictureBox
        /// - Fermeture du programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode appelée lors du survol de la souris sur la pictureBox.
        /// - Changement du curseur en "Main".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Méthode appelée lorsqu'on quitte le survol de la souris sur la pictureBox.
        /// - Changement du curseur en "Par défaut".
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
