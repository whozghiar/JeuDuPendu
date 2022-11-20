namespace JeuxDuPendu.Forms
{
    partial class GameMenuLocalPseudos
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
            this.bRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPseudo2 = new System.Windows.Forms.TextBox();
            this.bDemarrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxPseudo1 = new System.Windows.Forms.TextBox();
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // bRetour
            // 
            this.bRetour.AutoSize = true;
            this.bRetour.BackColor = System.Drawing.Color.LightGreen;
            this.bRetour.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bRetour.Location = new System.Drawing.Point(9, 9);
            this.bRetour.Margin = new System.Windows.Forms.Padding(0);
            this.bRetour.Name = "bRetour";
            this.bRetour.Size = new System.Drawing.Size(113, 43);
            this.bRetour.TabIndex = 19;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = false;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click);
            this.bRetour.MouseLeave += new System.EventHandler(this.bRetour_MouseLeave);
            this.bRetour.MouseHover += new System.EventHandler(this.bRetour_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pseudo joueur 2 :";
            // 
            // tBoxPseudo2
            // 
            this.tBoxPseudo2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPseudo2.Location = new System.Drawing.Point(334, 165);
            this.tBoxPseudo2.Name = "tBoxPseudo2";
            this.tBoxPseudo2.Size = new System.Drawing.Size(274, 51);
            this.tBoxPseudo2.TabIndex = 15;
            this.tBoxPseudo2.TextChanged += new System.EventHandler(this.tBoxPseudo2_TextChanged);
            // 
            // bDemarrer
            // 
            this.bDemarrer.BackColor = System.Drawing.Color.Yellow;
            this.bDemarrer.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDemarrer.Location = new System.Drawing.Point(130, 301);
            this.bDemarrer.Margin = new System.Windows.Forms.Padding(0);
            this.bDemarrer.Name = "bDemarrer";
            this.bDemarrer.Size = new System.Drawing.Size(542, 44);
            this.bDemarrer.TabIndex = 14;
            this.bDemarrer.Text = "Démarrer";
            this.bDemarrer.UseVisualStyleBackColor = false;
            this.bDemarrer.Click += new System.EventHandler(this.bDemarrer_Click);
            this.bDemarrer.MouseLeave += new System.EventHandler(this.bDemarrer_MouseLeave);
            this.bDemarrer.MouseHover += new System.EventHandler(this.bDemarrer_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pseudo joueur 1 :";
            // 
            // tBoxPseudo1
            // 
            this.tBoxPseudo1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPseudo1.Location = new System.Drawing.Point(334, 98);
            this.tBoxPseudo1.Name = "tBoxPseudo1";
            this.tBoxPseudo1.Size = new System.Drawing.Size(274, 51);
            this.tBoxPseudo1.TabIndex = 12;
            this.tBoxPseudo1.TextChanged += new System.EventHandler(this.tBoxPseudo1_TextChanged);
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(734, 384);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(54, 54);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 20;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // GameMenuLocalPseudos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxPseudo2);
            this.Controls.Add(this.bDemarrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxPseudo1);
            this.Name = "GameMenuLocalPseudos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu Du Pendu";
            this.Load += new System.EventHandler(this.Pseudo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPseudo2;
        private System.Windows.Forms.Button bDemarrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxPseudo1;
        private System.Windows.Forms.PictureBox pBoxLeave;
    }
}