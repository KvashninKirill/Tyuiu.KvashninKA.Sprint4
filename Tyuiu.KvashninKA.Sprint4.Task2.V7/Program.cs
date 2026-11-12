using Tyuiu.KvashninKA.Sprint4.Task2.V7.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task2.V7;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #2                                                                                           *");
        Console.WriteLine("* Вариант #7                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный случайными                           *");
        Console.WriteLine("* в диапазоне от 4 до 9 подсчитать сумму четных элементов массива.                                     *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        int[] numsArray = new int[12];
        Random rnd = new Random();

        for (int i = 0; i < numsArray.Length; i++)
        {
            numsArray[i] = rnd.Next(4, 10);
        }

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        int res = ds.Calculate(numsArray);
        Console.WriteLine("Сумма четных элементов массива = " + res);

        Console.ReadLine();
    }
}