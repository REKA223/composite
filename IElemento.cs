using System;
using System.Web;
using System.ComponentModel;

namespace EXPLORADORARCHIVOS
{
    public interface IELEMENTO
    {
        string Nombre { get; }
        void Mostrar(int nivel = 0);
        long Tamano();
        void Eliminar();
    }
}