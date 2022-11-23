using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloEV2
{
    class ListaProductos
    {
        List<string> Usuarios = new List<string>();
        List<string> Objeto = new List<string>();

        public void CreacionUsuario(string Nombre, string valor, string P1, string P2, string P3)
        {
            Usuarios.Add(Nombre);
            Usuarios.Add(valor);
            Usuarios.Add(P1);
            Usuarios.Add(P2);
            Usuarios.Add(P3);
        }

        public void ObjetoTrueque(string descripcion, string fecha)
        {   
            Objeto.Add(descripcion);
            Objeto.Add(fecha);
        }
        
        public void MostrarObjetos()
        {
            Console.WriteLine("-------------- Mostrando trueques disponibles: --------------");
            Console.WriteLine();
            for (int x = 0; x < Objeto.Count; x++)
            {
                Console.WriteLine(Objeto[x]);
            }   
        }

        public void MostrarSinMatch()
        {
            Console.WriteLine("-------------- Mostrando trueques sin match: --------------");
            Console.WriteLine();
            for (int x = 0; x < Objeto.Count; x++)
            {
                Console.WriteLine(Objeto[x]);
            }
        }

    }
}
