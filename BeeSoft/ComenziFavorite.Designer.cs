namespace MedicSoft
{
    partial class ComenziFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComenziFavorite));
            this.istoricMedicale = new System.Windows.Forms.CheckBox();
            this.biletTrimitere = new System.Windows.Forms.CheckBox();
            this.consultatieNoua = new System.Windows.Forms.CheckBox();
            this.deschideFisa = new System.Windows.Forms.CheckBox();
            this.diagnostic = new System.Windows.Forms.CheckBox();
            this.istoricConsultatii = new System.Windows.Forms.CheckBox();
            this.fisaPacient = new System.Windows.Forms.CheckBox();
            this.fisiere = new System.Windows.Forms.CheckBox();
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.SuspendLayout();
            // 
            // istoricMedicale
            // 
            this.istoricMedicale.AutoSize = true;
            this.istoricMedicale.BackColor = System.Drawing.Color.Transparent;
            this.istoricMedicale.Location = new System.Drawing.Point(377, 120);
            this.istoricMedicale.Name = "istoricMedicale";
            this.istoricMedicale.Size = new System.Drawing.Size(156, 17);
            this.istoricMedicale.TabIndex = 1;
            this.istoricMedicale.Text = "Istoric diagnostice/afectiuni";
            this.istoricMedicale.UseVisualStyleBackColor = false;
            this.istoricMedicale.CheckedChanged += new System.EventHandler(this.biletInvestigatii_CheckedChanged);
            // 
            // biletTrimitere
            // 
            this.biletTrimitere.AutoSize = true;
            this.biletTrimitere.BackColor = System.Drawing.Color.Transparent;
            this.biletTrimitere.Location = new System.Drawing.Point(84, 84);
            this.biletTrimitere.Name = "biletTrimitere";
            this.biletTrimitere.Size = new System.Drawing.Size(129, 17);
            this.biletTrimitere.TabIndex = 2;
            this.biletTrimitere.Text = "Bilet analiza afectiune";
            this.biletTrimitere.UseVisualStyleBackColor = false;
            this.biletTrimitere.CheckedChanged += new System.EventHandler(this.biletTrimitere_CheckedChanged);
            // 
            // consultatieNoua
            // 
            this.consultatieNoua.AutoSize = true;
            this.consultatieNoua.BackColor = System.Drawing.Color.Transparent;
            this.consultatieNoua.Location = new System.Drawing.Point(84, 152);
            this.consultatieNoua.Name = "consultatieNoua";
            this.consultatieNoua.Size = new System.Drawing.Size(120, 17);
            this.consultatieNoua.TabIndex = 4;
            this.consultatieNoua.Text = "Control periodic nou";
            this.consultatieNoua.UseVisualStyleBackColor = false;
            this.consultatieNoua.CheckedChanged += new System.EventHandler(this.consultatieNoua_CheckedChanged);
            // 
            // deschideFisa
            // 
            this.deschideFisa.AutoSize = true;
            this.deschideFisa.BackColor = System.Drawing.Color.Transparent;
            this.deschideFisa.Location = new System.Drawing.Point(84, 120);
            this.deschideFisa.Name = "deschideFisa";
            this.deschideFisa.Size = new System.Drawing.Size(133, 17);
            this.deschideFisa.TabIndex = 5;
            this.deschideFisa.Text = "Deschide fisa apicultor";
            this.deschideFisa.UseVisualStyleBackColor = false;
            this.deschideFisa.CheckedChanged += new System.EventHandler(this.deschideFisa_CheckedChanged);
            // 
            // diagnostic
            // 
            this.diagnostic.AutoSize = true;
            this.diagnostic.BackColor = System.Drawing.Color.Transparent;
            this.diagnostic.Location = new System.Drawing.Point(234, 84);
            this.diagnostic.Name = "diagnostic";
            this.diagnostic.Size = new System.Drawing.Size(97, 17);
            this.diagnostic.TabIndex = 6;
            this.diagnostic.Text = "Diagnostic nou";
            this.diagnostic.UseVisualStyleBackColor = false;
            this.diagnostic.CheckedChanged += new System.EventHandler(this.diagnostic_CheckedChanged);
            // 
            // istoricConsultatii
            // 
            this.istoricConsultatii.AutoSize = true;
            this.istoricConsultatii.BackColor = System.Drawing.Color.Transparent;
            this.istoricConsultatii.Location = new System.Drawing.Point(377, 84);
            this.istoricConsultatii.Name = "istoricConsultatii";
            this.istoricConsultatii.Size = new System.Drawing.Size(147, 17);
            this.istoricConsultatii.TabIndex = 8;
            this.istoricConsultatii.Text = "Istoric controale periodice";
            this.istoricConsultatii.UseVisualStyleBackColor = false;
            this.istoricConsultatii.CheckedChanged += new System.EventHandler(this.istoricConsultatii_CheckedChanged);
            // 
            // fisaPacient
            // 
            this.fisaPacient.AutoSize = true;
            this.fisaPacient.BackColor = System.Drawing.Color.Transparent;
            this.fisaPacient.Location = new System.Drawing.Point(234, 120);
            this.fisaPacient.Name = "fisaPacient";
            this.fisaPacient.Size = new System.Drawing.Size(89, 17);
            this.fisaPacient.TabIndex = 10;
            this.fisaPacient.Text = "Fisa Apicultor";
            this.fisaPacient.UseVisualStyleBackColor = false;
            this.fisaPacient.CheckedChanged += new System.EventHandler(this.fisaPacient_CheckedChanged);
            // 
            // fisiere
            // 
            this.fisiere.AutoSize = true;
            this.fisiere.BackColor = System.Drawing.Color.Transparent;
            this.fisiere.Location = new System.Drawing.Point(377, 152);
            this.fisiere.Name = "fisiere";
            this.fisiere.Size = new System.Drawing.Size(56, 17);
            this.fisiere.TabIndex = 11;
            this.fisiere.Text = "Fisiere";
            this.fisiere.UseVisualStyleBackColor = false;
            this.fisiere.CheckedChanged += new System.EventHandler(this.fisiere_CheckedChanged);
            // 
            // cancel1
            // 
            this.cancel1.AutoSize = true;
            this.cancel1.BackColor = System.Drawing.Color.Transparent;
            this.cancel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel1.Location = new System.Drawing.Point(300, 42);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(66, 23);
            this.cancel1.TabIndex = 82;
            this.cancel1.Text = "Renunta";
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ok1
            // 
            this.ok1.AutoSize = true;
            this.ok1.BackColor = System.Drawing.Color.Transparent;
            this.ok1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok1.Location = new System.Drawing.Point(241, 42);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(28, 23);
            this.ok1.TabIndex = 81;
            this.ok1.Text = "Ok";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancel.BackgroundImage = global::MedicSoft.Properties.Resources.cross11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Location = new System.Drawing.Point(310, 6);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(44, 43);
            this.cancel.TabIndex = 80;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ok.BackgroundImage = global::MedicSoft.Properties.Resources.ok_mark11;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ok.Location = new System.Drawing.Point(234, 6);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(44, 43);
            this.ok.TabIndex = 79;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // ComenziFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources.desktop_wallpaper_cute_honey_yellow_bumble_bee;
            this.ClientSize = new System.Drawing.Size(580, 224);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.fisiere);
            this.Controls.Add(this.fisaPacient);
            this.Controls.Add(this.istoricConsultatii);
            this.Controls.Add(this.diagnostic);
            this.Controls.Add(this.deschideFisa);
            this.Controls.Add(this.consultatieNoua);
            this.Controls.Add(this.biletTrimitere);
            this.Controls.Add(this.istoricMedicale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComenziFavorite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicSoft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox istoricMedicale;
        private System.Windows.Forms.CheckBox biletTrimitere;
        private System.Windows.Forms.CheckBox consultatieNoua;
        private System.Windows.Forms.CheckBox deschideFisa;
        private System.Windows.Forms.CheckBox diagnostic;
        private System.Windows.Forms.CheckBox istoricConsultatii;
        private System.Windows.Forms.CheckBox fisaPacient;
        private System.Windows.Forms.CheckBox fisiere;
        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private RoundButton cancel;
        private RoundButton ok;
    }
}