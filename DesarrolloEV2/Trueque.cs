using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloEV2
{
    class Trueque
    {
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string Valor { get; set; }

        public Trueque(string Descripcion)
        {

        }
        
        public Trueque(string Descripcion, string Fecha, string valor)
        {
            this.Descripcion = Descripcion;
            this.Fecha = Fecha;
            Valor = valor;
        }

    }
}
