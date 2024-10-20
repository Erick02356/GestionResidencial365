using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Zona_Alquilada
    {
        public int Id { get; set; }
        public DateTime FechaAparto { get; set; }
        public DateTime FechaUso { get; set; }
        public string EstadoPago { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal CostoLimpieza { get; set; }
        public decimal CostosExtra { get; set; }
        public decimal CostoTotal { get; set; }
        public string Descripcion { get; set; }
        public int Id_Apartamento { get; set; }
        public int Id_ZonaSocial { get; set; }
        public int Id_Inquilino { get; set; }
    }
}
