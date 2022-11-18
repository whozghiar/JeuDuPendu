using JeuxDuPendu.Forms;
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

namespace JeuxDuPendu
{
    public partial class GameMultijoueurMenu : Form
    {

        private GameMenu parent;
        public GameMultijoueurMenu(GameMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region Gestion des évènements.


        #region Gestion du bouton MultiLocal.
        /// <summary>
        /// Méthode appelée lors du clic du bouton MultiLocal.
        /// - Lance un nouveau formulaire.
        /// - Cache le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMultiLocal_Click(object sender, EventArgs e)
        {
            new Pseudo(this).Show();
            this.Hide();
        }
        /// <summary>
        /// Méthode appelée lors du survol du bouton MultiLocal.
        /// - Change le curseur de la souris en main.
        /// - Change la couleur du bouton en orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMultiLocal_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bMultiLocal.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton MultiLocal.
        /// - Change le curseur de la souris en flèche.
        /// - Change la couleur du bouton en jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMultiLocal_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            bMultiLocal.BackColor = Color.Yellow; 
        }
        #endregion
        
        #region Gestion du bouton créer.

        /// <summary>
        /// Méthode appelée lors du clic du bouton créer.
        /// - Lance un nouveau formulaire.
        /// - Cache le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreer_Click(object sender, EventArgs e)
        {
            new Creation(this).Show();
            this.Hide();
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton créer.
        /// - Change le curseur de la souris en main.
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
        /// Méthode appelée lors de la sortie du survol du bouton Solo.
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

        #region Gestion du bouton rejoindre.
        /// <summary>
        /// Méthode appelée lors du clic du bouton Rejoindre.
        /// - Lance un nouveau formulaire.
        /// - Cache le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRejoindre_Click(object sender, EventArgs e)
        {
            new Connexion(this).Show();
            this.Hide();
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Rejoindre.
        /// - Change la couleur du bouton en orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRejoindre_MouseHover(object sender, EventArgs e)
        {
             bRejoindre.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Rejoindre.
        /// - Change la couleur du bouton en jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRejoindre_MouseLeave(object sender, EventArgs e)
        {
            bRejoindre.BackColor = Color.Yellow;
        }
        #endregion

        #region Gestion du bouton retour.

        /// <summary>
        /// Méthode appelée lors du clic du bouton retour.
        /// - Affiche le formulaire parent.
        /// - Cache le formulaire actuel.
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
        /// - Change le curseur de la souris en flèche.
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

        #region Gestion du bouton Quitter.

        /// <summary>
        /// Méthode appelée lors du clic du bouton Quitter.
        /// - Quitte le programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode appelée lors du survol de la picture box Quitter.
        /// - Change le curseur de la souris en "MainHand".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol de la PictureBox.
        /// - Change le curseur de la souris en flèche.
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
