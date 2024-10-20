using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Usuario
    {
        public int Id_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Id_tipo_documento { get; set; }
        public bool Estado { get; set; } 
    }
}
