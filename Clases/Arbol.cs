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
        public void buscar(Persona p)
        {
            Buscar(raiz_principal, p);
        }
        private void Buscar(Nodo raiz, Persona p)
        {
            if (raiz == null)
            {
                Console.WriteLine("Elemento no encontrado");
            }
            else
            {
                if (p < raiz.dato)
                {
                    Buscar(raiz.izq, p);
                }
                else if (p > raiz.dato)
                {
                    Buscar(raiz.der, p);
                }
                else
                {
                    Console.WriteLine(raiz.dato);
                }
            }
        }
        public void eliminar(Persona p)
        {
            Eliminar(ref raiz_principal, p);
        }
        private void Eliminar(ref Nodo raiz, Persona p)
        {
            if (raiz == null)
            {
                Console.WriteLine("Elemento no encontrado");
            }
            else
            {
                if (p < raiz.dato)
                {
                    Eliminar(ref raiz.izq, p);
                }
                else if (p > raiz.dato)
                {
                    Eliminar(ref raiz.der, p);
                }
                else
                {
                    if (raiz.izq==null && raiz.der==null)
                    {
                        raiz = null;
                    }
                    else if (raiz.izq!=null && raiz.der==null)
                    {
                        Nodo temp = BuscarMayor(raiz.izq);

                        Persona aux = raiz.dato;
                        raiz.dato = temp.dato;
                        temp.dato = aux;

                        Eliminar(ref raiz.izq,p);
                    } else
                    {
                        Nodo temp = BuscarMenor(raiz.der);

                        Persona aux = raiz.dato;
                        raiz.dato = temp.dato;
                        temp.dato = aux;

                        Eliminar(ref raiz.der, p);
                    }
                }
            }
        }
        private Nodo BuscarMayor(Nodo raiz)
        {
            if (raiz.der != null)
            {
                return BuscarMayor(raiz.der);
            }
            else
            {
                return raiz;
            }
        }
        private Nodo BuscarMenor(Nodo raiz)
        {
            if (raiz.izq == null)
            {
                return raiz;
            } else
            {
                return BuscarMenor(raiz.izq);
            }
        }
    }
}
