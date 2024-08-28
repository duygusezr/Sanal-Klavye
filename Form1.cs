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
            // Form y�klendi�inde butonlara gerekli eventleri ekliyoruz
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Formdaki t�m butonlar� kontrol ediyoruz ve olay ba�lamas�n� yap�yoruz
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    // Her buton i�in Click eventini ba�l�yoruz
                    button.Click += Button_Click;

                    // E�er KeyDown olay�n� da tetiklemek istiyorsan�z:
                    button.KeyDown += Button_KeyDown;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Buton t�kland���nda tetiklenecek i�lem
            Button button = sender as Button;
            if (button != null)
            {
                // TextBox'a butonun metnini ekliyoruz
                AddTextToTextBox(button.Text);
            }
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            // KeyDown olay�nda yap�lacak i�lemler
            Button button = sender as Button;
            if (button != null)
            {
                // Bas�lan tu�u eklemek i�in
                AddTextToTextBox(e.KeyCode.ToString());
            }
        }

        private void AddTextToTextBox(string text)
        {
            // TextBox'a metin eklemek i�in fonksiyon
            textBox1.Text += text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BACKSPACE butonunun t�klama olay�
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TextBox'da herhangi bir de�i�iklik oldu�unda yap�lacak i�lemler
        }
    }
}
