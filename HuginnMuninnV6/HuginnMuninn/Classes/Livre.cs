using HuginnMuninn.Conn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HuginnMuninn.Classes
{
    class Livre
    {
        private int idLivre;
        private string titre;
        private string isbn;//pas un identifiant si occaz + rien avant 1970
        private int nombrePages;
        private int poids;//en gr
        private DateTime datePremierePublication;//en Varchar(20) dans bdd
        private DateTime datePublication;//en Varchar(20) dans bdd
        private float prixInitial;//chiffre a virgule
        private DateTime dateEntreeStock;//en Varchar(20) dans bdd
        private DateTime dateSortieStock;//en Varchar(20) dans bdd
        private float hauteur;//en cm
        private float largeur;//en cm
        private string commentaire;
        private string synopsys;
        private TypeLivre leType = new TypeLivre();
        private Devise laDevise = new Devise();
        private Sortie laSortie = new Sortie();
        private Etat unEtat = new Etat();
        private Editeur unEditeur = new Editeur();
        private List<Auteur> lesAuteurs = new List<Auteur>();
        private List<Genre> lesGenres = new List<Genre>();

        public Livre() { }
        public Livre(int id, string ti, string isbn, int nbP, int pds, DateTime dPP, DateTime dP, float pI, DateTime dES, DateTime dSS, float h, float l, string c, string syn, TypeLivre lT, Devise d, Sortie s, Etat et, Editeur ed, List<Auteur> ats, List<Genre> grs)
        {
            this.idLivre = id;
            this.titre = ti;
            this.isbn = isbn;
            this.nombrePages = nbP;
            this.poids = pds;
            this.datePremierePublication = dPP;
            this.datePublication = dP;
            this.prixInitial = pI;
            this.dateEntreeStock = dES;
            this.dateSortieStock = dSS;
            this.hauteur = h;
            this.largeur = l;
            this.commentaire = c;
            this.synopsys = syn;
            this.leType = lT;
            this.laDevise = d;
            this.laSortie = s;
            this.unEtat = et;
            this.unEditeur = ed;
            this.lesAuteurs = ats;
            this.lesGenres = grs;
        }

        public int GetIdLivre() { return this.idLivre; }
        public string GetTitre() { return this.titre; }
        public string GetIsbn() { return this.isbn; }
        public int GetNombrePages() { return this.nombrePages; }
        public int GetPoids() { return this.poids; }
        public DateTime GetDatePremierePublication() { return this.datePremierePublication; }
        public DateTime GetDatePublication() { return this.datePublication; }
        public float GetPrixInitial() { return this.prixInitial; }
        public DateTime GetDateEntreeStock() { return this.dateEntreeStock; }
        public DateTime GetDateSortieStock() { return this.dateSortieStock; }
        public float GetHauteur() { return this.hauteur; }
        public float GetLargeur() { return this.largeur; }
        public string GetCommentaire() { return this.commentaire; }
        public string GetSynopsys() { return this.synopsys; }
        public TypeLivre GetLeType() { return this.leType; }
        public Devise GetLaDevise() { return this.laDevise; }
        public Sortie GetLaSortie() { return this.laSortie; }
        public Etat GetUnEtat() { return this.unEtat; }
        public Editeur GetUnEditeur() { return this.unEditeur; }
        public List<Auteur> GetLesAuteurs() { return this.lesAuteurs; }
        public List<Genre> GetLesGenres() { return this.lesGenres; }
        public void SetIdLivre(int id) { this.idLivre = id; }
        public void SetTitre(string t) { this.titre = t; }
        public void SetIsbn(string isbn) { this.isbn = isbn; }
        public void SetNombrePages(int nb) { this.nombrePages = nb; }
        public void SetPoids(int pds) { this.poids = pds; }
        public void SetDatePremierePublication(DateTime dpp) { this.datePremierePublication = dpp; }
        public void SetDatePublication(DateTime dp) { this.datePublication = dp; }
        public void SetPrixInitial(float pi) { this.prixInitial = pi; }
        public void SetDateEntreeStock(DateTime des) { this.dateEntreeStock = des; }
        public void SetDateSortieStock(DateTime dss) { this.dateSortieStock = dss; }
        public void SetHauteur(float h) { this.hauteur = h; }
        public void SetLargeur(float l) { this.largeur = l; }
        public void SetCommentaire(string c) { this.commentaire = c; }
        public void SetSynopsys(string syn) { this.synopsys = syn; }
        public void SetLeType(TypeLivre lt) { this.leType = lt; }
        public void SetLaDevise(Devise d) { this.laDevise = d; }
        public void SetLaSortie(Sortie s) { this.laSortie = s; }
        public void SetUnEtat(Etat et) { this.unEtat = et; }
        public void SetUnEditeur(Editeur ed) { this.unEditeur = ed; }
        public void SetLesAuteurs(List<Auteur> ats) { this.lesAuteurs = ats; }
        public void SetLesGenres(List<Genre> grs) { this.lesGenres = grs; }

        public void Create()
        {
            string req = "INSERT INTO Livre VALUES (" + this.idLivre + ",'" + this.titre + "','" + this.isbn + "'," + this.nombrePages + "," + this.poids + ",'" + this.datePremierePublication.ToString("dd/MM/yyyy") + "','" + this.datePublication.ToString("dd/MM/yyyy") + "'," + this.prixInitial + ",'" + this.dateEntreeStock.ToString("dd/MM/yyyy") + "','" + this.dateSortieStock.ToString("dd/MM/yyyy") + "'," + this.hauteur + "," + this.largeur + ",'" + this.commentaire + "','" + this.synopsys + "'," + this.leType.GetIdTypeLivre() + "," + this.laDevise.GetIdDevise() + "," + this.laSortie.GetIdSortie() + "," + this.unEtat.GetIdEtat() + "," + this.unEditeur.GetIdEditeur() + ");";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            stmt.ExecuteNonQuery();
            foreach (Auteur a in lesAuteurs)
            {
                req = "INSERT INTO Ecrire VALUES (" + this.idLivre + "," + a.GetIdAuteur() + ");";
                stmt = new MySqlCommand(req, Global.conn);
                stmt.ExecuteNonQuery();
            }
            foreach (Genre a in lesGenres)
            {
                req = "INSERT INTO Definir VALUES (" + this.idLivre + "," + a.GetIdGenre() + ");";
                stmt = new MySqlCommand(req, Global.conn);
                stmt.ExecuteNonQuery();
            }
            Global.conn.Close();
        }
        public void Retrieve(int id)
        {
            Auteur unAuteur = new Auteur();
            Genre unGenre = new Genre();
            string req = "SELECT * FROM Livre WHERE idLivre =" + this.idLivre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            this.idLivre = int.Parse(rdr["idLivre"].ToString());
            this.titre = rdr["titre"].ToString();
            this.isbn = rdr["isbn"].ToString();
            this.nombrePages = int.Parse(rdr["nombrePages"].ToString());
            this.poids = int.Parse(rdr["poids"].ToString());
            this.datePremierePublication = DateTime.ParseExact(rdr["datePremierePublication"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.datePublication = DateTime.ParseExact(rdr["datePublication"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.prixInitial = float.Parse(rdr["prixInitial"].ToString());
            this.dateEntreeStock = DateTime.ParseExact(rdr["dateEntreeStock"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.dateSortieStock = DateTime.ParseExact(rdr["dateSortieStock"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.hauteur = float.Parse(rdr["hauteur"].ToString());
            this.largeur = float.Parse(rdr["largeur"].ToString());
            this.commentaire = rdr["commentaire"].ToString();
            this.synopsys = rdr["synopsys"].ToString();
            this.leType.Retrieve(int.Parse(rdr["idTypeLivre"].ToString()));
            this.laDevise.Retrieve(int.Parse(rdr["idDevise"].ToString()));
            this.laSortie.Retrieve(int.Parse(rdr["idSortie"].ToString()));
            this.unEtat.Retrieve(int.Parse(rdr["idEtat"].ToString()));
            this.unEditeur.Retrieve(int.Parse(rdr["idEditeur"].ToString()));
            req = "SELECT idAuteur FROM Ecrire WHERE idLivre =" + id;
            stmt = new MySqlCommand(req, Global.conn);
            rdr = stmt.ExecuteReader();
            rdr.Read();
            while (rdr.NextResult())
            {
                unAuteur.Retrieve(int.Parse(rdr["idAuteur"].ToString()));
                this.lesAuteurs.Add(unAuteur);
            }
            req = "SELECT idAuteur FROM Definir WHERE idGenre =" + id;
            stmt = new MySqlCommand(req, Global.conn);
            rdr = stmt.ExecuteReader();
            rdr.Read();
            while (rdr.NextResult())
            {
                unGenre.Retrieve(int.Parse(rdr["idGenre"].ToString()));
                this.lesGenres.Add(unGenre);
            }
            Global.conn.Close();
        }
        public void Update()
        {
            string req = "UPDATE Livre SET titre='" + this.titre + "',isbn = '" + this.isbn + "', nombrePages = " + this.nombrePages + ", poids = " + this.poids + ", datePremierePublication = '" + this.datePremierePublication.ToString("dd/MM/yyyy") + "', datePublication = '" + this.datePublication.ToString("dd/MM/yyyy") + "', prixInitial = " + this.prixInitial + ", dateEntreeStock = '" + this.dateEntreeStock.ToString("dd/MM/yyyy") + "',dateSortieStock = '" + this.dateSortieStock.ToString("dd/MM/yyyy") + "',hauteur = " + this.hauteur + ", largeur = " + this.largeur + ", commentaire = '" + this.commentaire + "', synopsys = '" + this.synopsys + "', idTypeLivre = " + this.leType.GetIdTypeLivre() + ", idDevise = " + this.laDevise.GetIdDevise() + ", idSortie = " + this.laSortie.GetIdSortie() + ", idEtat = " + this.unEtat.GetIdEtat() + ", idEditeur = " + this.unEditeur.GetIdEditeur() + "  WHERE idLivre =" + this.idLivre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            stmt.ExecuteNonQuery();
            foreach (Auteur a in lesAuteurs)
            {
                req = "UPDATE Ecrire SET idAuteur = " + a.GetIdAuteur() + " WHERE idLivre = " + this.idLivre + ";";
                stmt = new MySqlCommand(req, Global.conn);
                stmt.ExecuteNonQuery();
            }
            foreach (Genre a in lesGenres)
            {
                req = "UPDATE Definir SET idGenre = " + a.GetIdGenre() + " WHERE idLivre = " + this.idLivre + ";";
                stmt = new MySqlCommand(req, Global.conn);
                stmt.ExecuteNonQuery();
            }
            Global.conn.Close();
        }
        public void Delete()
        {
            string req = "DELETE FROM Definir WHERE idLivre =" + this.idLivre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            stmt.ExecuteNonQuery();

            req = "DELETE FROM Ecrire WHERE idLivre =" + this.idLivre;
            stmt = new MySqlCommand(req, Global.conn);
            stmt.ExecuteNonQuery();

            req = "DELETE FROM Livre WHERE idLivre =" + this.idLivre;
            stmt = new MySqlCommand(req, Global.conn);
            stmt.ExecuteNonQuery();
            Global.conn.Close();
        }
        public List<Livre> FindAll()
        {
            List<Livre> Ls = new List<Livre>();
            string aertyu;
            string req = "SELECT * FROM Livre";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rder = stmt.ExecuteReader();
            while (rder.Read())
            {
                Livre l = new Livre();
                l.SetIdLivre(int.Parse(rder["idLivre"].ToString()));
                l.SetTitre(rder["titre"].ToString());
                l.SetIsbn(rder["isbn"].ToString());
                l.SetNombrePages(int.Parse(rder["nombrePages"].ToString()));
                l.SetPoids(int.Parse(rder["poids"].ToString()));
                l.SetDatePremierePublication(DateTime.Parse(rder["datePremierePublication"].ToString(), CultureInfo.CurrentCulture));
                l.SetDatePublication(DateTime.Parse(rder["datePublication"].ToString(), CultureInfo.CurrentCulture));
                l.SetPrixInitial(float.Parse(rder["prixInitial"].ToString()));
                l.SetDateEntreeStock(DateTime.Parse(rder["dateEntreeStock"].ToString(), CultureInfo.CurrentCulture));
                l.SetDateSortieStock(DateTime.Parse(rder["dateSortieStock"].ToString(), CultureInfo.CurrentCulture));
                l.SetHauteur(float.Parse(rder["hauteur"].ToString()));
                l.SetLargeur(float.Parse(rder["largeur"].ToString()));
                l.SetCommentaire(rder["commentaire"].ToString());
                l.SetSynopsys(rder["synopsys"].ToString());
                TypeLivre tl = new TypeLivre();
                tl.Retrieve(int.Parse(rder["idTypeLivre"].ToString()));
                l.SetLeType(tl);
                Devise d = new Devise();
                d.Retrieve(int.Parse(rder["idDevise"].ToString()));
                l.SetLaDevise(d);
                Sortie s = new Sortie();
                s.Retrieve(int.Parse(rder["idSortie"].ToString()));
                l.SetLaSortie(s);
                Etat e = new Etat();
                l.Retrieve(int.Parse(rder["idEtat"].ToString()));
                l.SetLaSortie(s);
                Editeur ed = new Editeur();
                ed.Retrieve(int.Parse(rder["idEditeur"].ToString()));
                l.SetUnEditeur(ed);

                Ls.Add(l);

                req = "SELECT * FROM Ecrire WHERE idLivre = " + l.GetIdLivre() + ";";
                stmt = new MySqlCommand(req, Global.conn);
                rder = stmt.ExecuteReader();
                rder.Read();
                while (rder.NextResult())
                {
                    Auteur a = new Auteur();
                    a.Retrieve(int.Parse(rder["idAuteur"].ToString()));
                    lesAuteurs.Add(a);
                }
                req = "SELECT * FROM Definir WHERE idLivre = " + l.GetIdLivre() + ";";
                stmt = new MySqlCommand(req, Global.conn);
                rder = stmt.ExecuteReader();
                rder.Read();
                while (rder.NextResult())
                {
                    Genre g = new Genre();
                    g.Retrieve(int.Parse(rder["idGenre"].ToString()));
                    lesGenres.Add(g);
                }
            }
            Global.conn.Close();
            return Ls;
        }

        public int MaxId()
        {
            int id = 0;
            string req = "SELECT Max(idLivre) AS idLivre FROM Livre";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            if (rdr["idLivre"].ToString() == string.Empty) { id = 0; }
            else { id = int.Parse(rdr["idAuteur"].ToString()) + 1; }


            Global.conn.Close();
            return id;
        }
    }
}