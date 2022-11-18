namespace JeuxDuPendu
{
    partial class GameMultijoueurMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMultijoueurMenu));
            this.bMultiLocal = new System.Windows.Forms.Button();
            this.bRetour = new System.Windows.Forms.Button();
            this.bRejoindre = new System.Windows.Forms.Button();
            this.bCreer = new System.Windows.Forms.Button();
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bMultiLocal
            // 
            this.bMultiLocal.AutoSize = true;
            this.bMultiLocal.BackColor = System.Drawing.Color.Yellow;
            this.bMultiLocal.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bMultiLocal.Location = new System.Drawing.Point(47, 189);
            this.bMultiLocal.Margin = new System.Windows.Forms.Padding(0);
            this.bMultiLocal.Name = "bMultiLocal";
            this.bMultiLocal.Size = new System.Drawing.Size(204, 61);
            this.bMultiLocal.TabIndex = 7;
            this.bMultiLocal.Text = "Multijoueur Local";
            this.bMultiLocal.UseVisualStyleBackColor = false;
            this.bMultiLocal.Click += new System.EventHandler(this.bMultiLocal_Click);
            this.bMultiLocal.MouseLeave += new System.EventHandler(this.bMultiLocal_MouseLeave);
            this.bMultiLocal.MouseHover += new System.EventHandler(this.bMultiLocal_MouseHover);
            // 
            // bRetour
            // 
            this.bRetour.AutoSize = true;
            this.bRetour.BackColor = System.Drawing.Color.LightGreen;
            this.bRetour.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bRetour.Location = new System.Drawing.Point(12, 12);
            this.bRetour.Margin = new System.Windows.Forms.Padding(0);
            this.bRetour.Name = "bRetour";
            this.bRetour.Size = new System.Drawing.Size(113, 43);
            this.bRetour.TabIndex = 6;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = false;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click);
            this.bRetour.MouseLeave += new System.EventHandler(this.bRetour_MouseLeave);
            this.bRetour.MouseHover += new System.EventHandler(this.bRetour_MouseHover);
            // 
            // bRejoindre
            // 
            this.bRejoindre.AutoSize = true;
            this.bRejoindre.BackColor = System.Drawing.Color.Yellow;
            this.bRejoindre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bRejoindre.Location = new System.Drawing.Point(552, 186);
            this.bRejoindre.Margin = new System.Windows.Forms.Padding(0);
            this.bRejoindre.Name = "bRejoindre";
            this.bRejoindre.Size = new System.Drawing.Size(170, 66);
            this.bRejoindre.TabIndex = 5;
            this.bRejoindre.Text = "Rejoindre";
            this.bRejoindre.UseVisualStyleBackColor = false;
            this.bRejoindre.Click += new System.EventHandler(this.bRejoindre_Click);
            this.bRejoindre.MouseLeave += new System.EventHandler(this.bRejoindre_MouseLeave);
            this.bRejoindre.MouseHover += new System.EventHandler(this.bRejoindre_MouseHover);
            // 
            // bCreer
            // 
            this.bCreer.AutoSize = true;
            this.bCreer.BackColor = System.Drawing.Color.Yellow;
            this.bCreer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bCreer.Location = new System.Drawing.Point(300, 191);
            this.bCreer.Margin = new System.Windows.Forms.Padding(0);
            this.bCreer.Name = "bCreer";
            this.bCreer.Size = new System.Drawing.Size(197, 61);
            this.bCreer.TabIndex = 4;
            this.bCreer.Text = "Créer un serveur";
            this.bCreer.UseVisualStyleBackColor = false;
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            this.bCreer.MouseLeave += new System.EventHandler(this.bCreer_MouseLeave);
            this.bCreer.MouseHover += new System.EventHandler(this.bCreer_MouseHover);
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(734, 384);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(54, 54);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 9;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::JeuxDuPendu.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(141, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GameMultijoueurMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bMultiLocal);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.bRejoindre);
            this.Controls.Add(this.bCreer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMultijoueurMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu Du Pendu";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bMultiLocal;
        private System.Windows.Forms.Button bRetour;
        private System.Windows.Forms.Button bRejoindre;
        private System.Windows.Forms.Button bCreer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBoxLeave;
    }
}