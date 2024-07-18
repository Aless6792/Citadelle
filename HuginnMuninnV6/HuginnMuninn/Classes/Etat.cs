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

namespace HuginnMuninn.Classes
{
	/// <summary>
	/// Description of Devise.
	/// </summary>
	public class Etat
	{
		private int idEtat;
		private string libelle;
		public Etat(){}
		
		public Etat(int i, string l)
		{
			this.idEtat = i;
			this.libelle = l;
		}
        // Attributs

        public int GetIdEtat() { return this.idEtat; }
        public string GetLibelle() { return this.libelle; }

        public void SetIdEtat(int i) { this.idEtat = i; }
        public void SetLibelle(string l) { this.libelle = l; }
		
		public void Create()
		{
			string req = "INSERT INTO Etat VALUES (" + this.idEtat + ",'"+ this.libelle + "');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
		}

		public void Retrieve(int id)
		{
			string req = "SELECT * FROM Etat WHERE idEtat =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            this.idEtat = int.Parse(rdr["idEtat"].ToString());
			this.libelle = rdr["libelle"].ToString();
            Global.conn.Close();
        }

        public void Update()
		{
			string req = "UPDATE Etat SET libelle='" + this.libelle + "' WHERE idEtat =" + this.idEtat;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

		public void Delete()
		{
			string req = "DELETE FROM Etat WHERE idEtat =" + this.idEtat;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }
        public List<Etat> FindAll()
        {
            List<Etat> Es = new List<Etat>();

            string req = "SELECT * FROM Etat";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                Etat e = new Etat();
                e.SetIdEtat(int.Parse(rdr["idEtat"].ToString()));
                e.SetLibelle(rdr["Libelle"].ToString());

                Es.Add(e);
            }
            Global.conn.Close();
            return Es;
        }
        public int MaxId()
        {
            int id = 0;
            string req = "SELECT Max(idEtat) AS idEtat FROM Etat";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            if (rdr["idEtat"].ToString() == string.Empty) { id = 0; }
            else { id = int.Parse(rdr["idEtat"].ToString()) + 1; }


            Global.conn.Close();
            return id;
        }
    }
}
