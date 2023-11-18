using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opción;
            int elección_de_nivel;
            int cont = 0;
            int[] niveles = new int[100];
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Encuestas de Calidad");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta ");
                Console.WriteLine("2: Ver datos registrados ");
                Console.WriteLine("3: Eliminar un dato ");
                Console.WriteLine("4: Ordenar datos de menor a mayor ");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                opción = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opción)
                {
                    case 1:
                        Console.WriteLine("===================================");
                        Console.WriteLine("Nivel de Satisfacción ");
                        Console.WriteLine("===================================");
                        Console.WriteLine("¿Qué tan satisfecho está con la");
                        Console.WriteLine("atención de nuestra tienda?");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("1: Nada satisfecho");
                        Console.WriteLine("2: No muy satisfecho");
                        Console.WriteLine("3: Tolerable");
                        Console.WriteLine("4: Satisfecho");
                        Console.WriteLine("5: Muy satisfecho");
                        Console.WriteLine("===================================");
                        Console.Write("Ingrese una opción: ");
                        elección_de_nivel = int.Parse(Console.ReadLine());
                        niveles[cont] = elección_de_nivel;
                        cont++;
                        Console.Clear();
                        Console.WriteLine("=================================== ");
                        Console.WriteLine("Nivel de Satisfacción ");
                        Console.WriteLine("=================================== ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("¡Gracias por participar!");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("=================================== ");
                        Console.WriteLine("Presione una tecla para");
                        Console.WriteLine("regresar al menú . . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        int num,nivel_1 = 0,nivel_2 = 0,nivel_3 = 0,nivel_4 = 0,nivel_5 = 0;
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ver datos registrados");
                        Console.WriteLine("===================================");
                        for (int j = 0; j < cont; j++)
                        {
                            if (j % 5 == 0 && j != 0)
                            {
                                Console.WriteLine();
                            }
                            Console.Write("["+niveles[j]+ "] ");
                        }

                        for (int j = 0; j < niveles.Length; j++)
                        {
                            num = niveles[j];
                            if (num == 1)
                            {
                                nivel_1++;
                            }
                            if (num == 2)
                            {
                                nivel_2++;
                            }
                            if (num == 3)
                            {
                                nivel_3++;
                            }
                            if (num == 4) 
                            {
                                nivel_4++;
                            }
                            if (num == 5)
                            {
                                nivel_5++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine(" " + nivel_1 + " personas: Nada satisfecho");
                        Console.WriteLine(" " + nivel_2 + " personas: No muy satisfecho");
                        Console.WriteLine(" " + nivel_3 + " personas: Tolerable");
                        Console.WriteLine(" " + nivel_4 + " personas: Satisfecho");
                        Console.WriteLine(" " + nivel_5 + " personas: Muy satisfecho");
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        int posición;
                        Console.WriteLine("===================================");
                        Console.WriteLine("Eliminar un dato");
                        Console.WriteLine("===================================\n");
                        for (int j = 0; j < cont; j++)
                        {
                            if (j % 5 == 0 && j != 0)
                            {
                                Console.WriteLine();
                            }
                            Console.Write(j + ":[" + niveles[j] + "] ");
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("===================================");
                        Console.Write("Ingrese la posición a eliminar: ");
                        posición = int.Parse(Console.ReadLine());
                        int[] NuevoNiveles = new int[niveles.Length - 1]; 

                        for (int j = 0; j < niveles.Length - 1; j++)
                        {
                            if (posición > j)
                            {
                                NuevoNiveles[j] = niveles[j];
                            }
                            else
                            {
                                NuevoNiveles[j] = niveles[j + 1];
                            }
                        }
                        Console.WriteLine("===================================\n");
                        for (int j = 0; j < cont - 1; j++)
                        {
                            if (j % 5 == 0 && j != 0)
                            {
                                Console.WriteLine();
                            }
                            Console.Write(j + ":[" + NuevoNiveles[j] + "] ");
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        Console.Clear();
                            break;
                    case 4:
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ordenar datos");
                        Console.WriteLine("===================================\n");
                        Console.WriteLine("Datos ingresados:\n");
                        for (int j = 0; j < cont; j++)
                        {
                            if (j % 5 == 0 && j != 0)
                            {
                                Console.WriteLine();
                            }
                            Console.Write(j + ":[" + niveles[j] + "] ");
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ordenando ...");
                        Console.WriteLine("===================================\n");
                        for (int a = 0; a < cont; a++)
                        {
                            for (int j = a + 1; j < cont; j++)
                            {
                                int aux;
                                if (niveles[a] > niveles[j])
                                {
                                    aux = niveles[a];
                                    niveles[a] = niveles[j];
                                    niveles[j] = aux;
                                }
                            }
                        }
                        Console.ReadKey();
                        Console.WriteLine("Datos ordenados:\n");
                        for (int j = 0; j < cont; j++)
                        {
                            if (j % 5 == 0 && j != 0)
                            {
                                Console.WriteLine();
                            }
                            Console.Write(j + ":[" + niveles[j] + "] ");
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                }

            }
        }

    }
}
