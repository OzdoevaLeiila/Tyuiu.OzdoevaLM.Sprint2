using Tyuiu.OzdoevaLM.Sprint2.Task6.V8.Lib;

namespace Tyuiu.OzdoevaLM.Sprint2.Task6.V8.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #2 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("*Написать программу,которая использует сокращенную форму записи оператора *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.             *");
            Console.WriteLine("* По заданным n и m определить дату предыдущего дня.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите день: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.FindDateOfPreviousDay(d, m);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
