namespace MedicSoft
{
    partial class DiagnosticCurent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticCurent));
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.dataIdentificare = new System.Windows.Forms.DateTimePicker();
            this.codDiagnostic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.observatii = new System.Windows.Forms.RichTextBox();
            this.tipBoala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diagnosticClinic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stareBoala = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancel.BackgroundImage = global::MedicSoft.Properties.Resources.cross11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Location = new System.Drawing.Point(468, 23);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(39, 41);
            this.cancel.TabIndex = 81;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ok.BackgroundImage = global::MedicSoft.Properties.Resources.ok_mark11;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ok.Location = new System.Drawing.Point(363, 23);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(39, 41);
            this.ok.TabIndex = 80;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel1
            // 
            this.cancel1.AutoSize = true;
            this.cancel1.BackColor = System.Drawing.Color.Transparent;
            this.cancel1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel1.Location = new System.Drawing.Point(453, 56);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(76, 26);
            this.cancel1.TabIndex = 79;
            this.cancel1.Text = "Renunta";
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ok1
            // 
            this.ok1.AutoSize = true;
            this.ok1.BackColor = System.Drawing.Color.Transparent;
            this.ok1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok1.Location = new System.Drawing.Point(366, 56);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(33, 26);
            this.ok1.TabIndex = 78;
            this.ok1.Text = "Ok";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // dataIdentificare
            // 
            this.dataIdentificare.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdentificare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataIdentificare.Location = new System.Drawing.Point(360, 227);
            this.dataIdentificare.MinDate = new System.DateTime(2018, 1, 4, 0, 0, 0, 0);
            this.dataIdentificare.Name = "dataIdentificare";
            this.dataIdentificare.Size = new System.Drawing.Size(356, 22);
            this.dataIdentificare.TabIndex = 99;
            // 
            // codDiagnostic
            // 
            this.codDiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codDiagnostic.Location = new System.Drawing.Point(360, 108);
            this.codDiagnostic.Name = "codDiagnostic";
            this.codDiagnostic.Size = new System.Drawing.Size(356, 22);
            this.codDiagnostic.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(124, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 28);
            this.label7.TabIndex = 97;
            this.label7.Text = "Cod diagnostic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(124, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 28);
            this.label6.TabIndex = 96;
            this.label6.Text = "Diagnostic albine/stupina";
            // 
            // observatii
            // 
            this.observatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observatii.Location = new System.Drawing.Point(360, 330);
            this.observatii.Name = "observatii";
            this.observatii.Size = new System.Drawing.Size(356, 69);
            this.observatii.TabIndex = 95;
            this.observatii.Text = "";
            // 
            // tipBoala
            // 
            this.tipBoala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipBoala.Location = new System.Drawing.Point(360, 186);
            this.tipBoala.Name = "tipBoala";
            this.tipBoala.Size = new System.Drawing.Size(356, 22);
            this.tipBoala.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(124, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 93;
            this.label3.Text = "Observatii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(124, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 92;
            this.label1.Text = "Tip boala/afectiune";
            // 
            // diagnosticClinic
            // 
            this.diagnosticClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticClinic.Location = new System.Drawing.Point(360, 146);
            this.diagnosticClinic.Name = "diagnosticClinic";
            this.diagnosticClinic.Size = new System.Drawing.Size(356, 22);
            this.diagnosticClinic.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(124, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 100;
            this.label2.Text = "Data identificare";
            // 
            // stareBoala
            // 
            this.stareBoala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stareBoala.Location = new System.Drawing.Point(360, 268);
            this.stareBoala.Name = "stareBoala";
            this.stareBoala.Size = new System.Drawing.Size(356, 41);
            this.stareBoala.TabIndex = 103;
            this.stareBoala.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(124, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 28);
            this.label4.TabIndex = 102;
            this.label4.Text = "Stare boala/afectiune";
            // 
            // DiagnosticCurent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources.desktop_wallpaper_cute_honey_yellow_bumble_bee;
            this.ClientSize = new System.Drawing.Size(841, 429);
            this.Controls.Add(this.stareBoala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diagnosticClinic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataIdentificare);
            this.Controls.Add(this.codDiagnostic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.observatii);
            this.Controls.Add(this.tipBoala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiagnosticCurent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicSoft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton cancel;
        private RoundButton ok;
        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private System.Windows.Forms.DateTimePicker dataIdentificare;
        private System.Windows.Forms.TextBox codDiagnostic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox observatii;
        private System.Windows.Forms.TextBox tipBoala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diagnosticClinic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox stareBoala;
        private System.Windows.Forms.Label label4;
    }
}