using Tyuiu.KorovinMK.Sprint5.Task7.V3.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task7.V3;

class Program
{

    public static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #3                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V3.txt");
        string pathSaveFile = Path.Combine(@"C:\DataSprint5", "OutPutDataFileTask7V3.txt");

        Console.WriteLine("Данные находяться в файле: " + path);

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Результат находится в файле:");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);

        Console.ReadKey();

    }
}
