namespace Profile
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btnElave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(40, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 72F);
            this.lblIcon.Location = new System.Drawing.Point(40, 50);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(200, 170);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "👤";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnElave.Location = new System.Drawing.Point(40, 240);
            this.btnElave.Name = "btnElave";
            this.btnElave.Size = new System.Drawing.Size(200, 50);
            this.btnElave.TabIndex = 2;
            this.btnElave.Text = "Əlavə et";
            this.btnElave.UseVisualStyleBackColor = true;
            this.btnElave.Click += new System.EventHandler(this.btnElave_Click);
            this.textBox1.Location = new System.Drawing.Point(300, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "istifadəçi adı";
            this.textBox1.Size = new System.Drawing.Size(240, 27);
            this.textBox1.TabIndex = 3;
            this.textBox2.Location = new System.Drawing.Point(300, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "gmail ünvanı";
            this.textBox2.Size = new System.Drawing.Size(240, 27);
            this.textBox2.TabIndex = 4;
            this.textBox3.Location = new System.Drawing.Point(300, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Telefon";
            this.textBox3.Size = new System.Drawing.Size(240, 27);
            this.textBox3.TabIndex = 5;
            this.maskedTextBox1.Location = new System.Drawing.Point(300, 260);
            this.maskedTextBox1.Mask = "00-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(240, 27);
            this.maskedTextBox1.TabIndex = 6;
            this.btnSave.Location = new System.Drawing.Point(300, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.richTextBox1.Location = new System.Drawing.Point(40, 410);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(500, 55);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 485);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnElave);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnElave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
