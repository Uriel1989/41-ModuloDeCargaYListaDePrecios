using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _41_ModuloDeCargaYListaDePrecios
{
    class Carga
    {
        public string tipo { get; set; } /*EN ESTE CASO esta propiedad permite el uso de IF en la seccion PROGRAM*/
        public string Marca { get; set; }
        public int NumeroDeSerie { get; set; }
        public string Modelo { get; set; }
        public int Precio { get; set; }
    }
}
