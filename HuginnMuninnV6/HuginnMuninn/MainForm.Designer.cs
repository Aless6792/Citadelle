/*
 * Crée par SharpDevelop.
 * Utilisateur: y.fortin
 * Date: 22/11/2023
 * Heure: 14:39
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace HuginnMuninn
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_bdd = new System.Windows.Forms.ToolStripStatusLabel();
            this.Statut_bdd = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesDeLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_bdd,
            this.Statut_bdd});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2148, 42);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_bdd
            // 
            this.Status_bdd.Name = "Status_bdd";
            this.Status_bdd.Size = new System.Drawing.Size(0, 32);
            // 
            // Statut_bdd
            // 
            this.Statut_bdd.Name = "Statut_bdd";
            this.Statut_bdd.Size = new System.Drawing.Size(125, 32);
            this.Statut_bdd.Text = "Statut bdd";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.éditionToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2148, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connecterToolStripMenuItem,
            this.toolStripSeparator1,
            this.baseToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // connecterToolStripMenuItem
            // 
            this.connecterToolStripMenuItem.Name = "connecterToolStripMenuItem";
            this.connecterToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.connecterToolStripMenuItem.Text = "Connecter";
            this.connecterToolStripMenuItem.Click += new System.EventHandler(this.connecterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteursToolStripMenuItem,
            this.typesDeLivresToolStripMenuItem,
            this.deviseToolStripMenuItem,
            this.editeurToolStripMenuItem,
            this.etatToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.livreToolStripMenuItem,
            this.sortieToolStripMenuItem});
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.baseToolStripMenuItem.Text = "Base ...";
            // 
            // auteursToolStripMenuItem
            // 
            this.auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            this.auteursToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.auteursToolStripMenuItem.Text = "Auteurs";
            this.auteursToolStripMenuItem.Click += new System.EventHandler(this.auteursToolStripMenuItem_Click);
            // 
            // typesDeLivresToolStripMenuItem
            // 
            this.typesDeLivresToolStripMenuItem.Name = "typesDeLivresToolStripMenuItem";
            this.typesDeLivresToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.typesDeLivresToolStripMenuItem.Text = "Types de Livres";
            this.typesDeLivresToolStripMenuItem.Click += new System.EventHandler(this.typesDeLivresToolStripMenuItem_Click);
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.etatToolStripMenuItem.Text = "Etat";
            this.etatToolStripMenuItem.Click += new System.EventHandler(this.etatToolStripMenuItem_Click);
            // 
            // deviseToolStripMenuItem
            // 
            this.deviseToolStripMenuItem.Name = "deviseToolStripMenuItem";
            this.deviseToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.deviseToolStripMenuItem.Text = "Devise";
            this.deviseToolStripMenuItem.Click += new System.EventHandler(this.deviseToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.livreToolStripMenuItem.Text = "Livre";
            this.livreToolStripMenuItem.Click += new System.EventHandler(this.livreToolStripMenuItem_Click);
            // 
            // sortieToolStripMenuItem
            // 
            this.sortieToolStripMenuItem.Name = "sortieToolStripMenuItem";
            this.sortieToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.sortieToolStripMenuItem.Text = "Sortie";
            this.sortieToolStripMenuItem.Click += new System.EventHandler(this.sortieToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.quitToolStripMenuItem.Text = "Quitter";
            // 
            // éditionToolStripMenuItem
            // 
            this.éditionToolStripMenuItem.Name = "éditionToolStripMenuItem";
            this.éditionToolStripMenuItem.Size = new System.Drawing.Size(108, 38);
            this.éditionToolStripMenuItem.Text = "Édition";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.àProposToolStripMenuItem.Text = "À propos";
            // 
            // editeurToolStripMenuItem
            // 
            this.editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            this.editeurToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.editeurToolStripMenuItem.Text = "Editeur";
            this.editeurToolStripMenuItem.Click += new System.EventHandler(this.editeurToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2148, 1422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huginn & Muninn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem éditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem baseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesDeLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Status_bdd;
        private System.Windows.Forms.ToolStripStatusLabel Statut_bdd;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeurToolStripMenuItem;
    }
}
