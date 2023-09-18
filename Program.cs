// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double limite,factorial,opción;
Console.Write("Ingrese el número límite: ");
limite = double.Parse(Console.ReadLine());
Console.WriteLine("============================");
Console.WriteLine("Escoja una opción: ");
Console.WriteLine("(1) Números pares ");
Console.WriteLine("(2) Números impares ");
Console.WriteLine("(3) Factorial ");
opción = double.Parse(Console.ReadLine());
switch (opción)
{
	case 1:
		Console.Write("Los números pares son: ");
		for (int i = 1; i <= limite; i++)
		{
			if (i % 2 == 0)
			{
				Console.Write(i + ", ");
			}
		}
		break;

	case 2:
        Console.Write("Los números impares son: ");
        for (int i = 1; i <= limite; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + ", ");
            }
        }
        break;

	case 3:
		if (limite == 0)
		{
			Console.WriteLine("El factorial de {0} es: 1" ,limite);
		}
		else
		{
			factorial = 1;
			for (int i = 1; i <= limite; i++)
			{
                factorial = factorial * i;
            }
			Console.WriteLine("El factorial de {0} es: {1}" ,limite,factorial);
		}
		break;

	default:
		Console.WriteLine("Opción inválida");
		break;
}
