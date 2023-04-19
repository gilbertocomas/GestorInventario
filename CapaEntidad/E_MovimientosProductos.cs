using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_MovimientosProductos
    {
        public int CodMovimiento { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        
        public DateTime FechaMovimiento { get; set; }
    }
}
