using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnCursoNet.entidades;

namespace Negocio.Entidades
{
    public class AdmProductos
    {
        public static List<Producto> productos = new List<Producto>();
        
        public static List<Producto> Listar() 
        {
             return productos;
        }

        public static List<Producto> Listar(string Categoria)
        {
            return productos;
        }

        public static List<Producto> Listar(string Categoria, string SubCategoria)
        {
            return productos;
        }

        public static List<Producto> ListarDetalle(string Nombre)
        {
            return productos;
        }
    }
}
