﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Cliente
    {
        public int id { get; set; }

        public string NomCliente { get; set; }
        public string ApeCliente { get; set; }
        public int DNICliente { get; set; }

        public string CB
        {
            get {return "Cliente :" +NomCliente+"Apellido: "+ApeCliente+"DNI: "+DNICliente;}
        }

        public override string ToString()
        {
            return DNICliente.ToString();
        }
    }
}
