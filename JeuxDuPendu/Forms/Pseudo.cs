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
    public partial class Pseudo : Form
    {
        private Form parent;
        
        public Pseudo()
        {
            InitializeComponent();
        }

        public Pseudo(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region Getters
        /// <summary>
        /// Retourne le pseudo entré par l'utilisateur dans la textbox.
        /// </summary>
        /// <returns></returns>
        public string getPseudo1()
        {
            return tBoxPseudo1.Text;
        }

        /// <summary>
        /// Retourne le pseudo entré par l'utilisateur dans la textbox.
        /// </summary>
        /// <returns></returns>
        public string getPseudo2()
        {
            return tBoxPseudo2.Text;
        }

        #endregion

        #region Gestion des évènements.

        #region Gestion du chargement de la fenêtre.

        /// <summary>
        /// Méthode appelée lors du chargement du formulaire.
        /// - Le bouton démarrer n'est pas cliquable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pseudo_Load(object sender, EventArgs e)
        {
            bDemarrer.Enabled = false;
        }

        #endregion

        #region Gestion des tBox.
        /// <summary>
        /// Méthode appelée au changement de la tBox du pseudo 1.
        /// - Si une des tBox est vide : Le bouton démarrer n'est toujours pas disponible.
        /// - Si les tBox sont pleines : Le bouton démarrer est disponible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBoxPseudo1_TextChanged(object sender, EventArgs e)
        {
            if (tBoxPseudo1.Text != "" && tBoxPseudo2.Text != "")
            {
                bDemarrer.Enabled = true;
            }
            else
            {
                bDemarrer.Enabled = false;
            }
        }

        /// <summary>
        /// Méthode appelée au changement de la tBox du pseudo 2.
        /// - Si une des tBox est vide : Le bouton démarrer n'est toujours pas disponible.
        /// - Si les tBox sont pleines : Le bouton démarrer est disponible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBoxPseudo2_TextChanged(object sender, EventArgs e)
        {
            if (tBoxPseudo1.Text != "" && tBoxPseudo2.Text != "")
            {
                bDemarrer.Enabled = true;
            }
            else
            {
                bDemarrer.Enabled = false;
            }
        }
        #endregion
        
        #region Gestion du bouton retour.
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton retour.
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
        /// Méthode appelée lors du survol du bouton Retour.
        /// - Change le curseur en main.
        /// - Change la couleur du bouton en Rouge.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRetour_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bRetour.BackColor = Color.Red;
        }

        /// <summary>
        /// Méthode appelée lorsqu'on quitte le survol du bouton Retour.
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

        #region Gestion du bouton démarrer.

        /// <summary>
        /// Méthode appelée lors du clic du bouton démarrer.
        /// - Création d'une nouvelle instance de la classe Pendu. (Affiche un formulaire.)
        /// - Cache le formulaire actuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDemarrer_Click(object sender, EventArgs e)
        {
            new GameForm(this, true, tBoxPseudo1.Text, tBoxPseudo2.Text).Show();
            this.Hide();
        }
        /// <summary>
        /// Méthode appelée lors du survol du bouton Démarrer.
        /// - Change le curseur en main.
        /// - Change la couleur du bouton en Orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDemarrer_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            bDemarrer.BackColor = Color.Orange;
        }

        /// <summary>
        /// Méthode appelée lorsqu'on quitte le survol du bouton Démarrer.
        /// - Change le curseur en flèche.
        /// - Change la couleur du bouton en Jaune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDemarrer_MouseLeave(object sender, EventArgs e)
        {
            bDemarrer.BackColor = Color.Yellow;
        }
        #endregion
        
        #region Gestion du bouton quitter.
        /// <summary>
        /// Méthode appelée lors du clic sur la pictureBox.
        /// Fermeture du programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode appelée lors du survol de la pictureBox.
        /// - Change le curseur en main.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Méthode appelée lorsqu'on quitte le survol de la pictureBox.
        /// - Change le curseur en flèche.
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
