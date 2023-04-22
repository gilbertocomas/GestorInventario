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

        public DataTable N_consultarMovimientos()
        {
            return objMovimiento.D_consultarMovimientos ();
        }

        public DataTable N_10MayoresMovimientosProductos()
        {
            return objMovimiento.D_10MayoresMovimientosProductos();
        }

        public DataTable N_reporteIncrementoProductos()
        {
            return objMovimiento.D_reporteIncrementoProductos();
        }

        public DataTable N_reporteDecrementoProductos()
        {
            return objMovimiento.D_reporteDecrementoProductos();
        }
    }
}
