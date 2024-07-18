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
    public partial class FEtat : Form
    {
        private Etat et = new Etat();
        private string nomClasse;
        public FEtat()
        {
            InitializeComponent();
            dgv_etat.ColumnCount = 2;
            //Nommer les colonnes.
            dgv_etat.Columns[0].Name = "Id";
            dgv_etat.Columns[1].Name = "Libellé";
            nomClasse = et.GetType().Name;
        }

        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F2Champs_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            F2Champs fiche = new F2Champs(nomClasse);
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Text = "Etat des Livres";
            fiche.Show();
        }

        private void reload()
        {
            dgv_etat.Rows.Clear();
            List<Etat> Et;
            Et = et.FindAll();
            foreach (Etat b in Et)
            {
                dgv_etat.Rows.Add(b.GetIdEtat(), b.GetLibelle());
            }
        }

        private void FEtat_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_etat.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 2, nomClasse);
            fiche.Text = "Etat des livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_etat.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 3, nomClasse);
            fiche.Text = "Etat des Livres";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }
    }
}
