using Tyuiu.DikanovAA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Диканов А. А. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернараный оператор                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Диканов Артём Алексеевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных х, у с клавиатуры, если х < y * 2 - 10, то                   *");
            Console.WriteLine("*                   x           2       2                                 *");
            Console.WriteLine("*      (    y + 2  )          2x  cos(y)  + 12                            *");
            Console.WriteLine("* z = (1 + -------  )  иначе ------------------                           *");
            Console.WriteLine("*     (        2    )           2         2                               *");
            Console.WriteLine("*      (      x    )          y   - sin(x)  + 9                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();



        }
    }
}
