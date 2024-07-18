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
using static System.Net.WebRequestMethods;

namespace HuginnMuninn
{
    public partial class FTypeLivre : Form
    {
        private TypeLivre tl = new TypeLivre();
        private string nomClasse;

        public FTypeLivre()
        {
            InitializeComponent();
            //Créer les colonnes d'un DataGridView
            //D'abord ajouter le nombre de colonne. Compter depuis l'index 0.
            dgv_typeLivres.ColumnCount = 2;
            //Nommer les colonnes.
            dgv_typeLivres.Columns[0].Name = "Id";
            dgv_typeLivres.Columns[1].Name = "Libellé";
            nomClasse = tl.GetType().Name;
        }
        private void reload()
        {
            dgv_typeLivres.Rows.Clear();
            List<TypeLivre> Tls;
            Tls = tl.FindAll();
            foreach (TypeLivre b in Tls)
            {
                dgv_typeLivres.Rows.Add(b.GetIdTypeLivre(), b.GetLibelle());
            }
        }
        private void FTypeLivre_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void dgv_typeLivres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            F2Champs fiche = new F2Champs(nomClasse);
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Text = "Type de Livres";
            fiche.Show();
        }
        private void F2Champs_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_typeLivres.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 2, nomClasse);
            fiche.Text = "Type de Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void t_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_typeLivres.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 3, nomClasse);
            fiche.Text = "Type de Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
