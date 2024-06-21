namespace MedicSoft
{
    partial class SuportOnline
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
            this.problemText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel1
            // 
            this.cancel1.AutoSize = true;
            this.cancel1.BackColor = System.Drawing.Color.Transparent;
            this.cancel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel1.Location = new System.Drawing.Point(300, 42);
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
            this.ok1.Location = new System.Drawing.Point(241, 42);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(28, 23);
            this.ok1.TabIndex = 85;
            this.ok1.Text = "Ok";
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancel.BackgroundImage = global::MedicSoft.Properties.Resources.cross11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Location = new System.Drawing.Point(310, 6);
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
            // problemText
            // 
            this.problemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemText.Location = new System.Drawing.Point(72, 102);
            this.problemText.Name = "problemText";
            this.problemText.Size = new System.Drawing.Size(436, 91);
            this.problemText.TabIndex = 88;
            this.problemText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(76, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 28);
            this.label2.TabIndex = 87;
            this.label2.Text = "Descrieti problema pe care o aveti:";
            // 
            // SuportOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources.desktop_wallpaper_cute_honey_yellow_bumble_bee;
            this.ClientSize = new System.Drawing.Size(580, 224);
            this.Controls.Add(this.problemText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuportOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuportOnline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cancel1;
        private System.Windows.Forms.Label ok1;
        private RoundButton cancel;
        private RoundButton ok;
        private System.Windows.Forms.RichTextBox problemText;
        private System.Windows.Forms.Label label2;
    }
}