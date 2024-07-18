namespace HuginnMuninn
{
    partial class FEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditeur));
            this.dgv_editeur = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_reload = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editeur)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_editeur
            // 
            this.dgv_editeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_editeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_editeur.Location = new System.Drawing.Point(0, 0);
            this.dgv_editeur.Name = "dgv_editeur";
            this.dgv_editeur.RowHeadersWidth = 82;
            this.dgv_editeur.RowTemplate.Height = 33;
            this.dgv_editeur.Size = new System.Drawing.Size(1896, 827);
            this.dgv_editeur.TabIndex = 0;
            this.dgv_editeur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_editeur_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_modify,
            this.tsb_delete,
            this.tsb_reload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1896, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(178, 44);
            this.tsb_add.Text = "Ajouter Editeur";
            this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(191, 74);
            this.tsb_modify.Text = "Modifier Editeur";
            this.tsb_modify.Click += new System.EventHandler(this.tsb_modify_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(211, 74);
            this.tsb_delete.Text = "Supprimer Editeur";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_reload
            // 
            this.tsb_reload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_reload.Image = ((System.Drawing.Image)(resources.GetObject("tsb_reload.Image")));
            this.tsb_reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_reload.Name = "tsb_reload";
            this.tsb_reload.Size = new System.Drawing.Size(124, 74);
            this.tsb_reload.Text = "Recharger";
            this.tsb_reload.Click += new System.EventHandler(this.tsb_reload_Click);
            // 
            // FEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 827);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_editeur);
            this.Name = "FEditeur";
            this.Text = "Editeurs";
            this.Load += new System.EventHandler(this.FEditeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editeur)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_editeur;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_reload;
    }
}