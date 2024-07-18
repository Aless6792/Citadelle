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
	public class Editeur
	{
		private int idEditeur;
		private string nomEditeur;
		public Editeur(){}
		
		public Editeur(int i, string n)
		{
			this.idEditeur = i;
			this.nomEditeur = n;
		}

        public int GetIdEditeur() { return this.idEditeur; }
        public string GetNomEditeur() { return this.nomEditeur; }

        public void SetIdEditeur(int i) { this.idEditeur = i; }
        public void SetNomEditeur(string n) { this.nomEditeur = n; }
		
		public void Create()
		{
			string req = "INSERT INTO Editeur VALUES (" + this.idEditeur + ",'"+ this.nomEditeur + "');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

        public void Retrieve(int id)
		{
			string req = "SELECT * FROM Editeur WHERE idEditeur =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
			this.idEditeur = int.Parse(rdr["idEditeur"].ToString());
			this.nomEditeur = rdr["nomEditeur"].ToString();
            Global.conn.Close();
        }

		public void Update()
		{
			string req = "UPDATE Editeur SET nomEditeur='" + this.nomEditeur + "' WHERE idEditeur =" + this.idEditeur;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

        public void Delete()
		{
			string req = "DELETE FROM Editeur WHERE idEditeur =" + this.idEditeur;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }
        public List<Editeur> FindAll()
        {
            List<Editeur> Eds = new List<Editeur>();

            string req = "SELECT * FROM Editeur";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                Editeur ed = new Editeur();
                ed.SetIdEditeur(int.Parse(rdr["idEditeur"].ToString()));
                ed.SetNomEditeur(rdr["nomEditeur"].ToString());

                Eds.Add(ed);
            }
            Global.conn.Close();
            return Eds;
        }
        public int MaxId()
        {
            int id = 0;
            string req = "SELECT Max(idEditeur) AS idEditeur FROM Editeur";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            if (rdr["idEditeur"].ToString() == string.Empty) { id = 0; }
            else { id = int.Parse(rdr["idEditeur"].ToString()) + 1; }


            Global.conn.Close();
            return id;
        }
    }
}
