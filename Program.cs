// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int tipo_fruta,distancia,pago_total;
Console.WriteLine("Elija el tipo de fruta colocando el numero correspondiente.");
Console.WriteLine("Naranja (1)");
Console.WriteLine("Fresa (2)");
Console.WriteLine("Mango (3)");
tipo_fruta = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la distancia. ");
distancia = int.Parse(Console.ReadLine());
if (tipo_fruta == 1)
{
	if (distancia < 30)
	{
		pago_total = 2; 
		Console.WriteLine("El pago que debe realizar es: "+pago_total+" soles");
	}
	else
	{
        pago_total = 4;
        Console.WriteLine("El pago que debe realizar es: " + pago_total + " soles");
    }
}
else if (tipo_fruta == 2)
{
    if (distancia < 30)
    {
        pago_total = 6;
        Console.WriteLine("El pago que debe realizar es: " + pago_total + " soles");
    }
    else
    {
        pago_total = 9;
        Console.WriteLine("El pago que debe realizar es: " + pago_total + " soles");
    }
}
else if (tipo_fruta == 3)
{
    if (distancia < 30)
    {
        pago_total = 3;
        Console.WriteLine("El pago que debe realizar es: " + pago_total + " soles");
    }
    else
    {
        pago_total = 5;
        Console.WriteLine("El pago que debe realizar es: " + pago_total + " soles");
    }
}
else
{
    Console.WriteLine("Opción invalida");
}
