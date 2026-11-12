using Tyuiu.KvashninKA.Sprint4.Task0.V14.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task0.V14;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #0                                                                                           *");
        Console.WriteLine("* Вариант #14                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями              *");
        Console.WriteLine("* в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.  {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}   *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");
        
        int res = ds.GetSumOddArrEl(numsArray);
        Console.WriteLine("Сумма нечетных элементов массива = " + res);

        Console.ReadLine();
    }
}