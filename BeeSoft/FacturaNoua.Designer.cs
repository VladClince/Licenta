namespace MedicSoft
{
    partial class FacturaNoua
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
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.sumaFacturata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.detalii = new System.Windows.Forms.RichTextBox();
            this.tipDocument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sumaPlatita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cancel.TabIndex = 89;
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
            this.ok.TabIndex = 88;
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
            this.cancel1.TabIndex = 87;
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
            this.ok1.TabIndex = 86;
            this.ok1.Text = "Ok";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // sumaFacturata
            // 
            this.sumaFacturata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaFacturata.Location = new System.Drawing.Point(360, 283);
            this.sumaFacturata.Name = "sumaFacturata";
            this.sumaFacturata.Size = new System.Drawing.Size(356, 22);
            this.sumaFacturata.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(124, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 125;
            this.label5.Text = "Detalii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(124, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 124;
            this.label4.Text = "Tip document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(124, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 123;
            this.label2.Text = "Data";
            // 
            // data
            // 
            this.data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(360, 128);
            this.data.MinDate = new System.DateTime(2010, 2, 4, 0, 0, 0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(356, 22);
            this.data.TabIndex = 122;
            // 
            // detalii
            // 
            this.detalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalii.Location = new System.Drawing.Point(360, 208);
            this.detalii.Name = "detalii";
            this.detalii.Size = new System.Drawing.Size(356, 55);
            this.detalii.TabIndex = 121;
            this.detalii.Text = "";
            // 
            // tipDocument
            // 
            this.tipDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipDocument.Location = new System.Drawing.Point(360, 168);
            this.tipDocument.Name = "tipDocument";
            this.tipDocument.Size = new System.Drawing.Size(356, 22);
            this.tipDocument.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(124, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 28);
            this.label3.TabIndex = 119;
            this.label3.Text = "Suma facturata";
            // 
            // sumaPlatita
            // 
            this.sumaPlatita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaPlatita.Location = new System.Drawing.Point(360, 323);
            this.sumaPlatita.Name = "sumaPlatita";
            this.sumaPlatita.Size = new System.Drawing.Size(356, 22);
            this.sumaPlatita.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(124, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 128;
            this.label1.Text = "Suma platita";
            // 
            // FacturaNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources.desktop_wallpaper_cute_honey_yellow_bumble_bee;
            this.ClientSize = new System.Drawing.Size(841, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumaPlatita);
            this.Controls.Add(this.sumaFacturata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.detalii);
            this.Controls.Add(this.tipDocument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaNoua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaNoua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton cancel;
        private RoundButton ok;
        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private System.Windows.Forms.TextBox sumaFacturata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.RichTextBox detalii;
        private System.Windows.Forms.TextBox tipDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumaPlatita;
        private System.Windows.Forms.Label label1;
    }
}