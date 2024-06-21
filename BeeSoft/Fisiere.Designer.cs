namespace MedicSoft
{
    partial class Fisiere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fisiere));
            this.listBox = new System.Windows.Forms.ListBox();
            this.cancel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.cancel = new MedicSoft.RoundButton();
            this.ok = new MedicSoft.RoundButton();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Thistle;
            this.listBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(47, 178);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1149, 424);
            this.listBox.TabIndex = 67;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
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
            // Fisiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicSoft.Properties.Resources._4c;
            this.ClientSize = new System.Drawing.Size(1280, 655);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fisiere";
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
    }
}