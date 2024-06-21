namespace MedicSoft
{
    partial class ProgramariAsteptare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramariAsteptare));
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.InapoiLabel = new System.Windows.Forms.Label();
            this.Deconectare = new MedicSoft.RoundButton();
            this.Accepta1 = new System.Windows.Forms.Label();
            this.Accepta = new MedicSoft.RoundButton();
            this.Refuza1 = new System.Windows.Forms.Label();
            this.Refuza = new MedicSoft.RoundButton();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(435, 163);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(757, 444);
            this.listBox.TabIndex = 67;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Thistle;
            this.listBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(49, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 444);
            this.listBox1.TabIndex = 68;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // InapoiLabel
            // 
            this.InapoiLabel.AutoSize = true;
            this.InapoiLabel.BackColor = System.Drawing.Color.Transparent;
            this.InapoiLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InapoiLabel.Location = new System.Drawing.Point(1144, 102);
            this.InapoiLabel.Name = "InapoiLabel";
            this.InapoiLabel.Size = new System.Drawing.Size(61, 28);
            this.InapoiLabel.TabIndex = 78;
            this.InapoiLabel.Text = "Inapoi";
            this.InapoiLabel.Click += new System.EventHandler(this.InapoiLabel_Click);
            // 
            // Deconectare
            // 
            this.Deconectare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Deconectare.BackgroundImage = global::MedicSoft.Properties.Resources.logout;
            this.Deconectare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Deconectare.Location = new System.Drawing.Point(1137, 30);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(79, 72);
            this.Deconectare.TabIndex = 77;
            this.Deconectare.UseVisualStyleBackColor = false;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // Accepta1
            // 
            this.Accepta1.AutoSize = true;
            this.Accepta1.BackColor = System.Drawing.Color.Transparent;
            this.Accepta1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accepta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Accepta1.Location = new System.Drawing.Point(75, 102);
            this.Accepta1.Name = "Accepta1";
            this.Accepta1.Size = new System.Drawing.Size(74, 28);
            this.Accepta1.TabIndex = 82;
            this.Accepta1.Text = "Accepta";
            this.Accepta1.Click += new System.EventHandler(this.Accepta1_Click);
            // 
            // Accepta
            // 
            this.Accepta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Accepta.BackgroundImage = global::MedicSoft.Properties.Resources.ok_mark;
            this.Accepta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Accepta.Location = new System.Drawing.Point(65, 23);
            this.Accepta.Name = "Accepta";
            this.Accepta.Size = new System.Drawing.Size(90, 86);
            this.Accepta.TabIndex = 81;
            this.Accepta.UseVisualStyleBackColor = false;
            this.Accepta.Click += new System.EventHandler(this.Accepta_Click);
            // 
            // Refuza1
            // 
            this.Refuza1.AutoSize = true;
            this.Refuza1.BackColor = System.Drawing.Color.Transparent;
            this.Refuza1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refuza1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Refuza1.Location = new System.Drawing.Point(237, 102);
            this.Refuza1.Name = "Refuza1";
            this.Refuza1.Size = new System.Drawing.Size(65, 28);
            this.Refuza1.TabIndex = 80;
            this.Refuza1.Text = "Refuza";
            this.Refuza1.Click += new System.EventHandler(this.Refuza1_Click);
            // 
            // Refuza
            // 
            this.Refuza.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Refuza.BackgroundImage = global::MedicSoft.Properties.Resources.cross;
            this.Refuza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Refuza.Location = new System.Drawing.Point(224, 23);
            this.Refuza.Name = "Refuza";
            this.Refuza.Size = new System.Drawing.Size(90, 86);
            this.Refuza.TabIndex = 79;
            this.Refuza.UseVisualStyleBackColor = false;
            this.Refuza.Click += new System.EventHandler(this.Refuza_Click);
            // 
            // ProgramariAsteptare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.Accepta1);
            this.Controls.Add(this.Accepta);
            this.Controls.Add(this.Refuza1);
            this.Controls.Add(this.Refuza);
            this.Controls.Add(this.InapoiLabel);
            this.Controls.Add(this.Deconectare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgramariAsteptare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label InapoiLabel;
        private RoundButton Deconectare;
        private System.Windows.Forms.Label Accepta1;
        private RoundButton Accepta;
        private System.Windows.Forms.Label Refuza1;
        private RoundButton Refuza;
    }
}