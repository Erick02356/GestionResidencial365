using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Administradora
    {
        public int Id_Administradora {  get; set; }
        public string Nombre_uno_Administradora { get; set; }
        public string Nombre_dos_Administradora { get; set; }
        public string Apellido_uno_Administradora { get; set; }
        public string Apellido_dos_Administradora { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_Final {  get; set; }
        public int Id_Usuario { get; set; }

    }
}
