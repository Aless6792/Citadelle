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
    public partial class FEditeur : Form
    {
        private Editeur ed = new Editeur();
        private string nomClasse;
        public FEditeur()
        {
            InitializeComponent();
            dgv_editeur.ColumnCount = 2;
            //Nommer les colonnes.
            dgv_editeur.Columns[0].Name = "Id";
            dgv_editeur.Columns[1].Name = "Libellé";
            nomClasse = ed.GetType().Name;
        }

        private void dgv_editeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FEditeur_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            dgv_editeur.Rows.Clear();
            List<Editeur> Ed;
            Ed = ed.FindAll();
            foreach (Editeur b in Ed)
            {
                dgv_editeur.Rows.Add(b.GetIdEditeur(), b.GetNomEditeur());
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
            fiche.Text = "Editeurs";
            fiche.Show();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_editeur.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 2, nomClasse);
            fiche.Text = "Editeurs";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_editeur.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 3, nomClasse);
            fiche.Text = "Editeurs";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
