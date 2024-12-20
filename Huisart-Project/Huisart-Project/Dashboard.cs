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
using static Huisart_Project.DatabaseHelper;
using System.IO;

namespace Huisart_Project
{
    public partial class Dashboard : Form
    {
        private const string connectionString = "Server=LocalHost;Database=huisart;user=root";
        DatabaseHelper databaseHelper = new DatabaseHelper(connectionString);
        public Dashboard()
        {
            InitializeComponent();
            TelefoonnummerTxtBx.MaxLength = 12;
            TelefoonnummerTxtBx.TextChanged += TeleTxtBx_TextChanged;
            ToevoegBtn.Enabled = false;
            NotePanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ZoekBalk.GotFocus += RemoveText;
            ZoekBalk.LostFocus += AddText;
            AddText(null, null);

            fillGrid();
        }

        private void fillGrid()
        {
            List<DatabaseHelper.Patienten> patienten = databaseHelper.GetPatienten();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Voornaam");
            dataTable.Columns.Add("Achternaam");
            dataTable.Columns.Add("Adres");
            dataTable.Columns.Add("Emailadres");
            dataTable.Columns.Add("Telefoonnummer");
            dataTable.Columns.Add("id");

            foreach (var patient in patienten)
            {
                dataTable.Rows.Add(patient.voornaam, patient.achternaam, patient.adres, patient.emailadres, patient.telefoonnummer, patient.id);
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
            ToevoegBtn.Text = "Toevoegen";
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ToevoegPanel.Visible = true;
            AddButton.Enabled = false;
            ToevoegBtn.Text = "Update";

            foreach (DataGridViewColumn column in PatientenGrid.Columns)
            {
                foreach(Control control in ToevoegPanel.Controls)
                {
                    if(control.Name == column.HeaderText + "TxtBx")
                    {
                        control.Text = PatientenGrid.SelectedRows[0].Cells[column.HeaderText].Value.ToString();
                    }
                }
            }
        }

        private void AddPatientToDatabase()
        {
            ToevoegPanel.Visible = false;
            AddButton.Enabled = true;

            // Checkt of de textboxes niet leeg zijn
            if (InputFieldChecker())
            {
                // Voegt de nieuwe patient toe aan de datatable
                //DataTable dataTable = (DataTable)PatientenGrid.DataSource;
                //DataRow newRow = dataTable.NewRow();
                //newRow["Voornaam"] = VoornaamTxtBx.Text;
                //newRow["Achternaam"] = AchternaamTxtBx.Text;
                //newRow["Adres"] = AdresTxtBx.Text;
                //newRow["Emailadres"] = EmailadresTxtBx.Text;
                //newRow["Telefoonnummer"] = TelefoonnummerTxtBx.Text;
                //dataTable.Rows.Add(newRow);

                string query = "INSERT INTO patienten (first_name, last_name, Adres, email, Telefoonnummer) VALUES (@first_name, @last_name, @Adres, @email, @Telefoonnummer);";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", VoornaamTxtBx.Text);
                        cmd.Parameters.AddWithValue("@last_name", AchternaamTxtBx.Text);
                        cmd.Parameters.AddWithValue("@Adres", AdresTxtBx.Text);
                        cmd.Parameters.AddWithValue("@email", EmailadresTxtBx.Text);
                        cmd.Parameters.AddWithValue("@Telefoonnummer", TelefoonnummerTxtBx.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        fillGrid();
                    }
                }

                // Maakt de textboxes leeg
                ClearInputField();
            }
            else
            {
                return;
            }
        }

        private void UpdateDatabase()
        {
            ToevoegPanel.Visible = false;
            AddButton.Enabled = true;

            // Checkt of de textboxes niet leeg zijn
            if (InputFieldChecker())
            {
                string query = "UPDATE patienten SET first_name = @first_name, last_name = @last_name, Adres = @Adres, email = @email, Telefoonnummer = @Telefoonnummer WHERE id = @patient_id;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", VoornaamTxtBx.Text);
                        cmd.Parameters.AddWithValue("@last_name", AchternaamTxtBx.Text);
                        cmd.Parameters.AddWithValue("@Adres", AdresTxtBx.Text);
                        cmd.Parameters.AddWithValue("@email", EmailadresTxtBx.Text);
                        cmd.Parameters.AddWithValue("@Telefoonnummer", TelefoonnummerTxtBx.Text);

                        string id = PatientenGrid.SelectedRows[0].Cells["id"].Value.ToString();

                        cmd.Parameters.AddWithValue("@patient_id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        fillGrid();
                    }
                }

                // Maakt de textboxes leeg
                ClearInputField();
            }
            else
            {
                return;
            }
        }

        private void ToevoegBtn_Click(object sender, EventArgs e)
        { 
            if (ToevoegBtn.Text == "Toevoegen")
            {
                AddPatientToDatabase();
            }
            else if (ToevoegBtn.Text == "Update")
            {
                UpdateDatabase();
            }
        }

        //Deze functie zorgt ervoor dat de textboxes alleen letters accepteren
        private void OnlyAlphabeticField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checkt of de input een letter is
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        //Deze functie zorgt ervoor dat de textboxes alleen nummers accepteren
        private void OnlyNumericField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checkt of de input een nummer is
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        //Deze functie zorgt voor het filteren van de tabel op basis van een zoekbalk
        private void ZoekBalk_TextChanged(object sender, EventArgs e)
        {
            // Filtert de datatable op basis van de zoekbalk
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

        //Deze functie zorgt ervoor dat de textboxes worden leeggemaakt als de gebruiker op de clear button klikt
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Maakt de zoekbalk leeg
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
            // Voegt streepjes toe aan het telefoonnummer
            string Text = TelefoonnummerTxtBx.Text.Replace("-", string.Empty);
            if (Text.Length > 3 && Text.Length <= 6)
            {
                Text = Text.Insert(3, "-");
            }
            else if (Text.Length > 6)
            {
                Text = Text.Insert(3, "-").Insert(7, "-");
            }
            // Zorgt ervoor dat de cursor niet naar het begin van de textbox springt
            TelefoonnummerTxtBx.TextChanged -= TeleTxtBx_TextChanged;
            TelefoonnummerTxtBx.Text = Text;
            TelefoonnummerTxtBx.SelectionStart = TelefoonnummerTxtBx.Text.Length;
            TelefoonnummerTxtBx.TextChanged += TeleTxtBx_TextChanged;
            // Checkt of de textboxes niet leeg zijn
            InputCheck(sender, e);
        }

        private void InputCheck(object sender, EventArgs e)
        {
            if (InputFieldChecker())
            {
                ToevoegBtn.Enabled = true;
            }
            else
            {
                ToevoegBtn.Enabled = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ToevoegPanel.Visible = false;
            AddButton.Enabled = true;
            // Maakt de textboxes leeg
            ClearInputField();
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
            if(PatientenGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PatientenGrid.SelectedRows[0];
                var patientId = selectedRow.Cells["id"].Value.ToString();
                databaseHelper.AddNotitie(patientId, NotitieRichTxtBx.Text);
                LoadPatientNotities(patientId);
                NotitieRichTxtBx.Clear();
            }
            else
            {
                MessageBox.Show("Geen rij geselecteerd");
            }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPatientNotities(string patientID)
        {
            var notities = databaseHelper.GetNotitiesBYpatientId(patientID);
            DataTable notitiesTable = new DataTable();
            notitiesTable.Columns.Add("Notitie");
            notitiesTable.Columns.Add("Datum");

            foreach (var notitie in notities)
            {
                notitiesTable.Rows.Add(notitie.note, notitie.Created_at);
            }
            
            NoteGrid.DataSource = notitiesTable;
        }

        private void PatientenGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                PatientenBtnPnl.Visible = true;
                NotePanel.Visible = true;
            if (PatientenGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PatientenGrid.SelectedRows[0];
                var idValue = selectedRow.Cells["id"].Value;
                LoadPatientNotities(idValue.ToString());


            }
            else
            {
                MessageBox.Show("Geen rij geselecteerd");
            }
        }


        private bool InputFieldChecker()
        {
            // Checkt of de textboxes niet leeg zijn
            if (!string.IsNullOrEmpty(VoornaamTxtBx.Text) &&
                !string.IsNullOrEmpty(AchternaamTxtBx.Text) &&
                !string.IsNullOrEmpty(AdresTxtBx.Text) &&
                !string.IsNullOrEmpty(EmailadresTxtBx.Text) &&
                !string.IsNullOrEmpty(TelefoonnummerTxtBx.Text))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearInputField()
        {
            // Maakt de textboxes leeg
            VoornaamTxtBx.Text = "";
            AchternaamTxtBx.Text = "";
            AdresTxtBx.Text = "";
            EmailadresTxtBx.Text = "";
            TelefoonnummerTxtBx.Text = "";
        }

        private void PdeleteBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = PatientenGrid.SelectedRows;

            if (selectedRows.Count > 0)
            {
                string query = "DELETE FROM patienten WHERE id = @id";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedRows[0].Cells["id"].Value.ToString());
                      
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        fillGrid();
                    }
                }
            }
        }
    }
}
