namespace JeuxDuPendu
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.bMulti = new System.Windows.Forms.Button();
            this.bSolo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // bMulti
            // 
            this.bMulti.AutoSize = true;
            this.bMulti.BackColor = System.Drawing.Color.Yellow;
            this.bMulti.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.bMulti.Location = new System.Drawing.Point(501, 188);
            this.bMulti.Margin = new System.Windows.Forms.Padding(0);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(203, 75);
            this.bMulti.TabIndex = 3;
            this.bMulti.Text = "Multijoueur";
            this.bMulti.UseVisualStyleBackColor = false;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            this.bMulti.MouseLeave += new System.EventHandler(this.bMulti_MouseLeave);
            this.bMulti.MouseHover += new System.EventHandler(this.bMulti_MouseHover);
            // 
            // bSolo
            // 
            this.bSolo.AutoSize = true;
            this.bSolo.BackColor = System.Drawing.Color.Yellow;
            this.bSolo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSolo.Location = new System.Drawing.Point(96, 188);
            this.bSolo.Margin = new System.Windows.Forms.Padding(0);
            this.bSolo.Name = "bSolo";
            this.bSolo.Size = new System.Drawing.Size(222, 75);
            this.bSolo.TabIndex = 2;
            this.bSolo.Text = "Solo";
            this.bSolo.UseVisualStyleBackColor = false;
            this.bSolo.Click += new System.EventHandler(this.bSolo_Click);
            this.bSolo.MouseLeave += new System.EventHandler(this.bSolo_MouseLeave);
            this.bSolo.MouseHover += new System.EventHandler(this.bSolo_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::JeuxDuPendu.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(123, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(734, 384);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(54, 54);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 10;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.bSolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu Du Pendu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bSolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBoxLeave;
    }
}