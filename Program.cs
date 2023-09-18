// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Base,exponente,resultado;
Console.Write("Ingrese la base: ");
Base = int.Parse(Console.ReadLine());
Console.Write("Ingrese el exponente: ");
exponente = int.Parse(Console.ReadLine());
resultado = 1;
for (int i = 0; i < exponente; i++)
{
    resultado = resultado * Base;
}
Console.WriteLine("La potencia es: " + resultado);