﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_ENTIDADES
{
    public class Zona_Social
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Horario { get; set; }
        public string DiasHabiles { get; set; }
        public decimal CostoUso { get; set; }
        public string Restricciones { get; set; }
        public string Estado { get; set; }
    }
}
