using
    System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    class Libro
    {
        ILibrero libroIUnidad;
        public Libro(ILibrero objetoLibrero)
        {
            libroIUnidad = objetoLibrero;
        }
        public void IngresoLibro()
        {
            libroIUnidad.InstertarLibro();
        }
    }
}
