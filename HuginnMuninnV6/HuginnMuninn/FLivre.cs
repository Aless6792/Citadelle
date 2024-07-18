using HuginnMuninn.Classes;
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
    public partial class FLivre : Form
    {
        private Livre l = new Livre();
        private string nomClasse;
        public FLivre()
        {
            InitializeComponent();
            dgv_livre.ColumnCount = 21;
            dgv_livre.Columns[0].Name = "Id";
            dgv_livre.Columns[1].Name = "Titre";
            dgv_livre.Columns[2].Name = "Isbn";
            dgv_livre.Columns[3].Name = "Nombre de Pages";
            dgv_livre.Columns[4].Name = "Poids";
            dgv_livre.Columns[5].Name = "Date de Première Publication";
            dgv_livre.Columns[6].Name = "Date de Publication";
            dgv_livre.Columns[7].Name = "Prix Initial";
            dgv_livre.Columns[8].Name = "Date Entrée Stock";
            dgv_livre.Columns[9].Name = "Date Sortie Stock";
            dgv_livre.Columns[10].Name = "Hauteur";
            dgv_livre.Columns[11].Name = "Largeur";
            dgv_livre.Columns[12].Name = "Commentaire";
            dgv_livre.Columns[13].Name = "Synopsis";
            dgv_livre.Columns[14].Name = "Type";
            dgv_livre.Columns[15].Name = "La Devise";
            dgv_livre.Columns[16].Name = "La Sortie";
            dgv_livre.Columns[17].Name = "Un Etat";
            dgv_livre.Columns[18].Name = "Un Editeur";
            dgv_livre.Columns[19].Name = "Les Auteurs";
            dgv_livre.Columns[20].Name = "Les Genres";
        }

        private void dgv_livre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FLivre_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            dgv_livre.Rows.Clear();
            List<Livre> L;
            L = l.FindAll();
            foreach (Livre l in L)
            {
                List<Auteur> au = new List<Auteur>();
                List<Genre> Gs = new List<Genre>();
                au = l.GetLesAuteurs();
                string auteur = "";
                foreach (Auteur at in au)
                {
                    auteur = auteur + at.GetNomAuteur();
                }
                Gs = l.GetLesGenres();
                string genres = "";
                foreach (Genre g in Gs)
                { 
                    genres = genres + g.GetLibelle();
                }
                dgv_livre.Rows.Add(l.GetIdLivre(), l.GetTitre(), l.GetIsbn(), l.GetNombrePages(), l.GetPoids(), l.GetDatePremierePublication().ToString("d MMM yyyy"), l.GetDatePublication().ToString("d MMM yyyy"), l.GetPrixInitial(), l.GetDateEntreeStock().ToString("d MMM yyyy"), l.GetDateSortieStock().ToString("d MMM yyyy"), l.GetHauteur(), l.GetLargeur(), l.GetCommentaire(), l.GetSynopsys(), l.GetLeType(), l.GetLaDevise(), l.GetLaSortie(), l.GetUnEtat(), l.GetUnEditeur(), l.GetLesAuteurs(), l.GetLesGenres());
            }
        }

        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            FAddLivre fiche = new FAddLivre();
            fiche.FormClosing += new FormClosingEventHandler(this.FAddLivre_FormClosing);
            fiche.Show();
        }

        private void Fiche_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FAddLivre_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {

        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
