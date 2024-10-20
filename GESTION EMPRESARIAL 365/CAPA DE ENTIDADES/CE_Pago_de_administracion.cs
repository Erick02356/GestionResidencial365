using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Pago_de_administracion
    {
        public int Id_Pago_de_administracion { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaPeriodoFacturacion { get; set; }
        public DateTime FechaLimitePago { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal TotalAPagar { get; set; }
        public bool PagoAntesDe { get; set; }
        public bool PagoDespuesDe { get; set; }
        public decimal CostosAdicionales { get; set; }
        public string Descripcion { get; set; }
        public string EstadoDePago { get; set; }
        public int Id_Apartamento { get; set; }
        public int Id_Administradora { get; set; }
    }
}
