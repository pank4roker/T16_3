using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write($"Введите время первой процедуры: ");
            TimeSpan procedure_1 = TimeSpan.Parse(ReadLine());
            Write($"Введите время второй процедуры: ");
            TimeSpan procedure_2 = TimeSpan.Parse(ReadLine());
            Write($"Введите общее количество процедур: ");
            int countP = Convert.ToInt32(ReadLine());

            Proc procedures = new Proc(procedure_1, procedure_2, countP);
            procedures.OutPut();
            ReadKey();
        }
    }
}
