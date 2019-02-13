using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            // put your code here
            string result = "";
            int k = 0;

            if (source.Length % 2 != 0)
            {
                result = "No";
            }
            else if (source.Length % 2 == 0)
            {
                for (int i = 0; i <= source.Length / 2; i++)
                {
                    if (source[i] != source[source.Length - i])
                    {
                        k++;
                    }
                }

                if (k > 0)
                    result = "No";
                else
                    result = "Yes";
            }

            return result;
        }
    }
}
