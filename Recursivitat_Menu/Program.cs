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
            Console.WriteLine("Selecciona un metode de Recursivitat1:");
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
                    Console.WriteLine("Opció no valida.");
                    break;
            }
        }

        static void ShowRecursivitat2Menu()
        {
            Console.WriteLine("Selecciona un metode de Recursivitat2:");
            Console.WriteLine("1. FibonacciLineal");
            Console.WriteLine("2. EsTriangular");
            // Añade aquí los demás métodos de Recursivitat2
            Console.Write("Ingresa el número del metode (1-2): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine(Recursivitat2.FibonacciLineal(7));
                    break;
                case "2":
                    Console.WriteLine(Recursivitat2.EsTriangular(10));
                    break;
                // Añade aquí los demás casos para cada método de Recursivitat2
                default:
                    Console.WriteLine("Opció no valida.");
                    break;
            }
        }

        static void ShowRecursivitat3Menu()
        {
            Console.WriteLine("Selecciona un metode de Recursivitat3:");
            Console.WriteLine("1. Permutacions");
            // Añade aquí los demás métodos de Recursivitat3
            Console.Write("Ingresa el número del método (1-2): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine(Recursivitat3.Permutacions("ABCD"));
                    break;
                // Añade aquí los demás casos para cada método de Recursivitat3
                default:
                    Console.WriteLine("Opció no valida");
                    break;
            }
        }
    }
}
