using System.Globalization;
using System.Threading;
namespace MedicSoft
{
    partial class ConsultatieCurenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultatieCurenta));
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.alteSimptome = new System.Windows.Forms.RichTextBox();
            this.tratament = new System.Windows.Forms.RichTextBox();
            this.diagnosticPrincipal = new System.Windows.Forms.TextBox();
            this.dataConsult = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numeMedic = new System.Windows.Forms.TextBox();
            this.ora = new System.Windows.Forms.ComboBox();
            this.minute = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Cabinet = new System.Windows.Forms.RadioButton();
            this.Domiciliu = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.inaltime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.durataSimptom = new System.Windows.Forms.TextBox();
            this.greutate = new System.Windows.Forms.TextBox();
            this.Angajare = new System.Windows.Forms.CheckBox();
            this.ControlPeriodic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancel1
            // 
            this.cancel1.AutoSize = true;
            this.cancel1.BackColor = System.Drawing.Color.Transparent;
            this.cancel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel1.Location = new System.Drawing.Point(711, 123);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(80, 28);
            this.cancel1.TabIndex = 78;
            this.cancel1.Text = "Renunta";
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ok1
            // 
            this.ok1.AutoSize = true;
            this.ok1.BackColor = System.Drawing.Color.Transparent;
            this.ok1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok1.Location = new System.Drawing.Point(549, 123);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(34, 28);
            this.ok1.TabIndex = 77;
            this.ok1.Text = "Ok";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancel.BackgroundImage = global::MedicSoft.Properties.Resources.cross1;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Location = new System.Drawing.Point(712, 58);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(79, 72);
            this.cancel.TabIndex = 76;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ok.BackgroundImage = global::MedicSoft.Properties.Resources.ok_mark1;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ok.Location = new System.Drawing.Point(529, 58);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(79, 72);
            this.ok.TabIndex = 75;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // alteSimptome
            // 
            this.alteSimptome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteSimptome.Location = new System.Drawing.Point(716, 499);
            this.alteSimptome.Name = "alteSimptome";
            this.alteSimptome.Size = new System.Drawing.Size(356, 69);
            this.alteSimptome.TabIndex = 97;
            this.alteSimptome.Text = "";
            // 
            // tratament
            // 
            this.tratament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratament.Location = new System.Drawing.Point(189, 499);
            this.tratament.Name = "tratament";
            this.tratament.Size = new System.Drawing.Size(356, 72);
            this.tratament.TabIndex = 96;
            this.tratament.Text = "";
            // 
            // diagnosticPrincipal
            // 
            this.diagnosticPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticPrincipal.Location = new System.Drawing.Point(189, 429);
            this.diagnosticPrincipal.Name = "diagnosticPrincipal";
            this.diagnosticPrincipal.Size = new System.Drawing.Size(356, 22);
            this.diagnosticPrincipal.TabIndex = 95;
            // 
            // dataConsult
            // 
            this.dataConsult.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataConsult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataConsult.Location = new System.Drawing.Point(716, 224);
            this.dataConsult.MinDate = new System.DateTime(2018, 1, 4, 0, 0, 0, 0);
            this.dataConsult.Name = "dataConsult";
            this.dataConsult.Size = new System.Drawing.Size(356, 22);
            this.dataConsult.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(711, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 91;
            this.label5.Text = "Data control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(184, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 28);
            this.label3.TabIndex = 90;
            this.label3.Text = "Boli curente albine/stupina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(184, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 28);
            this.label2.TabIndex = 89;
            this.label2.Text = "Antecedente (ex: varrooza, nosemoza, etc.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(184, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 98;
            this.label4.Text = "Locul investigatiei";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(711, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 28);
            this.label6.TabIndex = 99;
            this.label6.Text = "Ora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(711, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 28);
            this.label7.TabIndex = 100;
            this.label7.Text = "Concluzii examen apicol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(711, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 28);
            this.label8.TabIndex = 101;
            this.label8.Text = "Examene suplimentare necesare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(184, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 28);
            this.label9.TabIndex = 102;
            this.label9.Text = "Motiv examen albine/stupina";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(184, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 28);
            this.label10.TabIndex = 103;
            this.label10.Text = "Nume specialist apicol";
            // 
            // numeMedic
            // 
            this.numeMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeMedic.Location = new System.Drawing.Point(189, 224);
            this.numeMedic.Name = "numeMedic";
            this.numeMedic.Size = new System.Drawing.Size(356, 22);
            this.numeMedic.TabIndex = 104;
            // 
            // ora
            // 
            this.ora.FormattingEnabled = true;
            this.ora.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.ora.Location = new System.Drawing.Point(716, 291);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(55, 21);
            this.ora.TabIndex = 106;
            // 
            // minute
            // 
            this.minute.FormattingEnabled = true;
            this.minute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.minute.Location = new System.Drawing.Point(788, 291);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(55, 21);
            this.minute.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(771, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 28);
            this.label11.TabIndex = 108;
            this.label11.Text = ":";
            // 
            // Cabinet
            // 
            this.Cabinet.AutoSize = true;
            this.Cabinet.BackColor = System.Drawing.Color.Transparent;
            this.Cabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cabinet.Location = new System.Drawing.Point(189, 291);
            this.Cabinet.Name = "Cabinet";
            this.Cabinet.Size = new System.Drawing.Size(118, 19);
            this.Cabinet.TabIndex = 109;
            this.Cabinet.TabStop = true;
            this.Cabinet.Text = "Asociatie apic.";
            this.Cabinet.UseVisualStyleBackColor = false;
            // 
            // Domiciliu
            // 
            this.Domiciliu.AutoSize = true;
            this.Domiciliu.BackColor = System.Drawing.Color.Transparent;
            this.Domiciliu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Domiciliu.Location = new System.Drawing.Point(314, 293);
            this.Domiciliu.Name = "Domiciliu";
            this.Domiciliu.Size = new System.Drawing.Size(86, 19);
            this.Domiciliu.TabIndex = 111;
            this.Domiciliu.TabStop = true;
            this.Domiciliu.Text = "Domiciliu";
            this.Domiciliu.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(711, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 28);
            this.label12.TabIndex = 113;
            this.label12.Text = "Inaltime stup (cm)";
            // 
            // inaltime
            // 
            this.inaltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inaltime.Location = new System.Drawing.Point(716, 363);
            this.inaltime.Name = "inaltime";
            this.inaltime.Size = new System.Drawing.Size(127, 22);
            this.inaltime.TabIndex = 114;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(899, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 28);
            this.label13.TabIndex = 115;
            this.label13.Text = "Greutate stup (kg)";
            // 
            // durataSimptom
            // 
            this.durataSimptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durataSimptom.Location = new System.Drawing.Point(716, 429);
            this.durataSimptom.Name = "durataSimptom";
            this.durataSimptom.Size = new System.Drawing.Size(356, 22);
            this.durataSimptom.TabIndex = 118;
            // 
            // greutate
            // 
            this.greutate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greutate.Location = new System.Drawing.Point(904, 362);
            this.greutate.Name = "greutate";
            this.greutate.Size = new System.Drawing.Size(127, 22);
            this.greutate.TabIndex = 121;
            // 
            // Angajare
            // 
            this.Angajare.AutoSize = true;
            this.Angajare.BackColor = System.Drawing.Color.Transparent;
            this.Angajare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Angajare.Location = new System.Drawing.Point(189, 364);
            this.Angajare.Name = "Angajare";
            this.Angajare.Size = new System.Drawing.Size(100, 19);
            this.Angajare.TabIndex = 122;
            this.Angajare.Text = "Inregistrare";
            this.Angajare.UseVisualStyleBackColor = false;
            // 
            // ControlPeriodic
            // 
            this.ControlPeriodic.AutoSize = true;
            this.ControlPeriodic.BackColor = System.Drawing.Color.Transparent;
            this.ControlPeriodic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ControlPeriodic.Location = new System.Drawing.Point(314, 364);
            this.ControlPeriodic.Name = "ControlPeriodic";
            this.ControlPeriodic.Size = new System.Drawing.Size(192, 19);
            this.ControlPeriodic.TabIndex = 123;
            this.ControlPeriodic.Text = "Control Periodic/Afectiune";
            this.ControlPeriodic.UseVisualStyleBackColor = false;
            // 
            // ConsultatieCurenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1273, 647);
            this.Controls.Add(this.ControlPeriodic);
            this.Controls.Add(this.Angajare);
            this.Controls.Add(this.greutate);
            this.Controls.Add(this.durataSimptom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.inaltime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Domiciliu);
            this.Controls.Add(this.Cabinet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.ora);
            this.Controls.Add(this.numeMedic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alteSimptome);
            this.Controls.Add(this.tratament);
            this.Controls.Add(this.diagnosticPrincipal);
            this.Controls.Add(this.dataConsult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultatieCurenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private RoundButton cancel;
        private RoundButton ok;
        private System.Windows.Forms.RichTextBox alteSimptome;
        private System.Windows.Forms.RichTextBox tratament;
        private System.Windows.Forms.TextBox diagnosticPrincipal;
        private System.Windows.Forms.DateTimePicker dataConsult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numeMedic;
        private System.Windows.Forms.ComboBox ora;
        private System.Windows.Forms.ComboBox minute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton Cabinet;
        private System.Windows.Forms.RadioButton Domiciliu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inaltime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox durataSimptom;
        private System.Windows.Forms.TextBox greutate;
        private System.Windows.Forms.CheckBox Angajare;
        private System.Windows.Forms.CheckBox ControlPeriodic;
    }
}