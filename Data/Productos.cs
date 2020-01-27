using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazorApp.Data
{
    public class Productos
    {
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Minimo { get; set; }
        public string Unidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            Minimo = 0;
            Unidad = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;
        }

        public Productos(int productoId,DateTime fecha, string descripcion, int cantidad, int minimo, string unidad, decimal costo, decimal precio, decimal ganancia)
        {
            ProductoId = productoId;
            Fecha = fecha;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Minimo = minimo;
            Unidad = unidad;
            Costo = costo;
            Precio = precio;
            Ganancia = ganancia;
        }
    }

}
