using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloEV2
{
     class Program
     {
        static void Main(string[] args)
        {
            #region declaracion de variables y obejtos
            bool exit = false;
            ListaProductos LP = new ListaProductos();
            
            #endregion

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("-------------- Bienvenido a Trueque --------------");
                Console.WriteLine();
                Console.WriteLine("1 - ¿ Desea crear un nuevo usuario ?");
                Console.WriteLine("2 - Ver trueques disponibles ");
                Console.WriteLine("3 - ¿ Buscar un producto en la bodega ?");
                Console.WriteLine("4 - ¿ Agregar un producto a la bodega ?");
                Console.WriteLine("5 - Mostrar productos en bodega");
                Console.WriteLine("6 - Buscar trueques sin match");
                Console.WriteLine("7 - Salir de Trueque ");
                Console.WriteLine();

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-------------- Creación de usuario --------------");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el nombre del usuario:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del producto que desea intercambiar:");
                        string desc = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor aproximado que desea obtener por el producto:");
                        string valor = Console.ReadLine();
                        Console.WriteLine("Ingrese su primera preferencia de producto para el trueque:");
                        string p1 = Console.ReadLine();
                        Console.WriteLine("Ingrese su segunda preferencia de producto para el trueque:");
                        string p2 = Console.ReadLine();
                        Console.WriteLine("Ingrese su tercera preferencia de producto para el trueque:");
                        string p3 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Se creará el usuario: " + nombre);
                        Console.WriteLine("Con el producto: " + desc);
                        Console.WriteLine("Por un valor aproximado de: " + valor);
                        Console.WriteLine("Sus preferencias de trueque son: " + p1 + ", " + p2 + ", " + p3);
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para confirmar");
                        Console.ReadLine();
                        Console.WriteLine(DateTime.Now + " ¡ Usuario creado con éxito !");
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para volver al menú...");
                        string fecha = DateTime.Now.ToString();
                        LP.CreacionUsuario(nombre, valor, p1, p2, p3);
                        LP.ObjetoTrueque(desc, fecha);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        LP.MostrarObjetos();
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para volver al menú...");
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Clear();
                        LP.MostrarSinMatch();
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para volver al menú...");
                        break;
                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("Presione ENTER para cerrar la aplicación...");
                        exit = true;
                        break;
                }

                Console.ReadKey();
            }
        }
     }
}
