using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEricJDPC
{
    public class Nodo
    {
        public Persona _persona { get; set; }
        public Nodo _siguiente { get; set; }

        public Nodo(Persona persona) 
        { 
            _persona = persona;
            _siguiente = null;
        }
        
        public Nodo(Persona persona, Nodo siguiente) 
        {
            _persona = persona;
            _siguiente = siguiente;
        }

        public Persona Persona { get { return _persona; } set { _persona = value; } }
        public Nodo Siguiente { get { return _siguiente; } set {  _siguiente=value; } }


    }
}
