/*
 * Crée par SharpDevelop.
 * Utilisateur: y.fortin
 * Date: 22/11/2023
 * Heure: 14:40
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using MySql.Data.MySqlClient;
using HuginnMuninn.Conn;
using System.Collections.Generic;

namespace HuginnMuninn.Classes
{
	/// <summary>
	/// Description of Devise.
	/// </summary>
	public class Genre
	{
		private int idGenre;
		private string libelle;
		public Genre(){}
		
		public Genre(int i, string l)
		{
			this.idGenre = i;
			this.libelle = l;
		}

        public int GetIdGenre() { return this.idGenre; }
        public string GetLibelle() { return this.libelle; }

        public void SetIdGenre(int i) { this.idGenre = i; }
        public void SetLibelle(string l) { this.libelle = l; }
		
		public void Create()
		{
			string req = "INSERT INTO Genre VALUES (" + this.idGenre + ",'"+ this.libelle + "');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

		public void Retrieve(int id)
		{
			string req = "SELECT * FROM Genre WHERE idGenre =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
			this.idGenre = int.Parse(rdr["idGenre"].ToString());
			this.libelle = rdr["libelle"].ToString();
            Global.conn.Close();
        }

		public void Update()
		{
			string req = "UPDATE Genre SET libelle='" + this.libelle + "' WHERE idGenre =" + this.idGenre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

		public void Delete()
		{
			string req = "DELETE FROM Genre WHERE idGenre =" + this.idGenre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}
        public List<Genre> FindAll()
        {
            List<Genre> Gs = new List<Genre>();

            string req = "SELECT * FROM Genre";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                Genre g = new Genre();
                g.SetIdGenre(int.Parse(rdr["idGenre"].ToString()));
                g.SetLibelle(rdr["Libelle"].ToString());

                Gs.Add(g);
            }
            Global.conn.Close();
            return Gs;
        }
        public int MaxId()
        {
            int id = 0;
            string req = "SELECT Max(idGenre) AS idGenre FROM Genre";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            if (rdr["idGenre"].ToString() == string.Empty) { id = 0; }
            else { id = int.Parse(rdr["idGenre"].ToString()) + 1; }


            Global.conn.Close();
            return id;
        }
    }
}
