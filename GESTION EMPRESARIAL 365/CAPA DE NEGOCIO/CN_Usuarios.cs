using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DE_DATOS;
using CAPA_DE_ENTIDADES;

namespace CAPA_DE_NEGOCIO
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios cd_Usuarios;

        public CN_Usuarios()
        {
            cd_Usuarios = new CD_Usuarios();
        }

        public List<CE_Usuario> Mostrar_Usuarios()
        {
            return cd_Usuarios.Mostrar_Usuarios();
        }

    }
}
