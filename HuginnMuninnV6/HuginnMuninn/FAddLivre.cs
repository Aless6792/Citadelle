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
    public partial class FAddLivre : Form
    {
        private int b;
        private int mode = 0; // 0/Default:Create. 2:Update 3:Delete
        private Livre l = new Livre();
        TypeLivre TL = new TypeLivre();
        Devise D = new Devise();
        Sortie S = new Sortie();
        Etat E = new Etat();
        Editeur ED = new Editeur();
        Auteur A = new Auteur();
        Genre G = new Genre();

        List<TypeLivre> tls = new List<TypeLivre>();
        List<Devise> ds = new List<Devise>();
        List<Sortie> ss = new List<Sortie>();
        List<Etat> es = new List<Etat>();
        List<Editeur> eds = new List<Editeur>();
        List<Auteur> As = new List<Auteur>();
        List<Genre> gs = new List<Genre>();
        public void formatage()
        {
            dtp_es.CustomFormat = "dd/MM/yyyy";
            dtp_p.CustomFormat = "dd/MM/yyyy";
            dtp_pp.CustomFormat = "dd/MM/yyyy";
            dtp_ss.CustomFormat = "dd/MM/yyyy";
        }
        public FAddLivre()
        {
            InitializeComponent();
            formatage();

        }
        public FAddLivre(int id, int mod)
        {
            InitializeComponent();
            formatage();
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

        private void FAddLivre_Load(object sender, EventArgs e)
        {
            ds = D.FindAll();
            foreach (Devise d in ds)
            {
                cb_d.Items.Add(new KeyValuePair<int, string>((int)d.GetIdDevise(), d.GetDevise()));
            }

            ss = S.FindAll();
            foreach (Sortie s in ss)
            {
                cb_s.Items.Add(new KeyValuePair<int, string>((int)s.GetIdSortie(), s.GetRaisonSortie()));
            }

            es = E.FindAll();
            foreach (Etat et in es)
            {
                cb_e.Items.Add(new KeyValuePair<int, string>((int)et.GetIdEtat(), et.GetLibelle()));
            }

            eds = ED.FindAll();
            foreach (Editeur ed in eds)
            {
                cb_ed.Items.Add(new KeyValuePair<int, string>((int)ed.GetIdEditeur(), ed.GetNomEditeur()));
            }

            tls = TL.FindAll();
            foreach (TypeLivre tl in tls)
            {
                cb_tl.Items.Add(new KeyValuePair<int, string>((int)tl.GetIdTypeLivre(), tl.GetLibelle()));
            }
            
            As = A.FindAll();
            foreach(Auteur a in As)
            {
                cb_a.Items.Add(new KeyValuePair <int, string>((int)a.GetIdAuteur(), a.GetNomAuteur()+" "+a.GetPrenomAuteur()));
            }
            
            gs = G.FindAll();
            foreach (Genre g in gs)
            {
                cb_g.Items.Add(new KeyValuePair<int, string>((int)g.GetIdGenre(), g.GetLibelle()));
            }
        }
        private void Getting()
        {
            l.Retrieve(b);
            tb_titre.Text = l.GetTitre();
            tb_isbn.Text = l.GetIsbn();
            tb_nbp.Text = l.GetNombrePages().ToString();
            tb_poids.Text = l.GetPoids().ToString();
            dtp_pp.Value = l.GetDatePremierePublication();
            dtp_p.Value = l.GetDatePublication();
            tb_prixini.Text = l.GetPrixInitial().ToString();
            dtp_es.Value = l.GetDateEntreeStock();
            dtp_ss.Value = l.GetDateSortieStock();
            tb_hauteur.Text = l.GetHauteur().ToString();
            tb_largeur.Text = l.GetLargeur().ToString();
            tb_com.Text = l.GetCommentaire();
            tb_synopsis.Text = l.GetSynopsys().ToString();
            cb_tl.Text = l.GetLeType().ToString();
            cb_d.Text = l.GetLaDevise().ToString();
            cb_s.Text = l.GetLaSortie().ToString();
            cb_e.Text = l.GetUnEtat().ToString();
            cb_ed.Text = l.GetUnEditeur().ToString();
        }

        private void Setting(int? id)
        {
            l.SetIdLivre((int)id);
            l.SetTitre(tb_titre.Text);
            l.SetIsbn(tb_isbn.Text);
            l.SetNombrePages(int.Parse(tb_nbp.Text));
            l.SetPoids(int.Parse(tb_poids.Text));
            l.SetDatePremierePublication(DateTime.Parse(dtp_pp.Text));
            l.SetDatePublication(DateTime.Parse(dtp_p.Text));
            l.SetPrixInitial(float.Parse(tb_prixini.Text));
            l.SetDateEntreeStock(DateTime.Parse(dtp_es.Text));
            l.SetDateSortieStock(DateTime.Parse(dtp_ss.Text));
            l.SetHauteur(float.Parse(tb_hauteur.Text));
            l.SetLargeur(float.Parse(tb_largeur.Text));
            l.SetCommentaire(tb_com.Text);
            l.SetSynopsys(tb_synopsis.Text);
            



        }

        private void b_valider_Click(object sender, EventArgs e)
        {

        }

        private void b_valider_Click_1(object sender, EventArgs e)
        {
            int? id;
            id = b;

            if (l.GetIdLivre() == null && (id == 0 || id == null))
            {
                id = l.MaxId();
            }
            switch (mode)
            {
                default:
                    Setting(id);
                    l.Create();
                    break;
                case 2:
                    Setting(id);
                    l.Update();
                    break;
                case 3:
                    l.Delete();
                    break;
            }
            this.Close();
        }
    

        private void cb_tl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_d_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_add_auteur_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (lb_auteur.Items.Count != 0)
            {
                for (i = 0; i <= lb_auteur.Items.Count-1; i++)
                {
                    if (lb_auteur.Items[i].ToString() != cb_a.SelectedItem.ToString())
                    {
                        MessageBox.Show(lb_auteur.Items[i].ToString());
                        MessageBox.Show(cb_a.SelectedItem.ToString());
                        lb_auteur.Items.Add(cb_a.SelectedItem.ToString());
                    }
                }
            }
            else
            {
                lb_auteur.Items.Add(cb_a.SelectedItem.ToString());
            }
            
        }

        private void b_del_auteur_Click(object sender, EventArgs e)
        {
            lb_auteur.Items.Remove(cb_a.SelectedItem.ToString());
        }

        private void b_add_genre_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (lb_genre.Items.Count != 0)
            {
                for (i = 0; i <= lb_genre.Items.Count - 1; i++)
                {
                    if (lb_genre.Items[i].ToString() != cb_g.SelectedItem.ToString())
                    {
                        MessageBox.Show(lb_genre.Items[i].ToString());
                        MessageBox.Show(cb_g.SelectedItem.ToString());
                        lb_auteur.Items.Add(cb_g.SelectedItem.ToString());
                    }
                }
            }
            else
            {
                lb_genre.Items.Add(cb_g.SelectedItem.ToString());
            }
        }

        private void b_del_genre_Click(object sender, EventArgs e)
        {
            lb_genre.Items.Remove(cb_g.SelectedItem.ToString());
        }
    }
}
