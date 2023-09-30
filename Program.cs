// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num_maximo, cont_actual = 0;
int vecesLleno = 0, vecesVacio = 0;

Console.Write("Ingrese un número máximo de personas: ");
num_maximo = Convert.ToInt32(Console.ReadLine());
Console.Clear();

while (true)
{
    double porcentajeAforo = ((double)cont_actual / num_maximo) * 100;

    Console.WriteLine($"| Asistentes actuales | {cont_actual}\n| Aforo               | {porcentajeAforo}%\n| Máximo              | {num_maximo} personas\n====================================\nPresione\n[ i ] si ingresa una persona\n[ s ] si sale una persona\n[ x ] para terminar");
    char opcion = Console.ReadKey().KeyChar;

    if (opcion == 'i' && cont_actual < num_maximo)
    {
        cont_actual++;
        if (cont_actual == num_maximo) vecesLleno++;
    }
    else if (opcion == 's' && cont_actual > 0)
    {
        cont_actual--;
        if (cont_actual == 0) vecesVacio++;
    }
    else if (opcion == 'x')
    {
        Console.Clear();
        Console.WriteLine($"=================================\nEl programa ha terminado\n====================================\nEstadísticas:\n----------------------------------\n{vecesLleno} veces se llenó el local\nEstuvo vacío {vecesVacio} veces");
        return;
    }

    Console.Clear();
}