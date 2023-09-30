// See https://aka.ms/new-console-template for more information
int num_maximo, cont_actual = 0, opcion, num_personas;

Console.Write("Ingrese un número máximo de personas: ");
num_maximo = int.Parse(Console.ReadLine());

Console.WriteLine("========================================");
Console.WriteLine($"El número máximo establecido es de {num_maximo} personas,");
Console.WriteLine("presione una tecla para comenzar a contar.");
Console.ReadKey();

while (true)
{
    Console.WriteLine("========================================");
    Console.WriteLine($"Personas actualmente en la tienda: {cont_actual}");
    Console.WriteLine("1. Registrar entrada de personas.");
    Console.WriteLine("2. Registrar salida de personas.");
    Console.WriteLine("3. Salir.");
    Console.Write("Seleccione una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese número de personas que entran: ");
            num_personas = Convert.ToInt32(Console.ReadLine());
            if (cont_actual + num_personas <= num_maximo)
            {
                cont_actual += num_personas;
            }
            else
            {
                Console.WriteLine("Superará el límite. No se puede ingresar esa cantidad de personas.");
            }
            break;

        case 2:
            Console.Write("Ingrese número de personas que salen: ");
            num_personas = Convert.ToInt32(Console.ReadLine());
            if (cont_actual - num_personas >= 0)
            {
                cont_actual -= num_personas;
            }
            else
            {
                Console.WriteLine("No puede salir más gente de la que está dentro.");
            }
            break;

        case 3:
            Console.WriteLine("Finalizando programa.");
            return;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}