namespace MedicSoft
{
    partial class EvidenteSiRapoarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidenteSiRapoarte));
            this.listBox = new System.Windows.Forms.ListBox();
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.alege1 = new System.Windows.Forms.Label();
            this.alegeComboBox = new System.Windows.Forms.ComboBox();
            this.alege = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.chooseDataBegin = new System.Windows.Forms.DateTimePicker();
            this.chooseDataFinal = new System.Windows.Forms.DateTimePicker();
            this.data1 = new System.Windows.Forms.Label();
            this.data2 = new System.Windows.Forms.Label();
            this.sorteaza = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(46, 367);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1143, 24);
            this.listBox.TabIndex = 67;
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
            this.cancel1.TabIndex = 82;
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
            this.ok1.TabIndex = 81;
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
            this.cancel.TabIndex = 80;
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
            this.ok.TabIndex = 79;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // alege1
            // 
            this.alege1.AutoSize = true;
            this.alege1.BackColor = System.Drawing.Color.Transparent;
            this.alege1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alege1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alege1.Location = new System.Drawing.Point(280, 163);
            this.alege1.Name = "alege1";
            this.alege1.Size = new System.Drawing.Size(189, 28);
            this.alege1.TabIndex = 83;
            this.alege1.Text = "Alegeti raportul dorit:";
            // 
            // alegeComboBox
            // 
            this.alegeComboBox.FormattingEnabled = true;
            this.alegeComboBox.Items.AddRange(new object[] {
            "Numarul de persoane apte intr-o anumita perioada",
            "Numarul de persoane inapte intr-o anumita perioada",
            "Numarul de bilete de trimitere emise intr-o anumita perioada",
            "Numarul de controale medicale efectuate intr-o anumita perioada",
            "Numarul de diagnostice emise intr-o anumita perioada",
            "Numarul de programari efectuate intr-o anumita perioada"});
            this.alegeComboBox.Location = new System.Drawing.Point(567, 200);
            this.alegeComboBox.Name = "alegeComboBox";
            this.alegeComboBox.Size = new System.Drawing.Size(313, 21);
            this.alegeComboBox.TabIndex = 97;
            // 
            // alege
            // 
            this.alege.AutoSize = true;
            this.alege.BackColor = System.Drawing.Color.Transparent;
            this.alege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alege.Location = new System.Drawing.Point(460, 201);
            this.alege.Name = "alege";
            this.alege.Size = new System.Drawing.Size(53, 16);
            this.alege.TabIndex = 98;
            this.alege.Text = "Alege:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Crescator",
            "Descrescator"});
            this.sortComboBox.Location = new System.Drawing.Point(567, 329);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(313, 21);
            this.sortComboBox.TabIndex = 101;
            // 
            // chooseDataBegin
            // 
            this.chooseDataBegin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDataBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDataBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chooseDataBegin.Location = new System.Drawing.Point(567, 241);
            this.chooseDataBegin.MinDate = new System.DateTime(1900, 1, 30, 0, 0, 0, 0);
            this.chooseDataBegin.Name = "chooseDataBegin";
            this.chooseDataBegin.Size = new System.Drawing.Size(313, 22);
            this.chooseDataBegin.TabIndex = 102;
            // 
            // chooseDataFinal
            // 
            this.chooseDataFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chooseDataFinal.Location = new System.Drawing.Point(567, 284);
            this.chooseDataFinal.MinDate = new System.DateTime(1900, 1, 30, 0, 0, 0, 0);
            this.chooseDataFinal.Name = "chooseDataFinal";
            this.chooseDataFinal.Size = new System.Drawing.Size(313, 22);
            this.chooseDataFinal.TabIndex = 103;
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.BackColor = System.Drawing.Color.Transparent;
            this.data1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1.Location = new System.Drawing.Point(429, 246);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(84, 16);
            this.data1.TabIndex = 104;
            this.data1.Text = "De la data:";
            // 
            // data2
            // 
            this.data2.AutoSize = true;
            this.data2.BackColor = System.Drawing.Color.Transparent;
            this.data2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data2.Location = new System.Drawing.Point(413, 289);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(100, 16);
            this.data2.TabIndex = 105;
            this.data2.Text = "Pana la data:";
            // 
            // sorteaza
            // 
            this.sorteaza.AutoSize = true;
            this.sorteaza.BackColor = System.Drawing.Color.Transparent;
            this.sorteaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorteaza.Location = new System.Drawing.Point(439, 330);
            this.sorteaza.Name = "sorteaza";
            this.sorteaza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sorteaza.Size = new System.Drawing.Size(74, 16);
            this.sorteaza.TabIndex = 106;
            this.sorteaza.Text = "Sorteaza:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(46, 397);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1143, 204);
            this.listBox1.TabIndex = 107;
            // 
            // EvidenteSiRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sorteaza);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.chooseDataFinal);
            this.Controls.Add(this.chooseDataBegin);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.alege);
            this.Controls.Add(this.alegeComboBox);
            this.Controls.Add(this.alege1);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvidenteSiRapoarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private RoundButton cancel;
        private RoundButton ok;
        private System.Windows.Forms.Label alege1;
        private System.Windows.Forms.ComboBox alegeComboBox;
        private System.Windows.Forms.Label alege;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.DateTimePicker chooseDataBegin;
        private System.Windows.Forms.DateTimePicker chooseDataFinal;
        private System.Windows.Forms.Label data1;
        private System.Windows.Forms.Label data2;
        private System.Windows.Forms.Label sorteaza;
        private System.Windows.Forms.ListBox listBox1;
    }
}