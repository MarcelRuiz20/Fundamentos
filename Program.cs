// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num1, num2, num3;
Console.WriteLine("Ingrese tres numeros enteros de distinto valor.");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("El numero mayor es: " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("El numero mayor es: " + num2);
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("El numero mayor es: " + num3);
}
