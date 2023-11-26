using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.BotterVV.Sprint5.Task7.V10.Lib;

namespace Tyuiu.BotterVV.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string saveFilepath = @"C:\DataSprint5\OutPutDataFileTask7V10.txt";

            FileInfo fileInfo = new FileInfo(saveFilepath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(saveFilepath);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] > 'А' && line[i] < 'Я') || (line[i] > 'A' && line[i] < 'Z'))
                        {
                            line = line.ToLower();
                            strLine = strLine + line;
                        }
                    }

                    File.AppendAllText(saveFilepath, strLine + Environment.NewLine);
                    strLine = "";
                }
                return saveFilepath;
            }
        }
    }
}
