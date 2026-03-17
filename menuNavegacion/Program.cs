using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Entrando al menú de libros...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Entrando al menú de usuarios...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Entrando al menú de préstamos...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Entrando a búsquedas y reportes...");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Entrando a guardar/cargar datos...");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
