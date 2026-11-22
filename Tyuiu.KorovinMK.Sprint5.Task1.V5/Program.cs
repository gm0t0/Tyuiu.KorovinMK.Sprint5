using Tyuiu.KorovinMK.Sprint5.Task1.V5.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task1.V5;

class Program
{

    public static void Main(string[] args)
    {
        int StartValue = -5;
        int StopValue = 5;
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #5                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #5                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("StartValue: " + StartValue);
        Console.WriteLine("StopValue: " + StopValue);



        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");
        string res = ds.SaveToFileTextData(StartValue, StopValue);

        Console.WriteLine("Файл: " + res); 
        Console.WriteLine("Создан!");

        Console.ReadKey();

    }
}


