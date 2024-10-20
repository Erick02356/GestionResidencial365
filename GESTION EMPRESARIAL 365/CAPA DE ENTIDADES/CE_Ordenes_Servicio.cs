using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Ordenes_Servicio
    {
        public int Id_Orden_servicio { get; set; }
        public decimal Costo { get; set; }
        public string UrlFactura { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int Id_Empresa { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Tipo { get; set; }
    }
}
