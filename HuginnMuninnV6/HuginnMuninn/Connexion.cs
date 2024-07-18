using HuginnMuninn.Conn;
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
    public partial class Form_Connexion : Form
    {
        public Form_Connexion()
        {
            InitializeComponent();
            tb_Serveur.Text = "127.0.0.1";
            tb_Utilisateur.Text = "alessandro";
            tb_Mdp.Text = "password";
            tb_BDD.Text = "HuginnMuninn";
        }

        private void b_Conn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_Serveur.Text)  && !string.IsNullOrWhiteSpace(tb_Utilisateur.Text) && !string.IsNullOrWhiteSpace(tb_Mdp.Text) && !string.IsNullOrWhiteSpace(tb_BDD.Text))
            {
                Global.Pilote(tb_Serveur.Text, tb_Utilisateur.Text, tb_Mdp.Text, tb_BDD.Text);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Élément manquant, connexion impossible.\nServeur : "+tb_Serveur.Text+"\nUtilisateur : "+tb_Utilisateur.Text + "\nMot de Passe : "+tb_Mdp.Text + "\nBDD : "+tb_BDD.Text, "Erreur");
            }
        }
    }
}
