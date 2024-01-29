namespace Recursivitat_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecciona una lista de funciones:");
                Console.WriteLine("1. Recursivitat1");
                Console.WriteLine("2. Recursivitat2");
                Console.WriteLine("3. Recursivitat3");
                Console.WriteLine("0. Salir");

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
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void ShowRecursivitat1Menu()
        {
            Console.WriteLine("Selecciona un método de Recursivitat1:");
            Console.WriteLine("1. SumaDigits");
            Console.WriteLine("2. SumaProducteAmbSumes");
            // Añade aquí los demás métodos de Recursivitat1
            Console.Write("Ingrese el número del método (1-2): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine(Recursivitat1.SumaDigits(11111));
                    break;
                case "2":
                    Console.WriteLine(Recursivitat1.SumaProducteAmbSumes(2, 3));
                    break;
                // Añade aquí los demás casos para cada método de Recursivitat1
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Resto de la clase Recursivitat2

        static void ShowRecursivitat2Menu()
        {
            Console.WriteLine("Selecciona un metode de Recursivitat2:");
            Console.WriteLine("1. FibonacciLineal");
            Console.WriteLine("2. EsTriangular");
            // Añade aquí los demás métodos de Recursivitat2
            Console.Write("Ingrese el número del método (1-2): ");
            Console.WriteLine("Selecciona un mètode de Recursivitat2:");
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

            Console.Write("Selecciona un número per executar el mètode corresponent: ");
            int opcio = int.Parse(Console.ReadLine());

            switch (opcio)
            {
                case 1:
                    Console.Write("Introdueix el valor de n: ");
                    int nFibonacci = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.FibonacciLineal(nFibonacci)}");
                    break;
                case 2:
                    Console.Write("Introdueix el número a verificar si és primer: ");
                    int numeroPrimer = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.EsPrimer(numeroPrimer)}");
                    break;
                case 3:
                    Console.Write("Introdueix el valor de n: ");
                    int nTriangular = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.EsTriangular(nTriangular)}");
                    break;
                case 4:
                    Console.Write("Introdueix el dividend: ");
                    int dividend = int.Parse(Console.ReadLine());
                    Console.Write("Introdueix el divisor: ");
                    int divisor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.DivisioEntera(dividend, divisor)}");
                    break;
                case 5:
                    Console.Write("Introdueix el número a invertir: ");
                    int numInvertir = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.InvertirNumero(numInvertir)}");
                    break;
                case 6:
                    Console.Write("Introdueix el valor de a: ");
                    int aMCD = int.Parse(Console.ReadLine());
                    Console.Write("Introdueix el valor de b: ");
                    int bMCD = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.MCD(aMCD, bMCD)}");
                    break;
                case 7:
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
                    Console.Write("Introdueix el número a interpretar: ");
                    int numInterpretar = int.Parse(Console.ReadLine());
                    Console.Write("Introdueix la base: ");
                    int baseInterpretar = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.InterpretarBase(numInterpretar, baseInterpretar)}");
                    break;
                case 9:
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
                    Console.Write("Introdueix el número a verificar: ");
                    int numEsBase = int.Parse(Console.ReadLine());
                    Console.Write("Introdueix la base: ");
                    int baseEsBase = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultat: {Recursivitat2.EsBase(numEsBase, baseEsBase)}");
                    break;

                case 11:
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

                    Console.WriteLine($"Resultat: {Recursivitat2.InterseccioBuida(vectorAInterseccioBuida, vectorBInterseccioBuida, longitudVectorsInterseccioBuida - 1, longitudVectorsInterseccioBuida - 1)}");
                    break;


                default:
                    Console.WriteLine("Opción no válida.");
                    Console.WriteLine("Opció no vàlida.");
                    break;
            }

        }




        static void ShowRecursivitat3Menu()
        {
            Console.WriteLine("Selecciona un metode de Recursivitat3:");
            Console.WriteLine("1. Permutacions");
            // Añade aquí los demás métodos de Recursivitat3
            Console.Write("Ingrese el número del método (1): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine(string.Join("\n", Recursivitat3.Permutacions("ABCD")));
                    break;
                // Añade aquí los demás casos para cada método de Recursivitat3
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
