using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public  class CE_Apartamento
    {
        public int Id_Apartamento { get; set; }
        public string Numero_Apartamento { get; set; }
        public string Estado_Apartamento { get; set; }
        public bool AlDiaConElPago_del_Apartamento { get; set; }
        public string Torre_Apartamento { get; set; }
        public decimal ValorAdministracion_Apartamento { get; set; }
        public string Descripcion_Apartamento { get; set; }
        public int Piso_Apartamento { get; set; }
        public decimal AreaM2_Apartamento { get; set; }
        public int Id_Propietario_Apartamento { get; set; }
    }
}
