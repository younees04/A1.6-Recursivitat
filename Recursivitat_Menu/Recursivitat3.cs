using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitat_Menu
{
    public class Recursivitat3
    {
        public static List<string> Permutacions(string str)
        {
            List<string> result = new List<string>();

            if (str.Length == 1)
            {
                result.Add(str);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string prefix = str[i].ToString();
                    string rest = str.Substring(0, i) + str.Substring(i + 1);
                    List<string> permutacionsDeRest = Permutacions(rest);
                    foreach (string permutation in permutacionsDeRest)
                    {
                        result.Add(prefix + permutation);
                    }
                }
            }
            return result;
        }

        // MOHA
        public static int MultiplicacioRussa(int a, int b)
        {
            int res = 0;

            if (a > 0)
            {
                if (a % 2 != 0)
                {
                    res = b + MultiplicacioRussa(a / 2, b * 2);
                }
                else
                {
                    res = MultiplicacioRussa(a / 2, b * 2);
                }
            }

            return res;
        }
    }
}
