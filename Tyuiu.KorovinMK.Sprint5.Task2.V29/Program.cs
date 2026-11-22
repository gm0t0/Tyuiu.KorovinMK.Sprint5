using Tyuiu.KorovinMK.Sprint5.Task2.V29.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task2.V29;

class Program
{

    public static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] {   { 9, 2, 5 },
                                        { 3, 2, 4 },
                                        { 2, 8, 8 } };

        int rows = mtrx.GetUpperBound(0) + 1;
        int cols = mtrx.Length / rows;
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #2                                                                *");
        Console.WriteLine("* Вариант #29                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{mtrx[i, j], 4}");
            }
            Console.WriteLine();
        }
        


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();

    }
}


