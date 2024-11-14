using Tyuiu.DikanovAA.Sprint2.Task6.V3.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task6.V3
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Диканов Артём Алексеевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на языке C#, которая использует оператор switch,     *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* Условие: Составить программу, которая в зависимости от порядкового      *");
            Console.WriteLine("* номера дня недели (1, 2, …, 7) выводит на экран его название            *");
            Console.WriteLine("* (понедельник, вторник, …, воскресенье).                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((value < 1) || (value > 7))
            {
                res = "Ошибка";
            }
            else
            {
                res = ds.FindDayName(value);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}
