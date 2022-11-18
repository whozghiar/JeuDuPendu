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

        private void bSolo_Click(object sender, EventArgs e)
        {
            GameForm jeu = new GameForm(this);
            jeu.Show();
            this.Hide();
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            GameMultijoueurMenu multijoueurMenu = new GameMultijoueurMenu(this);
            this.Hide();
            multijoueurMenu.Show();
            
        }

        private void bSolo_MouseHover(object sender, EventArgs e)
        {
            bSolo.BackColor = Color.Orange;
        }

        private void bSolo_MouseLeave(object sender, EventArgs e)
        {
            bSolo.BackColor = Color.Yellow;
        }

        private void bMulti_MouseHover(object sender, EventArgs e)
        {
            bMulti.BackColor = Color.Orange;
        }

        private void bMulti_MouseLeave(object sender, EventArgs e)
        {
            bMulti.BackColor = Color.Yellow;
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
