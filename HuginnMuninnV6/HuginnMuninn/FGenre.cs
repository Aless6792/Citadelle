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
    public partial class FGenre : Form
    {
        private Genre g = new Genre();
        private string nomClasse;
        public FGenre()
        {
            InitializeComponent();
            dgv_genre.ColumnCount = 2;
            //Nommer les colonnes.
            dgv_genre.Columns[0].Name = "Id";
            dgv_genre.Columns[1].Name = "Libellé";
            nomClasse = g.GetType().Name;
        }

        private void dgv_genre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FGenre_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            dgv_genre.Rows.Clear();
            List<Genre> G;
            G = g.FindAll();
            foreach (Genre g in G)
            {
                dgv_genre.Rows.Add(g.GetIdGenre(), g.GetLibelle());
            }
        }
        private void F2Champs_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            F2Champs fiche = new F2Champs(nomClasse);
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Text = "Genre des Livres";
            fiche.Show();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_genre.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 2, nomClasse);
            fiche.Text = "Genre des Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_genre.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 3, nomClasse);
            fiche.Text = "Genre des Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
