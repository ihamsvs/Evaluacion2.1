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

        public Trueque()
        {

        }

        public Trueque(string Descripcion, string Fecha)
        {
            this.Descripcion = Descripcion;
            this.Fecha = Fecha;
        }

    }
}
