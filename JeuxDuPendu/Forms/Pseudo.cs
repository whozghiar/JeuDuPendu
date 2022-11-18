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


        // Getter TextBox Pseudo 1 and Getter TextBox pseudo 2
        public string getPseudo1()
        {
            return tBoxPseudo1.Text;
        }

        public string getPseudo2()
        {
            return tBoxPseudo2.Text;
        }


        private void Pseudo_Load(object sender, EventArgs e)
        {
            bDemarrer.Enabled = false;
        }

        private void bDemarrer_Click(object sender, EventArgs e)
        {
            new GameForm(this,true,tBoxPseudo1.Text,tBoxPseudo2.Text).Show();
            this.Hide();
        }

        private void bRetour_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
             
        }

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

        private void bRetour_MouseHover(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.Red;
        }

        private void bRetour_MouseLeave(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.LightGreen;
        }

        private void bDemarrer_MouseHover(object sender, EventArgs e)
        {
            bDemarrer.BackColor = Color.Orange;
        }

        private void bDemarrer_MouseLeave(object sender, EventArgs e)
        {
            bDemarrer.BackColor = Color.Yellow;
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
