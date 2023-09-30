// See https://aka.ms/new-console-template for more information
int maximo_personas = 50, contador_actual = 3;

while (true)
{
    Console.Clear();

    double porcentajeAforo = ((double)contador_actual / maximo_personas) * 100;

    Console.WriteLine($"=================================\n| Asistentes actuales | {contador_actual}\n| Aforo               | {porcentajeAforo:0.00}%\n| Máximo              | {maximo_personas} personas\n====================================\nPresione\n[ i ] si ingresa una persona\n[ s ] si sale una persona\n[ x ] para terminar");
    char opcion = Console.ReadKey().KeyChar;

    if (opcion == 'i' && contador_actual < maximo_personas)
    {
        contador_actual++;
    }
    else if (opcion == 's' && contador_actual > 0)
    {
        contador_actual--;
    }
    else if (opcion == 'x')
    {
        return;
    }
}