using Tyuiu.KorovinMK.Sprint5.Task4.V20.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task4.V20;

class Program
{

    public static void Main(string[] args)
    {
        
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #4                                                                *");
        Console.WriteLine("* Вариант #20                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V20.txt");
        Console.WriteLine("Данные находятся в файле:" + path); 


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);

        Console.ReadKey();

    }
}
