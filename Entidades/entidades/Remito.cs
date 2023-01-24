using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.entidades;

namespace slnCursoNet.entidades
{
    public class Remito : DocumentoComercial
    {
        public Remito(string numero, DateTime fecha, string cliente,
            string direccion, string condicionIVA, string condicionVenta,
            string detalle, string fechaEntrega, decimal total) : base(numero, fecha, cliente,
             direccion, condicionIVA, condicionVenta,
            detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }



        public string FechaEntrega { get; set; }
    }
}



