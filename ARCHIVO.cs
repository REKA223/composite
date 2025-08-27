using System;
using System.ComponentModel;

namespace EXPLORADORARCHIVOS
{
    public sealed class ARCHIVO:IELEMENTO
    {
        public string Nombre { get; }
        private long _tamanio { get; }

        public ARCHIVO(string nombre, long bytes)
        {
            Nombre = nombre;
            _tamanio = bytes;
        }

        public void Mostrar(int nivel = 0)
        {
            Console.WriteLine($"{new string(' ', nivel)}- {Nombre} ({_tamanio} B)");
        }

        public void Eliminar(){ Console.WriteLine($"\nELIMINADO {Nombre}"); }

        public long Tamano()
        {
            return _tamanio;
        }
    }
}