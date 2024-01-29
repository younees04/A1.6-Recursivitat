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


        public static bool EstaOrdenat(int[] vector, int n, bool creixent, int index = 0)
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

        // MOHA PARELLS
        // 2.- Un número és primer si té estrictament dos divisors. Dissenyeu una funció que ens digui si un número és primer
        public static bool EsPrimer(int numero)
        {
            bool esPrimer = false;

            if (numero <= 1)
            {
                esPrimer = false;
            }

            int cantidadDivisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cantidadDivisores++;
                }

                if (cantidadDivisores > 2)
                {
                    esPrimer = false;
                }
            }

            esPrimer = cantidadDivisores == 2;
            return esPrimer;
        }

        // 4.- Fer una funció que faci la divisió entera entre dos números 
        public static int DivisioEntera(int dividendo, int divisor)
        {
            int res = 0;

            if (dividendo >= divisor)
            {
                res = 1 + DivisioEntera(dividendo - divisor, divisor);
            }

            return res;
        }

        // 6.- Fer una funció que calculi el Màxim Comú Divisor de dos naturals. 
        public static int MCD(int a, int b)
        {
            int res = 0;

            if (a == b)
            {
                res = a;
            }
            else if (a > b)
            {
                res = MCD(a - b, b);
            }
            else
            {
                res = MCD(a, b - a);
            }

            return res;
        }

        // 8.- Fer una funció que retorni un enter que sigui la interpretació en base b d’un altre enter n entrat com a argument a la funció.
        public static int InterpretarBase(int num, int basee)
        {
            int res = 0;

            if (num == 0)
            {
                res = 0;
            }
            else
            {
                res = InterpretarBase(num / 10, basee) * basee + num % 10;
            }

            return res;
        }


        // 10.- Fer una funció que ens digui si un nombre está en base b.
        public static bool EsBase(int num, int basee)
        {
            bool res;

            if (num == 0)
            {
                res = true;
            }

            else if (num % 10 >= basee)
            {
                res = false;
            }
            else
            {
                res = EsBase(num / 10, basee);
            }
            return res;
        }

        // 12.- Fer una funció recursiva que donat un vector V d’enters, digui quina és la longitud del prefix més llarg que suma zero.Si no n’hi ha cap, la funció retornarà 0. S’entén per prefix qualsevol subvector de V que comenci per V[0]. 
        public static int PrefixSumaZero(int[] vector, int posicio)
        {
            int res = 0;

            if (vector[posicio] == 0)
            {
                res = 1 + PrefixSumaZero(vector, posicio + 1);
            }

            return res;
        }

        // 14.- Dissenyeu un algorisme recursiu que donats dos vectors d’enters ordenats creixentment, a[1:n] i b[1:m] amb n i m diferents, n ≥ 0 i m ≥ 0, que representen dos conjunts d’enters, decideixi si la seva intersecció és buida o no.
        public static bool InterseccioBuida(int[] a, int[] b, int posA, int posB)
        {
            bool res = false;

            if (posA == a.Length || posB == b.Length)
            {
                res = true;
            }
            else if (a[posA] == b[posB])
            {
                res = false;
            }
            else if (a[posA] < b[posB])
            {
                res = InterseccioBuida(a, b, posA + 1, posB);
            }
            else
            {
                res = InterseccioBuida(a, b, posA, posB + 1);
            }

            return res;
        }
    }
}
