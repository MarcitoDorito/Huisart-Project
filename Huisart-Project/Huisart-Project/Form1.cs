using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Google.Protobuf.WellKnownTypes;

namespace Huisart_Project
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=LocalHost;Database=huisart;user=root";
        DatabaseHelper databaseHelper = new DatabaseHelper(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DatabaseHelper.Patienten> patienten = databaseHelper.GetPatienten();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Voornaam");
            dataTable.Columns.Add("Achternaam");
            dataTable.Columns.Add("Adres");
            dataTable.Columns.Add("Emailadres");
            dataTable.Columns.Add("Telefoonnummer");

            foreach (var patient in patienten)
            {
                dataTable.Rows.Add(patient.voornaam, patient.achternaam, patient.adres, patient.emailadres, patient.telefoonnummer);
            }
            PatientenGrid.DataSource = dataTable;
        }
    }
}
