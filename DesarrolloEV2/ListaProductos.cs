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
        
        public List<TruequesCompletados> TruequeC = new List<TruequesCompletados>();

        public void CreacionUsuario(string Nombre, string valor, string P1, string P2, string P3 )
        {
            Usuarios.Add(Nombre);
            Usuarios.Add(valor);
            Usuarios.Add(P1);
            Usuarios.Add(P2);
            Usuarios.Add(P3);
        }

        public void ObjetoTrueque(string descripcion, string fecha, string valor)
        {
            trueques.Add(new Trueque(descripcion, fecha, valor));
            
        }

        public void Match(string nombre)
        {
            IEnumerable<Trueque> ma = from n in trueques where n.Descripcion == nombre select n;
            Console.WriteLine("Objetos disponibles para trueque según su busqueda "+ nombre );
            foreach (Trueque tr in ma)
            {
                Console.WriteLine(tr.Descripcion + " "+ tr.Fecha+ " " + tr.Valor);
            }
            Console.WriteLine("¿ Por cuál objeto de la lista mostrada deseario intercambiar ?");
            string opcion = Console.ReadLine();
            Console.WriteLine("Usted que da a cambio de "+ opcion);
            string opcion2 = Console.ReadLine();
            Console.WriteLine("Se ha hecho el trueque de " + " " + opcion + " " + "por " + " " + opcion2);
            TruequeC.Add(new TruequesCompletados(opcion, opcion2));
            trueques.Remove(new Trueque(opcion));
            Console.WriteLine("Trueque confirmado y guardado en su respectiva lista");
        }
        
        public void MostrarTruequesCompletados()
        {
            Console.WriteLine("Mostrando trueques completos");
            foreach (TruequesCompletados i in TruequeC)
            {
                Console.WriteLine(" se ha intercambiado" + " " + i.objeto1 + " " + "por" + " " + i.objeto2);
            }
        }

        public void MostrarObjetos()
        {
            Console.WriteLine("Mostrando trueques disponibles:");
            Console.WriteLine();
            for (int x = 0; x < trueques.Count; x++)
            {
                Console.WriteLine(trueques[x].Descripcion + " "+ trueques[x].Fecha + " Valor aproximado: "+ trueques[x].Valor);
            }
        }
        
        public void BuscarObjetos(string valor)
        {    
            IEnumerable<Trueque> BV = from n in trueques where n.Valor == valor orderby n.Valor select n;
            Console.WriteLine("Trueques que tienen un valor aproximado al que busca");
            foreach (Trueque vb in trueques)
            {
                Console.WriteLine("Se han encontrado estos resultados " + vb.Descripcion + " " + vb.Fecha + "Con un valor de:  " + vb.Valor);
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
