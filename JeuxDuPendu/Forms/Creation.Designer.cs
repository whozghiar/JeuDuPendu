namespace JeuxDuPendu.Forms
{
    partial class Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCreer = new System.Windows.Forms.Button();
            this.bRetour = new System.Windows.Forms.Button();
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pseudo : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bCreer
            // 
            this.bCreer.BackColor = System.Drawing.Color.Yellow;
            this.bCreer.Location = new System.Drawing.Point(95, 126);
            this.bCreer.Margin = new System.Windows.Forms.Padding(0);
            this.bCreer.Name = "bCreer";
            this.bCreer.Size = new System.Drawing.Size(277, 44);
            this.bCreer.TabIndex = 2;
            this.bCreer.Text = "Créer serveur";
            this.bCreer.UseVisualStyleBackColor = false;
            this.bCreer.Click += new System.EventHandler(this.bCreer_Click);
            this.bCreer.MouseLeave += new System.EventHandler(this.bCreer_MouseLeave);
            this.bCreer.MouseHover += new System.EventHandler(this.bCreer_MouseHover);
            // 
            // bRetour
            // 
            this.bRetour.AutoSize = true;
            this.bRetour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRetour.BackColor = System.Drawing.Color.LightGreen;
            this.bRetour.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRetour.Location = new System.Drawing.Point(9, 9);
            this.bRetour.Margin = new System.Windows.Forms.Padding(0);
            this.bRetour.Name = "bRetour";
            this.bRetour.Size = new System.Drawing.Size(72, 30);
            this.bRetour.TabIndex = 4;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = false;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click);
            this.bRetour.MouseLeave += new System.EventHandler(this.bRetour_MouseLeave);
            this.bRetour.MouseHover += new System.EventHandler(this.bRetour_MouseHover);
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(415, 142);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(34, 28);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 10;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 182);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.bCreer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu Du Pendu";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCreer;
        private System.Windows.Forms.Button bRetour;
        private System.Windows.Forms.PictureBox pBoxLeave;
    }
}