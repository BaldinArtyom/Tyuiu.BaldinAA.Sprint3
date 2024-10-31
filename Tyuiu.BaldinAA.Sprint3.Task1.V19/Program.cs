using Tyuiu.BaldinAA.Sprint3.Task1.V19.Lib;
namespace Tyuiu.BaldinAA.Sprint3.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Балдин А. А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Балдин Артём Александрович | ИБКСб 24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле, при х=1:                                               *");
            Console.WriteLine("*     9          k                                                        *");
            Console.WriteLine("* p = П Cos x + ---                                                       *");
            Console.WriteLine("*    k=1         4                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue)); ;
        }
    }
}
