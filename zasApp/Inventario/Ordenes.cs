﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zas_Sistema_Administrativo_y_Inventario.Inventario
{
    public class Orden
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }
      
        public int Quantity { get; set; }
        public string Product { get; set; }
        public string Provider { get; set; }
    }
}
