using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class CE_Configuracion_Conjunto
    {
        public int Id_Confirguracion_conjunto { get; set; }
        public string Nombre_conjunto { get; set; }
        public string Direccion_conjunto { get; set; }
        public string Telefono_conjunto { get; set; }
        public string Nombre_Administradora_del_conjunto { get; set; }
        public float pago_por_metro_2_conjunto { get; set; }
        public float Interes_mora_conjunto { get; set; }
        public string Numero_de_cuenta_corriente_conjunto { get; set; }
        public float Saldo_conjunto { get; set; }
        public float Ingresos_conjunto { get; set; }
        public float Egresos_conjunto { get; set; }

    }
}
