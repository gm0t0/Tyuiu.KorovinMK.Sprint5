using Tyuiu.KorovinMK.Sprint5.Task1.V5.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователь\Пользователь\source\repose\Tyuiu.KorovinMK.Sprint5\Tyuiu.KorovinMK.Sprint5.Task1\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
