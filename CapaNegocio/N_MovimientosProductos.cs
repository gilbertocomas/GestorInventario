using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class N_MovimientosProductos
    {
        private readonly D_MovimientosProductos objMovimiento = new D_MovimientosProductos();

        public void N_incrementarProducto (E_MovimientosProductos movProducto)
        {
            objMovimiento.D_incrementarProducto(movProducto);
        }

        public void N_decrementarProducto (E_MovimientosProductos movProducto)
        {
            objMovimiento.D_decrementarProducto(movProducto);
        }

        public DataTable N_consultarMovimientos(E_MovimientosProductos movProducto)
        {
            return objMovimiento.D_consultarMovimientos (movProducto);
        }
    }
}
