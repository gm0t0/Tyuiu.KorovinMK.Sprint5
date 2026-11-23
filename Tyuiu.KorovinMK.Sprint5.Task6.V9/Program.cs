using Tyuiu.KorovinMK.Sprint5.Task6.V9.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task6.V9;

class Program
{

    public static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #9                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V9.txt");
        Console.WriteLine("Данные находятся в файле:" + path);


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Количество элементов длинной в 3 символа: " + res);

        Console.ReadKey();

    }
}
