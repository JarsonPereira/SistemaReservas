﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaReservas.Models
{
    public class Reserva
    {
        public int ID { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public int ID_Usuario { get; set; }

    }
}