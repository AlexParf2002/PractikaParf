using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e) //Настраиваем кнопку закрытия формы
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
        private void label_start_Click(object sender, EventArgs e) //Настраиваем переход межжду формами
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_menu_MouseHover(object sender, EventArgs e) //Настраиваем наведение курсора на кнопку
        {
            label_menu.Font = new Font(label_menu.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_menu_MouseLeave(object sender, EventArgs e) //Убираем курсор с кнопки
        {
            label_menu.Font = new Font(label_menu.Font, FontStyle.Bold);
        }

        private void label_menu_Click(object sender, EventArgs e) //Настраиваем переход межжду формами
        {
            Form1 result = new Form1();
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
