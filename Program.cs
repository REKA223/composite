
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPLORADORARCHIVOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new CARPETA("Proyecto");
            var src = new CARPETA("src");
            var img = new CARPETA("imagenes");

            src.Agregar(new ARCHIVO("Program.cs", 1200));
            src.Agregar(new ARCHIVO("Utils.cs", 800));

            img.Agregar(new ARCHIVO("logo.png", 24_000));
            img.Agregar(new ARCHIVO("banner.jpg", 180_000));

            root.Agregar(src);
            root.Agregar(img);
            root.Agregar(new ARCHIVO("README.md", 900));

            Console.WriteLine("Estructura:");
            root.Mostrar();

            Console.WriteLine($"\nTamaño total: {root.Tamano()} bytes");

            Console.WriteLine("\nEliminar carpeta 'imagenes'...");
            root.Eliminar(img);
            img.Eliminar();

            Console.WriteLine("\nEstructura tras eliminar:");
            root.Mostrar();
            Console.WriteLine($"\nTamaño total: {root.Tamano()} bytes");
        }
    }
}
