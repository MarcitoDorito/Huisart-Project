using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huisart_Project
{
    internal class DatabaseHelper
    {
        private string connectionString { get; }

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public class Patienten
        {
            public string voornaam;
            public string achternaam;
            public string adres;
            public string emailadres;
            public string telefoonnummer;
        }
        public List<Patienten> GetPatienten()
        {
            var patientenLijst = new List<Patienten>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM patienten";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Patienten patient = new Patienten();
                        patient.voornaam = reader["first_name"].ToString();
                        patient.achternaam = reader["last_name"].ToString();
                        patient.adres = reader["Adres"].ToString();
                        patient.emailadres = reader["email"].ToString();
                        patient.telefoonnummer = reader["Telefoonnummer"].ToString();
                        patientenLijst.Add(patient);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Console.WriteLine(patientenLijst);
                return patientenLijst;
            }
        }
    }
}
