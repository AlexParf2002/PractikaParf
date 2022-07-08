using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp1.Model
{
    class TList
    {
       
        string specialityName; //Наименование направления
        int pupilsCount; //Количество абитуриентов, подавших документы
        int positions; //Количество мест для приема
        TPupils[] pupils; //Данные о всех абитуриентах
        internal static string path;
        //путь файла, полученный с помощью события
        public TList() //Конструктор, используемый для наполнения экземпляров класса TPupils
        {
            Random rnd = new Random();
            try //обработка исключения
            {
                //Создаем объект класса StreamReader для считывания данных с файла
                StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8);
                //Объявляем локальные переменные для временного хранения данных
                string surname; string name; char pol; int day; int month; int year;
                int examrus; int exammath; int examit;
                specialityName = sr.ReadLine(); //Считываем с файла название направления
                pupilsCount = int.Parse(sr.ReadLine()); //Считываем количество абитуриентов
                positions = int.Parse(sr.ReadLine()); //Считываем количество мест для приема
                sr.ReadLine(); //Перемещаем указатель в файле на строчку вниз
                pupils = new TPupils[pupilsCount]; //Создаем массив объектов
                for (int i = 0; i < pupilsCount; i++) //Создаем абитуриентов
                {
                    //Считываем данные с файла
                    surname = sr.ReadLine();
                    name = sr.ReadLine();
                    pol = char.Parse(sr.ReadLine());
                    day = int.Parse(sr.ReadLine());
                    month = int.Parse(sr.ReadLine());
                    year = int.Parse(sr.ReadLine());
                    //Определение случайного размера баллов ЕГЭ
                    examrus = rnd.Next(1, 101);
                    exammath = rnd.Next(1, 101);
                    examit = rnd.Next(1, 101);
                    DateTime date = new DateTime(year, month, day);
                    //Создаем абитуриента
                    pupils[i] = new TPupils(surname, name, pol, date, examrus, exammath, examit);
                    sr.ReadLine();
                }
            }
            catch (Exception e) //В случае исключения, выводим информацию об ошибке
            {
                Console.WriteLine(e.Message);
            }
        }
        public string Inform()
        //Метод для отображения всех данных абитуриентов
        {
            string w = "Исходные данные абитуриентов:\n";
            for (int i = 0; i < pupils.Length; i++)
            {
                w += ($"{pupils[i].Surname()} {pupils[i].Name()} ({pupils[i].Pol()})\n" +
                    $"Дата рожденния - ({pupils[i].BirthDate()})\n" +
                    $"Математика - {pupils[i].ExamMath()}\nРусский язык - " +
                    $"{pupils[i].ExamRus()}\nИнформатика - {pupils[i].ExamIT()}\n\n");
            }
            w += "\n";
            return w;
        }
        public string Intelligence()
        //Метод для отображения всех данных абитуриентов
        {
            string w = "Сведения о поступающих:\n\n";
            w += $"Наименование направления: \n{specialityName}\n" +
                $"Количество абитуриентов: {pupilsCount}\n" +
                $"Количество мест для приема: {positions}";
            return w;
        }

        public string PupilsAges() //Метод для отображения данных о возрасте абитуриентов
        {
            string w = $"Данные о возрасте абитуриентов:\n";
            for (int i = 0; i < pupils.Length; i++)
            {
                w += ($"{pupils[i].Surname()} {pupils[i].Name()} - {pupils[i].Age()} лет\n");
            }
            w += "\n";
            return w;
        }
        public string SumExams()
        //Метод для отображения данных о суммарном балле ЕГЭ каждого абитуриента
        {
            string w = $"Данные о суммарном балле ЕГЭ абитуриентов:\n";
            for (int i = 0; i < pupils.Length; i++)
            {
                w += ($"{pupils[i].Surname()} {pupils[i].Name()} - {pupils[i].ExamRus()+ pupils[i].ExamMath()+ pupils[i].ExamIT()} баллов\n");
            }
            w += "\n";
            return w;
        }
        public string AllList()
        //Метод для отображения данных обо всех абитуриентах,
        //упорядоченный по суммарному баллу ЕГЭ, начиная с максимального
        {
            string w = "Рейтинг абитуриентов:";
            int [] sum = new int[pupilsCount];
            for (int i = 0; i < pupils.Length; i++)
            {
                sum[i] = pupils[i].ExamRus() + pupils[i].ExamMath() + pupils[i].ExamIT();
            }
            for (int i = 1; i < sum.Length; i++)
            {
                for (int k = 0; k < sum.Length - i; k++)
                {
                    if (sum[k] < sum[k + 1])
                    {
                        (pupils[k], pupils[k + 1]) = (pupils[k + 1], pupils[k]);
                        (sum[k], sum[k + 1]) = (sum[k + 1], sum[k]);
                    }
                }
            }
            w += "\n";
            for (int i = 0; i < sum.Length; i++)
            {
                w += $"{pupils[i].Surname()} {pupils[i].Name()} - {sum[i]} баллов\n";
            }
            w += "\n";
            return w;
        }
        public string FailList()
        //Метод для отображения данных об абитуриентах не поступивших на данное направление
        {
            string w = "\n";
             w = $"Список абитуриентов, не поступивших на направление\n\"{specialityName}\":\n";
            int c = 0;
            if (pupilsCount > positions)
                c = pupilsCount - positions; 
            else 
                c = positions - pupilsCount;
            int[] sum = new int[pupilsCount];
            for (int i = 0; i < pupils.Length; i++)
            {

                sum[i] = pupils[i].ExamRus() + pupils[i].ExamMath() + pupils[i].ExamIT();
            }
            for (int i = 1; i < sum.Length; i++)
            {
                for (int k = 0; k < sum.Length - i; k++)
                {
                    if (sum[k] < sum[k + 1])
                    {
                        (pupils[k], pupils[k + 1]) = (pupils[k + 1], pupils[k]);
                        (sum[k], sum[k + 1]) = (sum[k + 1], sum[k]);
                    }
                }
            }
            for (int i = 0; i < sum.Length; i++)
            {
                if (i <= c)
                    continue;
                else
                w += $"{pupils[i].Surname()} {pupils[i].Name()} - {sum[i]} баллов\n";
            }
            return w;
        }
       
    }
}
