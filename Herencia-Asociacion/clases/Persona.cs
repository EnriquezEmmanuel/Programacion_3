using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Persona{
      //ATRIBUTOS
      private string nombre;
      private int edad;
        
      //METODOS
      public void setEdad( int e ){ edad= e; }
      public int getEdad() { return edad; }

      public void setNom(string n) { nombre = n; }
      public string getNom() { return nombre; }


    }
}
