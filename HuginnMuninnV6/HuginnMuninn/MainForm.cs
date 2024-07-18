/*
 * Crée par SharpDevelop.
 * Utilisateur: y.fortin
 * Date: 22/11/2023
 * Heure: 14:39
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using HuginnMuninn.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HuginnMuninn
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {

        Form_Connexion connex = new Form_Connexion();

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //

            connex.Show();
            connex.BringToFront();
            connex.Activate();
        }


        private void connecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Connexion connex = new Form_Connexion();
            connex.Show();

        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAuteur fAuteur = new FAuteur();
            fAuteur.Show();
            if (fAuteur.WindowState == FormWindowState.Minimized)
            {
                fAuteur.MdiParent = this;
                fAuteur.WindowState = FormWindowState.Maximized;
            }
            else
            {
                fAuteur = new FAuteur();
                fAuteur.MdiParent = this;
                fAuteur.Show();
                fAuteur.WindowState = FormWindowState.Maximized;
            }
        }

        private void typesDeLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTypeLivre ftypelivre = new FTypeLivre();
            ftypelivre.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void etatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEtat fetat = new FEtat();
            fetat.Show();
        }

        private void deviseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDevise fDevise = new FDevise();
            fDevise.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGenre fGenre = new FGenre();
            fGenre.Show();
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLivre flivre = new FLivre();
            flivre.Show();
        }

        private void sortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSortie fSortie = new FSortie();
            fSortie.Show();
        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEditeur fediteur = new FEditeur();
            fediteur.Show();
        }
    }
}
