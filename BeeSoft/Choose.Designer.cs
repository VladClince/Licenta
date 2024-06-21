using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MedicSoft
{
    public class RoundButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(1, 1, this.Width - 5, this.Height - 5));
                this.Region = new Region(path);
            }
            base.OnResize(e);
        }
    }

    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            this.Administrare1 = new System.Windows.Forms.Label();
            this.Rapoarte1 = new System.Windows.Forms.Label();
            this.Deconectare1 = new System.Windows.Forms.Label();
            this.CNPlabel = new System.Windows.Forms.Label();
            this.cnp = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.nrFisa = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nrPacienti = new System.Windows.Forms.Label();
            this.pacientNou1 = new System.Windows.Forms.Label();
            this.Cauta1 = new System.Windows.Forms.Label();
            this.adaugaAngajat1 = new System.Windows.Forms.Label();
            this.Facturi1 = new System.Windows.Forms.Label();
            this.adminPacienti1 = new System.Windows.Forms.Label();
            this.managementUser1 = new System.Windows.Forms.Label();
            this.statisticiMed1 = new System.Windows.Forms.Label();
            this.pacientiEvidenta1 = new System.Windows.Forms.Label();
            this.alerteLunare1 = new System.Windows.Forms.Label();
            this.registruProg1 = new System.Windows.Forms.Label();
            this.statisticiBuget1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Anterior = new System.Windows.Forms.Label();
            this.Urmator = new System.Windows.Forms.Label();
            this.registruConsult1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeAngajat = new System.Windows.Forms.Label();
            this.schimbareParola1 = new System.Windows.Forms.Label();
            this.ComenziFavorite = new System.Windows.Forms.Label();
            this.adaugaPacient1 = new System.Windows.Forms.Label();
            this.dateConsult = new System.Windows.Forms.DateTimePicker();
            this.Pacient1 = new System.Windows.Forms.Label();
            this.editInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundButton2 = new MedicSoft.RoundButton();
            this.editInfo1 = new MedicSoft.RoundButton();
            this.adaugaPacient = new MedicSoft.RoundButton();
            this.schimbareParola = new MedicSoft.RoundButton();
            this.managementUser = new MedicSoft.RoundButton();
            this.adminPacienti = new MedicSoft.RoundButton();
            this.Facturi = new MedicSoft.RoundButton();
            this.adaugaAngajat = new MedicSoft.RoundButton();
            this.pacientiEvidenta = new MedicSoft.RoundButton();
            this.registruConsult = new MedicSoft.RoundButton();
            this.statisticiMed = new MedicSoft.RoundButton();
            this.statisticiBuget = new MedicSoft.RoundButton();
            this.registruProg = new MedicSoft.RoundButton();
            this.alerteLunare = new MedicSoft.RoundButton();
            this.Cauta = new MedicSoft.RoundButton();
            this.pacientNou = new MedicSoft.RoundButton();
            this.SuspendLayout();
            // 
            // Administrare1
            // 
            this.Administrare1.AutoSize = true;
            this.Administrare1.BackColor = System.Drawing.Color.Transparent;
            this.Administrare1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrare1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Administrare1.Location = new System.Drawing.Point(951, 54);
            this.Administrare1.Name = "Administrare1";
            this.Administrare1.Size = new System.Drawing.Size(80, 33);
            this.Administrare1.TabIndex = 7;
            this.Administrare1.Text = "Admin";
            this.Administrare1.Click += new System.EventHandler(this.Administrare1_Click);
            // 
            // Rapoarte1
            // 
            this.Rapoarte1.AutoSize = true;
            this.Rapoarte1.BackColor = System.Drawing.Color.Transparent;
            this.Rapoarte1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rapoarte1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rapoarte1.Location = new System.Drawing.Point(644, 54);
            this.Rapoarte1.Name = "Rapoarte1";
            this.Rapoarte1.Size = new System.Drawing.Size(213, 33);
            this.Rapoarte1.TabIndex = 8;
            this.Rapoarte1.Text = "Rapoarte / Evidente";
            this.Rapoarte1.Click += new System.EventHandler(this.Rapoarte1_Click);
            // 
            // Deconectare1
            // 
            this.Deconectare1.AutoSize = true;
            this.Deconectare1.BackColor = System.Drawing.Color.Transparent;
            this.Deconectare1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconectare1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Deconectare1.Location = new System.Drawing.Point(1203, 9);
            this.Deconectare1.Name = "Deconectare1";
            this.Deconectare1.Size = new System.Drawing.Size(92, 23);
            this.Deconectare1.TabIndex = 9;
            this.Deconectare1.Text = "Deconectare";
            this.Deconectare1.Click += new System.EventHandler(this.Deconectare1_Click);
            // 
            // CNPlabel
            // 
            this.CNPlabel.AutoSize = true;
            this.CNPlabel.BackColor = System.Drawing.Color.Transparent;
            this.CNPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPlabel.Location = new System.Drawing.Point(84, 113);
            this.CNPlabel.Name = "CNPlabel";
            this.CNPlabel.Size = new System.Drawing.Size(43, 16);
            this.CNPlabel.TabIndex = 13;
            this.CNPlabel.Text = "CNP:";
            // 
            // cnp
            // 
            this.cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnp.Location = new System.Drawing.Point(140, 110);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(151, 22);
            this.cnp.TabIndex = 14;
            this.cnp.TextChanged += new System.EventHandler(this.cnp_TextChanged);
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.Location = new System.Drawing.Point(445, 138);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(151, 22);
            this.telefon.TabIndex = 16;
            this.telefon.TextChanged += new System.EventHandler(this.telefon_TextChanged);
            // 
            // nrFisa
            // 
            this.nrFisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrFisa.Location = new System.Drawing.Point(445, 110);
            this.nrFisa.Name = "nrFisa";
            this.nrFisa.Size = new System.Drawing.Size(151, 22);
            this.nrFisa.TabIndex = 17;
            this.nrFisa.TextChanged += new System.EventHandler(this.nrFisa_TextChanged);
            // 
            // prenume
            // 
            this.prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenume.Location = new System.Drawing.Point(140, 166);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(151, 22);
            this.prenume.TabIndex = 18;
            this.prenume.TextChanged += new System.EventHandler(this.prenume_TextChanged);
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.Location = new System.Drawing.Point(140, 138);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(151, 22);
            this.nume.TabIndex = 19;
            this.nume.TextChanged += new System.EventHandler(this.nume_TextChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton1.Location = new System.Drawing.Point(87, 211);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(155, 20);
            this.RadioButton1.TabIndex = 22;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Deschide fisa curenta";
            this.RadioButton1.UseVisualStyleBackColor = false;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton3.Location = new System.Drawing.Point(419, 211);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(160, 20);
            this.RadioButton3.TabIndex = 24;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Control periodic albine";
            this.RadioButton3.UseVisualStyleBackColor = false;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton2.Location = new System.Drawing.Point(256, 211);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(180, 20);
            this.RadioButton2.TabIndex = 25;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Istoric controale periodice";
            this.RadioButton2.UseVisualStyleBackColor = false;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prenume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Data nasterii:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Numar apicultor:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(71, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Au fost gasiti ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(160, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "apicultori.";
            // 
            // nrPacienti
            // 
            this.nrPacienti.AutoSize = true;
            this.nrPacienti.BackColor = System.Drawing.Color.Transparent;
            this.nrPacienti.Location = new System.Drawing.Point(141, 278);
            this.nrPacienti.Name = "nrPacienti";
            this.nrPacienti.Size = new System.Drawing.Size(13, 13);
            this.nrPacienti.TabIndex = 33;
            this.nrPacienti.Text = "0";
            // 
            // pacientNou1
            // 
            this.pacientNou1.AutoSize = true;
            this.pacientNou1.BackColor = System.Drawing.Color.Transparent;
            this.pacientNou1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientNou1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pacientNou1.Location = new System.Drawing.Point(414, 248);
            this.pacientNou1.Name = "pacientNou1";
            this.pacientNou1.Size = new System.Drawing.Size(124, 28);
            this.pacientNou1.TabIndex = 36;
            this.pacientNou1.Text = "Apicultor Nou";
            this.pacientNou1.Click += new System.EventHandler(this.pacientNou1_Click);
            // 
            // Cauta1
            // 
            this.Cauta1.AutoSize = true;
            this.Cauta1.BackColor = System.Drawing.Color.Transparent;
            this.Cauta1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cauta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cauta1.Location = new System.Drawing.Point(159, 248);
            this.Cauta1.Name = "Cauta1";
            this.Cauta1.Size = new System.Drawing.Size(58, 28);
            this.Cauta1.TabIndex = 37;
            this.Cauta1.Text = "Cauta";
            this.Cauta1.Click += new System.EventHandler(this.Cauta1_Click);
            // 
            // adaugaAngajat1
            // 
            this.adaugaAngajat1.AutoSize = true;
            this.adaugaAngajat1.BackColor = System.Drawing.Color.Transparent;
            this.adaugaAngajat1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaAngajat1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adaugaAngajat1.Location = new System.Drawing.Point(1003, 472);
            this.adaugaAngajat1.Name = "adaugaAngajat1";
            this.adaugaAngajat1.Size = new System.Drawing.Size(218, 28);
            this.adaugaAngajat1.TabIndex = 72;
            this.adaugaAngajat1.Text = "Adauga personal asociatie";
            this.adaugaAngajat1.Click += new System.EventHandler(this.adaugaAngajat1_Click);
            // 
            // Facturi1
            // 
            this.Facturi1.AutoSize = true;
            this.Facturi1.BackColor = System.Drawing.Color.Transparent;
            this.Facturi1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facturi1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Facturi1.Location = new System.Drawing.Point(1002, 305);
            this.Facturi1.Name = "Facturi1";
            this.Facturi1.Size = new System.Drawing.Size(132, 28);
            this.Facturi1.TabIndex = 73;
            this.Facturi1.Text = "Facturi/Bonuri";
            this.Facturi1.Click += new System.EventHandler(this.Facturi1_Click);
            // 
            // adminPacienti1
            // 
            this.adminPacienti1.AutoSize = true;
            this.adminPacienti1.BackColor = System.Drawing.Color.Transparent;
            this.adminPacienti1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPacienti1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminPacienti1.Location = new System.Drawing.Point(699, 305);
            this.adminPacienti1.Name = "adminPacienti1";
            this.adminPacienti1.Size = new System.Drawing.Size(201, 28);
            this.adminPacienti1.TabIndex = 76;
            this.adminPacienti1.Text = "Administrare apicultori";
            this.adminPacienti1.Click += new System.EventHandler(this.adminPacienti1_Click);
            // 
            // managementUser1
            // 
            this.managementUser1.AutoSize = true;
            this.managementUser1.BackColor = System.Drawing.Color.Transparent;
            this.managementUser1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementUser1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.managementUser1.Location = new System.Drawing.Point(1004, 415);
            this.managementUser1.Name = "managementUser1";
            this.managementUser1.Size = new System.Drawing.Size(212, 28);
            this.managementUser1.TabIndex = 77;
            this.managementUser1.Text = "Administreaza utilizatori";
            this.managementUser1.Click += new System.EventHandler(this.managementUser1_Click);
            // 
            // statisticiMed1
            // 
            this.statisticiMed1.AutoSize = true;
            this.statisticiMed1.BackColor = System.Drawing.Color.Transparent;
            this.statisticiMed1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticiMed1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statisticiMed1.Location = new System.Drawing.Point(699, 202);
            this.statisticiMed1.Name = "statisticiMed1";
            this.statisticiMed1.Size = new System.Drawing.Size(209, 28);
            this.statisticiMed1.TabIndex = 78;
            this.statisticiMed1.Text = "Verificare albine/stupina";
            this.statisticiMed1.Click += new System.EventHandler(this.statisticiMed1_Click);
            // 
            // pacientiEvidenta1
            // 
            this.pacientiEvidenta1.AutoSize = true;
            this.pacientiEvidenta1.BackColor = System.Drawing.Color.Transparent;
            this.pacientiEvidenta1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientiEvidenta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pacientiEvidenta1.Location = new System.Drawing.Point(699, 98);
            this.pacientiEvidenta1.Name = "pacientiEvidenta1";
            this.pacientiEvidenta1.Size = new System.Drawing.Size(186, 28);
            this.pacientiEvidenta1.TabIndex = 81;
            this.pacientiEvidenta1.Text = "Apicultori inregistrati";
            this.pacientiEvidenta1.Click += new System.EventHandler(this.pacientiEvidenta1_Click);
            // 
            // alerteLunare1
            // 
            this.alerteLunare1.AutoSize = true;
            this.alerteLunare1.BackColor = System.Drawing.Color.Transparent;
            this.alerteLunare1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alerteLunare1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alerteLunare1.Location = new System.Drawing.Point(1002, 359);
            this.alerteLunare1.Name = "alerteLunare1";
            this.alerteLunare1.Size = new System.Drawing.Size(60, 28);
            this.alerteLunare1.TabIndex = 84;
            this.alerteLunare1.Text = "Alerte";
            this.alerteLunare1.Click += new System.EventHandler(this.alerteLunare1_Click);
            // 
            // registruProg1
            // 
            this.registruProg1.AutoSize = true;
            this.registruProg1.BackColor = System.Drawing.Color.Transparent;
            this.registruProg1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registruProg1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registruProg1.Location = new System.Drawing.Point(699, 252);
            this.registruProg1.Name = "registruProg1";
            this.registruProg1.Size = new System.Drawing.Size(254, 28);
            this.registruProg1.TabIndex = 85;
            this.registruProg1.Text = "Registru verif. stupine viitoare";
            this.registruProg1.Click += new System.EventHandler(this.registruProg1_Click);
            // 
            // statisticiBuget1
            // 
            this.statisticiBuget1.AutoSize = true;
            this.statisticiBuget1.BackColor = System.Drawing.Color.Transparent;
            this.statisticiBuget1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticiBuget1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statisticiBuget1.Location = new System.Drawing.Point(1003, 252);
            this.statisticiBuget1.Name = "statisticiBuget1";
            this.statisticiBuget1.Size = new System.Drawing.Size(168, 28);
            this.statisticiBuget1.TabIndex = 86;
            this.statisticiBuget1.Text = "Statistici financiare";
            this.statisticiBuget1.Click += new System.EventHandler(this.statisticiBuget1_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(77, 294);
            this.listBox.MultiColumn = true;
            this.listBox.Name = "listBox";
            this.listBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox.Size = new System.Drawing.Size(530, 224);
            this.listBox.TabIndex = 20;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Anterior
            // 
            this.Anterior.AutoSize = true;
            this.Anterior.BackColor = System.Drawing.Color.Transparent;
            this.Anterior.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Anterior.Location = new System.Drawing.Point(70, 538);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(67, 23);
            this.Anterior.TabIndex = 88;
            this.Anterior.Text = "Anterior";
            this.Anterior.Click += new System.EventHandler(this.label33_Click);
            // 
            // Urmator
            // 
            this.Urmator.AutoSize = true;
            this.Urmator.BackColor = System.Drawing.Color.Transparent;
            this.Urmator.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urmator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Urmator.Location = new System.Drawing.Point(143, 538);
            this.Urmator.Name = "Urmator";
            this.Urmator.Size = new System.Drawing.Size(68, 23);
            this.Urmator.TabIndex = 89;
            this.Urmator.Text = "Urmator";
            this.Urmator.Click += new System.EventHandler(this.Urmator_Click);
            // 
            // registruConsult1
            // 
            this.registruConsult1.AutoSize = true;
            this.registruConsult1.BackColor = System.Drawing.Color.Transparent;
            this.registruConsult1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registruConsult1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registruConsult1.Location = new System.Drawing.Point(699, 149);
            this.registruConsult1.Name = "registruConsult1";
            this.registruConsult1.Size = new System.Drawing.Size(250, 28);
            this.registruConsult1.TabIndex = 90;
            this.registruConsult1.Text = "Registru verif. stupine trecute";
            this.registruConsult1.Click += new System.EventHandler(this.registruConsult1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Bine ai venit ";
            // 
            // numeAngajat
            // 
            this.numeAngajat.AutoSize = true;
            this.numeAngajat.BackColor = System.Drawing.Color.Transparent;
            this.numeAngajat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeAngajat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numeAngajat.Location = new System.Drawing.Point(120, 29);
            this.numeAngajat.Name = "numeAngajat";
            this.numeAngajat.Size = new System.Drawing.Size(0, 16);
            this.numeAngajat.TabIndex = 92;
            // 
            // schimbareParola1
            // 
            this.schimbareParola1.AutoSize = true;
            this.schimbareParola1.BackColor = System.Drawing.Color.Transparent;
            this.schimbareParola1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schimbareParola1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.schimbareParola1.Location = new System.Drawing.Point(1003, 98);
            this.schimbareParola1.Name = "schimbareParola1";
            this.schimbareParola1.Size = new System.Drawing.Size(135, 28);
            this.schimbareParola1.TabIndex = 93;
            this.schimbareParola1.Text = "Schimba parola";
            this.schimbareParola1.Click += new System.EventHandler(this.schimbareParola1_Click);
            // 
            // ComenziFavorite
            // 
            this.ComenziFavorite.AutoSize = true;
            this.ComenziFavorite.BackColor = System.Drawing.Color.Transparent;
            this.ComenziFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComenziFavorite.Location = new System.Drawing.Point(548, 231);
            this.ComenziFavorite.Name = "ComenziFavorite";
            this.ComenziFavorite.Size = new System.Drawing.Size(48, 13);
            this.ComenziFavorite.TabIndex = 95;
            this.ComenziFavorite.Text = "Editeaza";
            this.ComenziFavorite.Click += new System.EventHandler(this.ComenziFavorite_Click);
            // 
            // adaugaPacient1
            // 
            this.adaugaPacient1.AutoSize = true;
            this.adaugaPacient1.BackColor = System.Drawing.Color.Transparent;
            this.adaugaPacient1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaPacient1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adaugaPacient1.Location = new System.Drawing.Point(699, 359);
            this.adaugaPacient1.Name = "adaugaPacient1";
            this.adaugaPacient1.Size = new System.Drawing.Size(149, 28);
            this.adaugaPacient1.TabIndex = 97;
            this.adaugaPacient1.Text = "Adauga apicultor";
            this.adaugaPacient1.Click += new System.EventHandler(this.adaugaPacient1_Click);
            // 
            // dateConsult
            // 
            this.dateConsult.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateConsult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateConsult.Location = new System.Drawing.Point(445, 166);
            this.dateConsult.MinDate = new System.DateTime(1900, 1, 30, 0, 0, 0, 0);
            this.dateConsult.Name = "dateConsult";
            this.dateConsult.Size = new System.Drawing.Size(151, 22);
            this.dateConsult.TabIndex = 99;
            this.dateConsult.ValueChanged += new System.EventHandler(this.dateConsult_ValueChanged);
            // 
            // Pacient1
            // 
            this.Pacient1.AutoSize = true;
            this.Pacient1.BackColor = System.Drawing.Color.Transparent;
            this.Pacient1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pacient1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pacient1.Location = new System.Drawing.Point(430, 54);
            this.Pacient1.Name = "Pacient1";
            this.Pacient1.Size = new System.Drawing.Size(190, 33);
            this.Pacient1.TabIndex = 100;
            this.Pacient1.Text = "Gestiune apicultor";
            // 
            // editInfo
            // 
            this.editInfo.AutoSize = true;
            this.editInfo.BackColor = System.Drawing.Color.Transparent;
            this.editInfo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editInfo.Location = new System.Drawing.Point(1002, 149);
            this.editInfo.Name = "editInfo";
            this.editInfo.Size = new System.Drawing.Size(198, 28);
            this.editInfo.TabIndex = 101;
            this.editInfo.Text = "Editeaza info personale";
            this.editInfo.Click += new System.EventHandler(this.editInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1003, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 103;
            this.label3.Text = "Suport online";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.roundButton2.BackgroundImage = global::MedicSoft.Properties.Resources.cursor;
            this.roundButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton2.Location = new System.Drawing.Point(957, 197);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(39, 41);
            this.roundButton2.TabIndex = 104;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // editInfo1
            // 
            this.editInfo1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.editInfo1.BackgroundImage = global::MedicSoft.Properties.Resources.contract;
            this.editInfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editInfo1.Location = new System.Drawing.Point(957, 146);
            this.editInfo1.Name = "editInfo1";
            this.editInfo1.Size = new System.Drawing.Size(39, 41);
            this.editInfo1.TabIndex = 102;
            this.editInfo1.UseVisualStyleBackColor = false;
            this.editInfo1.Click += new System.EventHandler(this.editInfo1_Click);
            // 
            // adaugaPacient
            // 
            this.adaugaPacient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adaugaPacient.BackgroundImage = global::MedicSoft.Properties.Resources.user21;
            this.adaugaPacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adaugaPacient.Location = new System.Drawing.Point(650, 354);
            this.adaugaPacient.Name = "adaugaPacient";
            this.adaugaPacient.Size = new System.Drawing.Size(39, 41);
            this.adaugaPacient.TabIndex = 96;
            this.adaugaPacient.UseVisualStyleBackColor = false;
            this.adaugaPacient.Click += new System.EventHandler(this.adaugaPacient_Click);
            // 
            // schimbareParola
            // 
            this.schimbareParola.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.schimbareParola.BackgroundImage = global::MedicSoft.Properties.Resources._lock;
            this.schimbareParola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.schimbareParola.Location = new System.Drawing.Point(957, 93);
            this.schimbareParola.Name = "schimbareParola";
            this.schimbareParola.Size = new System.Drawing.Size(39, 41);
            this.schimbareParola.TabIndex = 94;
            this.schimbareParola.UseVisualStyleBackColor = false;
            this.schimbareParola.Click += new System.EventHandler(this.schimbareParola_Click);
            // 
            // managementUser
            // 
            this.managementUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.managementUser.BackgroundImage = global::MedicSoft.Properties.Resources.user3;
            this.managementUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.managementUser.Location = new System.Drawing.Point(958, 410);
            this.managementUser.Name = "managementUser";
            this.managementUser.Size = new System.Drawing.Size(39, 41);
            this.managementUser.TabIndex = 68;
            this.managementUser.UseVisualStyleBackColor = false;
            this.managementUser.Click += new System.EventHandler(this.managementUser_Click);
            // 
            // adminPacienti
            // 
            this.adminPacienti.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adminPacienti.BackgroundImage = global::MedicSoft.Properties.Resources.team;
            this.adminPacienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminPacienti.Location = new System.Drawing.Point(650, 301);
            this.adminPacienti.Name = "adminPacienti";
            this.adminPacienti.Size = new System.Drawing.Size(39, 41);
            this.adminPacienti.TabIndex = 67;
            this.adminPacienti.UseVisualStyleBackColor = false;
            this.adminPacienti.Click += new System.EventHandler(this.adminPacienti_Click);
            // 
            // Facturi
            // 
            this.Facturi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Facturi.BackgroundImage = global::MedicSoft.Properties.Resources.bill;
            this.Facturi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Facturi.Location = new System.Drawing.Point(958, 301);
            this.Facturi.Name = "Facturi";
            this.Facturi.Size = new System.Drawing.Size(39, 41);
            this.Facturi.TabIndex = 64;
            this.Facturi.UseVisualStyleBackColor = false;
            this.Facturi.Click += new System.EventHandler(this.Facturi_Click);
            // 
            // adaugaAngajat
            // 
            this.adaugaAngajat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adaugaAngajat.BackgroundImage = global::MedicSoft.Properties.Resources.user21;
            this.adaugaAngajat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adaugaAngajat.Location = new System.Drawing.Point(958, 467);
            this.adaugaAngajat.Name = "adaugaAngajat";
            this.adaugaAngajat.Size = new System.Drawing.Size(39, 41);
            this.adaugaAngajat.TabIndex = 63;
            this.adaugaAngajat.UseVisualStyleBackColor = false;
            this.adaugaAngajat.Click += new System.EventHandler(this.adaugaAngajat_Click);
            // 
            // pacientiEvidenta
            // 
            this.pacientiEvidenta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pacientiEvidenta.BackgroundImage = global::MedicSoft.Properties.Resources.employees__2_;
            this.pacientiEvidenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pacientiEvidenta.Location = new System.Drawing.Point(650, 93);
            this.pacientiEvidenta.Name = "pacientiEvidenta";
            this.pacientiEvidenta.Size = new System.Drawing.Size(39, 41);
            this.pacientiEvidenta.TabIndex = 60;
            this.pacientiEvidenta.UseVisualStyleBackColor = false;
            this.pacientiEvidenta.Click += new System.EventHandler(this.pacientiEvidenta_Click);
            // 
            // registruConsult
            // 
            this.registruConsult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.registruConsult.BackgroundImage = global::MedicSoft.Properties.Resources.istockphoto_1143675835_612x6123;
            this.registruConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registruConsult.Location = new System.Drawing.Point(650, 146);
            this.registruConsult.Name = "registruConsult";
            this.registruConsult.Size = new System.Drawing.Size(39, 41);
            this.registruConsult.TabIndex = 59;
            this.registruConsult.UseVisualStyleBackColor = false;
            this.registruConsult.Click += new System.EventHandler(this.registruConsult_Click);
            // 
            // statisticiMed
            // 
            this.statisticiMed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.statisticiMed.BackgroundImage = global::MedicSoft.Properties.Resources.calendar;
            this.statisticiMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statisticiMed.Location = new System.Drawing.Point(650, 197);
            this.statisticiMed.Name = "statisticiMed";
            this.statisticiMed.Size = new System.Drawing.Size(39, 41);
            this.statisticiMed.TabIndex = 57;
            this.statisticiMed.UseVisualStyleBackColor = false;
            this.statisticiMed.Click += new System.EventHandler(this.statisticiMed_Click);
            // 
            // statisticiBuget
            // 
            this.statisticiBuget.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.statisticiBuget.BackgroundImage = global::MedicSoft.Properties.Resources.coins;
            this.statisticiBuget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statisticiBuget.Location = new System.Drawing.Point(958, 249);
            this.statisticiBuget.Name = "statisticiBuget";
            this.statisticiBuget.Size = new System.Drawing.Size(39, 41);
            this.statisticiBuget.TabIndex = 56;
            this.statisticiBuget.UseVisualStyleBackColor = false;
            this.statisticiBuget.Click += new System.EventHandler(this.statisticiBuget_Click);
            // 
            // registruProg
            // 
            this.registruProg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.registruProg.BackgroundImage = global::MedicSoft.Properties.Resources.calendar;
            this.registruProg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registruProg.Location = new System.Drawing.Point(650, 249);
            this.registruProg.Name = "registruProg";
            this.registruProg.Size = new System.Drawing.Size(39, 41);
            this.registruProg.TabIndex = 55;
            this.registruProg.UseVisualStyleBackColor = false;
            this.registruProg.Click += new System.EventHandler(this.registruProg_Click);
            // 
            // alerteLunare
            // 
            this.alerteLunare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.alerteLunare.BackgroundImage = global::MedicSoft.Properties.Resources.danger;
            this.alerteLunare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alerteLunare.Location = new System.Drawing.Point(957, 354);
            this.alerteLunare.Name = "alerteLunare";
            this.alerteLunare.Size = new System.Drawing.Size(39, 41);
            this.alerteLunare.TabIndex = 54;
            this.alerteLunare.UseVisualStyleBackColor = false;
            this.alerteLunare.Click += new System.EventHandler(this.alerteLunare_Click);
            // 
            // Cauta
            // 
            this.Cauta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Cauta.BackgroundImage = global::MedicSoft.Properties.Resources.magnifying_glass_icon;
            this.Cauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cauta.Location = new System.Drawing.Point(236, 238);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(55, 50);
            this.Cauta.TabIndex = 35;
            this.Cauta.UseVisualStyleBackColor = false;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // pacientNou
            // 
            this.pacientNou.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pacientNou.BackgroundImage = global::MedicSoft.Properties.Resources.newsletter;
            this.pacientNou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pacientNou.Location = new System.Drawing.Point(356, 237);
            this.pacientNou.Name = "pacientNou";
            this.pacientNou.Size = new System.Drawing.Size(52, 53);
            this.pacientNou.TabIndex = 34;
            this.pacientNou.UseVisualStyleBackColor = false;
            this.pacientNou.Click += new System.EventHandler(this.pacientNou_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._3e1;
            this.ClientSize = new System.Drawing.Size(1297, 570);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editInfo1);
            this.Controls.Add(this.editInfo);
            this.Controls.Add(this.Pacient1);
            this.Controls.Add(this.dateConsult);
            this.Controls.Add(this.adaugaPacient1);
            this.Controls.Add(this.adaugaPacient);
            this.Controls.Add(this.ComenziFavorite);
            this.Controls.Add(this.schimbareParola);
            this.Controls.Add(this.schimbareParola1);
            this.Controls.Add(this.numeAngajat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registruConsult1);
            this.Controls.Add(this.Urmator);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.statisticiBuget1);
            this.Controls.Add(this.registruProg1);
            this.Controls.Add(this.alerteLunare1);
            this.Controls.Add(this.pacientiEvidenta1);
            this.Controls.Add(this.statisticiMed1);
            this.Controls.Add(this.managementUser1);
            this.Controls.Add(this.adminPacienti1);
            this.Controls.Add(this.Facturi1);
            this.Controls.Add(this.adaugaAngajat1);
            this.Controls.Add(this.managementUser);
            this.Controls.Add(this.adminPacienti);
            this.Controls.Add(this.Facturi);
            this.Controls.Add(this.adaugaAngajat);
            this.Controls.Add(this.pacientiEvidenta);
            this.Controls.Add(this.registruConsult);
            this.Controls.Add(this.statisticiMed);
            this.Controls.Add(this.statisticiBuget);
            this.Controls.Add(this.registruProg);
            this.Controls.Add(this.alerteLunare);
            this.Controls.Add(this.Cauta1);
            this.Controls.Add(this.pacientNou1);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.pacientNou);
            this.Controls.Add(this.nrPacienti);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nrFisa);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.CNPlabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Deconectare1);
            this.Controls.Add(this.Rapoarte1);
            this.Controls.Add(this.Administrare1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.Load += new System.EventHandler(this.Choose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Administrare1;
        private Label Rapoarte1;
        private Label Deconectare1;
        private Label CNPlabel;
        private TextBox cnp;
        private TextBox telefon;
        private TextBox nrFisa;
        private TextBox prenume;
        private TextBox nume;
        private RadioButton RadioButton1;
        private RadioButton RadioButton3;
        private RadioButton RadioButton2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label nrPacienti;
        private RoundButton pacientNou;
        private RoundButton Cauta;
        private Label pacientNou1;
        private Label Cauta1;
        private RoundButton alerteLunare;
        private RoundButton registruProg;
        private RoundButton statisticiBuget;
        private RoundButton statisticiMed;
        private RoundButton registruConsult;
        private RoundButton pacientiEvidenta;
        private RoundButton adaugaAngajat;
        private RoundButton Facturi;
        private RoundButton adminPacienti;
        private RoundButton managementUser;
        private Label adaugaAngajat1;
        private Label Facturi1;
        private Label adminPacienti1;
        private Label managementUser1;
        private Label statisticiMed1;
        private Label pacientiEvidenta1;
        private Label alerteLunare1;
        private Label registruProg1;
        private Label statisticiBuget1;
        private ListBox listBox;
        private Label Anterior;
        private Label Urmator;
        private Label registruConsult1;
        private Label label1;
        private Label numeAngajat;
        private Label schimbareParola1;
        private RoundButton schimbareParola;
        private Label ComenziFavorite;
        private RoundButton adaugaPacient;
        private Label adaugaPacient1;
        private DateTimePicker dateConsult;
        private Label Pacient1;
        private RoundButton editInfo1;
        private Label editInfo;
        private RoundButton roundButton2;
        private Label label3;
    }
}