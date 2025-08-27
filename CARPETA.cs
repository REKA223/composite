using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EXPLORADORARCHIVOS
{
    
    public sealed class CARPETA : IELEMENTO
    {
        public string Nombre { get; }
        private List<IELEMENTO> _hijos=new List<IELEMENTO>();
        public CARPETA(string nombre)
        {
            Nombre = nombre;
        }

        public void Agregar(IELEMENTO hijo){_hijos.Add(hijo);}
        public void Eliminar(IELEMENTO hijo){_hijos.Remove(hijo);}
        public IELEMENTO ObtenerHijo(int i) { return _hijos[i];}
        public void Eliminar()
        {
            foreach (var hijo in _hijos.ToArray())
                hijo.Eliminar();
            _hijos.Clear();
        }
        public void Mostrar(int nivel = 0)
        {
            Console.WriteLine($"{Nombre}/");
            foreach (var hijo in _hijos)
                hijo.Mostrar(nivel +1);
        }

        public long Tamano()
        {
            return _hijos.Sum(h => h.Tamano());
        }
    }
}