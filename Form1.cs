namespace Profile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnElave_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Şəkil|*.jpg;*.jpeg;*.png;*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(d.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("İstifadəçi adını daxil edin!");
            }
            else
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Gmail ünvanını daxil edin!");
                }
                else
                {
                    if (textBox3.Text.Trim() == "")
                    {
                        MessageBox.Show("Telefonu daxil edin!");
                    }
                    else
                    {
                        if (maskedTextBox1.MaskFull == false)
                        {
                            MessageBox.Show("Tarixi tam daxil edin!");
                        }
                        else
                        {
                            richTextBox1.Text = textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + maskedTextBox1.Text;
                            MessageBox.Show("Yadda saxlanıldı!");
                        }
                    }
                }
            }
        }
    }
}
