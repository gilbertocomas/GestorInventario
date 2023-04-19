using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        public int CodUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string RolUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
