using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06AplicacionPedidos
{
    public static class FuncionesPrincipales
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public static void EjemploCliente()
        {
            clsClientes cliente;
            cliente = new clsClientes();
            cliente.idCliente = 1;
            cliente.NombreCompleto = "Marcos Hernandez";
            cliente.Rfc = "HEHM010165";
            Console.WriteLine(cliente.ToString());
        }

        public static void EjemploRecordProducto()
        {
            clsProductos Producto = new clsProductos();
            Producto.idProducto = 1;
            Producto.Descripcion = "REF MANZANA 600 ML";
            Producto.CodigoBarras = "0001";
            clsProductos Producto2 = new clsProductos();
            Producto2 = Producto;
            Producto2.CodigoBarras = "";
            recProductos rProducto = new recProductos(1, "REF MANZANA 600 ML", "0001");
            recProductos rProducto2 = rProducto with { CodigoBarras = "" };
            Console.WriteLine(Producto);
            Console.WriteLine(Producto2);
            Console.WriteLine(rProducto);
            Console.WriteLine(rProducto2);
            if (Producto == Producto2)
                Console.WriteLine("Los objetos son iguales");
            else
                Console.WriteLine("Los objetos son diferentes");
            if (rProducto == rProducto2)
                Console.WriteLine("Los registros son iguales");
            else
                Console.WriteLine("Los registros son diferentes");
        }

        public static void EjemploDesglosaImpuestos()
        {
            clsProductosPrecios Producto = new clsProductosPrecios();
            Producto.idProducto = 1;
            Producto.Descripcion = "REF MANZANA 600 ML";
            Producto.CodigoBarras = "0001";
            Producto.PrecioPublico = 17.5m;
            Producto.PrecioMayoreo = 17;
            Producto.PorcentajeIva = 16;
            Producto.PorcentajeIeps = 8;
            decimal precioSinImpuestos, MontoIva = 0, MontoIeps = 0;
            Console.WriteLine(Producto);
            recMontosImpuestos Montos = new recMontosImpuestos(0, 0);
            precioSinImpuestos = Producto.DesglosaImpuestos(Montos);
            Console.WriteLine(precioSinImpuestos.ToString("C"));
            Console.WriteLine(Montos.ToString());
        }
        #endregion
    }
}
