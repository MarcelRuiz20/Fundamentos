// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int maximo_personas, contador_actual = 0, opcion, personas;

int total_Ingresos = 0, total_Salidas = 0, veces_Lleno = 0, veces_Vacio = 0;

Console.Write("Ingrese un número máximo de personas: ");
maximo_personas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("========================================");
Console.WriteLine($"El número máximo establecido es de {maximo_personas} personas,");
Console.WriteLine("presione una tecla para comenzar a contar.");
Console.ReadKey();

while (true)
{
    Console.Clear(); // Limpiamos la pantalla para una mejor visualización

    Console.WriteLine("========================================");
    Console.WriteLine($"Personas actualmente en la tienda: {contador_actual}");
    Console.WriteLine("1. Registrar entrada de personas.");
    Console.WriteLine("2. Registrar salida de personas.");
    Console.WriteLine("3. Salir.");
    Console.Write("Seleccione una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese número de personas que entran: ");
            personas = Convert.ToInt32(Console.ReadLine());
            if (contador_actual + personas <= maximo_personas)
            {
                contador_actual += personas;
                total_Ingresos += personas;
                if (contador_actual == maximo_personas)
                {
                    veces_Lleno++;
                }
            }
            else
            {
                Console.WriteLine("Superará el límite. No se puede ingresar esa cantidad de personas.");
            }
            break;

        case 2:
            Console.Write("Ingrese número de personas que salen: ");
            personas = Convert.ToInt32(Console.ReadLine());
            if (contador_actual - personas >= 0)
            {
                contador_actual -= personas;
                total_Salidas += personas;
                if (contador_actual == 0)
                {
                    veces_Vacio++;
                }
            }
            else
            {
                Console.WriteLine("No puede salir más gente de la que está dentro.");
            }
            break;

        case 3:
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("====================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{total_Ingresos} personas ingresaron");
            Console.WriteLine($"{total_Salidas} personas salieron");
            Console.WriteLine($"{veces_Lleno} veces se llenó el local");
            Console.WriteLine($"Estuvo vacío {veces_Vacio} veces");
            return;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}