using System.Collections.Generic;

namespace ElasticGrid
{
    public static class PositiveDivisors
    {
        public static IEnumerable<int> OutputPositiveDivisor(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
