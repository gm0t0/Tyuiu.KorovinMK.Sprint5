using Tyuiu.KorovinMK.Sprint5.Task2.V29.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователь\Пользователь\source\repose\Tyuiu.KorovinMK.Sprint5\Tyuiu.KorovinMK.Sprint5.Task2\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
