// See https://aka.ms/new-console-template for more information
double mont_consumo,mont_descuento,precio_descontado,impuesto,total_a_pagar;
Console.WriteLine("Ingrese el monto de su consumo ");
mont_consumo = double.Parse(Console.ReadLine());
if (mont_consumo <= 100)
{
    mont_descuento = mont_consumo * 0.1;
    precio_descontado = mont_consumo - mont_descuento;
    impuesto = precio_descontado * 0.18;
    total_a_pagar= precio_descontado + impuesto;
    Console.WriteLine("Factura:");
    Console.WriteLine("********");
    Console.WriteLine("El monto del descuento es: "+mont_descuento);
    Console.WriteLine("El impuesto es: "+impuesto);
    Console.WriteLine("El sub total es: "+precio_descontado);
    Console.WriteLine("El importe a pagar es: "+total_a_pagar);
}
if (mont_consumo > 100)
{
    mont_descuento = mont_consumo * 0.2;
    precio_descontado = mont_consumo - mont_descuento;
    impuesto = precio_descontado * 0.18;
    total_a_pagar = precio_descontado + impuesto;
    Console.WriteLine("Factura:");
    Console.WriteLine("********");
    Console.WriteLine("El monto del descuento es: " + mont_descuento);
    Console.WriteLine("El impuesto es: " + impuesto);
    Console.WriteLine("El sub total es: " + precio_descontado);
    Console.WriteLine("El importe a pagar es: " + total_a_pagar);
}
