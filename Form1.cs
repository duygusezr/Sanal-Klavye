using System;
using System.Drawing;
using System.Windows.Forms;

namespace yeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form yüklendiðinde butonlara gerekli eventleri ekliyoruz
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Formdaki tüm butonlarý kontrol ediyoruz ve olay baðlamasýný yapýyoruz
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    // Her buton için Click eventini baðlýyoruz
                    button.Click += Button_Click;

                    // Eðer KeyDown olayýný da tetiklemek istiyorsanýz:
                    button.KeyDown += Button_KeyDown;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Buton týklandýðýnda tetiklenecek iþlem
            Button button = sender as Button;
            if (button != null)
            {
                // TextBox'a butonun metnini ekliyoruz
                AddTextToTextBox(button.Text);
            }
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            // KeyDown olayýnda yapýlacak iþlemler
            Button button = sender as Button;
            if (button != null)
            {
                // Basýlan tuþu eklemek için
                AddTextToTextBox(e.KeyCode.ToString());
            }
        }

        private void AddTextToTextBox(string text)
        {
            // TextBox'a metin eklemek için fonksiyon
            textBox1.Text += text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BACKSPACE butonunun týklama olayý
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TextBox'da herhangi bir deðiþiklik olduðunda yapýlacak iþlemler
        }
    }
}
