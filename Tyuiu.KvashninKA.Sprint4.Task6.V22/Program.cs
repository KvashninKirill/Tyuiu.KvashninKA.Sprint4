using Tyuiu.KvashninKA.Sprint4.Task6.V22.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task6.V22;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                              *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры в C#                                                             *");
        Console.WriteLine("* Задание #6                                                                                             *");
        Console.WriteLine("* Вариант #22                                                                                            *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                     *");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
        Console.WriteLine("* Дан строковый массив данных [\"Снег\", \"Дождь\", \"Туман\", \"Град\", \"Ветер\", \"Туча\", \"Засуха\"]*");
        Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых равна 4 символам.                      *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("*                                                                                                        *");
        Console.WriteLine("**********************************************************************************************************");



        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
        Console.WriteLine("**********************************************************************************************************");

        string[] weather = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < weather.Length; i++)
        {
            Console.WriteLine(weather[i]);
        }

        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("**********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
        Console.WriteLine("**********************************************************************************************************");

        string[] res = ds.Calculate(weather);

        Console.WriteLine("Элементы массива, длина которых равна 4 символам:");
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadLine();
    }
}