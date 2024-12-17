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
            this.PatientenGrid.Location = new System.Drawing.Point(12, 191);
            this.PatientenGrid.Name = "PatientenGrid";
            this.PatientenGrid.Size = new System.Drawing.Size(652, 366);
            this.PatientenGrid.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 563);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(167, 39);
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
            this.ToevoegPanel.Location = new System.Drawing.Point(436, 12);
            this.ToevoegPanel.Name = "ToevoegPanel";
            this.ToevoegPanel.Size = new System.Drawing.Size(228, 173);
            this.ToevoegPanel.TabIndex = 3;
            this.ToevoegPanel.Visible = false;
            // 
            // ToevoegBtn
            // 
            this.ToevoegBtn.Location = new System.Drawing.Point(74, 145);
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(114, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ZoekBalk
            // 
            this.ZoekBalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekBalk.Location = new System.Drawing.Point(12, 159);
            this.ZoekBalk.Name = "ZoekBalk";
            this.ZoekBalk.Size = new System.Drawing.Size(222, 26);
            this.ZoekBalk.TabIndex = 4;
            this.ZoekBalk.TextChanged += new System.EventHandler(this.ZoekBalk_TextChanged);
            this.ZoekBalk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeenNummer_KeyPress);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 614);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ZoekBalk);
            this.Controls.Add(this.ToevoegPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PatientenGrid);
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

