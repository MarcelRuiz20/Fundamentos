// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int edad,cant_adivinanzas,mont_inicial,mont_final;
Console.WriteLine("Ingrese su edad ");
edad = int.Parse(Console.ReadLine()); 
Console.WriteLine("Ingrese la cantidad de adivinanzas que acertó");
Console.WriteLine("Debe ser como minimo 1 y como maximo 5");
cant_adivinanzas = int.Parse(Console.ReadLine());   
if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad");
	if (cant_adivinanzas < 3)
	{
		mont_inicial = 30;
		Console.WriteLine("Por haber acertado menos de 3 adivinanzas" +
            " se ganó: "+mont_inicial+" soles");
	}
    else if (cant_adivinanzas >= 3 && cant_adivinanzas < 5)
    {
        mont_inicial = 50;
        Console.WriteLine("Por haber acertado 3 o más adivinanzas" +
         " se ganó: " + mont_inicial + " soles");

    }
    else if (cant_adivinanzas == 5)
    {
        mont_inicial = 50;
        mont_final = mont_inicial + 5 * edad + 2 * cant_adivinanzas;
        Console.WriteLine("Felicidades, es el ganador del sorteo " +
            "ya que acertó las 5 adivinanzas");
        Console.WriteLine("Por ello se ha ganado la suma de "+mont_final+" soles");
    }
    else
    {
        Console.WriteLine("Opción invalida");
    }
}
if (edad < 18)
{
    Console.WriteLine("Es menor de edad");
    if (cant_adivinanzas < 3)
    {
        mont_inicial = 50;
        Console.WriteLine("Por haber acertado menos de 3 adivinanzas" +
            " se ganó: " + mont_inicial + " soles");
    }
    else if (cant_adivinanzas >= 3 && cant_adivinanzas < 5)
    {
        mont_inicial = 80;
        Console.WriteLine("Por haber acertado 3 o más adivinanzas" +
            " se ganó: " + mont_inicial + " soles");

    }
    else if (cant_adivinanzas == 5)
    {
        mont_inicial = 80;
        mont_final = mont_inicial + 5 * edad + 2 * cant_adivinanzas;
        Console.WriteLine("Felicidades, es el ganador del sorteo " +
            "ya que acertó las 5 adivinanzas");
        Console.WriteLine("Por ello se ha ganado la suma de " + mont_final + " soles");
    }
    else
    {
        Console.WriteLine("Opción invalida");
    }
}