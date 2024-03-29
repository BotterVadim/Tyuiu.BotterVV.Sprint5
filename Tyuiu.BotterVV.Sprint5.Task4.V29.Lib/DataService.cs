﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BotterVV.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round((Convert.ToDouble(strX) / (2 * Convert.ToDouble(strX)) + Math.Sin(Math.Pow(Convert.ToDouble(strX), 2))), 3);
            return res;
        }
    }
}
