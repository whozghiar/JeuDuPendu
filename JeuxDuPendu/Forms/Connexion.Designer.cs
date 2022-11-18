namespace JeuxDuPendu.Forms
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.bCreer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxPort = new System.Windows.Forms.TextBox();
            this.bRetour = new System.Windows.Forms.Button();
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // bCreer
            // 
            this.bCreer.BackColor = System.Drawing.Color.Yellow;
            this.bCreer.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreer.Location = new System.Drawing.Point(259, 325);
            this.bCreer.Margin = new System.Windows.Forms.Padding(0);
            this.bCreer.Name = "bCreer";
            this.bCreer.Size = new System.Drawing.Size(277, 44);
            this.bCreer.TabIndex = 5;
            this.bCreer.Text = "Rejoindre";
            this.bCreer.UseVisualStyleBackColor = false;
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            this.bCreer.MouseLeave += new System.EventHandler(this.bCreer_MouseLeave);
            this.bCreer.MouseHover += new System.EventHandler(this.bCreer_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pseudo : ";
            // 
            // tBoxPseudo
            // 
            this.tBoxPseudo.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPseudo.Location = new System.Drawing.Point(262, 90);
            this.tBoxPseudo.Name = "tBoxPseudo";
            this.tBoxPseudo.Size = new System.Drawing.Size(274, 51);
            this.tBoxPseudo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP :";
            // 
            // tBoxIP
            // 
            this.tBoxIP.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxIP.Location = new System.Drawing.Point(262, 176);
            this.tBoxIP.Name = "tBoxIP";
            this.tBoxIP.Size = new System.Drawing.Size(274, 51);
            this.tBoxIP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port :";
            // 
            // tBoxPort
            // 
            this.tBoxPort.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPort.Location = new System.Drawing.Point(259, 245);
            this.tBoxPort.Name = "tBoxPort";
            this.tBoxPort.Size = new System.Drawing.Size(274, 51);
            this.tBoxPort.TabIndex = 8;
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
            this.bRetour.TabIndex = 11;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = false;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click_1);
            this.bRetour.MouseLeave += new System.EventHandler(this.bRetour_MouseLeave);
            this.bRetour.MouseHover += new System.EventHandler(this.bRetour_MouseHover);
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(734, 384);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(54, 54);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 12;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxIP);
            this.Controls.Add(this.bCreer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxPseudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu Du Pendu";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxPort;
        private System.Windows.Forms.Button bRetour;
        private System.Windows.Forms.PictureBox pBoxLeave;
    }
}