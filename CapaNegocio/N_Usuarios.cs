using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class N_Usuarios
    {
        private readonly D_Usuarios objUsuario = new D_Usuarios();

        public void N_crearUsuario (E_Usuarios usuario)
        {
            objUsuario.D_crearUsuario(usuario);
        }

        public void N_actualizarUsuario(E_Usuarios usuario)
        {
            objUsuario.D_actualizarUsuario(usuario);
        }

        public void N_eliminarUsuario(E_Usuarios usuario)
        {
            objUsuario.D_eliminarUsuario(usuario);
        }

        public DataTable N_consultarUsuarios(E_Usuarios usuario)
        {
            return objUsuario.D_consultarUsuarios (usuario);
        }

        public DataTable N_consultarUsuarioPorId(E_Usuarios usuario)
        {
            return objUsuario.D_consultarUsuarioPorId (usuario);
        }
    }
}
