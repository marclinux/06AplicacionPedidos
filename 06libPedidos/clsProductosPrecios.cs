﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class clsProductosPrecios : clsProductos
    {
        #region Propiedades
        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PorcentajeIeps { get; set; }
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() +
                $"Precio público: {PrecioPublico.ToString("C")}" +
                $"Precio mayoreo: {PrecioMayoreo.ToString("C")} " +
                $"Porcentaje Iva: {PorcentajeIva.ToString()}" +
                $"Porcentaje Ieps: {PorcentajeIeps.ToString()}";
        }

        public decimal DesglosaImpuestos(recMontosImpuestos Montos)
        {
            decimal resultado = 0;
            recImpuestos Impuestos = new recImpuestos(PorcentajeIva, PorcentajeIeps);
            resultado = CalculoPrecios.DesglosaImpuestos(PrecioPublico, Impuestos,
                                            Montos);
            return resultado;
        }
        #endregion
    }
}
