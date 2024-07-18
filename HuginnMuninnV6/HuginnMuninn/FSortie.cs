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
    public partial class FSortie : Form
    {
        private Sortie s = new Sortie();
        private string nomClasse;
        public FSortie()
        {
            InitializeComponent();
            dgv_sortie.ColumnCount = 2;
            //Nommer les colonnes.
            dgv_sortie.Columns[0].Name = "Id";
            dgv_sortie.Columns[1].Name = "Libellé";
            nomClasse = s.GetType().Name;
        }

        private void dgv_sortie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FSortie_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            dgv_sortie.Rows.Clear();
            List<Sortie> S;
            S = s.FindAll();
            foreach (Sortie s in S)
            {
                dgv_sortie.Rows.Add(s.GetIdSortie(), s.GetRaisonSortie());
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
            fiche.Text = "Sortie des Livres";
            fiche.Show();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_sortie.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 2, nomClasse);
            fiche.Text = "Sortie des Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_sortie.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 3, nomClasse);
            fiche.Text = "Sortie des Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
