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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

    #region Gestion des évènements.



        #region Gestion du bouton Solo.

        /// <summary>
        /// Méthode appelée lors du clic du bouton Solo.
        /// - Lance un nouveau formulaire.
        /// - Cache le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSolo_Click(object sender, EventArgs e)
        {
            GameForm jeu = new GameForm(this);
            jeu.Show();
            this.Hide();
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Solo.
        /// - Change le curseur de la souris en main.
        /// - Change la couleur du bouton en orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSolo_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bSolo.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Solo.
        /// - Change la couleur du bouton en jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSolo_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            bSolo.BackColor = Color.Yellow;
        }

        #endregion

        #region Gestion du bouton Multi.

        /// <summary>
        /// Méthode appelée lors du clic du bouton Multi.
        /// - Affiche un nouveau formulaire.
        /// - Cache le formulaire actif.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMulti_Click(object sender, EventArgs e)
        {
            GameMultijoueurMenu multijoueurMenu = new GameMultijoueurMenu(this);
            this.Hide();
            multijoueurMenu.Show();

        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Multi.
        /// - Change le curseur de la souris en main.
        /// - Changement de la couleur du bouton en orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMulti_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bMulti.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Multi.
        /// - Change le curseur de la souris en flèche.
        /// - Changement de la couleur du bouton en jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMulti_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            bMulti.BackColor = Color.Yellow;
        }

        #endregion

        #region Gestion du bouton Quitter.

        /// <summary>
        /// Méthode appelée lors du clic sur le bouton Quitter.
        /// - Quitte le programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode appelée lors du survol du bouton Quitter.
        /// - Change le curseur de la souris.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Méthode appelée lors de la sortie du survol du bouton Quitter.
        /// - Change le curseur de la souris.
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
