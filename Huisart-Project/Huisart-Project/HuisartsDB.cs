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
            public string id;
        }

        public class Notes
        {
            public string note;
            public DateTime Created_at;
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
                        patient.id = reader["id"].ToString();
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

        public List<Notes> GetNotitiesBYpatientId(string patientId)
        {
            var notitiesLijst = new List<Notes>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Notitie, created_at FROM patientennotitie WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", patientId);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Notes note = new Notes();
                        note.note = reader["Notitie"].ToString();
                        note.Created_at = Convert.ToDateTime(reader["created_at"]);
                        notitiesLijst.Add(note);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Console.WriteLine(notitiesLijst);
                return notitiesLijst;
            }
        }
        public void AddNotitie(string patientId, string notitie)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO patientennotitie (id, notitie, created_at) VALUES (@id, @notitie, @created_at)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", patientId);
                command.Parameters.AddWithValue("@Notitie", notitie);
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}