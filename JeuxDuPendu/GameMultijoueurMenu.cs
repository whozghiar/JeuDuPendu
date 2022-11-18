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

        private void bRetour_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();

        }

        private void bMultiLocal_Click(object sender, EventArgs e)
        {
            new Pseudo(this).Show();
            this.Hide();
        }

        private void bMultiLocal_MouseHover(object sender, EventArgs e)
        {
            bMultiLocal.BackColor = Color.Orange;
        }

        private void bMultiLocal_MouseLeave(object sender, EventArgs e)
        {
            bMultiLocal.BackColor = Color.Yellow; 
        }

        private void bCreer_MouseHover(object sender, EventArgs e)
        {
            bCreer.BackColor = Color.Orange;
        }

        private void bCreer_MouseLeave(object sender, EventArgs e)
        {
            bCreer.BackColor = Color.Yellow;
        }

        private void bRejoindre_MouseHover(object sender, EventArgs e)
        {
             bRejoindre.BackColor = Color.Orange;
        }

        private void bRejoindre_MouseLeave(object sender, EventArgs e)
        {
            bRejoindre.BackColor = Color.Yellow;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            // Créer un nouveau formulaire GameMenuMultijoueurCreation
            new Creation(this).Show();
            this.Hide();
        }

        private void bRejoindre_Click(object sender, EventArgs e)
        {
            new Connexion(this).Show();
            this.Hide();
        }

        private void bRetour_MouseHover(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.Red;
        }

        private void bRetour_MouseLeave(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.LightGreen;
        }

        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pBoxLeave_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
