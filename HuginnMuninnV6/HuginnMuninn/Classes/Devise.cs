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
	public class Devise
	{
		private int idDevise;
		private string devise;
		public Devise(){}
		
		public Devise(int i, string d)
		{
			this.idDevise = i;
			this.devise = d;
		}

        public int GetIdDevise() { return this.idDevise; }
        public string GetDevise() { return this.devise; }

        public void SetIdDevise(int i) { this.idDevise = i; }
        public void SetDevise(string d) { this.devise = d; }

        public void Create()
		{
			string req = "INSERT INTO Devise VALUES ("+ this.idDevise +",'"+ this.devise+"');";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

		public void Retrieve(int id)
		{
			string req = "SELECT * FROM Devise WHERE idDevise =" + id;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            this.idDevise = int.Parse(rdr["idDevise"].ToString());
			this.devise = rdr["devise"].ToString();
            Global.conn.Close();
        }

		public void Update()
		{
			string req = "UPDATE Devise SET devise='"+this.devise+"' WHERE idDevise =" + this.idDevise;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }

		public void Delete()
		{
			string req = "DELETE FROM Devise WHERE idDevise ="+this.idDevise;
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
			stmt.ExecuteNonQuery();
            Global.conn.Close();
        }
        public List<Devise> FindAll()
        {
            List<Devise> Ds = new List<Devise>();

            string req = "SELECT * FROM Devise";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                Devise d = new Devise();
                d.SetIdDevise(int.Parse(rdr["idDevise"].ToString()));
                d.SetDevise(rdr["Devise"].ToString());

                Ds.Add(d);
            }
            Global.conn.Close();
            return Ds;
        }
        public int MaxId()
        {
            int id = 0;
            string req = "SELECT Max(idDevise) AS idDevise FROM Devise";
            Global.conn.Open();
            MySqlCommand stmt = new MySqlCommand(req, Global.conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            rdr.Read();
            if (rdr["idDevise"].ToString() == string.Empty) { id = 0; }
            else { id = int.Parse(rdr["idDevise"].ToString()) + 1; }


            Global.conn.Close();
            return id;
        }
    }
}
