namespace MedicSoft
{
    partial class ContacteazaProgramari
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
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.mesaj = new System.Windows.Forms.RichTextBox();
            this.Anulare = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancel1
            // 
            this.cancel1.AutoSize = true;
            this.cancel1.BackColor = System.Drawing.Color.Transparent;
            this.cancel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel1.Location = new System.Drawing.Point(315, 40);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(66, 23);
            this.cancel1.TabIndex = 86;
            this.cancel1.Text = "Renunta";
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ok1
            // 
            this.ok1.AutoSize = true;
            this.ok1.BackColor = System.Drawing.Color.Transparent;
            this.ok1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok1.Location = new System.Drawing.Point(209, 40);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(94, 23);
            this.ok1.TabIndex = 85;
            this.ok1.Text = "Trimite mail";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancel.BackgroundImage = global::MedicSoft.Properties.Resources.cross11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Location = new System.Drawing.Point(326, 6);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(44, 43);
            this.cancel.TabIndex = 84;
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
            this.ok.TabIndex = 83;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(56, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 90;
            this.label6.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(56, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 91;
            this.label1.Text = "Mesaj";
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.Location = new System.Drawing.Point(121, 81);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(390, 22);
            this.telefon.TabIndex = 92;
            // 
            // mesaj
            // 
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesaj.Location = new System.Drawing.Point(121, 111);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(390, 71);
            this.mesaj.TabIndex = 93;
            this.mesaj.Text = "";
            // 
            // Anulare
            // 
            this.Anulare.AutoSize = true;
            this.Anulare.BackColor = System.Drawing.Color.Transparent;
            this.Anulare.Location = new System.Drawing.Point(121, 188);
            this.Anulare.Name = "Anulare";
            this.Anulare.Size = new System.Drawing.Size(118, 17);
            this.Anulare.TabIndex = 94;
            this.Anulare.Text = "Anulare programare";
            this.Anulare.UseVisualStyleBackColor = false;
            // 
            // ContacteazaProgramari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources.desktop_wallpaper_cute_honey_yellow_bumble_bee;
            this.ClientSize = new System.Drawing.Size(580, 224);
            this.Controls.Add(this.Anulare);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContacteazaProgramari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContacteazaProgramari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private RoundButton cancel;
        private RoundButton ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.RichTextBox mesaj;
        private System.Windows.Forms.CheckBox Anulare;
    }
}