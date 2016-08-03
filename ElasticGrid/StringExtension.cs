using System;

namespace ElasticGrid
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this String str)
        {
            if (str == null || str == "")
            {
                return true;
            }
            return false;
        }
    }
}
