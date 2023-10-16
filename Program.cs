// See https://aka.ms/new-console-template for more information
int primera_eleccion;int segunda_eleccion = 0;int tercera_eleccion; int opción_segunda_eleccion = 0; int cantidad;
double suma_cant_venta_1 = 0, suma_cant_venta_2 = 0, suma_cant_venta_3 = 0, suma_cant_venta_4 = 0;
double suma_cant_devolución_1 = 0, suma_cant_devolución_2 = 0, suma_cant_devolución_3 = 0, suma_cant_devolución_4 = 0;
double total_1, total_2, total_3, total_4; double total_rubro_1, total_rubro_2, total_rubro_3, total_rubro_4;
double suma_producto_venta_1 = 0, suma_producto_venta_2 = 0, suma_producto_venta_3 = 0, suma_producto_venta_4 = 0;
double suma_producto_devolución_1 = 0, suma_producto_devolución_2 = 0, suma_producto_devolución_3 = 0, suma_producto_devolución_4 = 0;
double precio , producto_venta ,producto_devolución = 0, total_general;
do
{
    Console.WriteLine("==========================");
    Console.WriteLine("Tienda de don Lucas ");
    Console.WriteLine("==========================");
    Console.WriteLine("1: Registrar venta ");
    Console.WriteLine("2: Registrar devolucion ");
    Console.WriteLine("3: Cerrar caja ");
    Console.WriteLine("==========================");
    Console.Write("Ingrese una opcion: ");
    primera_eleccion = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (primera_eleccion)
    {
        case 1:
            Console.WriteLine("==========================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("==========================");
            Console.WriteLine("1: Limpieza ");
            Console.WriteLine("2: Abarrotes ");
            Console.WriteLine("3: Golosinas ");
            Console.WriteLine("4: Electronicos ");
            Console.WriteLine("5: <- Regresar ");
            Console.WriteLine("==========================");
            Console.Write("Ingrese una opcion: ");
            segunda_eleccion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (segunda_eleccion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar venta de Limpieza");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han ingresado " + cantidad + " unidades");
                        producto_venta = cantidad * precio;
                        Console.WriteLine("Se han ingresado S/ " + producto_venta + " en caja");
                        suma_cant_venta_1 += cantidad;
                        suma_producto_venta_1 += producto_venta;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Registrar más productos de limpieza");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();

                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar venta de Abarrotes");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han ingresado " + cantidad + " unidades");
                        producto_venta = cantidad * precio;
                        Console.WriteLine("Se han ingresado S/ " + producto_venta + " en caja");
                        suma_cant_venta_2 += cantidad;
                        suma_producto_venta_2 += producto_venta;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Registrar más productos de Abarrotes");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear() ;   
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar venta de Golosinas");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han ingresado " + cantidad + " unidades");
                        producto_venta = cantidad * precio;
                        Console.WriteLine("Se han ingresado S/ " + producto_venta + " en caja");
                        suma_cant_venta_3 += cantidad;
                        suma_producto_venta_3 += producto_venta;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Registrar más productos de Golosinas");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();
                    break;
                case 4:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar venta de Electronicos");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han ingresado " + cantidad + " unidades");
                        producto_venta = cantidad * precio;
                        Console.WriteLine("Se han ingresado S/ " + producto_venta + " en caja");
                        suma_cant_venta_4 += cantidad;
                        suma_producto_venta_4 += producto_venta;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Registrar más productos de Electronicos");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();
                    break;
            }
            break;
        case 2:
            Console.WriteLine("==========================");
            Console.WriteLine("Registrar devolucion de:");
            Console.WriteLine("==========================");
            Console.WriteLine("1: Limpieza ");
            Console.WriteLine("2: Abarrotes ");
            Console.WriteLine("3: Golosinas ");
            Console.WriteLine("4: Electronicos ");
            Console.WriteLine("5: <- Regresar ");
            Console.WriteLine("==========================");
            Console.Write("Ingrese una opcion: ");
            segunda_eleccion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (segunda_eleccion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar devolucion de Limpieza");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han regresado " + cantidad + " unidades");
                        producto_devolución = cantidad * precio;
                        Console.WriteLine("Se han devuelto S/ " + producto_devolución + " de caja");
                        suma_cant_devolución_1 += cantidad;
                        suma_producto_devolución_1 += producto_devolución;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Devolver más productos de limpieza");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar devolucion de Abarrotes");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han regresado " + cantidad + " unidades");
                        producto_devolución = cantidad * precio;
                        Console.WriteLine("Se han devuelto S/ " + producto_devolución + " de caja");
                        suma_cant_devolución_2 += cantidad;
                        suma_producto_devolución_2 += producto_devolución;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Devolver más productos de Abarrotes");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar devolucion de Golosinas");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han regresado " + cantidad + " unidades");
                        producto_devolución = cantidad * precio;
                        Console.WriteLine("Se han devuelto S/ " + producto_devolución + " de caja");
                        suma_cant_devolución_3 += cantidad;
                        suma_producto_devolución_3 += producto_devolución;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Devolver más productos de Golosinas");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();
                    break;
                case 4:
                    do
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar devolucion de Electronicos");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese cantidad de unidades: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: S/ ");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("================================");
                        Console.WriteLine("Se han regresado " + cantidad + " unidades");
                        producto_devolución = cantidad * precio;
                        Console.WriteLine("Se han devuelto S/ " + producto_devolución + " de caja");
                        suma_cant_devolución_4 += cantidad;
                        suma_producto_devolución_4 += producto_devolución;
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Devolver más productos de Electronicos");
                        Console.WriteLine("2: <- Regresar");
                        Console.WriteLine("================================");
                        Console.WriteLine("Ingrese una opción:");
                        opción_segunda_eleccion = int.Parse(Console.ReadLine());
                    } while (opción_segunda_eleccion == 1);
                    Console.Clear();
                    break;
            }
            break;
        case 3:
            total_1 = suma_cant_venta_1 - suma_cant_devolución_1;
            total_2 = suma_cant_venta_2 - suma_cant_devolución_2;
            total_3 = suma_cant_venta_3 - suma_cant_devolución_3;
            total_4 = suma_cant_venta_4 - suma_cant_devolución_4;

            total_rubro_1 = suma_producto_venta_1 - suma_producto_devolución_1;
            total_rubro_2 = suma_producto_venta_2 - suma_producto_devolución_2;
            total_rubro_3 = suma_producto_venta_3 - suma_producto_devolución_3;
            total_rubro_4 = suma_producto_venta_4 - suma_producto_devolución_4;

            Console.WriteLine("===============================");
            Console.WriteLine("Cerrando caja");
            Console.WriteLine("===============================");
            Console.WriteLine("Totales");
            Console.WriteLine("===============================");
            Console.WriteLine("           |    " + suma_cant_venta_1 + " vendidos");
            Console.WriteLine("Limpieza   |    " + suma_cant_devolución_1 + " devueltos");
            Console.WriteLine("           |    " + total_1 + " en total"                 );
            Console.WriteLine("           |    S/ " + total_rubro_1 + " en caja");
            Console.WriteLine("===============================");
            Console.WriteLine("           |    " + suma_cant_venta_2 + " vendidos");
            Console.WriteLine("Abarrotes  |    " + suma_cant_devolución_2 + " devueltos");
            Console.WriteLine("           |    " + total_2 + " en total");
            Console.WriteLine("           |    S/ " + total_rubro_2 + " en caja");
            Console.WriteLine("===============================");
            Console.WriteLine("           |    " + suma_cant_venta_3 + " vendidos");
            Console.WriteLine("Golosinas  |    " + suma_cant_devolución_3 + " devueltos");
            Console.WriteLine("           |    " + total_3 + " en total");
            Console.WriteLine("           |    S/ " + total_rubro_3 + " en caja");
            Console.WriteLine("===============================");
            Console.WriteLine("           |    " + suma_cant_venta_4 + " vendidos");
            Console.WriteLine("Eletro     |    " + suma_cant_devolución_4 + " devueltos");
            Console.WriteLine("           |    " + total_4 + " en total");
            Console.WriteLine("           |    S/ " + total_rubro_4 + " en caja");
            Console.WriteLine("===============================");
            
            total_general = total_rubro_1 + total_rubro_2 + total_rubro_3 + total_rubro_4;
            Console.WriteLine("Queda en caja " + total_general);
            Console.ReadKey();
            break;
    }
} while (segunda_eleccion == 5 || opción_segunda_eleccion == 2);