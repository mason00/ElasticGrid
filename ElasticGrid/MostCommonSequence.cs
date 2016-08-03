using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticGrid
{
    public static class MostCommonSequence
    {
        public static int[] Output(int[] input)
        {
            var inputCounts = new Dictionary<int, int>();
            var maxCount = 0;
            foreach(int i in input)
            {
                if (!inputCounts.ContainsKey(i))
                {
                    inputCounts.Add(i, 1);
                }
                else
                {
                    inputCounts[i]++;
                }
                if (inputCounts[i] > maxCount)
                {
                    maxCount = inputCounts[i];
                }
            }

            return inputCounts.Where(x => x.Value == maxCount).Select(x => x.Key).ToArray();
        }
    }
}
