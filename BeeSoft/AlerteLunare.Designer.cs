namespace MedicSoft
{
    partial class AlerteLunare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlerteLunare));
            this.Deconectare = new MedicSoft.RoundButton();
            this.InapoiLabel = new System.Windows.Forms.Label();
            this.adaugaAlerta = new MedicSoft.RoundButton();
            this.adaugaAlerta1 = new System.Windows.Forms.Label();
            this.stergeAlerta = new MedicSoft.RoundButton();
            this.stergeAlerta1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Deconectare
            // 
            this.Deconectare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Deconectare.BackgroundImage = global::MedicSoft.Properties.Resources.logout;
            this.Deconectare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Deconectare.Location = new System.Drawing.Point(1134, 30);
            this.Deconectare.Name = "Deconectare";
            this.Deconectare.Size = new System.Drawing.Size(79, 72);
            this.Deconectare.TabIndex = 68;
            this.Deconectare.UseVisualStyleBackColor = false;
            this.Deconectare.Click += new System.EventHandler(this.Deconectare_Click);
            // 
            // InapoiLabel
            // 
            this.InapoiLabel.AutoSize = true;
            this.InapoiLabel.BackColor = System.Drawing.Color.Transparent;
            this.InapoiLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InapoiLabel.Location = new System.Drawing.Point(1141, 102);
            this.InapoiLabel.Name = "InapoiLabel";
            this.InapoiLabel.Size = new System.Drawing.Size(61, 28);
            this.InapoiLabel.TabIndex = 69;
            this.InapoiLabel.Text = "Inapoi";
            // 
            // adaugaAlerta
            // 
            this.adaugaAlerta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adaugaAlerta.BackgroundImage = global::MedicSoft.Properties.Resources.delete_button;
            this.adaugaAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adaugaAlerta.Location = new System.Drawing.Point(65, 23);
            this.adaugaAlerta.Name = "adaugaAlerta";
            this.adaugaAlerta.Size = new System.Drawing.Size(90, 86);
            this.adaugaAlerta.TabIndex = 70;
            this.adaugaAlerta.UseVisualStyleBackColor = false;
            this.adaugaAlerta.Click += new System.EventHandler(this.adaugaAlerta_Click);
            // 
            // adaugaAlerta1
            // 
            this.adaugaAlerta1.AutoSize = true;
            this.adaugaAlerta1.BackColor = System.Drawing.Color.Transparent;
            this.adaugaAlerta1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaAlerta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adaugaAlerta1.Location = new System.Drawing.Point(49, 102);
            this.adaugaAlerta1.Name = "adaugaAlerta1";
            this.adaugaAlerta1.Size = new System.Drawing.Size(127, 28);
            this.adaugaAlerta1.TabIndex = 71;
            this.adaugaAlerta1.Text = "Adauga Alerta";
            this.adaugaAlerta1.Click += new System.EventHandler(this.adaugaAlerta1_Click);
            // 
            // stergeAlerta
            // 
            this.stergeAlerta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.stergeAlerta.BackgroundImage = global::MedicSoft.Properties.Resources.delete_button;
            this.stergeAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergeAlerta.Location = new System.Drawing.Point(224, 23);
            this.stergeAlerta.Name = "stergeAlerta";
            this.stergeAlerta.Size = new System.Drawing.Size(90, 86);
            this.stergeAlerta.TabIndex = 75;
            this.stergeAlerta.UseVisualStyleBackColor = false;
            this.stergeAlerta.Click += new System.EventHandler(this.stergeAlerta_Click);
            // 
            // stergeAlerta1
            // 
            this.stergeAlerta1.AutoSize = true;
            this.stergeAlerta1.BackColor = System.Drawing.Color.Transparent;
            this.stergeAlerta1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeAlerta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stergeAlerta1.Location = new System.Drawing.Point(209, 102);
            this.stergeAlerta1.Name = "stergeAlerta1";
            this.stergeAlerta1.Size = new System.Drawing.Size(117, 28);
            this.stergeAlerta1.TabIndex = 76;
            this.stergeAlerta1.Text = "Sterge Alerta";
            this.stergeAlerta1.Click += new System.EventHandler(this.stergeAlerta1_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(48, 178);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1144, 424);
            this.listBox.TabIndex = 77;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // AlerteLunare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.stergeAlerta1);
            this.Controls.Add(this.stergeAlerta);
            this.Controls.Add(this.adaugaAlerta1);
            this.Controls.Add(this.adaugaAlerta);
            this.Controls.Add(this.InapoiLabel);
            this.Controls.Add(this.Deconectare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlerteLunare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton Deconectare;
        private System.Windows.Forms.Label InapoiLabel;
        private RoundButton adaugaAlerta;
        private System.Windows.Forms.Label adaugaAlerta1;
        private RoundButton stergeAlerta;
        private System.Windows.Forms.Label stergeAlerta1;
        private System.Windows.Forms.ListBox listBox;
    }
}