namespace HuginnMuninn
{
    partial class FAddAuteur
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
            this.tb_NomAuteur = new System.Windows.Forms.TextBox();
            this.tb_PrenomAuteur = new System.Windows.Forms.TextBox();
            this.tb_DateNaisAuteur = new System.Windows.Forms.TextBox();
            this.tb_DateMortAuteur = new System.Windows.Forms.TextBox();
            this.l_nomAuteur = new System.Windows.Forms.Label();
            this.l_prenomAuteur = new System.Windows.Forms.Label();
            this.l_dateNaisAuteur = new System.Windows.Forms.Label();
            this.l_dateMortAuteur = new System.Windows.Forms.Label();
            this.b_valider = new System.Windows.Forms.Button();
            this.b_Annuler = new System.Windows.Forms.Button();
            this.l_format = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_NomAuteur
            // 
            this.tb_NomAuteur.Location = new System.Drawing.Point(244, 63);
            this.tb_NomAuteur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_NomAuteur.Name = "tb_NomAuteur";
            this.tb_NomAuteur.Size = new System.Drawing.Size(196, 31);
            this.tb_NomAuteur.TabIndex = 0;
            // 
            // tb_PrenomAuteur
            // 
            this.tb_PrenomAuteur.Location = new System.Drawing.Point(244, 135);
            this.tb_PrenomAuteur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_PrenomAuteur.Name = "tb_PrenomAuteur";
            this.tb_PrenomAuteur.Size = new System.Drawing.Size(196, 31);
            this.tb_PrenomAuteur.TabIndex = 1;
            // 
            // tb_DateNaisAuteur
            // 
            this.tb_DateNaisAuteur.Location = new System.Drawing.Point(244, 215);
            this.tb_DateNaisAuteur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_DateNaisAuteur.Name = "tb_DateNaisAuteur";
            this.tb_DateNaisAuteur.Size = new System.Drawing.Size(196, 31);
            this.tb_DateNaisAuteur.TabIndex = 2;
            // 
            // tb_DateMortAuteur
            // 
            this.tb_DateMortAuteur.Location = new System.Drawing.Point(244, 292);
            this.tb_DateMortAuteur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_DateMortAuteur.Name = "tb_DateMortAuteur";
            this.tb_DateMortAuteur.Size = new System.Drawing.Size(196, 31);
            this.tb_DateMortAuteur.TabIndex = 3;
            // 
            // l_nomAuteur
            // 
            this.l_nomAuteur.AutoSize = true;
            this.l_nomAuteur.Location = new System.Drawing.Point(24, 69);
            this.l_nomAuteur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_nomAuteur.Name = "l_nomAuteur";
            this.l_nomAuteur.Size = new System.Drawing.Size(68, 25);
            this.l_nomAuteur.TabIndex = 1;
            this.l_nomAuteur.Text = "Nom :";
            // 
            // l_prenomAuteur
            // 
            this.l_prenomAuteur.AutoSize = true;
            this.l_prenomAuteur.Location = new System.Drawing.Point(24, 140);
            this.l_prenomAuteur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_prenomAuteur.Name = "l_prenomAuteur";
            this.l_prenomAuteur.Size = new System.Drawing.Size(98, 25);
            this.l_prenomAuteur.TabIndex = 1;
            this.l_prenomAuteur.Text = "Prénom :";
            // 
            // l_dateNaisAuteur
            // 
            this.l_dateNaisAuteur.AutoSize = true;
            this.l_dateNaisAuteur.Location = new System.Drawing.Point(24, 221);
            this.l_dateNaisAuteur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_dateNaisAuteur.Name = "l_dateNaisAuteur";
            this.l_dateNaisAuteur.Size = new System.Drawing.Size(203, 25);
            this.l_dateNaisAuteur.TabIndex = 1;
            this.l_dateNaisAuteur.Text = "Date de naissance :";
            // 
            // l_dateMortAuteur
            // 
            this.l_dateMortAuteur.AutoSize = true;
            this.l_dateMortAuteur.Location = new System.Drawing.Point(24, 298);
            this.l_dateMortAuteur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_dateMortAuteur.Name = "l_dateMortAuteur";
            this.l_dateMortAuteur.Size = new System.Drawing.Size(163, 25);
            this.l_dateMortAuteur.TabIndex = 1;
            this.l_dateMortAuteur.Text = "Date de décès :";
            // 
            // b_valider
            // 
            this.b_valider.Location = new System.Drawing.Point(40, 408);
            this.b_valider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b_valider.Name = "b_valider";
            this.b_valider.Size = new System.Drawing.Size(150, 44);
            this.b_valider.TabIndex = 4;
            this.b_valider.Text = "Valider";
            this.b_valider.UseVisualStyleBackColor = true;
            this.b_valider.Click += new System.EventHandler(this.b_valider_Click);
            // 
            // b_Annuler
            // 
            this.b_Annuler.Location = new System.Drawing.Point(258, 408);
            this.b_Annuler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b_Annuler.Name = "b_Annuler";
            this.b_Annuler.Size = new System.Drawing.Size(150, 44);
            this.b_Annuler.TabIndex = 5;
            this.b_Annuler.Text = "Annuler";
            this.b_Annuler.UseVisualStyleBackColor = true;
            this.b_Annuler.Click += new System.EventHandler(this.b_Annuler_Click);
            // 
            // l_format
            // 
            this.l_format.AutoSize = true;
            this.l_format.Location = new System.Drawing.Point(184, 354);
            this.l_format.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_format.Name = "l_format";
            this.l_format.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_format.Size = new System.Drawing.Size(253, 25);
            this.l_format.TabIndex = 3;
            this.l_format.Text = "Format date : 31/12/1980";
            // 
            // FAddAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 502);
            this.ControlBox = false;
            this.Controls.Add(this.l_format);
            this.Controls.Add(this.b_Annuler);
            this.Controls.Add(this.b_valider);
            this.Controls.Add(this.l_dateMortAuteur);
            this.Controls.Add(this.l_dateNaisAuteur);
            this.Controls.Add(this.l_prenomAuteur);
            this.Controls.Add(this.l_nomAuteur);
            this.Controls.Add(this.tb_DateMortAuteur);
            this.Controls.Add(this.tb_DateNaisAuteur);
            this.Controls.Add(this.tb_PrenomAuteur);
            this.Controls.Add(this.tb_NomAuteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FAddAuteur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un auteur";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FAddAuteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NomAuteur;
        private System.Windows.Forms.TextBox tb_PrenomAuteur;
        private System.Windows.Forms.TextBox tb_DateNaisAuteur;
        private System.Windows.Forms.TextBox tb_DateMortAuteur;
        private System.Windows.Forms.Label l_nomAuteur;
        private System.Windows.Forms.Label l_prenomAuteur;
        private System.Windows.Forms.Label l_dateNaisAuteur;
        private System.Windows.Forms.Label l_dateMortAuteur;
        private System.Windows.Forms.Button b_valider;
        private System.Windows.Forms.Button b_Annuler;
        private System.Windows.Forms.Label l_format;
    }
}