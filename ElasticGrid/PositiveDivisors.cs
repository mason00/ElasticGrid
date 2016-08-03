using System.Collections.Generic;

namespace ElasticGrid
{
    public static class PositiveDivisors
    {
        public static int[] OutputPositiveDivisor(int input)
        {
            var buffer = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    buffer.Add(i);
                }
            }

            return buffer.ToArray();
        }
    }
}
