﻿using System;
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

        private void bCreer_Click(object sender, EventArgs e)
        {
        }

        private void bCreer_MouseHover(object sender, EventArgs e)
        {
            bCreer.BackColor = Color.Orange;
        }

        private void bCreer_MouseLeave(object sender, EventArgs e)
        {
            bCreer.BackColor = Color.Yellow;
        }

        private void bRetour_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void bRetour_MouseHover(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.Red;
        }

        private void bRetour_MouseLeave(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.LightGreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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