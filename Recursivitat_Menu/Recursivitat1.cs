using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitat_Menu
{
    public class Recursivitat1
    {
        public static int SumaDigits(int num)
        {
            int suma = 0;

            if (num == 0)
            {
                suma = num;
            }

            else
            {
                suma = suma + num % 10 + SumaDigits(num / 10);
            }
            return suma;

        }

        public static int SumaProducteAmbSumes(int a, int b)
        {
            int resultat = 0;

            if (a == 0)
            {
                resultat = 0;
            }

            else
            {
                resultat = resultat + b + SumaProducteAmbSumes(a - 1, b);
            }
            return resultat;
        }

        //3
        public static int Potencia(int a, int b)
        {
            int resultat = 0;

            if (b == 0)
            {
                resultat = 1;
            }

            else
            {
                resultat = resultat + a * Potencia(a, b - 1);
            }
            return resultat;
        }

        // 4
        public static int DivisioEntera(int num1, int num2)
        {
            int quocient = 0;
            if (num1 < num2)
            {
                quocient = 0;
            }

            else
            {
                quocient = 1 + DivisioEntera(num1 - num2, num2);
            }

            return quocient;
        }

        //5

        public static int Modul(int a, int b)
        {
            int resultat = 0;

            if (a < b)
            {
                resultat = a;
            }

            else
            {
                resultat += Modul(a - b, b);
            }
            return resultat;
        }

        //7.
        public static int Fibonacci(int n)
        {
            int resultat = 0;

            if (n == 0)
            {
                resultat = 0;
            }

            else if (n == 1)
            {
                resultat = 1;
            }

            else
            {
                resultat = Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            return resultat;
        }
        //9
        public static int ComptarXifres(int n)
        {
            int resultat = 0;

            if (n == 0)
            {
                resultat = 0;
            }

            else
            {
                resultat = 1 + ComptarXifres(n / 10);
            }
            return resultat;
        }
    }
}
