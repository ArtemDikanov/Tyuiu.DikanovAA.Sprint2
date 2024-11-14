using Tyuiu.DikanovAA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Диканов А. А. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Диканов Артём Алексеевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на языке C#, которая использует оператор switch,     *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
            Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите дату: ");
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            string date;
            if (m > 12 || m < 1 || g < 0)
            {
                date = "Введено неверное значение";
            }
            else
            {
                date = "Дата следующего дня: " + ds.FindDateOfNextDay(g, m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(date);
            Console.ReadKey();


        }
    }
}
