using Tyuiu.KorovinMK.Sprint5.Task6.V9.Lib;
namespace Tyuiu.KorovinMK.Sprint5.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServcieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
