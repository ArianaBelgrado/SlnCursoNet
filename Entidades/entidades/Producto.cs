﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }

        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        private decimal _PrecioBruto;
        private decimal _PrecioVenta;

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iVA, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iVA;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public decimal PrecioBruto
        {
            get
            {
                _PrecioBruto = PrecioCosto + Convert.ToDecimal(Margen);
                return _PrecioBruto;
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                _PrecioVenta = PrecioBruto * Convert.ToDecimal(1 + IVA);
                return _PrecioVenta;
            }
        }
    }
    
}

