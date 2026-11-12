using Tyuiu.KvashninKA.Sprint4.Task3.V12.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task3.V12;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #3                                                                                           *");
        Console.WriteLine("* Вариант #12                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями             *");
        Console.WriteLine("* в диапазоне от 2 до 9. Найдите минимальный элемент третьем столбце массива. 9, 7, 4, 9, 7,           *");
        Console.WriteLine("*  5, 2, 5, 7, 6,           8, 3, 3, 5, 7,                                                             *");
        Console.WriteLine("*  8, 4, 2, 4, 5,                                                                                      *");
        Console.WriteLine("*  8, 8, 9, 5, 6,                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int[,] mtrx = new int[,]
            {
                { 9, 7, 4, 9, 7 },
                { 5, 2, 5, 7, 6 },
                { 8, 3, 3, 5, 7 },
                { 8, 4, 2, 4, 5 },
                { 8, 8, 9, 5, 6 }
            };

        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.GetUpperBound(1) + 1;

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        int res = ds.Calculate(mtrx);
        Console.WriteLine("Минимальный элемент в третьем столбце = " + res);

        Console.ReadLine();
    }
}