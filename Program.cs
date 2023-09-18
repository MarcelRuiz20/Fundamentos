// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num_1,num_2,resultado;
Console.Write("Ingrese el primer número: ");
num_1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num_2 = int.Parse(Console.ReadLine());
resultado = 0;
for (int i = 0; i < num_2; i++)
{
    resultado = resultado + num_1;
}
Console.WriteLine("El producto es: "+resultado);