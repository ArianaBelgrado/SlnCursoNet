using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invvestigacion.Entidades
{
    public class AvionCarga : Avion
    {
        public string Peso { get; set; }
        public string TipoMercaderia { get; set; }

        public override bool Aterriza()
        {
            return true;
        }

        public override bool Despegar()
        {
            return false;
        }
    }
}
