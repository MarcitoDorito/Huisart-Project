namespace Huisart_Project
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PatientenGrid = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.ToevoegPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ToevoegBtn = new System.Windows.Forms.Button();
            this.telefoonNummerTxt = new System.Windows.Forms.Label();
            this.emaiTxt = new System.Windows.Forms.Label();
            this.AdresTxt = new System.Windows.Forms.Label();
            this.AchternaamTxt = new System.Windows.Forms.Label();
            this.NaamTxt = new System.Windows.Forms.Label();
            this.TelefoonnummerTxtBx = new System.Windows.Forms.TextBox();
            this.EmailadresTxtBx = new System.Windows.Forms.TextBox();
            this.AdresTxtBx = new System.Windows.Forms.TextBox();
            this.AchternaamTxtBx = new System.Windows.Forms.TextBox();
            this.VoornaamTxtBx = new System.Windows.Forms.TextBox();
            this.ZoekBalk = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PatientenBtnPnl = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.NotePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.AddNotebtn = new System.Windows.Forms.Button();
            this.NoteGrid = new System.Windows.Forms.DataGridView();
            this.NotitieRichTxtBx = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientenGrid)).BeginInit();
            this.ToevoegPanel.SuspendLayout();
            this.PatientenBtnPnl.SuspendLayout();
            this.NotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientenGrid
            // 
            this.PatientenGrid.AllowUserToResizeRows = false;
            this.PatientenGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.PatientenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientenGrid.Location = new System.Drawing.Point(12, 191);
            this.PatientenGrid.MultiSelect = false;
            this.PatientenGrid.Name = "PatientenGrid";
            this.PatientenGrid.RowHeadersWidth = 62;
            this.PatientenGrid.RowTemplate.ReadOnly = true;
            this.PatientenGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientenGrid.Size = new System.Drawing.Size(708, 366);
            this.PatientenGrid.TabIndex = 1;
            this.PatientenGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientenGrid_CellClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 563);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(167, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Patient Toevoegen";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ToevoegPanel
            // 
            this.ToevoegPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ToevoegPanel.Controls.Add(this.CancelBtn);
            this.ToevoegPanel.Controls.Add(this.ToevoegBtn);
            this.ToevoegPanel.Controls.Add(this.telefoonNummerTxt);
            this.ToevoegPanel.Controls.Add(this.emaiTxt);
            this.ToevoegPanel.Controls.Add(this.AdresTxt);
            this.ToevoegPanel.Controls.Add(this.AchternaamTxt);
            this.ToevoegPanel.Controls.Add(this.NaamTxt);
            this.ToevoegPanel.Controls.Add(this.TelefoonnummerTxtBx);
            this.ToevoegPanel.Controls.Add(this.EmailadresTxtBx);
            this.ToevoegPanel.Controls.Add(this.AdresTxtBx);
            this.ToevoegPanel.Controls.Add(this.AchternaamTxtBx);
            this.ToevoegPanel.Controls.Add(this.VoornaamTxtBx);
            this.ToevoegPanel.Location = new System.Drawing.Point(440, 13);
            this.ToevoegPanel.Name = "ToevoegPanel";
            this.ToevoegPanel.Size = new System.Drawing.Size(280, 173);
            this.ToevoegPanel.TabIndex = 3;
            this.ToevoegPanel.Visible = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(111, 145);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ToevoegBtn
            // 
            this.ToevoegBtn.Location = new System.Drawing.Point(14, 145);
            this.ToevoegBtn.Name = "ToevoegBtn";
            this.ToevoegBtn.Size = new System.Drawing.Size(75, 23);
            this.ToevoegBtn.TabIndex = 10;
            this.ToevoegBtn.Text = "Toevoegen";
            this.ToevoegBtn.UseVisualStyleBackColor = true;
            this.ToevoegBtn.Click += new System.EventHandler(this.ToevoegBtn_Click);
            // 
            // telefoonNummerTxt
            // 
            this.telefoonNummerTxt.AutoSize = true;
            this.telefoonNummerTxt.Location = new System.Drawing.Point(3, 119);
            this.telefoonNummerTxt.Name = "telefoonNummerTxt";
            this.telefoonNummerTxt.Size = new System.Drawing.Size(86, 13);
            this.telefoonNummerTxt.TabIndex = 9;
            this.telefoonNummerTxt.Text = "Telefoonnummer";
            // 
            // emaiTxt
            // 
            this.emaiTxt.AutoSize = true;
            this.emaiTxt.Location = new System.Drawing.Point(3, 92);
            this.emaiTxt.Name = "emaiTxt";
            this.emaiTxt.Size = new System.Drawing.Size(32, 13);
            this.emaiTxt.TabIndex = 8;
            this.emaiTxt.Text = "Email";
            // 
            // AdresTxt
            // 
            this.AdresTxt.AutoSize = true;
            this.AdresTxt.Location = new System.Drawing.Point(3, 65);
            this.AdresTxt.Name = "AdresTxt";
            this.AdresTxt.Size = new System.Drawing.Size(34, 13);
            this.AdresTxt.TabIndex = 7;
            this.AdresTxt.Text = "Adres";
            // 
            // AchternaamTxt
            // 
            this.AchternaamTxt.AutoSize = true;
            this.AchternaamTxt.Location = new System.Drawing.Point(4, 41);
            this.AchternaamTxt.Name = "AchternaamTxt";
            this.AchternaamTxt.Size = new System.Drawing.Size(64, 13);
            this.AchternaamTxt.TabIndex = 6;
            this.AchternaamTxt.Text = "Achternaam";
            // 
            // NaamTxt
            // 
            this.NaamTxt.AutoSize = true;
            this.NaamTxt.Location = new System.Drawing.Point(4, 18);
            this.NaamTxt.Name = "NaamTxt";
            this.NaamTxt.Size = new System.Drawing.Size(35, 13);
            this.NaamTxt.TabIndex = 5;
            this.NaamTxt.Text = "Naam";
            // 
            // TelefoonnummerTxtBx
            // 
            this.TelefoonnummerTxtBx.Location = new System.Drawing.Point(111, 119);
            this.TelefoonnummerTxtBx.Name = "TelefoonnummerTxtBx";
            this.TelefoonnummerTxtBx.Size = new System.Drawing.Size(156, 20);
            this.TelefoonnummerTxtBx.TabIndex = 4;
            this.TelefoonnummerTxtBx.TextChanged += new System.EventHandler(this.TeleTxtBx_TextChanged);
            this.TelefoonnummerTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericField_KeyPress);
            // 
            // EmailadresTxtBx
            // 
            this.EmailadresTxtBx.Location = new System.Drawing.Point(111, 92);
            this.EmailadresTxtBx.Name = "EmailadresTxtBx";
            this.EmailadresTxtBx.Size = new System.Drawing.Size(156, 20);
            this.EmailadresTxtBx.TabIndex = 3;
            this.EmailadresTxtBx.TextChanged += new System.EventHandler(this.InputCheck);
            // 
            // AdresTxtBx
            // 
            this.AdresTxtBx.Location = new System.Drawing.Point(111, 65);
            this.AdresTxtBx.Name = "AdresTxtBx";
            this.AdresTxtBx.Size = new System.Drawing.Size(156, 20);
            this.AdresTxtBx.TabIndex = 2;
            this.AdresTxtBx.TextChanged += new System.EventHandler(this.InputCheck);
            // 
            // AchternaamTxtBx
            // 
            this.AchternaamTxtBx.Location = new System.Drawing.Point(111, 38);
            this.AchternaamTxtBx.Name = "AchternaamTxtBx";
            this.AchternaamTxtBx.Size = new System.Drawing.Size(156, 20);
            this.AchternaamTxtBx.TabIndex = 1;
            this.AchternaamTxtBx.TextChanged += new System.EventHandler(this.InputCheck);
            this.AchternaamTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAlphabeticField_KeyPress);
            // 
            // VoornaamTxtBx
            // 
            this.VoornaamTxtBx.Location = new System.Drawing.Point(111, 12);
            this.VoornaamTxtBx.Name = "VoornaamTxtBx";
            this.VoornaamTxtBx.Size = new System.Drawing.Size(156, 20);
            this.VoornaamTxtBx.TabIndex = 0;
            this.VoornaamTxtBx.TextChanged += new System.EventHandler(this.InputCheck);
            this.VoornaamTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAlphabeticField_KeyPress);
            // 
            // ZoekBalk
            // 
            this.ZoekBalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekBalk.Location = new System.Drawing.Point(12, 159);
            this.ZoekBalk.Name = "ZoekBalk";
            this.ZoekBalk.Size = new System.Drawing.Size(222, 26);
            this.ZoekBalk.TabIndex = 4;
            this.ZoekBalk.TextChanged += new System.EventHandler(this.ZoekBalk_TextChanged);
            this.ZoekBalk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAlphabeticField_KeyPress);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(241, 157);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(91, 28);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "verwijder tekst";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PatientenBtnPnl
            // 
            this.PatientenBtnPnl.Controls.Add(this.DeleteBtn);
            this.PatientenBtnPnl.Controls.Add(this.UpdateBtn);
            this.PatientenBtnPnl.Location = new System.Drawing.Point(279, 563);
            this.PatientenBtnPnl.Name = "PatientenBtnPnl";
            this.PatientenBtnPnl.Size = new System.Drawing.Size(250, 39);
            this.PatientenBtnPnl.TabIndex = 6;
            this.PatientenBtnPnl.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(133, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(114, 33);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Patient Verwijder ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.PdeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(3, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(114, 33);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Patient Bijwerken";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NotePanel
            // 
            this.NotePanel.Controls.Add(this.NotitieRichTxtBx);
            this.NotePanel.Controls.Add(this.button2);
            this.NotePanel.Controls.Add(this.AddNotebtn);
            this.NotePanel.Controls.Add(this.NoteGrid);
            this.NotePanel.Location = new System.Drawing.Point(726, 13);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Size = new System.Drawing.Size(377, 599);
            this.NotePanel.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddNotebtn
            // 
            this.AddNotebtn.Location = new System.Drawing.Point(3, 550);
            this.AddNotebtn.Name = "AddNotebtn";
            this.AddNotebtn.Size = new System.Drawing.Size(144, 46);
            this.AddNotebtn.TabIndex = 1;
            this.AddNotebtn.Text = "Notitie Plaatsen";
            this.AddNotebtn.UseVisualStyleBackColor = true;
            this.AddNotebtn.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // NoteGrid
            // 
            this.NoteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.NoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.NoteGrid.Location = new System.Drawing.Point(3, 3);
            this.NoteGrid.Name = "NoteGrid";
            this.NoteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.NoteGrid.RowTemplate.DividerHeight = 5;
            this.NoteGrid.RowTemplate.Height = 50;
            this.NoteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NoteGrid.Size = new System.Drawing.Size(371, 396);
            this.NoteGrid.TabIndex = 0;
            // 
            // NotitieRichTxtBx
            // 
            this.NotitieRichTxtBx.Location = new System.Drawing.Point(4, 406);
            this.NotitieRichTxtBx.Name = "NotitieRichTxtBx";
            this.NotitieRichTxtBx.Size = new System.Drawing.Size(370, 138);
            this.NotitieRichTxtBx.TabIndex = 3;
            this.NotitieRichTxtBx.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 614);
            this.Controls.Add(this.NotePanel);
            this.Controls.Add(this.PatientenBtnPnl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ZoekBalk);
            this.Controls.Add(this.ToevoegPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PatientenGrid);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientenGrid)).EndInit();
            this.ToevoegPanel.ResumeLayout(false);
            this.ToevoegPanel.PerformLayout();
            this.PatientenBtnPnl.ResumeLayout(false);
            this.NotePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NoteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PatientenGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ToevoegPanel;
        private System.Windows.Forms.TextBox EmailadresTxtBx;
        private System.Windows.Forms.TextBox AdresTxtBx;
        private System.Windows.Forms.TextBox AchternaamTxtBx;
        private System.Windows.Forms.TextBox VoornaamTxtBx;
        private System.Windows.Forms.TextBox TelefoonnummerTxtBx;
        private System.Windows.Forms.Label telefoonNummerTxt;
        private System.Windows.Forms.Label emaiTxt;
        private System.Windows.Forms.Label AdresTxt;
        private System.Windows.Forms.Label AchternaamTxt;
        private System.Windows.Forms.Label NaamTxt;
        private System.Windows.Forms.Button ToevoegBtn;
        private System.Windows.Forms.TextBox ZoekBalk;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel PatientenBtnPnl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel NotePanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddNotebtn;
        private System.Windows.Forms.DataGridView NoteGrid;
        private System.Windows.Forms.RichTextBox NotitieRichTxtBx;
    }
}

