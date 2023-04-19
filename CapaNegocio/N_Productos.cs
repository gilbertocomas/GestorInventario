using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Productos
    {
        private readonly D_Productos objProducto = new D_Productos();
        
        public void N_crearProducto (E_Productos producto)
        {
            objProducto.D_crearProducto(producto);
        }

        public void N_actualizarProducto(E_Productos producto)
        {
            objProducto.D_actualizarProducto (producto);
        }

        public void N_eliminarProducto (E_Productos producto)
        {
            objProducto.D_eliminarProducto(producto);
        }

        public DataTable N_buscarProductos (E_Productos producto)
        {
            return objProducto.D_buscarProductos(producto);
        }

        public DataTable N_buscarProductoPorId(E_Productos producto)
        {
            return objProducto.D_buscarProductoPorId (producto);
        }
    }
}
