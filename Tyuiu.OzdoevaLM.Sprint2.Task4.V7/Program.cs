using Tyuiu.OzdoevaLM.Sprint2.Task4.V7.Lib;

namespace Tyuiu.OzdoevaLM.Sprint2.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение перменных x, y.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            Console.WriteLine("Введите значение переменной X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = double.Parse(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Значение Z = " + res);

            Console.ReadKey();
        }
    }
}