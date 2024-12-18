namespace Huisart_Project
{
    partial class Form1
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
            this.PatientenGrid = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.ToevoegPanel = new System.Windows.Forms.Panel();
            this.ToevoegBtn = new System.Windows.Forms.Button();
            this.telefoonNummerTxt = new System.Windows.Forms.Label();
            this.emaiTxt = new System.Windows.Forms.Label();
            this.AdresTxt = new System.Windows.Forms.Label();
            this.AchternaamTxt = new System.Windows.Forms.Label();
            this.NaamTxt = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ZoekBalk = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatientenGrid)).BeginInit();
            this.ToevoegPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientenGrid
            // 
            this.PatientenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientenGrid.Location = new System.Drawing.Point(18, 294);
            this.PatientenGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientenGrid.MultiSelect = false;
            this.PatientenGrid.Name = "PatientenGrid";
            this.PatientenGrid.RowHeadersWidth = 62;
            this.PatientenGrid.Size = new System.Drawing.Size(978, 563);
            this.PatientenGrid.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 866);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(250, 60);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "UpdateLijst";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ToevoegPanel
            // 
            this.ToevoegPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ToevoegPanel.Controls.Add(this.ToevoegBtn);
            this.ToevoegPanel.Controls.Add(this.telefoonNummerTxt);
            this.ToevoegPanel.Controls.Add(this.emaiTxt);
            this.ToevoegPanel.Controls.Add(this.AdresTxt);
            this.ToevoegPanel.Controls.Add(this.AchternaamTxt);
            this.ToevoegPanel.Controls.Add(this.NaamTxt);
            this.ToevoegPanel.Controls.Add(this.textBox5);
            this.ToevoegPanel.Controls.Add(this.textBox4);
            this.ToevoegPanel.Controls.Add(this.textBox3);
            this.ToevoegPanel.Controls.Add(this.textBox2);
            this.ToevoegPanel.Controls.Add(this.textBox1);
            this.ToevoegPanel.Location = new System.Drawing.Point(654, 18);
            this.ToevoegPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToevoegPanel.Name = "ToevoegPanel";
            this.ToevoegPanel.Size = new System.Drawing.Size(342, 266);
            this.ToevoegPanel.TabIndex = 3;
            this.ToevoegPanel.Visible = false;
            // 
            // ToevoegBtn
            // 
            this.ToevoegBtn.Location = new System.Drawing.Point(111, 223);
            this.ToevoegBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToevoegBtn.Name = "ToevoegBtn";
            this.ToevoegBtn.Size = new System.Drawing.Size(112, 35);
            this.ToevoegBtn.TabIndex = 10;
            this.ToevoegBtn.Text = "Toevoegen";
            this.ToevoegBtn.UseVisualStyleBackColor = true;
            this.ToevoegBtn.Click += new System.EventHandler(this.ToevoegBtn_Click);
            // 
            // telefoonNummerTxt
            // 
            this.telefoonNummerTxt.AutoSize = true;
            this.telefoonNummerTxt.Location = new System.Drawing.Point(4, 183);
            this.telefoonNummerTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefoonNummerTxt.Name = "telefoonNummerTxt";
            this.telefoonNummerTxt.Size = new System.Drawing.Size(129, 20);
            this.telefoonNummerTxt.TabIndex = 9;
            this.telefoonNummerTxt.Text = "Telefoonnummer";
            // 
            // emaiTxt
            // 
            this.emaiTxt.AutoSize = true;
            this.emaiTxt.Location = new System.Drawing.Point(4, 142);
            this.emaiTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaiTxt.Name = "emaiTxt";
            this.emaiTxt.Size = new System.Drawing.Size(48, 20);
            this.emaiTxt.TabIndex = 8;
            this.emaiTxt.Text = "Email";
            // 
            // AdresTxt
            // 
            this.AdresTxt.AutoSize = true;
            this.AdresTxt.Location = new System.Drawing.Point(4, 100);
            this.AdresTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdresTxt.Name = "AdresTxt";
            this.AdresTxt.Size = new System.Drawing.Size(51, 20);
            this.AdresTxt.TabIndex = 7;
            this.AdresTxt.Text = "Adres";
            // 
            // AchternaamTxt
            // 
            this.AchternaamTxt.AutoSize = true;
            this.AchternaamTxt.Location = new System.Drawing.Point(6, 63);
            this.AchternaamTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AchternaamTxt.Name = "AchternaamTxt";
            this.AchternaamTxt.Size = new System.Drawing.Size(96, 20);
            this.AchternaamTxt.TabIndex = 6;
            this.AchternaamTxt.Text = "Achternaam";
            // 
            // NaamTxt
            // 
            this.NaamTxt.AutoSize = true;
            this.NaamTxt.Location = new System.Drawing.Point(6, 28);
            this.NaamTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaamTxt.Name = "NaamTxt";
            this.NaamTxt.Size = new System.Drawing.Size(51, 20);
            this.NaamTxt.TabIndex = 5;
            this.NaamTxt.Text = "Naam";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(166, 183);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 26);
            this.textBox5.TabIndex = 4;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeenLetters_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 142);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 26);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 100);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeenNummer_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeenNummer_KeyPress);
            // 
            // ZoekBalk
            // 
            this.ZoekBalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekBalk.Location = new System.Drawing.Point(18, 245);
            this.ZoekBalk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ZoekBalk.Name = "ZoekBalk";
            this.ZoekBalk.Size = new System.Drawing.Size(331, 35);
            this.ZoekBalk.TabIndex = 4;
            this.ZoekBalk.TextChanged += new System.EventHandler(this.ZoekBalk_TextChanged);
            this.ZoekBalk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeenNummer_KeyPress);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(362, 242);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(136, 43);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "verwijder tekst";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 945);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ZoekBalk);
            this.Controls.Add(this.ToevoegPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PatientenGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientenGrid)).EndInit();
            this.ToevoegPanel.ResumeLayout(false);
            this.ToevoegPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PatientenGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ToevoegPanel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label telefoonNummerTxt;
        private System.Windows.Forms.Label emaiTxt;
        private System.Windows.Forms.Label AdresTxt;
        private System.Windows.Forms.Label AchternaamTxt;
        private System.Windows.Forms.Label NaamTxt;
        private System.Windows.Forms.Button ToevoegBtn;
        private System.Windows.Forms.TextBox ZoekBalk;
        private System.Windows.Forms.Button ClearBtn;
    }
}

