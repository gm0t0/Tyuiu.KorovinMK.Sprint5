using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorovinMK.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new[] { ' ', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string part in parts)
                    {
                        double value = double.Parse(part.Replace(",", "."), CultureInfo.InvariantCulture);
                        if (value > 0)
                        {
                            sum += value;
                            count++;
                        }
                    }
                    
                }
            }
            if (count == 0) return 0;
            return Math.Round(sum / count, 3);
           
            
        }
    }
}
