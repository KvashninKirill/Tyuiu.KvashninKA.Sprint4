using Tyuiu.KvashninKA.Sprint4.Task1.V27.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task1.V27;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                           *");
        Console.WriteLine("* Задание #1                                                                                           *");
        Console.WriteLine("* Вариант #27                                                                                          *");
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

        int len;
        Console.WriteLine("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Введите значение {i + 1}-го элемента:");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nИсходный массив:");
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