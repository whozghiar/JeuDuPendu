namespace JeuxDuPendu
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.lCrypedWord = new System.Windows.Forms.Label();
            this.bRetour = new System.Windows.Forms.Button();
            this.lJoueur = new System.Windows.Forms.Label();
            this.lMauvaisesLettres = new System.Windows.Forms.Label();
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(167, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 315);
            this.panel1.TabIndex = 0;
            // 
            // bReset
            // 
            this.bReset.AutoSize = true;
            this.bReset.BackColor = System.Drawing.Color.Yellow;
            this.bReset.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bReset.Location = new System.Drawing.Point(246, 380);
            this.bReset.Margin = new System.Windows.Forms.Padding(0);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(181, 43);
            this.bReset.TabIndex = 1;
            this.bReset.Text = "Nouvelle partie";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            this.bReset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bReset_KeyPress);
            this.bReset.MouseLeave += new System.EventHandler(this.bReset_MouseLeave);
            this.bReset.MouseHover += new System.EventHandler(this.bReset_MouseHover);
            // 
            // lCrypedWord
            // 
            this.lCrypedWord.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCrypedWord.Location = new System.Drawing.Point(12, 332);
            this.lCrypedWord.Margin = new System.Windows.Forms.Padding(0);
            this.lCrypedWord.Name = "lCrypedWord";
            this.lCrypedWord.Size = new System.Drawing.Size(673, 48);
            this.lCrypedWord.TabIndex = 2;
            this.lCrypedWord.Text = "--";
            this.lCrypedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bRetour
            // 
            this.bRetour.BackColor = System.Drawing.Color.LightGreen;
            this.bRetour.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bRetour.Location = new System.Drawing.Point(12, 13);
            this.bRetour.Margin = new System.Windows.Forms.Padding(0);
            this.bRetour.Name = "bRetour";
            this.bRetour.Size = new System.Drawing.Size(113, 43);
            this.bRetour.TabIndex = 3;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = false;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click);
            this.bRetour.MouseLeave += new System.EventHandler(this.bRetour_MouseLeave);
            this.bRetour.MouseHover += new System.EventHandler(this.bRetour_MouseHover);
            // 
            // lJoueur
            // 
            this.lJoueur.AutoSize = true;
            this.lJoueur.BackColor = System.Drawing.Color.LightGreen;
            this.lJoueur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.lJoueur.Location = new System.Drawing.Point(527, 13);
            this.lJoueur.Margin = new System.Windows.Forms.Padding(0);
            this.lJoueur.Name = "lJoueur";
            this.lJoueur.Size = new System.Drawing.Size(103, 26);
            this.lJoueur.TabIndex = 4;
            this.lJoueur.Text = "Joueur :";
            this.lJoueur.Visible = false;
            // 
            // lMauvaisesLettres
            // 
            this.lMauvaisesLettres.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMauvaisesLettres.ForeColor = System.Drawing.Color.Red;
            this.lMauvaisesLettres.Location = new System.Drawing.Point(167, 434);
            this.lMauvaisesLettres.Margin = new System.Windows.Forms.Padding(0);
            this.lMauvaisesLettres.Name = "lMauvaisesLettres";
            this.lMauvaisesLettres.Size = new System.Drawing.Size(340, 34);
            this.lMauvaisesLettres.TabIndex = 5;
            this.lMauvaisesLettres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(628, 411);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(54, 54);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 10;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(694, 477);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.lMauvaisesLettres);
            this.Controls.Add(this.lJoueur);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.lCrypedWord);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu Du Pendu";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lCrypedWord;
        private System.Windows.Forms.Button bRetour;
        private System.Windows.Forms.Label lJoueur;
        private System.Windows.Forms.Label lMauvaisesLettres;
        private System.Windows.Forms.PictureBox pBoxLeave;
    }
}

