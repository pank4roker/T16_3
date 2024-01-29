using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T16_3
{
    /// <summary>
    /// класс DateClass для работы с датой
    /// </summary>
    class DateClass
    {
        /// <summary>
        ///поле DateTime data;
        /// </summary>
        private DateTime data;
        /// <summary>
        /// Поле, обозначающее день
        /// </summary>
        public int year;
        /// <summary>
        /// Поле, обозначающее день
        /// </summary>
        public int month;
        /// <summary>
        /// Поле, обозначающее день
        /// </summary>
        public int day;
        /// <summary>
        /// Constr. without param
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// Constr. with param
        /// </summary>
        /// <param name="data">Задаём дату</param>
        public DateClass(int year,int month,int day)
        {
            //this.year = year; this.month = month; this.day = day;
            data = new DateTime(year, month, day);

        }
        /// <summary>
        /// свойство, позволяющее установить или получить значение поле класса
        /// </summary>
        public DateTime Data { get => data; set => data = value; }
        /// <summary>
        /// вычислить дату предыдущего дня;
        /// </summary>
        /// <returns>Дата предыдущего дня</returns>
        public DateTime Yesterday()
        {
            return data.AddDays(-1);
        }
        /// <summary>
        ///  вычислить дату следующего дня
        /// </summary>
        /// <returns>Дата следующего дня</returns>
        public DateTime Tomorrow()
        {
            return data.AddDays(1);
        }
        /// <summary>
        /// определить сколько дней осталось до конца месяца.
        /// </summary>
        /// <returns>Количество дней, оставшихся до конца месяца</returns>
        public int Residue()
        {
            return DateTime.DaysInMonth(data.Year, data.Month) - data.Day;
        }
        public DateTime Output()
        {
            return data;
        }
        public TimeSpan Interval(DateTime Data1,DateTime Data2)
        {
            TimeSpan interval = (Data1 - Data2);
            return interval;
        }

    }
}
