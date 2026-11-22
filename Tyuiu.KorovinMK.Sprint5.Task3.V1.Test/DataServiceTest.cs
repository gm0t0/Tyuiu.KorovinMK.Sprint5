using Tyuiu.KorovinMK.Sprint5.Task3.V1.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователь\Пользователь\source\repose\Tyuiu.KorovinMK.Sprint5\Tyuiu.KorovinMK.Sprint5.Task3\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
