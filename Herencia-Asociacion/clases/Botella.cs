using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Botella
    {
      private string contenido;
      private int capacidad;

      //PROPIEDADES
      public int Capacidad{
            get { return capacidad; }
            set { capacidad = value; }

      }
      public string Contenido{
            get { return contenido; }
            set { contenido = value; }

      }
    }
}
