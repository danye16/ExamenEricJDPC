using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEricJDPC
{
    public class ListaSencilla
    {
       private Nodo primero;
       private Nodo ultimo;

        public ListaSencilla()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if (primero!=null) return false;
            else return true;
        }
        public void InsertarPrincipio(Persona persona)
        {
            if(ListaVacia())
            {
                primero = ultimo = new Nodo(persona);
            }
            else
            {
               primero = new Nodo(persona, primero);
            }
        }

        public void InsertarFinal(Persona persona) 
        {
            if (ListaVacia())
            {
                primero = ultimo = new Nodo(persona);
            }
            else
            {
                ultimo = ultimo.Siguiente= new Nodo(persona);
            }
        }

        public void Imprimir()
        {
            if(ListaVacia())
            {
                Console.WriteLine("La lista ta vacia");
            }
            else
            {
                Nodo actual = primero;
                while(actual != null) 
                {
                    Console.WriteLine($"El nombre es {actual.Persona.Nombre} y tiene una edad de {actual.Persona.Edad}");
                    actual = actual.Siguiente;
                }
            }
        }
        public int Longitud()
        {
            int contador = 1;
            if(ListaVacia())
            { return 0; }

            if (primero != null && primero.Siguiente == null)
            {
                return 1;
            }
            else {
                Nodo actual = primero;
                while (actual!=null) 
                {
                    actual = actual.Siguiente;
                    contador++;
                }
                return contador;
                 }
        }
        //public void ImprimirAscendente()
        //{
        //    int longitud= Longitud();
        //    if (ListaVacia())
        //    {
        //        Console.WriteLine("La lista ta vacia");
        //    }
        //    else
        //    {
        //        for(int i =0; i<longitud;i++ )
        //        {
        //            for (int j=0; i<longitud;i++)
        //            {
        //                Nodo actual= primero;
        //                Nodo auxiliar;
        //                while (actual!=null)
        //                { 
        //                    if (longitud<j+1)
        //                    {
        //                        auxiliar= actual;
        //                        j+1=i;
        //                        actual.Persona.Edad = i;
                                
        //                    }
        //                    actual = actual.Siguiente;}
        //            }
        //        }

        //        while (actual != null)
        //        {
        //            Console.WriteLine($"El nombre es {actual.Persona.Nombre} y tiene una edad de {actual.Persona.Edad}");
        //            actual = actual.Siguiente;
        //        }
        //    }
        //}

        public void Buscar(int edad)
        {
            bool centinela = false;
            if(ListaVacia()) 
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                int posicion = 1;
                while (actual!= null) 
                {
                    if (edad ==actual.Persona.Edad)
                    {
                        Console.WriteLine($"Si existe una perrito con la edad de {edad} y se encuentra en la posición {posicion}");
                        centinela = true;
                        break;
                    }
                    else
                    {
                        actual= actual.Siguiente;
                        posicion++;
                    }
                }
                if(!centinela)
                { Console.WriteLine("No existe un perrito con esa edad"); }
            }
        }


    }
}
