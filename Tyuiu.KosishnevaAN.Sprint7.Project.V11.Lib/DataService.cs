using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.KosishnevaAN.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string path)
        {
            string[] str = File.ReadAllLines(path);

            //определение количества столбцов и строк
            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }


        public int MIN(string[,] array, int id)
        {
            int min = 100000000;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (Convert.ToInt32(array[i, 2]) == id)
                    {
                        try
                        {
                            min = Math.Min(min, Convert.ToInt32(array[i, 7]));
                        }
                        catch { }
                    }
                }
                catch { };
                if (min == 100000000)
                {
                    min = 0;
                }
            }
            return min;
        }
    }
}
