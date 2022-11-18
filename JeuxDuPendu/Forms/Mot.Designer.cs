namespace JeuxDuPendu.Forms
{
    partial class Mot
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
            this.pBoxLeave = new System.Windows.Forms.PictureBox();
            this.bChoix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxMot = new System.Windows.Forms.TextBox();
            this.bRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxLeave
            // 
            this.pBoxLeave.Image = global::JeuxDuPendu.Properties.Resources.exit;
            this.pBoxLeave.Location = new System.Drawing.Point(416, 144);
            this.pBoxLeave.Name = "pBoxLeave";
            this.pBoxLeave.Size = new System.Drawing.Size(34, 28);
            this.pBoxLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLeave.TabIndex = 15;
            this.pBoxLeave.TabStop = false;
            this.pBoxLeave.Click += new System.EventHandler(this.pBoxLeave_Click);
            this.pBoxLeave.MouseLeave += new System.EventHandler(this.pBoxLeave_MouseLeave);
            this.pBoxLeave.MouseHover += new System.EventHandler(this.pBoxLeave_MouseHover);
            // 
            // bChoix
            // 
            this.bChoix.BackColor = System.Drawing.Color.Yellow;
            this.bChoix.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.bChoix.Location = new System.Drawing.Point(96, 128);
            this.bChoix.Margin = new System.Windows.Forms.Padding(0);
            this.bChoix.Name = "bChoix";
            this.bChoix.Size = new System.Drawing.Size(277, 44);
            this.bChoix.TabIndex = 13;
            this.bChoix.Text = "Choisir ce mot";
            this.bChoix.UseVisualStyleBackColor = false;
            this.bChoix.Click += new System.EventHandler(this.bChoix_Click);
            this.bChoix.MouseLeave += new System.EventHandler(this.bChoix_MouseLeave);
            this.bChoix.MouseHover += new System.EventHandler(this.bChoix_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mot :";
            // 
            // tBoxMot
            // 
            this.tBoxMot.Location = new System.Drawing.Point(96, 65);
            this.tBoxMot.Name = "tBoxMot";
            this.tBoxMot.Size = new System.Drawing.Size(274, 22);
            this.tBoxMot.TabIndex = 11;
            this.tBoxMot.TextChanged += new System.EventHandler(this.tBoxMot_TextChanged);
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
            this.bRetour.TabIndex = 16;
            this.bRetour.Text = "Retour";
            this.bRetour.UseVisualStyleBackColor = false;
            this.bRetour.Click += new System.EventHandler(this.bRetour_Click);
            this.bRetour.MouseLeave += new System.EventHandler(this.bRetour_MouseLeave);
            this.bRetour.MouseHover += new System.EventHandler(this.bRetour_MouseHover);
            // 
            // Mot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 182);
            this.Controls.Add(this.bRetour);
            this.Controls.Add(this.pBoxLeave);
            this.Controls.Add(this.bChoix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxMot);
            this.Name = "Mot";
            this.Text = "Mot";
            this.Load += new System.EventHandler(this.Mot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLeave;
        private System.Windows.Forms.Button bChoix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMot;
        private System.Windows.Forms.Button bRetour;
    }
}