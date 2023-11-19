using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotterVV.Sprint5.Task0.V2.Lib;

namespace Tyuiu.BotterVV.Sprint5.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint5\Tyuiu.BotterVV.Sprint5.Task0.V2\bin\Debug";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
