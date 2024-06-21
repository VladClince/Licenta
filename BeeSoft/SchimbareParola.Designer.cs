namespace MedicSoft
{
    partial class SchimbareParola
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
            this.ok1 = new System.Windows.Forms.Label();
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok = new MedicSoft.RoundButton();
            this.cancel = new MedicSoft.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.parolaCurenta = new System.Windows.Forms.TextBox();
            this.parolaNoua = new System.Windows.Forms.TextBox();
            this.parolaNoua2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok1
            // 
            this.ok1.AutoSize = true;
            this.ok1.BackColor = System.Drawing.Color.Transparent;
            this.ok1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok1.Location = new System.Drawing.Point(228, 36);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(33, 26);
            this.ok1.TabIndex = 74;
            this.ok1.Text = "Ok";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // cancel1
            // 
            this.cancel1.AutoSize = true;
            this.cancel1.BackColor = System.Drawing.Color.Transparent;
            this.cancel1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel1.Location = new System.Drawing.Point(315, 36);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(76, 26);
            this.cancel1.TabIndex = 75;
            this.cancel1.Text = "Renunta";
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ok.BackgroundImage = global::MedicSoft.Properties.Resources.ok_mark11;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ok.Location = new System.Drawing.Point(225, 3);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(39, 41);
            this.ok.TabIndex = 76;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancel.BackgroundImage = global::MedicSoft.Properties.Resources.cross11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Location = new System.Drawing.Point(330, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(39, 41);
            this.cancel.TabIndex = 77;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(96, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 28);
            this.label6.TabIndex = 89;
            this.label6.Text = "Parola curenta";
            // 
            // parolaCurenta
            // 
            this.parolaCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaCurenta.Location = new System.Drawing.Point(250, 90);
            this.parolaCurenta.Name = "parolaCurenta";
            this.parolaCurenta.PasswordChar = '*';
            this.parolaCurenta.Size = new System.Drawing.Size(226, 22);
            this.parolaCurenta.TabIndex = 91;
            // 
            // parolaNoua
            // 
            this.parolaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaNoua.Location = new System.Drawing.Point(250, 130);
            this.parolaNoua.Name = "parolaNoua";
            this.parolaNoua.PasswordChar = '*';
            this.parolaNoua.Size = new System.Drawing.Size(226, 22);
            this.parolaNoua.TabIndex = 92;
            // 
            // parolaNoua2
            // 
            this.parolaNoua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaNoua2.Location = new System.Drawing.Point(250, 171);
            this.parolaNoua2.Name = "parolaNoua2";
            this.parolaNoua2.PasswordChar = '*';
            this.parolaNoua2.Size = new System.Drawing.Size(226, 22);
            this.parolaNoua2.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(96, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Parola noua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(96, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 95;
            this.label2.Text = "Parola noua";
            // 
            // SchimbareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources.desktop_wallpaper_cute_honey_yellow_bumble_bee;
            this.ClientSize = new System.Drawing.Size(588, 220);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolaNoua2);
            this.Controls.Add(this.parolaNoua);
            this.Controls.Add(this.parolaCurenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchimbareParola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchimbareParola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ok1;
        private System.Windows.Forms.Label cancel1;
        private RoundButton ok;
        private RoundButton cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox parolaCurenta;
        private System.Windows.Forms.TextBox parolaNoua;
        private System.Windows.Forms.TextBox parolaNoua2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}