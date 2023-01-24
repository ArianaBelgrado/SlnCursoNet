using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invvestigacion.Entidades
{
    public abstract class Avion
    {
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public abstract bool Aterriza();
        public abstract bool Despegar();

    }
}
