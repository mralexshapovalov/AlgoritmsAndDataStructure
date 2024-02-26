using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsAndDataStructures.ES
{
    public class Time_complexity
    {
        public static IEnumerable<int> ReadInts(string filePath)
        {
            using (TextReader reader = File.OpenText(filePath))
            {
                string lastLine;
                while ((lastLine = reader.ReadLine()) != null)
                {
                    yield return int.Parse(lastLine);
                }

            }
        }
    }

    public class ThreeSum
    {
        public static int Count(int[] a)
        {
            int n = a.Length;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }


}
