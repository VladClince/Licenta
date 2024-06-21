namespace MedicSoft
{
    partial class RegistruConsultatii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistruConsultatii));
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.InapoiLabel = new System.Windows.Forms.Label();
            this.Deconectare = new MedicSoft.RoundButton();
            this.stergeConsultatie1 = new System.Windows.Forms.Label();
            this.stergeConsultatie = new MedicSoft.RoundButton();
            this.datePacient1 = new System.Windows.Forms.Label();
            this.datePacient = new MedicSoft.RoundButton();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(49, 172);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(366, 424);
            this.listBox.TabIndex = 65;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Thistle;
            this.listBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(495, 172);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 424);
            this.listBox1.TabIndex = 66;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // stergeConsultatie1
            // 
            this.stergeConsultatie1.AutoSize = true;
            this.stergeConsultatie1.BackColor = System.Drawing.Color.Transparent;
            this.stergeConsultatie1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeConsultatie1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stergeConsultatie1.Location = new System.Drawing.Point(236, 102);
            this.stergeConsultatie1.Name = "stergeConsultatie1";
            this.stergeConsultatie1.Size = new System.Drawing.Size(62, 28);
            this.stergeConsultatie1.TabIndex = 70;
            this.stergeConsultatie1.Text = "Sterge";
            this.stergeConsultatie1.Click += new System.EventHandler(this.stergeConsultatie1_Click);
            // 
            // stergeConsultatie
            // 
            this.stergeConsultatie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.stergeConsultatie.BackgroundImage = global::MedicSoft.Properties.Resources.delete_button;
            this.stergeConsultatie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergeConsultatie.Location = new System.Drawing.Point(224, 23);
            this.stergeConsultatie.Name = "stergeConsultatie";
            this.stergeConsultatie.Size = new System.Drawing.Size(90, 86);
            this.stergeConsultatie.TabIndex = 69;
            this.stergeConsultatie.UseVisualStyleBackColor = false;
            this.stergeConsultatie.Click += new System.EventHandler(this.stergeConsultatie_Click);
            // 
            // datePacient1
            // 
            this.datePacient1.AutoSize = true;
            this.datePacient1.BackColor = System.Drawing.Color.Transparent;
            this.datePacient1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePacient1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datePacient1.Location = new System.Drawing.Point(60, 102);
            this.datePacient1.Name = "datePacient1";
            this.datePacient1.Size = new System.Drawing.Size(129, 28);
            this.datePacient1.TabIndex = 72;
            this.datePacient1.Text = "Date Apicultor";
            this.datePacient1.Click += new System.EventHandler(this.datePacient1_Click);
            // 
            // datePacient
            // 
            this.datePacient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.datePacient.BackgroundImage = global::MedicSoft.Properties.Resources.avatar;
            this.datePacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.datePacient.Location = new System.Drawing.Point(65, 23);
            this.datePacient.Name = "datePacient";
            this.datePacient.Size = new System.Drawing.Size(90, 86);
            this.datePacient.TabIndex = 71;
            this.datePacient.UseVisualStyleBackColor = false;
            this.datePacient.Click += new System.EventHandler(this.datePacient_Click);
            // 
            // RegistruConsultatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.datePacient1);
            this.Controls.Add(this.datePacient);
            this.Controls.Add(this.stergeConsultatie1);
            this.Controls.Add(this.stergeConsultatie);
            this.Controls.Add(this.InapoiLabel);
            this.Controls.Add(this.Deconectare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistruConsultatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.Load += new System.EventHandler(this.RegistruConsultatii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label InapoiLabel;
        private RoundButton Deconectare;
        private System.Windows.Forms.Label stergeConsultatie1;
        private RoundButton stergeConsultatie;
        private System.Windows.Forms.Label datePacient1;
        private RoundButton datePacient;
    }
}