using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Inquilino
    {
        public int Id_Inquilino { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int Id_Apartamento { get; set; }
        public int Id_Usuario { get; set; }
    }
}
