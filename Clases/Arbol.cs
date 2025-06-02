using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public Nodo raiz_principal = null;

        public void insertar(Persona p)
        {
            Insertar(ref raiz_principal,p);
        }
        private void Insertar(ref Nodo raiz, Persona p)
        {
            if (raiz == null)
            {
                Nodo nuevo= new Nodo();
                nuevo.dato = p;

                raiz= nuevo;
            }
            else
            {
                if (p < raiz.dato)
                {
                    Insertar(ref raiz.izq, p);
                }
                else if (p>raiz.dato)
                {
                    Insertar(ref raiz.der, p);
                } else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }

        public void inOrden()
        {
            InOrden(raiz_principal);
        }
        private void InOrden(Nodo raiz)
        {
            if (raiz!=null)
            {
                InOrden(raiz.izq);
                Console.WriteLine(raiz.dato);
                InOrden(raiz.der);
            }
        }
    }
}
