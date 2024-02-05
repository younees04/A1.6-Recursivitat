namespace Recursivitat_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecciona una llista de funcions:");
                Console.WriteLine("1. Recursivitat1");
                Console.WriteLine("2. Recursivitat2");
                Console.WriteLine("3. Recursivitat3");
                Console.WriteLine("0. Sortir");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowRecursivitat1Menu();
                        break;
                    case "2":
                        ShowRecursivitat2Menu();
                        break;
                    case "3":
                        ShowRecursivitat3Menu();
                        break;
                    case "0":
                        return; // Surt del programa
                    default:
                        Console.WriteLine("Opció no válida.");
                        break;
                }
            }
        }

        static void ShowRecursivitat1Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecciona un mètode de Recursivitat1:");
                Console.WriteLine("1. SumaDigits");
                Console.WriteLine("2. SumaProducteAmbSumes");
                Console.WriteLine("3. Potència");
                Console.WriteLine("4. Modul");
                Console.WriteLine("5. Fibonacci");
                Console.WriteLine("6. ComptarXifres");
                Console.WriteLine("7. DivisióEntera");
                Console.WriteLine("8. ValorMàxim");
                Console.WriteLine("9. TrobaPosició");
                Console.WriteLine("10. EsBase");
                Console.WriteLine();
                Console.Write("Introdueix el número del mètode (1-10): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Introdueix el número per a SumaDigits: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.SumaDigits(num1));
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.Write("Introdueix el primer número per a SumaProducteAmbSumes: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix el segon número per a SumaProducteAmbSumes: ");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.SumaProducteAmbSumes(num2, num3));
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.Write("Introdueix el número base per a Potència: ");
                        int num4 = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix l'exponent per a Potència: ");
                        int num5 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.Potencia(num4, num5));
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.Write("Introdueix el primer número per a Modul: ");
                        int num6 = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix el segon número per a Modul: ");
                        int num7 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.Modul(num6, num7));
                        break;
                    case "5":
                        Console.WriteLine();
                        Console.Write("Introdueix el número per a Fibonacci: ");
                        int num8 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.Fibonacci(num8));
                        break;
                    case "6":
                        Console.WriteLine();
                        Console.Write("Introdueix el número per a ComptarXifres: ");
                        int num9 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.ComptarXifres(num9));
                        break;
                    case "7":
                        Console.WriteLine();
                        Console.Write("Introdueix el primer número per a DivisióEntera: ");
                        int num10 = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix el segon número per a DivisióEntera: ");
                        int num11 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.DivisioEntera(num10, num11));
                        break;
                    case "8":
                        Console.WriteLine();
                        int[] vector = { 10, 5, 8, 20 };
                        Console.WriteLine(Recursivitat1.ValorMaxim(vector, vector.Length - 1));
                        break;
                    case "9":
                        Console.WriteLine();
                        int[] array = { 10, 20, 30, 40, 50 };
                        Console.Write("Introdueix el valor a buscar en TrobaPosició: ");
                        int valor = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.TrobaPosicio(array, valor, array.Length - 1));
                        break;
                    case "10":
                        Console.WriteLine();
                        Console.Write("Introdueix el número per a EsBase: ");
                        int num12 = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix la base per a EsBase: ");
                        int baseNum = int.Parse(Console.ReadLine());
                        Console.WriteLine(Recursivitat1.EsBase(num12, baseNum));
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opció no vàlida.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Presiona Enter per a tornar al menú de Recursivitat1...");
                Console.ReadLine();
            }
        }

        static void ShowRecursivitat2Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecciona un metode de Recursivitat2:");
                Console.WriteLine("1. FibonacciLineal");
                Console.WriteLine("2. EsPrimer");
                Console.WriteLine("3. EsTriangular");
                Console.WriteLine("4. DivisioEntera");
                Console.WriteLine("5. InvertirNumero");
                Console.WriteLine("6. MCD");
                Console.WriteLine("7. ProducteEscalar");
                Console.WriteLine("8. InterpretarBase");
                Console.WriteLine("9. CoincideixAmbSumaPrecedents");
                Console.WriteLine("10. EsBase");
                Console.WriteLine("11. EstaOrdenat");
                Console.WriteLine("12. PrefixSumaZero");
                Console.WriteLine("13. EsDescomponible");
                Console.WriteLine("14. InterseccioBuida");
                Console.WriteLine("0. Sortir");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Selecciona un número per executar el mètode corresponent: ");
                int opcio = int.Parse(Console.ReadLine());

                switch (opcio)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Introdueix el valor de n: ");
                        int nFibonacci = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.FibonacciLineal(nFibonacci)}");
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Introdueix el número a verificar si és primer: ");
                        int numeroPrimer = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.EsPrimer(numeroPrimer)}");
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Introdueix el valor de n: ");
                        int nTriangular = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.EsTriangular(nTriangular)}");
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.Write("Introdueix el dividend: ");
                        int dividend = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix el divisor: ");
                        int divisor = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.DivisioEntera(dividend, divisor)}");
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.Write("Introdueix el número a invertir: ");
                        int numInvertir = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.InvertirNumero(numInvertir)}");
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.Write("Introdueix el valor de a: ");
                        int aMCD = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix el valor de b: ");
                        int bMCD = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.MCD(aMCD, bMCD)}");
                        break;
                    case 7:
                        Console.WriteLine();
                        Console.Write("Introdueix la longitud dels vectors: ");
                        int longitudVectors = int.Parse(Console.ReadLine());
                        int[] vectorA = new int[longitudVectors];
                        int[] vectorB = new int[longitudVectors];

                        Console.WriteLine("Introdueix els valors del vector A:");
                        for (int i = 0; i < longitudVectors; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorA[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Introdueix els valors del vector B:");
                        for (int i = 0; i < longitudVectors; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorB[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine($"Resultat: {Recursivitat2.ProducteEscalar(vectorA, vectorB, longitudVectors)}");
                        break;
                    case 8:
                        Console.WriteLine();
                        Console.Write("Introdueix el número a interpretar: ");
                        int numInterpretar = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix la base: ");
                        int baseInterpretar = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.InterpretarBase(numInterpretar, baseInterpretar)}");
                        break;
                    case 9:
                        Console.WriteLine();
                        Console.Write("Introdueix la longitud de la llista: ");
                        int longitudLlista = int.Parse(Console.ReadLine());
                        int[] llista = new int[longitudLlista];

                        Console.WriteLine("Introdueix els valors de la llista:");
                        for (int i = 0; i < longitudLlista; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            llista[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine($"Resultat: {Recursivitat2.CoincideixAmbSumaPrecedents(llista, longitudLlista)}");
                        break;
                    case 10:
                        Console.WriteLine();
                        Console.Write("Introdueix el número a verificar: ");
                        int numEsBase = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix la base: ");
                        int baseEsBase = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {Recursivitat2.EsBase(numEsBase, baseEsBase)}");
                        break;

                    case 11:
                        Console.WriteLine();
                        Console.Write("Introdueix la longitud del vector: ");
                        int longitudVectorOrdenat = int.Parse(Console.ReadLine());
                        int[] vectorOrdenat = new int[longitudVectorOrdenat];

                        Console.WriteLine("Introdueix els valors del vector ordenat creixentment:");
                        for (int i = 0; i < longitudVectorOrdenat; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorOrdenat[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine($"Resultat: {Recursivitat2.EstaOrdenat(vectorOrdenat, longitudVectorOrdenat, true)}");
                        break;
                    case 12:
                        Console.WriteLine();
                        Console.Write("Introdueix la longitud del vector: ");
                        int longitudVectorPrefixSumaZero = int.Parse(Console.ReadLine());
                        int[] vectorPrefixSumaZero = new int[longitudVectorPrefixSumaZero];

                        Console.WriteLine("Introdueix els valors del vector:");
                        for (int i = 0; i < longitudVectorPrefixSumaZero; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorPrefixSumaZero[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine($"Resultat: {Recursivitat2.PrefixSumaZero(vectorPrefixSumaZero, longitudVectorPrefixSumaZero - 1)}");
                        break;
                    case 13:
                        Console.WriteLine();
                        Console.Write("Introdueix la longitud del vector: ");
                        int longitudVectorDescomponible = int.Parse(Console.ReadLine());
                        int[] vectorDescomponible = new int[longitudVectorDescomponible];

                        Console.WriteLine("Introdueix els valors del vector:");
                        for (int i = 0; i < longitudVectorDescomponible; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorDescomponible[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine($"Resultat: {Recursivitat2.EsDescomponible(vectorDescomponible, longitudVectorDescomponible)}");
                        break;

                    case 14:
                        Console.WriteLine();
                        Console.Write("Introdueix la longitud dels vectors ordenats creixentment: ");
                        int longitudVectorsInterseccioBuida = int.Parse(Console.ReadLine());
                        int[] vectorAInterseccioBuida = new int[longitudVectorsInterseccioBuida];
                        int[] vectorBInterseccioBuida = new int[longitudVectorsInterseccioBuida];

                        Console.WriteLine("Introdueix els valors del vector A:");
                        for (int i = 0; i < longitudVectorsInterseccioBuida; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorAInterseccioBuida[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Introdueix els valors del vector B:");
                        for (int i = 0; i < longitudVectorsInterseccioBuida; i++)
                        {
                            Console.Write($"Valor {i + 1}: ");
                            vectorBInterseccioBuida[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine();
                        Console.WriteLine($"Resultat: {Recursivitat2.InterseccioBuida(vectorAInterseccioBuida, vectorBInterseccioBuida, longitudVectorsInterseccioBuida - 1, longitudVectorsInterseccioBuida - 1)}");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Opció no vàlida.");
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Presiona Enter per a tornar al menú de Recursivitat2...");
                Console.ReadLine();
            }
        }

        static void ShowRecursivitat3Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecciona un mètode de Recursivitat3:");
                Console.WriteLine("1. Permutacions");
                Console.WriteLine("2. Multiplicació Russa");
                Console.WriteLine("0. Sortir");
                Console.WriteLine();
                Console.Write("Introdueix el número del mètode (1-2): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Introdueix la cadena per a Permutacions: ");
                        string str = Console.ReadLine();
                        List<string> permutacions = Recursivitat3.Permutacions(str);

                        Console.WriteLine("Permutacions:");
                        foreach (string permutacio in permutacions)
                        {
                            Console.WriteLine(permutacio);
                        }
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.Write("Introdueix el primer número per a Multiplicació Russa: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Introdueix el segon número per a Multiplicació Russa: ");
                        int num2 = int.Parse(Console.ReadLine());
                        int resultat = Recursivitat3.MultiplicacioRussa(num1, num2);
                        Console.WriteLine($"Resultat de Multiplicació Russa: {resultat}");
                        break;
                    case "0":
                            return;
                    default:
                        Console.WriteLine("Opció no vàlida.");
                        break;
                }
                Console.WriteLine("Prem Enter per a tornar al menú de Recursivitat3...");
                Console.ReadLine();
            }
        }

    }
}
