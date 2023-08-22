using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Autos
    {
        private string patente;
        private string marca;
        private string modelo;
        private string año;
        private string dni;

        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Año { get => año; set => año = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}
