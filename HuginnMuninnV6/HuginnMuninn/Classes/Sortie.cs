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
	public class Sortie
	{
		private int idSortie;
		private string raisonSortie;
		public Sortie(){}
		
		public Sortie(int i, string r)
		{
			this.idSortie = i;
			this.raisonSortie = r;
		}

        public int GetIdSortie() { return this.idSortie; }
        public string GetRaisonSortie() { return this.raisonSortie; }

        public void SetIdSortie(int i) { this.idSortie = i; }
        public void SetRaisonSortie(string r) { this.raisonSortie = r; }
	
		public void Create()
		{
			string req = "INSERT INTO Sortie VALUES (" + this.idSortie + ",'"+ this.raisonSortie + "');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}

        public void Retrieve(int id)
		{
			string req = "SELECT * FROM Sortie WHERE idSortie =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
			this.idSortie = int.Parse(rdr["idSortie"].ToString());
			this.raisonSortie = rdr["raisonSortie"].ToString();
			Global.conn.Close();
        }

		public void Update()
		{
			string req = "UPDATE Sortie SET raisonSortie='" + this.raisonSortie + "' WHERE idSortie =" + this.idSortie;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}

        public void Delete()
		{
			string req = "DELETE FROM Sortie WHERE idSortie =" + this.idSortie;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
			Global.conn.Close();
		}
        public List<Sortie> FindAll()
        {
            List<Sortie> Ss = new List<Sortie>();

            string req = "SELECT * FROM Sortie";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                Sortie s = new Sortie();
                s.SetIdSortie(int.Parse(rdr["idSortie"].ToString()));
                s.SetRaisonSortie(rdr["raisonSortie"].ToString());

                Ss.Add(s);
            }
            Global.conn.Close();
            return Ss;
        }
        public int MaxId()
        {
            int id = 0;
            string req = "SELECT Max(idSortie) AS idSortie FROM Sortie";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            if (rdr["idSortie"].ToString() == string.Empty) { id = 0; }
            else { id = int.Parse(rdr["idSortie"].ToString()) + 1; }


            Global.conn.Close();
            return id;
        }
    }
}
