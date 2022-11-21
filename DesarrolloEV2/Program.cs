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
            DiccionarioProductos p = new DiccionarioProductos();
            #endregion

            while (!exit)
            {
                Console.WriteLine("-------------- Bienvenido a Trueque --------------");
                Console.WriteLine("1 - ¿ Desea intercambiar un producto ? ");
                Console.WriteLine("2 - ¿ Buscar un producto en la bodega ?");
                Console.WriteLine("3 - ¿ Agregar un producto a la bodega ?");
                Console.WriteLine("4 - Mostrar productos en bodega");
                Console.WriteLine("5 - Buscar trueques sin match");
                Console.WriteLine("6 - Salir de Trueque ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Intercambiar producto");
                        break;
                    case 2:
                        Console.WriteLine("Nombre del producto:");
                        break;
                    case 3:
                        Console.WriteLine("¿Qué producto desea agregar?");
                        Console.WriteLine("Ingrese la llave del producto:");
                        int key = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del producto:");
                        string nombre = Console.ReadLine();
                        p.AgregarProducto(key, nombre);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el identificador del producto:");
                        int llave = int.Parse(Console.ReadLine());
                        p.MostrarProductos(llave);
                        break;
                    case 5:
                        Console.WriteLine("Buscando trueques sin match:");
                        break;
                    case 6:
                        Console.WriteLine("Cerrando aplicacion.........");
                        exit = true;
                        break;




                }




                Console.ReadKey();
            }
        }
    }
}

