using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorovinMK.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', ',', '.', ';', '-', '!', '?', '-', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach  (string word in words)
                    {
                        if (word.Length == 3)
                        count++;
                    }
                }
                    
            }
            return count;
        }
    }
}
