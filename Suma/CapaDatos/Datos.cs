﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;

namespace CapaDatos
{
    public class Datos
    {
        public double D_Suma(Entidad obj)
        {
            double n1, n2 ,res;
            n1 = obj.a;
            n2 = obj.b;

            res = n1 + n2;

            return res;
 
        }
    }
}
