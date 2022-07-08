using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) //Настраиваем кнопку закрытия формы
        {
            Application.Exit();
        }

        private void label_exit_Click(object sender, EventArgs e)  //Настраиваем кнопку выхода
        {
            Application.Exit();
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
            Form Form1 = Application.OpenForms[0];
            Form1.Show();
            Form1.Location = this.Location;
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

        private void Open_start_Click(object sender, EventArgs e)
        //Настраиваем кнопку запуска
        {
            try //Обработка исключения
            {
                //Создаем объект класса OpenFileDialog для открытия файла
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                choofdlog.FilterIndex = 1;
                choofdlog.Multiselect = true;
                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    //Записываем путь к файлу в поле класса "TList"
                    TList.path = choofdlog.FileName;
                }

                TList pup = new TList(); //Создание новой группы
                richTextBox1.Text = pup.PupilsAges()+ pup.SumExams() + pup.AllList()+ pup.FailList();
                richTextBox2.Text = pup.Inform();
                richTextBox3.Text = pup.Intelligence();
            }
            catch //В случае исключения, выводим информацию об ошибке
            {
                MessageBox.Show("Файл не был выбран", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        //Настраиваем кнопку сохранения файла
        {
            //Создаем объект класса SaveFileDialog для сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Создаем объект класса StreamReader для записывания данных в файл
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
