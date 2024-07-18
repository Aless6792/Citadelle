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
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace HuginnMuninn.Classes
{
	/// <summary>
	/// Description of Devise.
	/// </summary>
	public class Auteur
	{
		// Attributs
		private int? idAuteur;
		private string nomAuteur;
		private string prenomAuteur;
		private DateTime dateNaissance;
		private DateTime dateMort;
		
		// Constructeur Vide
        public Auteur() { }
		
		// Constructeur Surchargé
		public Auteur(int i, string d, string f, DateTime g, DateTime h)
		{
            this.idAuteur = i;
			this.nomAuteur = d;
			this.prenomAuteur = f;
			this.dateNaissance = g;
			this.dateMort = h;
		}

		// Assesseurs en Lecture
        public int? GetIdAuteur() { return this.idAuteur; }
        public string GetNomAuteur() { return this.nomAuteur; }
        public string GetPrenomAuteur() { return this.prenomAuteur; }
        public DateTime GetDateNaissance() { return this.dateNaissance; }
        public DateTime GetDateMort() { return this.dateMort; }

		// Assesseurs en Ecriture
        public void SetIdAuteur(int? i) { this.idAuteur = i; }
        public void SetNomAuteur(string d) { this.nomAuteur = d; }
        public void SetPrenomAuteur(string f) { this.prenomAuteur = f; }
        public void SetDateNaissance(DateTime g) { this.dateNaissance = g; }
        public void SetDateMort(DateTime h) { this.dateMort = h; }

		// Méthodes
		public void Create()
		{
			
			string req = "INSERT INTO Auteur VALUES (" + this.idAuteur + ",'"+ this.nomAuteur + "','" + this.prenomAuteur + "','"+this.dateNaissance.ToString("dd/MM/yyyy") +"','"+this.dateMort.ToString("dd/MM/yyyy") +"');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

        public void Retrieve(int id)
		{
            string req = "SELECT * FROM Auteur WHERE idAuteur =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
			rdr.Read();
            this.idAuteur = int.Parse(rdr["idAuteur"].ToString());
			this.nomAuteur = rdr["nomAuteur"].ToString();
			this.prenomAuteur = rdr["prenomAuteur"].ToString();
			this.dateNaissance = DateTime.ParseExact(rdr["dateNaissance"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
			this.dateMort = DateTime.ParseExact(rdr["dateMort"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Global.conn.Close();
        }

		public void Update()
		{
			string req = "UPDATE Auteur SET nomAuteur= '" + this.nomAuteur + "', prenomAuteur = '"+ this.prenomAuteur + "', dateNaissance = '"+this.dateNaissance.ToString("dd/MM/yyyy") +"', dateMort = '"+this.dateMort.ToString("dd/MM/yyyy") +"' WHERE idAuteur =" + this.idAuteur;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

        public void Delete()
		{
			string req = "DELETE FROM Auteur WHERE idAuteur =" + this.idAuteur;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

		public List<Auteur> FindAll()
		{
			List<Auteur> As = new List<Auteur>();
			
            string req = "SELECT * FROM Auteur";
			Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
			while (rdr.Read()) 
			{
                Auteur a = new Auteur();
                a.SetIdAuteur(int.Parse(rdr["idAuteur"].ToString()));
				a.SetNomAuteur(rdr["nomAuteur"].ToString());
				a.SetPrenomAuteur(rdr["prenomAuteur"].ToString());
				a.SetDateNaissance(DateTime.Parse(rdr["dateNaissance"].ToString(), CultureInfo.CurrentCulture));
				a.SetDateMort(DateTime.Parse(rdr["dateMort"].ToString(), CultureInfo.CurrentCulture));

				As.Add(a);
            }
            Global.conn.Close();
            return As;
        }

		public int MaxId()
		{
			int id = 0;
            string req = "SELECT Max(idAuteur) AS idAuteur FROM Auteur";
			Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
			rdr.Read();
			if (rdr["idAuteur"].ToString() == string.Empty) { id = 0; }
			else { id = int.Parse(rdr["idAuteur"].ToString()) + 1; }
			
			
			Global.conn.Close();
            return id;
		}
	}
}
