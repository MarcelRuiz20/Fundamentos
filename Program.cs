// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num_notas;
float promedio_final,nota, suma_notas;
Console.Write("Ingrese el número de notas: ");
num_notas = int.Parse(Console.ReadLine());
suma_notas = 0;
for (int i = 1; i <= num_notas; i++)
{
    Console.Write("Ingrese la nota " + i + ": ");
    nota = int.Parse(Console.ReadLine());
    suma_notas = suma_notas + nota;
}
promedio_final = suma_notas / num_notas;
Console.WriteLine("El promedio es " + promedio_final);