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
                Console.WriteLine("1 - ¿ Crear un usuario ?");
                Console.WriteLine("2 - Ver trueques disponibles ");
                Console.WriteLine("3 - ¿ Quieres intercambiar algo ?");
                Console.WriteLine("4 - Ver lista de trueques completados");
                Console.WriteLine("5 - Buscar productos por valor");
                Console.WriteLine("6 - Buscar trueques sin match");
                Console.WriteLine("7 - Salir de Trueque");
                Console.WriteLine();

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------ Creación de usuario ------------");
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
                        Console.WriteLine("Por un valor de: " + valor);
                        Console.WriteLine("Sus preferencias de trueque son: " + p1 + ", " + p2 + ", " + p3);
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para confirmar");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(DateTime.Now + " ¡ Usuario creado con éxito !");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para volver al menú...");
                        string fecha = DateTime.Now.ToShortDateString();
                        LP.CreacionUsuario(nombre, valor, p1, p2, p3);
                        LP.ObjetoTrueque(desc, fecha, valor);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        LP.MostrarObjetos();
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para volver al menú...");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("------------ Sección de intercambio ------------");
                        Console.WriteLine();
                        Console.WriteLine("Por favor ingrese el nombre de un producto para hacer match: ");
                        string match = Console.ReadLine();
                        LP.Match(match);
                        break;
                    case 4:
                        Console.Clear();
                        LP.MostrarTruequesCompletados();
                        Console.WriteLine();
                        Console.WriteLine("Presione la tecla ENTER para volver al menú...");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("------------ Busqueda por valor ------------");
                        Console.WriteLine();
                        Console.WriteLine("Por favor ingrese el valor del producto para iniciar la busqueda: ");
                        string v = Console.ReadLine();
                        LP.BuscarObjetos(v);
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
