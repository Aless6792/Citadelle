namespace HuginnMuninn
{
    partial class F2Champs
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
            this.b_valider = new System.Windows.Forms.Button();
            this.b_annuler = new System.Windows.Forms.Button();
            this.l_libelle = new System.Windows.Forms.Label();
            this.tb_libelle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_valider
            // 
            this.b_valider.Location = new System.Drawing.Point(107, 239);
            this.b_valider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b_valider.Name = "b_valider";
            this.b_valider.Size = new System.Drawing.Size(149, 44);
            this.b_valider.TabIndex = 0;
            this.b_valider.Text = "Valider";
            this.b_valider.UseVisualStyleBackColor = true;
            this.b_valider.Click += new System.EventHandler(this.b_valider_Click);
            // 
            // b_annuler
            // 
            this.b_annuler.Location = new System.Drawing.Point(350, 239);
            this.b_annuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.b_annuler.Name = "b_annuler";
            this.b_annuler.Size = new System.Drawing.Size(149, 44);
            this.b_annuler.TabIndex = 0;
            this.b_annuler.Text = "Annuler";
            this.b_annuler.UseVisualStyleBackColor = true;
            this.b_annuler.Click += new System.EventHandler(this.b_annuler_Click);
            // 
            // l_libelle
            // 
            this.l_libelle.AutoSize = true;
            this.l_libelle.Location = new System.Drawing.Point(91, 82);
            this.l_libelle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_libelle.Name = "l_libelle";
            this.l_libelle.Size = new System.Drawing.Size(75, 25);
            this.l_libelle.TabIndex = 1;
            this.l_libelle.Text = "Libelle";
            // 
            // tb_libelle
            // 
            this.tb_libelle.Location = new System.Drawing.Point(267, 82);
            this.tb_libelle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_libelle.Name = "tb_libelle";
            this.tb_libelle.Size = new System.Drawing.Size(232, 31);
            this.tb_libelle.TabIndex = 2;
            this.tb_libelle.TextChanged += new System.EventHandler(this.tb_libelle_TextChanged);
            // 
            // F2Champs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 382);
            this.Controls.Add(this.tb_libelle);
            this.Controls.Add(this.l_libelle);
            this.Controls.Add(this.b_annuler);
            this.Controls.Add(this.b_valider);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F2Champs";
            this.Text = "F2Champs";
            this.Load += new System.EventHandler(this.F2Champs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_valider;
        private System.Windows.Forms.Button b_annuler;
        private System.Windows.Forms.Label l_libelle;
        private System.Windows.Forms.TextBox tb_libelle;
    }
}