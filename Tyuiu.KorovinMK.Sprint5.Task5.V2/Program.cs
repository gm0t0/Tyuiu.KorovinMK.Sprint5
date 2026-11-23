using Tyuiu.KorovinMK.Sprint5.Task5.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task5.V2;

class Program
{

    public static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #5                                                                *");
        Console.WriteLine("* Вариант #2                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask5V2.txt");
        Console.WriteLine("Данные находятся в файле:" + path);


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Среднее значение всех положительных элементов = " + res);

        Console.ReadKey();

    }
}
