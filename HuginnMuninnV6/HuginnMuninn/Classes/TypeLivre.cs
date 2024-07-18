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
using System.Globalization;
using System.Data;

namespace HuginnMuninn.Classes
{
	/// <summary>
	/// Description of Devise.
	/// </summary>
	public class TypeLivre
	{
		private int idTypeLivre;
		private string libelle;
		public TypeLivre(){}
		
		public TypeLivre(int i, string d)
		{
			this.idTypeLivre = i;
			this.libelle = d;
		}

        public int GetIdTypeLivre() { return this.idTypeLivre; }
        public string GetLibelle() { return this.libelle; }

        public void SetIdTypeLivre(int i) { this.idTypeLivre = i; }
        public void SetLibelle(string d) { this.libelle = d; }
		
		public void Create()
		{
			string req = "INSERT INTO TypeLivre VALUES (" + this.idTypeLivre + ",'"+ this.libelle + "');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}

		public void Retrieve(int id)
		{
			string req = "SELECT * FROM TypeLivre WHERE idTypeLivre =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            this.idTypeLivre = int.Parse(rdr["idTypeLivre"].ToString());
			this.libelle = rdr["libelle"].ToString();
            Global.conn.Close();
		}

		public void Update()
		{
			string req = "UPDATE TypeLivre SET libelle='" + this.libelle + "' WHERE idTypeLivre =" + this.idTypeLivre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}

		public void Delete()
		{
			string req = "DELETE FROM TypeLivre WHERE idTypeLivre =" + this.idTypeLivre;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}
        public List<TypeLivre> FindAll()
        {
            List<TypeLivre> Tls = new List<TypeLivre>();

            string req = "SELECT * FROM typelivre";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                TypeLivre tl = new TypeLivre();
                tl.SetIdTypeLivre(int.Parse(rdr["idTypeLivre"].ToString()));
                tl.SetLibelle(rdr["libelle"].ToString());

                Tls.Add(tl);
            }
            Global.conn.Close();
            return Tls;
        }

		public int MaxId()
		{
			int id = 0;
			string req = "SELECT Max(idTypeLivre) AS idTypeLivre FROM typelivre";
			Global.conn.Open();
			MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
			rdr.Read();
			if (rdr["idTypeLivre"].ToString() == string.Empty) { id = 0; } 
			else { id = int.Parse(rdr["idTypeLivre"].ToString()) + 1; }
			Global.conn.Close();
			return id;
        }
    }
}
