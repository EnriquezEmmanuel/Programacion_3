using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.setNom("Emmanuel");
            p1.setEdad (38);

            Console.WriteLine("Nombre: " + p1.getNom() + ", edad= " + p1.getEdad()+"\n" );
            //Console.WriteLine("edad= " + p1.getEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 300;
            b1.Contenido = "vino";
            Console.WriteLine("La botella contiene " + b1.Contenido + " y su capacidad es de " + b1.Capacidad + "ml.");
            
            /*Creación de vector
            int[] variable = new int[cantidad]
            <tipo de dato>[] <nombre variable> = new (palabra clave) <tipo de dato>[<cantidad>] */
            Articulo[] artcls = new Articulo[3]; // Creamos un vector de clase. pero el objeto no fue instanciado. 
           
            Console.WriteLine("Si desea continuar con la carga de artículos ingrese 's': ");
            
            if(Console.ReadLine()=="s")
            {
                for (int i = 0; i < 3; i++)
                {

                    artcls[i] = new Articulo(); //creamos la intancia del objeto

                    Console.WriteLine("Ingrese un número de articulo: ");
                    artcls[i].CodigoArticulo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio: ");
                    artcls[i].Precio = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de la marca (1-10): ");
                    artcls[i].CodigoMarca = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Articulo: " + artcls[i].CodigoArticulo + "\n");
                    Console.WriteLine("Precio: " + artcls[i].Precio + "\n");
                    Console.WriteLine("Código de la marca: " + artcls[i].CodigoMarca + "\n\n");
                }
            }


            Console.WriteLine("\n ID: " + b1.GetHashCode());//ID uunico interno que teine el objeto




            //CLASE STRING
            string texto1 = "Esta es una prueba de la clase string";
            Console.WriteLine("Cadena original: " + texto1 + "\n");   

            texto1= texto1.Replace("prueba", "evaluación");
            Console.WriteLine("Reemplazando una cadena: " + texto1 + "\n");

            texto1 = texto1.Replace('a', '4'); //nótese que estna comilla simple para cuando es un solo caracter
            Console.WriteLine("Reemplazando un caracter: " + texto1 + "\n");

            texto1 = texto1.ToUpper();
            Console.WriteLine("Cadena en mayúscula: " + texto1 + "\n");

            texto1 = texto1.ToLower();
            Console.WriteLine("Cadena en minúscula: " + texto1 + "\n");

            texto1 = texto1.Replace("string", "STRING");
            texto1 = texto1.Replace('4', 'a');
            texto1 = texto1.Replace("esta", "Esta");
            Console.WriteLine("Restaurando la cadena original: " + texto1 + "\n");


            Console.ReadKey();



        }
    }
}
