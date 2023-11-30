using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Mi_tiendita
{
    // Clase principal del programa que contiene todos los métodos y la lógica de negocio
    class Program
    {
        // Lista de productos que representa el inventario de la tienda
        static List<Producto> inventario = new List<Producto>();
        // Lista de almacenes que la tienda gestiona
        static List<Almacen> almacenes = new List<Almacen>();

        // Punto de entrada principal del programa
        static void Main(string[] args)
        {
            // Creación e inicialización de almacenes predeterminados
            Almacen central = new Almacen("Central");
            Almacen norte = new Almacen("Norte");
            almacenes.Add(central);
            almacenes.Add(norte);

            // Variable para controlar la continuación del bucle principal
            bool continuar = true;
            while (continuar)
            {
                // Limpieza de la consola para una nueva visualización del menú
                Console.Clear();
                // Presentación del menú principal al usuario
                Console.WriteLine("=============================================");
                Console.WriteLine("||   Sistema de Inventario 'Mi Tiendita'   ||");
                Console.WriteLine("=============================================");
                Console.WriteLine("|| 1. Gestionar Productos                  ||");
                Console.WriteLine("|| 2. Gestionar Almacenes                  ||");
                Console.WriteLine("|| 3. Agregar y Extraer Productos          ||");
                Console.WriteLine("|| 4. Salir                                ||");
                Console.WriteLine("=============================================");
                Console.WriteLine("Seleccione una opción y presione Enter:");

                // Captura de la elección del usuario
                string opcion = Console.ReadLine();
                // Estructura de decisión que dirige al usuario al submenú correspondiente
                switch (opcion)
                {
                    case "1":
                        GestionarProductos();
                        break;
                    case "2":
                        GestionarAlmacenes();
                        break;
                    case "3":
                        AgregarYExtraerProductos();
                        break;
                    case "4":
                        continuar = false; // Salir del programa
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.ReadKey(); // Esperar a que el usuario reconozca el mensaje antes de continuar
                        break;
                }
            }
        }

        // Método que muestra y maneja las operaciones relacionadas con los productos
        static void GestionarProductos()
        {
            // Controla el regreso al menú principal
            bool volver = false;
            while (!volver)
            {
                // Limpieza de la consola y presentación del menú de gestión de productos
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("||    Gestionar Productos - Mi Tiendita    ||");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("|| 1. Agregar Producto                     ||");
                Console.WriteLine("|| 2. Eliminar Producto                    ||");
                Console.WriteLine("|| 3. Modificar Producto                   ||");
                Console.WriteLine("|| 4. Mostrar Inventario                   ||");
                Console.WriteLine("|| 5. Volver al Menú Principal             ||");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Seleccione una opción:");

                // Captura de la elección del usuario para el submenú de productos
                string opcion = Console.ReadLine();
                // Estructura de decisión que invoca el método correspondiente basado en la elección del usuario
                switch (opcion)
                {
                    // Caso para agregar un nuevo producto al inventario
                    case "1":
                        AgregarProducto();
                        break;
                    // Caso para eliminar un producto existente
                    case "2":
                        EliminarProducto();
                        break;
                    // Caso para modificar un producto existente
                    case "3":
                        ModificarProducto();
                        break;
                    // Caso para mostrar todos los productos en el inventario
                    case "4":
                        MostrarInventario();
                        break;
                    // Caso para volver al menú principal
                    case "5":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Método para agregar un nuevo producto al inventario
        static void AgregarProducto()
        {
            // Instrucciones en consola y captura del nombre del producto
            Console.Clear();
            Console.WriteLine("=== Pantalla para Agregar Producto ===");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();

            // Instrucciones en consola y captura del precio del producto
            Console.WriteLine("Ingrese el precio del producto:");
            // Intenta convertir el texto ingresado en un valor decimal para el precio
            if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
            {
                Console.WriteLine("Precio inválido.");
                Console.ReadKey();
                return; // Termina el método si el precio es inválido
            }

            // Instrucciones en consola y captura de la cantidad del producto
            Console.WriteLine("Ingrese la cantidad del producto:");
            // Intenta convertir el texto ingresado en un valor entero para la cantidad
            if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad < 0)
            {
                Console.WriteLine("Cantidad inválida.");
                Console.ReadKey();
                return; // Termina el método si la cantidad es inválida
            }

            // Crea un nuevo producto con los datos ingresados y lo agrega al inventario
            Producto nuevoProducto = new Producto(nombre, precio, cantidad);
            inventario.Add(nuevoProducto);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Producto agregado exitosamente.");
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }

        // Método para eliminar un producto del inventario
        static void EliminarProducto()
        {
            // Instrucciones en consola y captura del nombre del producto a eliminar
            Console.Clear();
            Console.WriteLine("=== Pantalla para Eliminar Producto ===");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Ingrese el nombre del producto a eliminar:");
            string nombre = Console.ReadLine();

            // Busca el producto en el inventario usando Linq y lo elimina si existe
            Producto productoAEliminar = inventario.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (productoAEliminar != null)
            {
                inventario.Remove(productoAEliminar);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado."); // Mensaje si el producto no se encuentra
            }

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }

        // Método para modificar un producto existente en el inventario
        static void ModificarProducto()
        {
            // Instrucciones en consola y captura del nombre del producto a modificar
            Console.Clear();
            Console.WriteLine("=== Pantalla para Modificar Producto ===");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese el nombre del producto a modificar:");
            string nombre = Console.ReadLine();

            // Busca el producto en el inventario usando Linq
            Producto productoAModificar = inventario.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (productoAModificar != null)
            {
                // Si el producto existe, solicita y actualiza el nuevo precio
                Console.WriteLine("Ingrese el nuevo precio:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal nuevoPrecio))
                {
                    Console.WriteLine("Precio inválido.");
                    Console.ReadKey();
                    return; // Termina el método si el precio es inválido
                }

                // Solicita y actualiza la nueva cantidad
                Console.WriteLine("Ingrese la nueva cantidad:");
                if (!int.TryParse(Console.ReadLine(), out int nuevaCantidad) || nuevaCantidad < 0)
                {
                    Console.WriteLine("Cantidad inválida.");
                    Console.ReadKey();
                    return; // Termina el método si la cantidad es inválida
                }

                // Actualiza el producto con los nuevos valores
                productoAModificar.Precio = nuevoPrecio;
                productoAModificar.Cantidad = nuevaCantidad;
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Producto modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado."); // Mensaje si el producto no se encuentra
            }

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }

        // Método para mostrar todos los productos en el inventario
        static void MostrarInventario()
        {
            // Instrucciones en consola para mostrar el inventario
            Console.Clear();
            Console.WriteLine("=== Pantalla para Mostrar Inventario ===");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Inventario Actual:");
            // Itera a través de cada producto en el inventario y los muestra
            foreach (Producto p in inventario)
            {
                Console.WriteLine($"Producto: {p.Nombre} - Precio: ${p.Precio} - Cantidad: {p.Cantidad}");
            }
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }

        // Método que muestra y maneja las operaciones relacionadas con los almacenes
        static void GestionarAlmacenes()
        {
            // Controla el regreso al menú principal
            bool volver = false;
            while (!volver)
            {
                // Limpieza de la consola y presentación del menú de gestión de almacenes
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("||   Gestionar Almacenes - Mi Tiendita   ||");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|| 1. Agregar Almacén                    ||");
                Console.WriteLine("|| 2. Eliminar Almacén                   ||");
                Console.WriteLine("|| 3. Mostrar Almacenes                  ||");
                Console.WriteLine("|| 4. Volver al Menú Principal           ||");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Seleccione una opción:");

                // Captura de la elección del usuario para el submenú de almacenes
                string opcion = Console.ReadLine();
                // Estructura de decisión que invoca el método correspondiente basado en la elección del usuario
                switch (opcion)
                {
                    // Caso para agregar un nuevo almacén
                    case "1":
                        AgregarAlmacen();
                        break;
                    // Caso para eliminar un almacén existente
                    case "2":
                        EliminarAlmacen();
                        break;
                    // Caso para mostrar todos los almacenes
                    case "3":
                        MostrarAlmacenes();
                        break;
                    // Caso para volver al menú principal
                    case "4":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Método para agregar un nuevo almacén a la lista de almacenes
        static void AgregarAlmacen()
        {
            // Instrucciones en consola y captura del nombre del nuevo almacén
            Console.Clear();
            Console.WriteLine("=== Pantalla para Agregar Almacén ===");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese el nombre del nuevo almacén:");
            string nombre = Console.ReadLine();

            // Verifica si ya existe un almacén con el mismo nombre
            var existe = almacenes.Any(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (!existe)
            {
                // Crea un nuevo almacén y lo agrega a la lista si no existe
                Almacen nuevoAlmacen = new Almacen(nombre);
                almacenes.Add(nuevoAlmacen);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Almacén agregado exitosamente.");
            }
            else
            {
                // Mensaje si el almacén ya existe
                Console.WriteLine("Un almacén con ese nombre ya existe.");
            }
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }

        // Método para eliminar un almacén de la lista de almacenes
        static void EliminarAlmacen()
        {
            // Instrucciones en consola y captura del nombre del almacén a eliminar
            Console.Clear();
            Console.WriteLine("=== Pantalla para Eliminar Almacén ===");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ingrese el nombre del almacén a eliminar:");
            string nombre = Console.ReadLine();

            // Busca el almacén en la lista usando Linq y lo elimina si existe
            Almacen almacenAEliminar = almacenes.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (almacenAEliminar != null)
            {
                almacenes.Remove(almacenAEliminar);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Almacén eliminado exitosamente.");
            }
            else
            {
                // Mensaje si el almacén no se encuentra
                Console.WriteLine("Almacén no encontrado.");
            }

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }

        // Método para mostrar todos los almacenes y su información
        static void MostrarAlmacenes()
        {
            // Instrucciones en consola para mostrar los almacenes
            Console.Clear();
            Console.WriteLine("=== Pantalla para Mostrar Almacenes ===");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Lista de Almacenes:");
            // Itera a través de cada almacén en la lista y los muestra
            foreach (Almacen a in almacenes)
            {
                Console.WriteLine($"Almacén: {a.Nombre}");
                // Se podría añadir la visualización del stock llamando al método MostrarStock del almacén
            }
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
        }
        // Método que muestra y maneja las operaciones de agregar y extraer productos de los almacenes
        static void AgregarYExtraerProductos()
        {
            bool volver = false;
            while (!volver)
            {
                // Limpieza de la consola y presentación del menú para agregar y extraer productos
                Console.Clear();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("||  Agregar y Extraer Productos - Mi Tiendita  ||");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|| 1. Ingresar Producto en Almacén             ||");
                Console.WriteLine("|| 2. Extraer Producto de Almacén              ||");
                Console.WriteLine("|| 3. Ver Stock Actual                         ||");
                Console.WriteLine("|| 4. Volver al Menú Principal                 ||");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Seleccione una opción:");

                // Captura de la elección del usuario para agregar o extraer productos
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        IngresarProductoEnAlmacen();
                        break;
                    case "2":
                        ExtraerProductoDeAlmacen();
                        break;
                    case "3":
                        VerStockActual();
                        break;
                    case "4":
                        volver = true; // Regresa al menú principal
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Permite al usuario agregar un producto a un almacén específico
        static void IngresarProductoEnAlmacen()
        {
            Console.Clear();
            Console.WriteLine("=== Pantalla para Ingresar Producto en Almacén ===");
            Console.WriteLine("--------------------------------------------------");
            Almacen almacenSeleccionado = SeleccionarAlmacen();
            if (almacenSeleccionado == null) return;

            Producto productoSeleccionado = SeleccionarProducto();
            if (productoSeleccionado == null) return;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ingrese la cantidad a ingresar:");
            if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                Console.ReadKey();
                return;
            }

            // Agrega el producto y la cantidad especificada al stock del almacén seleccionado
            almacenSeleccionado.AgregarProducto(productoSeleccionado, cantidad);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Producto ingresado en el almacén exitosamente.");
            Console.ReadKey();
        }

        // Permite al usuario extraer un producto de un almacén específico
        static void ExtraerProductoDeAlmacen()
        {
            Console.Clear();
            Console.WriteLine("=== Pantalla para Extraer Producto de Almacén ===");
            Console.WriteLine("--------------------------------------------------");
            Almacen almacenSeleccionado = SeleccionarAlmacen();
            if (almacenSeleccionado == null) return;

            Producto productoSeleccionado = SeleccionarProducto();
            if (productoSeleccionado == null) return;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ingrese la cantidad a extraer:");
            if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                Console.ReadKey();
                return;
            }

            // Extrae la cantidad especificada del producto del stock del almacén seleccionado
            almacenSeleccionado.ExtraerProducto(productoSeleccionado, cantidad);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Producto extraído del almacén exitosamente.");
            Console.ReadKey();
        }

        // Muestra el stock actual de todos los almacenes
        static void VerStockActual()
        {
            Console.Clear();
            Console.WriteLine("=== Pantalla para Ver Stock Actual ===");
            Console.WriteLine("--------------------------------------");
            if (!almacenes.Any())
            {
                Console.WriteLine("No hay almacenes para mostrar.");
            }
            else
            {
                foreach (Almacen almacen in almacenes)
                {
                    Console.WriteLine($"Stock del Almacén '{almacen.Nombre}':");
                    almacen.MostrarStock();
                }
            }
            Console.ReadKey();
        }

        // Auxiliar para seleccionar un almacén de la lista
        static Almacen SeleccionarAlmacen()
        {
            ListarAlmacenes();
            Console.Write("Seleccione el almacén: ");
            string nombreAlmacen = Console.ReadLine();
            Almacen almacenSeleccionado = almacenes.FirstOrDefault(a => a.Nombre.Equals(nombreAlmacen, StringComparison.OrdinalIgnoreCase));
            if (almacenSeleccionado == null)
            {
                Console.WriteLine("Almacén no encontrado.");
                Console.ReadKey();
            }
            return almacenSeleccionado;
        }

        // Auxiliar para seleccionar un producto del inventario
        static Producto SeleccionarProducto()
        {
            ListarProductos();
            Console.Write("Seleccione el producto: ");
            string nombreProducto = Console.ReadLine();
            Producto productoSeleccionado = inventario.FirstOrDefault(p => p.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));
            if (productoSeleccionado == null)
            {
                Console.WriteLine("Producto no encontrado.");
                Console.ReadKey();
            }
            return productoSeleccionado;
        }

        // Muestra todos los almacenes disponibles
        static void ListarAlmacenes()
        {
            Console.WriteLine("Almacenes disponibles:");
            foreach (Almacen almacen in almacenes)
            {
                Console.WriteLine(almacen.Nombre);
            }
            Console.WriteLine("--------------------------------------------------");
        }

        // Muestra todos los productos disponibles en el inventario
        static void ListarProductos()
        {
            Console.WriteLine();
            Console.WriteLine("Productos disponibles:");
            foreach (Producto producto in inventario)
            {
                Console.WriteLine(producto.Nombre);
            }
            Console.WriteLine("--------------------------------------------------");
        }

        // Clase que define la estructura y comportamiento de los productos
        class Producto
        {
            public string Nombre { get; private set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto(string nombre, decimal precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
        }

        // Clase que define la estructura y comportamiento de los almacenes
        class Almacen
        {
            public string Nombre { get; private set; }
            public Dictionary<Producto, int> Stock { get; private set; }

            public Almacen(string nombre)
            {
                Nombre = nombre;
                Stock = new Dictionary<Producto, int>();
            }

            // Agrega productos al stock del almacén
            public void AgregarProducto(Producto producto, int cantidad)
            {
                // Verifica que el producto exista en el inventario antes de agregarlo
                if (!inventario.Contains(producto))
                {
                    Console.WriteLine("Producto no encontrado en el inventario.");
                    return;
                }

                // Agrega o actualiza la cantidad del producto en el stock del almacén
                if (Stock.ContainsKey(producto))
                {
                    Stock[producto] += cantidad;
                }
                else
                {
                    Stock.Add(producto, cantidad);
                }
                Console.WriteLine($"Producto {producto.Nombre} agregado al almacén {Nombre}.");
            }

            // Extrae productos del stock del almacén
            public void ExtraerProducto(Producto producto, int cantidad)
            {
                // Verifica que el producto exista en el stock del almacén antes de extraerlo
                if (!inventario.Contains(producto) || !Stock.ContainsKey(producto))
                {
                    Console.WriteLine("Producto no encontrado en el almacén.");
                    return;
                }

                // Actualiza la cantidad del producto en el stock del almacén
                if (Stock[producto] >= cantidad)
                {
                    Stock[producto] -= cantidad;
                    // Si la cantidad llega a cero, elimina el producto del stock
                    if (Stock[producto] == 0)
                    {
                        Stock.Remove(producto);
                    }
                    Console.WriteLine($"Producto {producto.Nombre} extraído del almacén {Nombre}.");
                }
                else
                {
                    Console.WriteLine("No hay suficiente stock para extraer.");
                }
            }

            // Muestra el stock actual del almacén
            public void MostrarStock()
            {
                // Si el almacén está vacío, muestra un mensaje correspondiente
                if (Stock.Count == 0)
                {
                    Console.WriteLine("El almacén está vacío.");
                    return;
                }

                // Muestra cada producto y su cantidad en el stock del almacén
                foreach (var item in Stock)
                {
                    Console.WriteLine($"Producto: {item.Key.Nombre}, Cantidad: {item.Value}");
                }
            }
        }
    }
}
