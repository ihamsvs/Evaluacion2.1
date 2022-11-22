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
                Console.WriteLine("-------------- Bienvenido a Trueque --------------");
                Console.WriteLine("1 - ¿ Crear un usuario ?");
                Console.WriteLine("2 - Ver trueques disponibles ");
                Console.WriteLine("3 - ¿ Buscar un producto en la bodega ?");
                Console.WriteLine("4 - ¿ Agregar un producto a la bodega ?");
                Console.WriteLine("5 - Mostrar productos en bodega");
                Console.WriteLine("6 - Buscar trueques sin match");
                Console.WriteLine("7 - Salir de Trueque ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------ Creacion de usuario ------------");
                        Console.WriteLine("Ingrese el nombre de usuario");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese una descripcion");
                        string desc = Console.ReadLine();
                        Console.WriteLine("Ingrese un valor aproximado");
                        string valor = Console.ReadLine();
                        Console.WriteLine("Ingrese su primera preferencia para el trueque");
                        string p1 = Console.ReadLine();
                        Console.WriteLine("Ingrese su segunda preferencia para el trueque");
                        string p2 = Console.ReadLine();
                        Console.WriteLine("Ingrese su tercera preferencia para el trueque");
                        string p3 = Console.ReadLine();
                        LP.CreacionUsuario(nombre, valor, p1, p2, p3);
                        LP.ObjetoTrueque(desc);
                        break;
                    case 2:
                        Console.Clear();
                        LP.MostrarObjetos();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        Console.WriteLine("Cerrando aplicacion.........");
                        exit = true;
                        break;




                }




                Console.ReadKey();
            }
        }
    }
}

