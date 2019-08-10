using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Negocio
    {
        Datos dts = new Datos();
        public double N_Suma(Entidad obj)
        {
            return dts.D_Suma(obj);
        }
       
    }
}
