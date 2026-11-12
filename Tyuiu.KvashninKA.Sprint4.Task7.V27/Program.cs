using Tyuiu.KvashninKA.Sprint4.Task7.V27.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task7.V27;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                             *");
        Console.WriteLine("* Задание #7                                                                                             *");
        Console.WriteLine("* Вариант #27                                                                                            *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                     *");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"583197256891\". Преобразуйте ее в матрицу 4 на 3                   *");
        Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых равна 4 символам.                      *");
        Console.WriteLine("* и подсчитайте количество четных чисел.                                                                 *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("**********************************************************************************************************");



        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
        Console.WriteLine("**********************************************************************************************************");

        int n = 4;
        int m = 3;
        string value = "583197256891";

        int index = 0;
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{value[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        int res = ds.Calculate(n, m, value);
        Console.WriteLine("Количество четных элементов = " + res);

        Console.ReadLine();
    }
}