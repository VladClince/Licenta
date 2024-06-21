namespace MedicSoft
{
    partial class StatisticiBugetare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticiBugetare));
            this.cancel1 = new System.Windows.Forms.Label();
            this.adauga1 = new System.Windows.Forms.Label();
            this.cancel = new MedicSoft.RoundButton();
            this.adauga = new MedicSoft.RoundButton();
            this.listBox = new System.Windows.Forms.ListBox();
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
            // adauga1
            // 
            this.adauga1.AutoSize = true;
            this.adauga1.BackColor = System.Drawing.Color.Transparent;
            this.adauga1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adauga1.Location = new System.Drawing.Point(511, 123);
            this.adauga1.Name = "adauga1";
            this.adauga1.Size = new System.Drawing.Size(117, 28);
            this.adauga1.TabIndex = 77;
            this.adauga1.Text = "Factura noua";
            this.adauga1.Click += new System.EventHandler(this.adauga1_Click);
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
            // adauga
            // 
            this.adauga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adauga.BackgroundImage = global::MedicSoft.Properties.Resources.prescription;
            this.adauga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adauga.Location = new System.Drawing.Point(529, 58);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(79, 72);
            this.adauga.TabIndex = 75;
            this.adauga.UseVisualStyleBackColor = false;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(49, 175);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1143, 424);
            this.listBox.TabIndex = 79;
            // 
            // StatisticiBugetare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.adauga1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.adauga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticiBugetare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociatia apicola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label adauga1;
        private RoundButton cancel;
        private RoundButton adauga;
        private System.Windows.Forms.ListBox listBox;
    }
}