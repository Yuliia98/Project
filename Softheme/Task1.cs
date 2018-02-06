using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Softheme
{
    class Task1
    {
      public void countOne()
        {
            int countOne = 0;
            int[] arrayOne = new int[100];//Массив,для записи количества единиц

            string text = System.IO.File.ReadAllText(@".\input.txt");
            char[] array = text.ToCharArray();
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    countOne += 1;
                }
                else
                {
                    arrayOne[j] = countOne;
                    countOne = 0;
                    j++;

                }
            }
            if (countOne != 0)
            {
                arrayOne[j] = countOne;
                j++;
            }

            //Максимальная последовательность
            int max = 0;
            for (int i = 0; i < j; i++)
            {
                if (arrayOne[i] > max)
                    max = arrayOne[i];
            }
            StreamWriter sw = new StreamWriter(@".\output.txt");
            sw.WriteLine(max);
            sw.Close();
        }
    }
    }

