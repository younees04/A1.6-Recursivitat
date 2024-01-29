using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitat_Menu
{
    public class Recursivitat2
    {
        //1
        public static int FibonacciLineal(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }

        //3
        public static bool EsTriangular(int n, int sum = 0, int i = 1)
        {
            if (sum == n)
            {
                return true;
            }

            if (sum > n)
            {
                return false;
            }

            return EsTriangular(n, sum + i, i + 1);
        }

        //5
        public static int InvertirNumero(int numero)
        {
            int invertit = 0;

            while (numero != 0)
            {
                invertit = invertit * 10 + numero % 10;
                numero /= 10;
            }

            return invertit;
        }

        //7
        public static int ProducteEscalar(int[] a, int[] b, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return a[n - 1] * b[n - 1] + ProducteEscalar(a, b, n - 1);
        }

        //9

        public static bool CoincideixAmbSumaPrecedents(int[] vector, int index)
        {
            //primer element del vector, la suma és zero.
            if (index == 0)
            {
                return false;
            }

            // Crida recursiva per comprovar si l'element actual coincideix amb la suma dels precedents.
            return vector[index] == SumaPrecedents(vector, index - 1, 0) || CoincideixAmbSumaPrecedents(vector, index - 1);
        }

        public static int SumaPrecedents(int[] vector, int index, int suma)
        {
            if (index == 0)
            {
                return 0;
            }

            return vector[index - 1] + SumaPrecedents(vector, index - 1, suma);
        }

        //11


        static bool EstaOrdenat(int[] vector, int n, bool creixent, int index = 0)
        {
            if (n <= 1 || index == n - 1)
            {
                return true;
            }

            bool condicioOrdenacio = creixent ? vector[index] <= vector[index + 1] : vector[index] >= vector[index + 1];

            return condicioOrdenacio && EstaOrdenat(vector, n, creixent, index + 1);
        }

        //13
        public static bool EsDescomponible(int[] vector, int n, int index = 0, int sumaEsquerra = 0)
        {
            //si hem arribat al final del vector.
            if (index == n)
            {
                return false;
            }

            // Comprovar si la suma de les dues parts és la mateixa.
            if (sumaEsquerra == SumaRestant(vector, index + 1))
            {
                return true;
            }

            return EsDescomponible(vector, n, index + 1, sumaEsquerra + vector[index]);
        }

        public static int SumaRestant(int[] vector, int index)
        {
            int suma = 0;
            for (int i = index; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            return suma;
        }
    }
}
