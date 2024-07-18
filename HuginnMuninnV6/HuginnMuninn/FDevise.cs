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
    public partial class FDevise : Form
    {
        private Devise d = new Devise();
        private string nomClasse;
        public FDevise()
        {
            InitializeComponent();
            dgv_devise.ColumnCount = 2;
            //Nommer les colonnes.
            dgv_devise.Columns[0].Name = "Id";
            dgv_devise.Columns[1].Name = "Libellé";
            nomClasse = d.GetType().Name;
        }

        private void FDevise_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            dgv_devise.Rows.Clear();
            List<Devise> D;
            D = d.FindAll();
            foreach (Devise d in D)
            {
                dgv_devise.Rows.Add(d.GetIdDevise(), d.GetDevise());
            }
        }
        private void F2Champs_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void dgv_devise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            F2Champs fiche = new F2Champs(nomClasse);
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Text = "Etat Devise";
            fiche.Show();
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_devise.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 2, nomClasse);
            fiche.Text = "Etat Devise";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_devise.CurrentRow.Cells[0].Value;
            F2Champs fiche = new F2Champs(id, 3, nomClasse);
            fiche.Text = "Etat Devise";
            fiche.FormClosing += new FormClosingEventHandler(this.F2Champs_FormClosing);
            fiche.Show();
        }

        private void tsb_reload_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}