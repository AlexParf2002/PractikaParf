using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class TPupils
    {
        string surname; //Фамилия абитуриента
        string name; //Имя абитуриента
        char pol; // Пол абитуриента
        DateTime date; //Дата рождения абитуриента
        int examrus; //Баллы абитуриента за экзамен по русскому языку
        int exammath; //Баллы абитуриента за экзамен по математике
        int examit; //Баллы абитуриента за экзамен по информатике
        public TPupils(string surname, string name, char pol, DateTime date, int examrus, int exammath, int examit)
        //Конструктор, используемый при создании экземпляра класса
        {
            this.surname = surname;
            this.name = name;
            this.pol = pol;
            this.date = date;
            this.examrus = examrus;
            this.exammath = exammath;
            this.examit = examit;
        }
        public int Age() //Метод для определения возраста абитуриента
        {
            //Создаем дату, соответствующую текущей дате
            DateTime today = DateTime.Today;
            //Вычисляем разность в годах между текущей датой и датой рождения абитуриента
            int age = today.Year - date.Year;
            //Отнимаем от текущей даты разность в годах
            today = today.AddYears(-age);
            //Если дата рождения абитуриента больше, чем текущая дата за вычетом найденной разности в годах,
            //то из найденного возраста следует вычесть 1 год, так как он полностью не закончился
            if (date > today) age--;
            return age;
        }
        public string ShowPupils() //Метод для вывода основных данных абитуриента
        {
            string w = $"Фамилия, имя: {surname} {name}\n";
            w += $"День рождения: {date.Day}.{date.Month}.{date.Year}\n";
            w += $"Пол: {pol}\n";
            w += $"Баллы по русскому языку: {examrus}\n";
            w += $"Баллы по матеематике: {exammath}\n";
            w += $"Баллы по информатике: {examit}\n";
            return w;
        }
        public string Name()
        //Метод, позволяющий использовать поле "name" класса TPupils в другом классе
        {
            return name;
        }
        public string Surname()
        //Метод, позволяющий использовать поле "surname" класса TPupils в другом классе
        {
            return surname;
        }
        public char Pol()
        //Метод, позволяющий использовать поле "pol" класса TPupils в другом классе
        {
            return pol;
        }
        public int ExamRus()
        //Метод, позволяющий использовать поле "examrus" класса TPupils в другом классе
        {
            return examrus;
        }
        public int ExamMath()
        //Метод, позволяющий использовать поле "exammath" класса TPupils в другом классе
        {
            return exammath;
        }
        public int ExamIT()
        //Метод, позволяющий использовать поле "examit" класса TPupils в другом классе
        {
            return examit;
        }
        public string BirthDate()
        //Метод, передающий дату рождения абитуриента в другой класс
        {
            string t = $"{date.Day}.{date.Month}.{date.Year}";
            return t;
        }
        
    }
}
