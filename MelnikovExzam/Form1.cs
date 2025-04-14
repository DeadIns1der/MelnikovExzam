using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelnikovExzam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelCaptcha.Text = GenerateCaptcha(4);
            label1.Visible = false;

        }

        private string GenerateCaptcha(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "user" && password == "user")
            {
                // Открываем главную форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Скрываем текущую форму
            }
            else
            {
                label1.Text = "Неверный логин или пароль!";
                label1.Visible = true;
                labelCaptcha.Text = GenerateCaptcha(4);
            }

        }
    }
}
