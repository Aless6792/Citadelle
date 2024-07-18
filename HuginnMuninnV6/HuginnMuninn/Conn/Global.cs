/*
 * Crée par SharpDevelop.
 * Utilisateur: y.fortin
 * Date: 22/11/2023
 * Heure: 14:49
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HuginnMuninn.Conn
{
	/// <summary>
	/// Description of Global.
	/// </summary>
	public class Global
	{
		private static String Server;
        public static String User;
		private static String Password;
		private static String Database;
        private static string pilote;
		public static MySqlConnection conn;

        public static void Pilote(String S, String U, String P, String D)
		{ 
			pilote = "Server="+S+";User ID="+U+";Password="+P+";Database="+D;
	        conn = new MySqlConnection(pilote);
			try
			{
				conn.Open();
                conn.Close();
            }
            /**/
            catch (Exception e) { MessageBox.Show("Erreur de connexion. Vérifiez que les informations sont bien entrées et que le serveur est en bon état de fonctionnement.\r\nUne fois vérifié, veuillez vous connecter.\r\n\r\n"+e.Message, "Erreur de connexion");}
			
			
			
		}

		public String getServer() { return Server; }
		public String getUser() { return User; }
		public String getPassword() { return Password; }
		public String getDatabase() { return Database; }

		public void setServeur(String S) {  Server = S; }
		public void setUser(String U) { User = U; }
		public void setPassword(String P) { Password = P; }
		public void setDatabase(String D) { Database = D; }

		


	}
}
