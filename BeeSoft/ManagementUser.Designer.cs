namespace MedicSoft
{
    partial class ManagementUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementUser));
            this.listBox = new System.Windows.Forms.ListBox();
            this.InapoiLabel = new System.Windows.Forms.Label();
            this.Deconectare = new MedicSoft.RoundButton();
            this.Editeaza1 = new System.Windows.Forms.Label();
            this.sterge1 = new System.Windows.Forms.Label();
            this.Sterge = new MedicSoft.RoundButton();
            this.Editeaza = new MedicSoft.RoundButton();
            this.Salvare1 = new System.Windows.Forms.Label();
            this.Salvare = new MedicSoft.RoundButton();
            this.Renunta1 = new System.Windows.Forms.Label();
            this.Renunta = new MedicSoft.RoundButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cnp = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.RichTextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataNasterii = new System.Windows.Forms.DateTimePicker();
            this.dataAngajare = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(53, 193);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(366, 404);
            this.listBox.TabIndex = 65;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // InapoiLabel
            // 
            this.InapoiLabel.AutoSize = true;
            this.InapoiLabel.BackColor = System.Drawing.Color.Transparent;
            this.InapoiLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InapoiLabel.Location = new System.Drawing.Point(1196, 102);
            this.InapoiLabel.Name = "InapoiLabel";
            this.InapoiLabel.Size = new System.Drawing.Size(61, 28);
            this.InapoiLabel.TabIndex = 68;
            this.InapoiLabel.Text = "Inapoi";
            this.InapoiLabel.Click += new System.EventHandler(this.InapoiLabel_Click);
            // 
            // Deconectare
            // 
            this.Deconectare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Deconectare.BackgroundImage = global::MedicSoft.Properties.Resources.logout;
            this.Deconectare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Deconectare.Location = new System.Drawing.Point(1189, 30);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(79, 72);
            this.Deconectare.TabIndex = 67;
            this.Deconectare.UseVisualStyleBackColor = false;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // Editeaza1
            // 
            this.Editeaza1.AutoSize = true;
            this.Editeaza1.BackColor = System.Drawing.Color.Transparent;
            this.Editeaza1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeaza1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Editeaza1.Location = new System.Drawing.Point(36, 102);
            this.Editeaza1.Name = "Editeaza1";
            this.Editeaza1.Size = new System.Drawing.Size(148, 28);
            this.Editeaza1.TabIndex = 72;
            this.Editeaza1.Text = "Editeaza Angajat";
            this.Editeaza1.Click += new System.EventHandler(this.Editeaza1_Click);
            // 
            // sterge1
            // 
            this.sterge1.AutoSize = true;
            this.sterge1.BackColor = System.Drawing.Color.Transparent;
            this.sterge1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sterge1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sterge1.Location = new System.Drawing.Point(204, 102);
            this.sterge1.Name = "sterge1";
            this.sterge1.Size = new System.Drawing.Size(130, 28);
            this.sterge1.TabIndex = 71;
            this.sterge1.Text = "Sterge Angajat";
            this.sterge1.Click += new System.EventHandler(this.sterge1_Click);
            // 
            // Sterge
            // 
            this.Sterge.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sterge.BackgroundImage = global::MedicSoft.Properties.Resources.delete_button;
            this.Sterge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sterge.Location = new System.Drawing.Point(224, 23);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(90, 86);
            this.Sterge.TabIndex = 70;
            this.Sterge.UseVisualStyleBackColor = false;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // Editeaza
            // 
            this.Editeaza.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Editeaza.BackgroundImage = global::MedicSoft.Properties.Resources.edit;
            this.Editeaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Editeaza.Location = new System.Drawing.Point(65, 23);
            this.Editeaza.Name = "Editeaza";
            this.Editeaza.Size = new System.Drawing.Size(90, 86);
            this.Editeaza.TabIndex = 69;
            this.Editeaza.UseVisualStyleBackColor = false;
            this.Editeaza.Click += new System.EventHandler(this.Editeaza_Click);
            // 
            // Salvare1
            // 
            this.Salvare1.AutoSize = true;
            this.Salvare1.BackColor = System.Drawing.Color.Transparent;
            this.Salvare1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvare1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Salvare1.Location = new System.Drawing.Point(391, 102);
            this.Salvare1.Name = "Salvare1";
            this.Salvare1.Size = new System.Drawing.Size(70, 28);
            this.Salvare1.TabIndex = 136;
            this.Salvare1.Text = "Salvare";
            this.Salvare1.Click += new System.EventHandler(this.Salvare1_Click);
            // 
            // Salvare
            // 
            this.Salvare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Salvare.BackgroundImage = global::MedicSoft.Properties.Resources.save_file_option;
            this.Salvare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salvare.Location = new System.Drawing.Point(386, 23);
            this.Salvare.Name = "Salvare";
            this.Salvare.Size = new System.Drawing.Size(90, 86);
            this.Salvare.TabIndex = 135;
            this.Salvare.UseVisualStyleBackColor = false;
            this.Salvare.Click += new System.EventHandler(this.Salvare_Click);
            // 
            // Renunta1
            // 
            this.Renunta1.AutoSize = true;
            this.Renunta1.BackColor = System.Drawing.Color.Transparent;
            this.Renunta1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renunta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Renunta1.Location = new System.Drawing.Point(551, 102);
            this.Renunta1.Name = "Renunta1";
            this.Renunta1.Size = new System.Drawing.Size(80, 28);
            this.Renunta1.TabIndex = 134;
            this.Renunta1.Text = "Renunta";
            this.Renunta1.Click += new System.EventHandler(this.Renunta1_Click);
            // 
            // Renunta
            // 
            this.Renunta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Renunta.BackgroundImage = global::MedicSoft.Properties.Resources.cross2;
            this.Renunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Renunta.Location = new System.Drawing.Point(546, 23);
            this.Renunta.Name = "Renunta";
            this.Renunta.Size = new System.Drawing.Size(90, 86);
            this.Renunta.TabIndex = 133;
            this.Renunta.UseVisualStyleBackColor = false;
            this.Renunta.Click += new System.EventHandler(this.Renunta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(594, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 147;
            this.label7.Text = "Data inregistrare";
            // 
            // cnp
            // 
            this.cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnp.Location = new System.Drawing.Point(807, 293);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(356, 22);
            this.cnp.TabIndex = 146;
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.Location = new System.Drawing.Point(807, 456);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(356, 22);
            this.telefon.TabIndex = 145;
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.Location = new System.Drawing.Point(807, 199);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(356, 22);
            this.nume.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(594, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 143;
            this.label6.Text = "Nume";
            // 
            // adresa
            // 
            this.adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresa.Location = new System.Drawing.Point(807, 351);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(356, 72);
            this.adresa.TabIndex = 142;
            this.adresa.Text = "";
            // 
            // prenume
            // 
            this.prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenume.Location = new System.Drawing.Point(807, 244);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(356, 22);
            this.prenume.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(594, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 140;
            this.label5.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(591, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 139;
            this.label3.Text = "Cod Numeric Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(594, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 138;
            this.label2.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(591, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 137;
            this.label1.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(594, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 149;
            this.label4.Text = "Data nasterii";
            // 
            // dataNasterii
            // 
            this.dataNasterii.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasterii.Location = new System.Drawing.Point(807, 559);
            this.dataNasterii.MinDate = new System.DateTime(1945, 12, 19, 0, 0, 0, 0);
            this.dataNasterii.Name = "dataNasterii";
            this.dataNasterii.Size = new System.Drawing.Size(356, 22);
            this.dataNasterii.TabIndex = 150;
            // 
            // dataAngajare
            // 
            this.dataAngajare.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAngajare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAngajare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAngajare.Location = new System.Drawing.Point(807, 510);
            this.dataAngajare.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dataAngajare.Name = "dataAngajare";
            this.dataAngajare.Size = new System.Drawing.Size(356, 22);
            this.dataAngajare.TabIndex = 151;
            // 
            // ManagementUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.dataAngajare);
            this.Controls.Add(this.dataNasterii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salvare1);
            this.Controls.Add(this.Salvare);
            this.Controls.Add(this.Renunta1);
            this.Controls.Add(this.Renunta);
            this.Controls.Add(this.Editeaza1);
            this.Controls.Add(this.sterge1);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Editeaza);
            this.Controls.Add(this.InapoiLabel);
            this.Controls.Add(this.Deconectare);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagementUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label InapoiLabel;
        private RoundButton Deconectare;
        private System.Windows.Forms.Label Editeaza1;
        private System.Windows.Forms.Label sterge1;
        private RoundButton Sterge;
        private RoundButton Editeaza;
        private System.Windows.Forms.Label Salvare1;
        private RoundButton Salvare;
        private System.Windows.Forms.Label Renunta1;
        private RoundButton Renunta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cnp;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox adresa;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataNasterii;
        private System.Windows.Forms.DateTimePicker dataAngajare;
    }
}