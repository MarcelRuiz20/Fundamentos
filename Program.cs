// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num_dias,categoria_hotel,mont_tarifa,precio_diario,sub_total,pago_total,costo_desayuno_diario,costo_desayuno_total;
Console.WriteLine("Ingrese la cantidad de dias de su estadia en el hotel");
num_dias = int.Parse(Console.ReadLine());
Console.WriteLine("Elija una categoria de hotel, colocando el numero correspondiente");
Console.WriteLine("Tres estrellas (3)");
Console.WriteLine("Cinco estrellas (5)");
categoria_hotel = int.Parse(Console.ReadLine());
if (num_dias >= 1 && num_dias <= 5)
{
    if (categoria_hotel == 3)
    {
        precio_diario = 100;
        sub_total = precio_diario * num_dias;
        // Precio total del desayuno
        costo_desayuno_diario = 7;
        costo_desayuno_total = costo_desayuno_diario * num_dias;
        // Precio final que debe pagar 
        pago_total = costo_desayuno_total + sub_total;
        Console.WriteLine("El pago que debe realizar es: "+pago_total+" soles");
    }
    else if (categoria_hotel == 5)
    {
        precio_diario = 300;
        sub_total = precio_diario * num_dias;
        // Precio total del desayuno
        costo_desayuno_diario = 7;
        costo_desayuno_total = costo_desayuno_diario * num_dias;
        // Precio final que debe pagar 
        pago_total = costo_desayuno_total + sub_total;
        Console.WriteLine("El pago que debe realizar es: " +pago_total+" soles");
    }
    else
    {
        Console.WriteLine("Opción invalida");
    }
}
else if (num_dias >= 6 && num_dias <= 10)
{
    if (categoria_hotel == 3)
    {
        precio_diario = 85;
        sub_total = precio_diario * num_dias;
        // Precio total del desayuno
        costo_desayuno_diario = 7;
        costo_desayuno_total = costo_desayuno_diario * num_dias;
        // Precio final que debe pagar 
        pago_total = costo_desayuno_total + sub_total;
        Console.WriteLine("El pago que debe realizar es: " +pago_total+" soles");
    }
    else if (categoria_hotel == 5)
    {
        precio_diario = 270;
        sub_total = precio_diario * num_dias;
        // Precio total del desayuno
        costo_desayuno_diario = 7;
        costo_desayuno_total = costo_desayuno_diario * num_dias;
        // Precio final que debe pagar 
        pago_total = costo_desayuno_total + sub_total;
        Console.WriteLine("El pago que debe realizar es: " +pago_total+" soles");
    }
    else
    {
        Console.WriteLine("Opción invalida");
    }
}
else if (num_dias >= 11)
{
    if (categoria_hotel == 3)
    {
        precio_diario = 70;
        sub_total = precio_diario * num_dias;
        // Precio total del desayuno
        costo_desayuno_diario = 7;
        costo_desayuno_total = costo_desayuno_diario * num_dias;
        // Precio final que debe pagar 
        pago_total = costo_desayuno_total + sub_total;
        Console.WriteLine("El pago que debe realizar es: " +pago_total+" soles");
    }
    else if (categoria_hotel == 5)
    {
        precio_diario = 250;
        sub_total = precio_diario * num_dias;
        // Precio total del desayuno
        costo_desayuno_diario = 7;
        costo_desayuno_total = costo_desayuno_diario * num_dias;
        // Precio final que debe pagar 
        pago_total = costo_desayuno_total + sub_total;
        Console.WriteLine("El pago que debe realizar es: " +pago_total+" soles");
    }
    else
    {
        Console.WriteLine("Opción invalida");
    }
}