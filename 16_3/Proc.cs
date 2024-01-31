using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;

namespace _16_3
{
    /// <summary>
    /// Класс описывающий процедуры
    /// </summary>
    class Proc
    {
        /// <summary>
        /// Поле описывающее начало первой процедуры
        /// </summary>
        public TimeSpan procedure_1;
        /// <summary>
        /// Поле описывающее начало Второй процедуры
        /// </summary>
        public TimeSpan procedure_2;
        /// <summary>
        /// Общее количество процедур
        /// </summary>
        private int countP;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Proc() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="procedure_1"></param>
        /// <param name="procedure_2"></param>
        /// <param name="countP"></param>
        public Proc(TimeSpan procedure_1, TimeSpan procedure_2, int countP)
        {
            this.procedure_1 = procedure_1;
            this.procedure_2 = procedure_2;
            this.countP = countP;
        }
        /// <summary>
        /// Метод вывода 
        /// </summary>
        public void OutPut()
        {
            WriteLine("Время проведения медицинских процедур:");
            TimeSpan procedure = procedure_2 - procedure_1;
            TimeSpan time = procedure_1;
            for(int i=0;i<countP;i++)
            {
                WriteLine($"Процедура №{i + 1}: {time}");
                time += procedure;
            }    
        }
    }
}
