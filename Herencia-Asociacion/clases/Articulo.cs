using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Articulo
    {
        //forma corta de darle una propiedad sin darle los atributos.
        public int CodigoArticulo { get; set; }  
        public float Precio { get; set; }
        private int codigoMarca;

        public int CodigoMarca
        {
            get { return codigoMarca; }
            set
            {
                if (value > 0 && value < 11) //recordar que para una sola instrución puede ir sin llaves
                    codigoMarca = value;
                else
                    codigoMarca = -1;
            }
        }

    }
}
