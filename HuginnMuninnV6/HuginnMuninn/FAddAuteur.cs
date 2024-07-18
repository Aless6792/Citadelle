using HuginnMuninn.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuginnMuninn
{
    public partial class FAddAuteur : Form
    {
        private int b;
        private int mode = 0; //0Default:Create. 2:Update 3:Delete
        private Auteur a = new Auteur();
        public FAddAuteur()
        {
            InitializeComponent();
        }
        //Instance si mode 2||3
        public FAddAuteur(int id, int mod)
        {
            InitializeComponent();
            mode = mod;
            b = id;
            switch (mode)
            {
                default:
                    b_valider.Text = "Valider";
                    break;
                case 2:
                    b_valider.Text = "Confirmer";
                    Getting();
                    break;
                case 3:
                    b_valider.Text = "Supprimer";
                    Getting();
                    break;
            }
        }
        private void Getting()
        {
            a.Retrieve(b);
            tb_NomAuteur.Text = a.GetNomAuteur();
            tb_PrenomAuteur.Text = a.GetPrenomAuteur();
            tb_DateNaisAuteur.Text = a.GetDateNaissance().ToString("dd/MM/yyyy");
            tb_DateMortAuteur.Text = a.GetDateMort().ToString("dd/MM/yyyy");
        }

        private void Setting(int? id)
        {
            a.SetIdAuteur(id);
            a.SetNomAuteur(tb_NomAuteur.Text);
            a.SetPrenomAuteur(tb_PrenomAuteur.Text);
            a.SetDateNaissance(DateTime.Parse(tb_DateNaisAuteur.Text));
            a.SetDateMort(DateTime.Parse(tb_DateMortAuteur.Text));
        }

        private void b_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_valider_Click(object sender, EventArgs e)
        {
            int? id;
            id = b;
            if (a.GetIdAuteur() == null && (id == 0 || id == null))
            { 
                id = a.MaxId();
            }
            switch (mode)
            {
                default:
                    Setting(id);
                    a.Create();
                    break;
                case 2:
                    Setting(id);
                    a.Update();
                    break;
                case 3:
                    a.Delete();
                    break;
            }
            this.Close();
        }

        private void FAddAuteur_Load(object sender, EventArgs e)
        {

        }
    }
}
