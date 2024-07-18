namespace HuginnMuninn
{
    partial class Form_Connexion
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
            this.b_Conn = new System.Windows.Forms.Button();
            this.tb_Serveur = new System.Windows.Forms.TextBox();
            this.tb_Utilisateur = new System.Windows.Forms.TextBox();
            this.tb_Mdp = new System.Windows.Forms.TextBox();
            this.tb_BDD = new System.Windows.Forms.TextBox();
            this.l_Serveur = new System.Windows.Forms.Label();
            this.l_Utilisateur = new System.Windows.Forms.Label();
            this.l_Mdp = new System.Windows.Forms.Label();
            this.l_BDD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Conn
            // 
            this.b_Conn.Location = new System.Drawing.Point(70, 171);
            this.b_Conn.Name = "b_Conn";
            this.b_Conn.Size = new System.Drawing.Size(75, 23);
            this.b_Conn.TabIndex = 0;
            this.b_Conn.Text = "Connexion";
            this.b_Conn.UseVisualStyleBackColor = true;
            this.b_Conn.Click += new System.EventHandler(this.b_Conn_Click);
            // 
            // tb_Serveur
            // 
            this.tb_Serveur.Location = new System.Drawing.Point(106, 12);
            this.tb_Serveur.Name = "tb_Serveur";
            this.tb_Serveur.Size = new System.Drawing.Size(100, 20);
            this.tb_Serveur.TabIndex = 1;
            // 
            // tb_Utilisateur
            // 
            this.tb_Utilisateur.Location = new System.Drawing.Point(106, 47);
            this.tb_Utilisateur.Name = "tb_Utilisateur";
            this.tb_Utilisateur.Size = new System.Drawing.Size(100, 20);
            this.tb_Utilisateur.TabIndex = 2;
            // 
            // tb_Mdp
            // 
            this.tb_Mdp.Location = new System.Drawing.Point(106, 84);
            this.tb_Mdp.Name = "tb_Mdp";
            this.tb_Mdp.PasswordChar = '*';
            this.tb_Mdp.Size = new System.Drawing.Size(100, 20);
            this.tb_Mdp.TabIndex = 3;
            // 
            // tb_BDD
            // 
            this.tb_BDD.Location = new System.Drawing.Point(106, 123);
            this.tb_BDD.Name = "tb_BDD";
            this.tb_BDD.Size = new System.Drawing.Size(100, 20);
            this.tb_BDD.TabIndex = 4;
            // 
            // l_Serveur
            // 
            this.l_Serveur.AutoSize = true;
            this.l_Serveur.Location = new System.Drawing.Point(12, 15);
            this.l_Serveur.Name = "l_Serveur";
            this.l_Serveur.Size = new System.Drawing.Size(44, 13);
            this.l_Serveur.TabIndex = 5;
            this.l_Serveur.Text = "Serveur";
            // 
            // l_Utilisateur
            // 
            this.l_Utilisateur.AutoSize = true;
            this.l_Utilisateur.Location = new System.Drawing.Point(12, 50);
            this.l_Utilisateur.Name = "l_Utilisateur";
            this.l_Utilisateur.Size = new System.Drawing.Size(53, 13);
            this.l_Utilisateur.TabIndex = 6;
            this.l_Utilisateur.Text = "Utilisateur";
            // 
            // l_Mdp
            // 
            this.l_Mdp.AutoSize = true;
            this.l_Mdp.Location = new System.Drawing.Point(12, 87);
            this.l_Mdp.Name = "l_Mdp";
            this.l_Mdp.Size = new System.Drawing.Size(72, 13);
            this.l_Mdp.TabIndex = 7;
            this.l_Mdp.Text = "Mot de Passe";
            // 
            // l_BDD
            // 
            this.l_BDD.AutoSize = true;
            this.l_BDD.Location = new System.Drawing.Point(12, 126);
            this.l_BDD.Name = "l_BDD";
            this.l_BDD.Size = new System.Drawing.Size(85, 13);
            this.l_BDD.TabIndex = 8;
            this.l_BDD.Text = "Base de donnée";
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 212);
            this.Controls.Add(this.l_BDD);
            this.Controls.Add(this.l_Mdp);
            this.Controls.Add(this.l_Utilisateur);
            this.Controls.Add(this.l_Serveur);
            this.Controls.Add(this.tb_BDD);
            this.Controls.Add(this.tb_Mdp);
            this.Controls.Add(this.tb_Utilisateur);
            this.Controls.Add(this.tb_Serveur);
            this.Controls.Add(this.b_Conn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Connexion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Conn;
        private System.Windows.Forms.TextBox tb_Serveur;
        private System.Windows.Forms.TextBox tb_Utilisateur;
        private System.Windows.Forms.TextBox tb_Mdp;
        private System.Windows.Forms.TextBox tb_BDD;
        private System.Windows.Forms.Label l_Serveur;
        private System.Windows.Forms.Label l_Utilisateur;
        private System.Windows.Forms.Label l_Mdp;
        private System.Windows.Forms.Label l_BDD;
    }
}