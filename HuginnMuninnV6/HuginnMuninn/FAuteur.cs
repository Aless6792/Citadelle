using HuginnMuninn.Classes;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuginnMuninn
{
    public partial class FAuteur : Form
    {
        public FAuteur()
        {
            InitializeComponent();
            //Créer les colonnes d'un DataGridView
            //D'abord ajouter le nombre de colonne. Compter depuis l'index 0.
            dgv_Auteurs.ColumnCount = 11;
            //Nommer les colonnes.
            dgv_Auteurs.Columns[0].Name = "Id";
            dgv_Auteurs.Columns[1].Name = "Nom";
            dgv_Auteurs.Columns[2].Name = "Prénom";
            dgv_Auteurs.Columns[3].Name = "Jour de Naissance";
            dgv_Auteurs.Columns[4].Name = "Quantième de Naissance";
            dgv_Auteurs.Columns[5].Name = "Mois de Naissance";
            dgv_Auteurs.Columns[6].Name = "Année de Naissance";
            dgv_Auteurs.Columns[7].Name = "Jour de Mort";
            dgv_Auteurs.Columns[8].Name = "Quantième de Mort";
            dgv_Auteurs.Columns[9].Name = "Mois de Mort";
            dgv_Auteurs.Columns[10].Name = "Année de Mort";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Tool Strip Bar
        private void tsb_addAuteur_Click(object sender, EventArgs e)
        {
            FAddAuteur fiche = new FAddAuteur();
            fiche.FormClosing += new FormClosingEventHandler(this.FAddAuteur_FormClosing);
            fiche.Show();
        }

        private void reload()
        {
            dgv_Auteurs.Rows.Clear();
            Auteur auteur = new Auteur();
            List<Auteur> As;
            As = auteur.FindAll();
            foreach (Auteur b in As)
            {
                dgv_Auteurs.Rows.Add(b.GetIdAuteur(),b.GetNomAuteur(),b.GetPrenomAuteur(), b.GetDateNaissance().ToString("dddd"), b.GetDateNaissance().ToString("dd"), b.GetDateNaissance().ToString("MMMM"), b.GetDateNaissance().ToString("yyyy"), b.GetDateMort().ToString("dddd"), b.GetDateMort().ToString("dd"), b.GetDateMort().ToString("MMMM"), b.GetDateMort().ToString("yyyy"));
            }
        }

        private void FAuteur_Load(object sender, EventArgs e)
        {
            reload();
        }

        // Bouton Recharger
        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }

        //Réactualisation des form à la fermeture de celle-ci
        private void FAddAuteur_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        // Tool Strip Bar
        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_Auteurs.CurrentRow.Cells[0].Value;
            FAddAuteur fiche = new FAddAuteur(id, 2);
            fiche.FormClosing += new FormClosingEventHandler(this.FAddAuteur_FormClosing);
            fiche.Show();
        }

        // Tool Strip Bar
        private void tsb_Delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_Auteurs.CurrentRow.Cells[0].Value;
            FAddAuteur fiche = new FAddAuteur(id, 3);
            fiche.FormClosing += new FormClosingEventHandler(this.FAddAuteur_FormClosing);
            fiche.Show();
        }
    }
}
