using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuginnMuninn.Classes;

namespace HuginnMuninn
{
    public partial class F2Champs : Form
    {
        private string objet;
        private int b;
        private int mode = 0; //0Default:Create. 2:Update 3:Delete
        private TypeLivre a = new TypeLivre();
        private Devise d = new Devise();
        private Editeur ed = new Editeur();
        private Etat etat = new Etat();
        private Genre g = new Genre();
        private Sortie s = new Sortie();
        private Livre l = new Livre();
        public F2Champs(string obj)
        {
            InitializeComponent();
            objet = obj;
        }
        public F2Champs(int id, int mod, string obj)
        {
            InitializeComponent();
            objet = obj;
            mode = mod;
            b = id;
            switch (mode)
            {
                default:
                    b_valider.Text = "Valider";
                    Getting();
                    break;
                case 2:
                    b_valider.Text = "Modifier";
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
            switch (objet){
                default:
                    break;
                case "TypeLivre":
                    a.Retrieve(b);
                    tb_libelle.Text = a.GetLibelle();
                    break;
                case "Devise":
                    d.Retrieve(b);
                    tb_libelle.Text = d.GetDevise();
                    break;
                case "Editeur":
                    ed.Retrieve(b);
                    tb_libelle.Text = ed.GetNomEditeur();
                    break;
                case "Etat":
                    etat.Retrieve(b);
                    tb_libelle.Text = etat.GetLibelle();
                    break;
                case "Genre":
                    g.Retrieve(b);
                    tb_libelle.Text = g.GetLibelle();
                    break;
                case "Sortie":
                    s.Retrieve(b);
                    tb_libelle.Text = s.GetRaisonSortie();
                    break;
            }
            
        }
        private void Setting(int id)
        {
            switch (objet)
            {
                default:
                    break;
                case "TypeLivre":
                    a.SetIdTypeLivre(id);
                    a.SetLibelle(tb_libelle.Text);
                    break;
                case "Devise":
                    d.SetIdDevise(id);
                    d.SetDevise(tb_libelle.Text);
                    break;
                case "Editeur":
                    ed.SetIdEditeur(id);
                    ed.SetNomEditeur(tb_libelle.Text);
                    break;
                case "Etat":
                    etat.SetIdEtat(id);
                    etat.SetLibelle(tb_libelle.Text);
                    break;
                case "Genre":
                    g.SetIdGenre(id);
                    g.SetLibelle(tb_libelle.Text);
                    break;
                case "Sortie":
                    s.SetIdSortie(id);
                    s.SetRaisonSortie(tb_libelle.Text);
                    break;
            } 
        }
        private void b_valider_Click(object sender, EventArgs e)
        {
            int? id =0;
            id = b;
            switch (objet)
            {
                default:
                    break;
                case "TypeLivre":
                    switch (mode)
                    {
                        default:
                            id = a.MaxId();
                            b = (int)id;
                            Setting(b);
                            a.Create();
                            break;
                        case 2:
                            Setting(b);
                            a.Update();
                            break;
                        case 3:
                            a.Delete();
                            break;
                    }
                    break;
                case "Devise":
                    switch (mode)
                    {
                        default:
                            id = d.MaxId();
                            b = (int)id;
                            Setting(b);
                            d.Create();
                            break;
                        case 2:
                            Setting(b);
                            d.Update();
                            break;
                        case 3:
                            d.Delete();
                            break;
                    }
                    break;
                case "Editeur":
                    switch (mode)
                    {
                        default:
                            id = ed.MaxId();
                            b = (int)id;
                            Setting(b);
                            ed.Create();
                            break;
                        case 2:
                            Setting(b);
                            ed.Update();
                            break;
                        case 3:
                            ed.Delete();
                            break;
                    }
                    break;
                case "Etat":
                    switch (mode)
                    {
                        default:
                            id = etat.MaxId();
                            b = (int)id;
                            Setting(b);
                            etat.Create();
                            break;
                        case 2:
                            Setting(b);
                            etat.Update();
                            break;
                        case 3:
                            etat.Delete();
                            break;
                    }
                    break;
                case "Genre":
                    switch (mode)
                    {
                        default:
                            id = g.MaxId();
                            b = (int)id;
                            Setting(b);
                            g.Create();
                            break;
                        case 2:
                            Setting(b);
                            g.Update();
                            break;
                        case 3:
                            g.Delete();
                            break;
                    }
                    break;
                case "Sortie":
                    switch (mode)
                    {
                        default:
                            id = s.MaxId();
                            b = (int)id;
                            Setting(b);
                            s.Create();
                            break;
                        case 2:
                            Setting(b);
                            s.Update();
                            break;
                        case 3:
                            s.Delete();
                            break;
                    }
                    break;
            }
            this.Close();
        }

        private void tb_libelle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void b_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F2Champs_Load(object sender, EventArgs e)
        {

        }
    }
}
