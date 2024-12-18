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
            TeleTxtBx.MaxLength = 12;
            TeleTxtBx.TextChanged += TeleTxtBx_TextChanged;
            ToevoegBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ZoekBalk.GotFocus += RemoveText;
            ZoekBalk.LostFocus += AddText;
            AddText(null, null);

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

        private void RemoveText(object sender, EventArgs e)
        {
            if (ZoekBalk.Text == "Zoek hier naar een patient")
            {
                ZoekBalk.Text = "";
                ZoekBalk.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ZoekBalk.Text))
            {
                ZoekBalk.Text = "Zoek hier naar een patient";
                ZoekBalk.ForeColor = Color.Gray;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ToevoegPanel.Visible = true;
            AddButton.Enabled = false;
        }

        private void ToevoegBtn_Click(object sender, EventArgs e)
        {

            ToevoegPanel.Visible = false;
            AddButton.Enabled = true;
            if (NaamTxtBx.Text != null && AchternaamTxtBx.Text != null && AdresTxtBx.Text != null && EmailTxtBx.Text != null && TeleTxtBx.Text != null)
            {
                NaamTxtBx.Text = "";
                AchternaamTxtBx.Text = "";
                AdresTxtBx.Text = "";
                EmailTxtBx.Text = "";
                TeleTxtBx.Text = "";
            }
            else
            {
                return;
            }
        }

        private void GeenNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void GeenLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void ZoekBalk_TextChanged(object sender, EventArgs e)
        {
            string filterText = ZoekBalk.Text;
            var dataTable = PatientenGrid.DataSource as DataTable;
            if (dataTable != null)
            {
                DataView dataView = dataTable.DefaultView;
                if (string.IsNullOrWhiteSpace(filterText) || filterText == "Zoek hier naar een patient")
                {
                    dataView.RowFilter = string.Empty;
                }
                else
                {
                    filterText = filterText.Replace("'", "''");
                    string[] filterPart = filterText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (filterPart.Length == 1)
                    {
                        dataView.RowFilter = string.Format("Voornaam LIKE '%{0}%' OR Achternaam LIKE '%{0}%'", filterPart[0]);
                    }
                    else if (filterPart.Length == 2)
                    {
                        dataView.RowFilter = string.Format("Voornaam LIKE '%{0}%' AND Achternaam LIKE '%{1}%'", filterPart[0], filterPart[1]);
                    }
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (ZoekBalk.Text != "Zoek hier naar een patient")
            {
                ZoekBalk.Text = "";
                AddText(null, null);
            }
            else
            {
                return;
            }

        }

        private void TeleTxtBx_TextChanged(object sender, EventArgs e)
        {
            string Text = TeleTxtBx.Text.Replace("-", string.Empty);
            if (Text.Length > 3 && Text.Length <= 6)
            {
                Text = Text.Insert(3, "-");
            }
            else if (Text.Length > 6)
            {
                Text = Text.Insert(3, "-").Insert(7, "-");
            }
            TeleTxtBx.TextChanged -= TeleTxtBx_TextChanged;
            TeleTxtBx.Text = Text;
            TeleTxtBx.SelectionStart = TeleTxtBx.Text.Length;
            TeleTxtBx.TextChanged += TeleTxtBx_TextChanged;
        }

        private void InputCheck(object sender, EventArgs e)
        {
            if (NaamTxtBx.Text != null && AchternaamTxtBx.Text != null && AdresTxtBx.Text != null && EmailTxtBx.Text != null)
            {
                ToevoegBtn.Enabled = true;
            }
            else
            {
                ToevoegBtn.Enabled = false;
            }
        }
    }
}
