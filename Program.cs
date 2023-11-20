using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opción;
            int edad;
            int cont = 0;
            int cont_si = 0;
            int cont_no = 0;
            int[] cont_edades = new int[6];
            string vacunación;
            int[] edades = new int[100];
            string[] vacunas = new string[100];
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Encuesta Covid-19");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Mostrar Datos de la encuesta");
                Console.WriteLine("3: Mostrar Resultados");
                Console.WriteLine("4: Buscar Personas por edad");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                opción = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opción)
                {
                    case 1:
                        Console.WriteLine("================================");
                        Console.WriteLine("Encuesta de vacunación");
                        Console.WriteLine("================================");
                        Console.Write("¿Qué edad tienes?: ");
                        edad = int.Parse(Console.ReadLine());
                        edades[cont] = edad;
                        if (edad >= 1 && edad <= 20)
                        {
                            cont_edades[0]++;
                        }
                        if (edad >= 21 && edad <= 30)
                        {
                            cont_edades[1]++;
                        }
                        if (edad >= 31 && edad <= 40)
                        {
                            cont_edades[2]++;
                        }
                        if (edad >= 41 && edad <= 50)
                        {
                            cont_edades[3]++;
                        }
                        if (edad >= 51 && edad <= 60)
                        {
                            cont_edades[4]++;
                        }
                        if (edad >= 61)
                        {
                            cont_edades[5]++;
                        }
                        Console.WriteLine("------------------");
                        Console.WriteLine("¿Te has vacunado?");
                        Console.WriteLine("Sí");
                        Console.WriteLine("No");
                        Console.WriteLine("===================================");
                        Console.Write("Escriba una opción: ");
                        vacunación = Console.ReadLine();
                        vacunas[cont] = vacunación;
                        cont++;
                        if (vacunación == "Si" || vacunación == "si" || vacunación == "SI")
                        {
                            cont_si++;
                        }
                        else
                        {
                            cont_no++;
                        }
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Encuesta de vacunación");
                        Console.WriteLine("===================================\n\n");
                        Console.WriteLine("¡Gracias por participar!\n\n");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case 2:
                        Console.WriteLine("===================================");
                        Console.WriteLine("Datos de la encuesta");
                        Console.WriteLine("===================================\n");
                        Console.WriteLine("  ID | Edad | Vacunado");
                        Console.WriteLine("=======================");
                        for (int j = 0; j < cont; j++)
                        {
                            Console.WriteLine("   "+j +" |  "+ edades[j]+ "  |   " + vacunas[j]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case 3:
                        Console.WriteLine("===================================");
                        Console.WriteLine("Resultados de la encuesta");
                        Console.WriteLine("===================================\n");
                        Console.WriteLine(cont_si + " personas se han vacunado");
                        Console.WriteLine(cont_no + " personas no se han vacunado\n");
                        Console.WriteLine("Existen:");
                        Console.WriteLine(cont_edades[0] + " personas entre 01 y 20 años");
                        Console.WriteLine(cont_edades[1] + " personas entre 21 y 30 años");
                        Console.WriteLine(cont_edades[2] + " personas entre 31 y 40 años");
                        Console.WriteLine(cont_edades[3] + " personas entre 41 y 50 años");
                        Console.WriteLine(cont_edades[4] + " personas entre 51 y 60 años");
                        Console.WriteLine(cont_edades[5] + " personas de más de 61 años\n");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case 4:
                        cont_si = 0;
                        cont_no = 0;
                        Console.WriteLine("================================");
                        Console.WriteLine("Busca a personas por edad");
                        Console.WriteLine("================================");
                        Console.Write("¿Qué edad quieres buscar?: ");
                        edad = int.Parse(Console.ReadLine());
                        for (int j = 0; j < cont; j++)
                        {
                            if (edad == edades[j] && (vacunas[j] == "Si" || vacunas [j] == "si" || vacunas[j] == "SI"))
                            {
                                cont_si++;
                            }
                            if (edad == edades[j] && (vacunas[j] == "No" || vacunas[j] == "no" || vacunas[j] == "NO"))
                            {
                                cont_no++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine(cont_si + " se vacunaron");
                        Console.WriteLine(cont_no + " no se vacunaron\n");
                        Console.WriteLine("================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
