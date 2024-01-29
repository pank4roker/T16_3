using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_3
{
    internal class Program
    {
        static DateTime Input(string input)
        {
            WriteLine($"Введите {input} дату: ");
            Write("День: ");
            int day = Convert.ToInt32(ReadLine());
            Write("Месяц: ");
            int month = Convert.ToInt32(ReadLine());
            Write("Год: ");
            int year = Convert.ToInt32(ReadLine());
            return new DateTime(year, month, day);
        }
        static void Main(string[] args)
        {
            try
            {
                //Task 1

                /*WriteLine($"Введите дату: ");
                Write("День: ");
                int day = Convert.ToInt32(ReadLine());
                Write("Месяц: ");
                int month = Convert.ToInt32(ReadLine());
                Write("Год: ");
                int year = Convert.ToInt32(ReadLine());

                DateClass date1 = new DateClass(year, month, day);
                Write($"{date1.Output().ToString("d")}\nПредыдущий день: {date1.Yesterday().ToString("d")}\nПоследующий день: {date1.Tomorrow().ToString("d")}\nКол-во дней до конца месяца: {date1.Residue()}");*/

                //Task 2

                DateTime date_1 = Input("первую");
                DateTime date_2 = Input("вторую");
                TimeSpan delta = date_1 - date_2;
                WriteLine($"Первая дата: {date_1.ToShortDateString()}\nВторая дата: {date_2.ToShortDateString()}\nРазница: {delta.Days}");

                //Task 3




            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
