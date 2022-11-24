using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloEV2 
{
    class ListaProductos 
    {
        public List<string> Usuarios = new List<string>();

        public List<Trueque> trueques = new List<Trueque>();

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
            trueques.Add(new Trueque(descripcion, fecha));

        }

        public void Match(string nombre) 
        {
            IEnumerable<Trueque> ma = from n in trueques where n.Descripcion == nombre select n;
            Console.WriteLine("Objetos disponibles para trueque según su busqueda " + nombre);
            foreach (Trueque tr in ma) 
            {
                Console.WriteLine(tr.Descripcion + " " + tr.Fecha);
            }
        }

        public void MostrarObjetos() 
        {
            Console.WriteLine("-------------- Mostrando trueques disponibles: --------------");
            Console.WriteLine();
            for (int x = 0; x < trueques.Count; x++)
            {
                Console.WriteLine(trueques[x].Descripcion + " " + trueques[x].Fecha);
            }
        }

        public void MostrarSinMatch()
        {
            Console.WriteLine("-------------- Mostrando trueques sin match: --------------");
            Console.WriteLine();
            for (int x = 0; x < trueques.Count; x++)
            {
                Console.WriteLine(trueques[x].Descripcion + " " + trueques[x].Fecha);
            }
        }

    }
}
