using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnCursoNet.entidades;

namespace Negocio.Entidades
{
    public class AdmCompras
    {
        public static List<Producto> item = new List<Producto>();
        public static List<Vendedor> vendedors= new List<Vendedor>();
        public void Agregar(Producto item, byte Cantidad) { }

        public void Modificar(byte Cantidad) { }

        public void Eliminar(string Nombre ) { }

        public void Confirmar ( Vendedor vendedor ) { }

        public void Eliminar () { }
    }
}
