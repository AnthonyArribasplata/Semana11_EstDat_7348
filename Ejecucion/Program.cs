using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol abb= new Arbol();

            Persona p1= new Persona();
            p1.nombre = "Juan Perez";
            p1.edad = 32;
            abb.insertar(p1);

            Persona p2= new Persona();
            p2.nombre = "Jhon Doe";
            p2.edad = 30;
            abb.insertar(p2);

            Persona p3 = new Persona();
            p3.nombre = "Anthony Arribasplata";
            p3.edad = 30;
            abb.insertar(p3);


            Persona pe= new Persona();
            pe.nombre = "Jhon Doe";

            abb.eliminar(pe);

            abb.inOrden();
        }
    }
}
