namespace MedicSoft
{
    partial class RegistruProgramari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistruProgramari));
            this.InapoiLabel = new System.Windows.Forms.Label();
            this.Deconectare = new MedicSoft.RoundButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataCurenta = new System.Windows.Forms.DateTimePicker();
            this.oraSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stergeConsultatie1 = new System.Windows.Forms.Label();
            this.contacteaza1 = new System.Windows.Forms.Label();
            this.datePersonale1 = new System.Windows.Forms.Label();
            this.stergeConsultatie = new MedicSoft.RoundButton();
            this.contacteaza = new MedicSoft.RoundButton();
            this.datePersonale = new MedicSoft.RoundButton();
            this.SuspendLayout();
            // 
            // InapoiLabel
            // 
            this.InapoiLabel.AutoSize = true;
            this.InapoiLabel.BackColor = System.Drawing.Color.Transparent;
            this.InapoiLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InapoiLabel.Location = new System.Drawing.Point(1147, 102);
            this.InapoiLabel.Name = "InapoiLabel";
            this.InapoiLabel.Size = new System.Drawing.Size(61, 28);
            this.InapoiLabel.TabIndex = 80;
            this.InapoiLabel.Text = "Inapoi";
            this.InapoiLabel.Click += new System.EventHandler(this.InapoiLabel_Click);
            // 
            // Deconectare
            // 
            this.Deconectare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Deconectare.BackgroundImage = global::MedicSoft.Properties.Resources.logout;
            this.Deconectare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Deconectare.Location = new System.Drawing.Point(1140, 30);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(79, 72);
            this.Deconectare.TabIndex = 79;
            this.Deconectare.UseVisualStyleBackColor = false;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Thistle;
            this.listBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(54, 230);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 364);
            this.listBox1.TabIndex = 81;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(471, 230);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(719, 364);
            this.listBox.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(49, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 91;
            this.label7.Text = "Selectati data";
            // 
            // dataCurenta
            // 
            this.dataCurenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCurenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataCurenta.Location = new System.Drawing.Point(54, 192);
            this.dataCurenta.MinDate = new System.DateTime(2018, 1, 4, 0, 0, 0, 0);
            this.dataCurenta.Name = "dataCurenta";
            this.dataCurenta.Size = new System.Drawing.Size(373, 22);
            this.dataCurenta.TabIndex = 93;
            this.dataCurenta.ValueChanged += new System.EventHandler(this.dataCurenta_ValueChanged);
            // 
            // oraSearch
            // 
            this.oraSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oraSearch.Location = new System.Drawing.Point(471, 194);
            this.oraSearch.Name = "oraSearch";
            this.oraSearch.Size = new System.Drawing.Size(337, 22);
            this.oraSearch.TabIndex = 95;
            this.oraSearch.TextChanged += new System.EventHandler(this.oraSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(466, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Introduceti ora";
            // 
            // numeSearch
            // 
            this.numeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeSearch.Location = new System.Drawing.Point(877, 194);
            this.numeSearch.Name = "numeSearch";
            this.numeSearch.Size = new System.Drawing.Size(313, 22);
            this.numeSearch.TabIndex = 97;
            this.numeSearch.TextChanged += new System.EventHandler(this.numeSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(872, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 28);
            this.label2.TabIndex = 96;
            this.label2.Text = "Introduceti numele apicultorului";
            // 
            // stergeConsultatie1
            // 
            this.stergeConsultatie1.AutoSize = true;
            this.stergeConsultatie1.BackColor = System.Drawing.Color.Transparent;
            this.stergeConsultatie1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeConsultatie1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stergeConsultatie1.Location = new System.Drawing.Point(395, 102);
            this.stergeConsultatie1.Name = "stergeConsultatie1";
            this.stergeConsultatie1.Size = new System.Drawing.Size(68, 28);
            this.stergeConsultatie1.TabIndex = 103;
            this.stergeConsultatie1.Text = "Sterge ";
            this.stergeConsultatie1.Click += new System.EventHandler(this.stergeConsultatie1_Click);
            // 
            // contacteaza1
            // 
            this.contacteaza1.AutoSize = true;
            this.contacteaza1.BackColor = System.Drawing.Color.Transparent;
            this.contacteaza1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacteaza1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contacteaza1.Location = new System.Drawing.Point(215, 102);
            this.contacteaza1.Name = "contacteaza1";
            this.contacteaza1.Size = new System.Drawing.Size(108, 28);
            this.contacteaza1.TabIndex = 102;
            this.contacteaza1.Text = "Contacteaza";
            this.contacteaza1.Click += new System.EventHandler(this.contacteaza1_Click);
            // 
            // datePersonale1
            // 
            this.datePersonale1.AutoSize = true;
            this.datePersonale1.BackColor = System.Drawing.Color.Transparent;
            this.datePersonale1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePersonale1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datePersonale1.Location = new System.Drawing.Point(49, 102);
            this.datePersonale1.Name = "datePersonale1";
            this.datePersonale1.Size = new System.Drawing.Size(126, 28);
            this.datePersonale1.TabIndex = 101;
            this.datePersonale1.Text = "Date apicultor";
            this.datePersonale1.Click += new System.EventHandler(this.datePersonale1_Click);
            // 
            // stergeConsultatie
            // 
            this.stergeConsultatie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.stergeConsultatie.BackgroundImage = global::MedicSoft.Properties.Resources.delete_button;
            this.stergeConsultatie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergeConsultatie.Location = new System.Drawing.Point(386, 23);
            this.stergeConsultatie.Name = "stergeConsultatie";
            this.stergeConsultatie.Size = new System.Drawing.Size(90, 86);
            this.stergeConsultatie.TabIndex = 100;
            this.stergeConsultatie.UseVisualStyleBackColor = false;
            this.stergeConsultatie.Click += new System.EventHandler(this.stergeConsultatie_Click);
            // 
            // contacteaza
            // 
            this.contacteaza.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.contacteaza.BackgroundImage = global::MedicSoft.Properties.Resources.telephone;
            this.contacteaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contacteaza.Location = new System.Drawing.Point(224, 23);
            this.contacteaza.Name = "contacteaza";
            this.contacteaza.Size = new System.Drawing.Size(90, 86);
            this.contacteaza.TabIndex = 99;
            this.contacteaza.UseVisualStyleBackColor = false;
            this.contacteaza.Click += new System.EventHandler(this.contacteaza_Click);
            // 
            // datePersonale
            // 
            this.datePersonale.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.datePersonale.BackgroundImage = global::MedicSoft.Properties.Resources.avatar;
            this.datePersonale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.datePersonale.Location = new System.Drawing.Point(65, 23);
            this.datePersonale.Name = "datePersonale";
            this.datePersonale.Size = new System.Drawing.Size(90, 86);
            this.datePersonale.TabIndex = 98;
            this.datePersonale.UseVisualStyleBackColor = false;
            this.datePersonale.Click += new System.EventHandler(this.datePersonale_Click);
            // 
            // RegistruProgramari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.stergeConsultatie1);
            this.Controls.Add(this.contacteaza1);
            this.Controls.Add(this.datePersonale1);
            this.Controls.Add(this.stergeConsultatie);
            this.Controls.Add(this.contacteaza);
            this.Controls.Add(this.datePersonale);
            this.Controls.Add(this.numeSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oraSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCurenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.InapoiLabel);
            this.Controls.Add(this.Deconectare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistruProgramari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InapoiLabel;
        private RoundButton Deconectare;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataCurenta;
        private System.Windows.Forms.TextBox oraSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stergeConsultatie1;
        private System.Windows.Forms.Label contacteaza1;
        private System.Windows.Forms.Label datePersonale1;
        private RoundButton stergeConsultatie;
        private RoundButton contacteaza;
        private RoundButton datePersonale;
    }
}