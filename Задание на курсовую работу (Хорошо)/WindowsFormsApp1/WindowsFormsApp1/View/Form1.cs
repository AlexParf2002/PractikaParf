using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //Настраиваем кнопку закрытия формы
        {
            Application.Exit();
        }

        private void label_start_MouseHover(object sender, EventArgs e) //Настраиваем наведение курсора на кнопку
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Underline | FontStyle.Bold);
        }
        private void label_start_MouseLeave(object sender, EventArgs e) //Убираем курсор с кнопки
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_start_Click(object sender, EventArgs e)
        //Настраиваем переход межжду формами
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_information_MouseHover(object sender, EventArgs e) //Настраиваем наведение курсора на кнопку
        {
            label_information.Font = new Font(label_information.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void label_information_MouseLeave(object sender, EventArgs e) //Убираем курсор с кнопки
        {
            label_information.Font = new Font(label_information.Font, FontStyle.Bold);

        }

        private void label_information_Click(object sender, EventArgs e) //Настраиваем переход межжду формами
        {
            Form3 result = new Form3();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_exit_MouseHover(object sender, EventArgs e) //Настраиваем наведение курсора на кнопку
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e) //Убираем курсор с кнопки
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Bold);
        }

        private void label_exit_Click(object sender, EventArgs e) //Настраиваем кнопку выхода
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

