using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElizarovKI.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ElizarovKI.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #2 | Выполнил: Елизаров К. И. | ИИПб-23-2";

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #2                                                               *");
                Console.WriteLine("* Тема: Получение результата из switch                                    *");
                Console.WriteLine("* Задание #6                                                              *");
                Console.WriteLine("* Вариант #9                                                              *");
                Console.WriteLine("* Выполнил: Елизаров Кирилл Игоревич | ИИПб-23-2                          *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
                Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Введите месяц: ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Завтра будет " + ds.FindDateOfNextDay(m, n));

            }catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
