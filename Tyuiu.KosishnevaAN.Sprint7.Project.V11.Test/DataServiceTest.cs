using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KosishnevaAN.Sprint7.Project.V11.Lib;

namespace Tyuiu.KosishnevaAN.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void proverkaPath()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.KosishnevaAN.Sprint7\Tyuiu.KosishnevaAN.Sprint7.Project.V11\bin\Debug\БАЗА ДАННЫХ1.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
