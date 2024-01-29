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
    }
}
