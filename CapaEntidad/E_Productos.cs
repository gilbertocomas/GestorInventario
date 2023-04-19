using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Productos
    {
        public int CodProducto { get; set; }
        public string DesProducto { get; set; }
        public string Categoria { get; set; }
        public double CostoProducto { get; set; }
        public double PrecioProducto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UnidadMedidaProducto { get; set; }
        public int Existencia { get; set; }
        public int CodUsuario { get; set; }


    }
}
