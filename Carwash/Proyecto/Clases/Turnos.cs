using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Turnos
    {
        private DateTime fecha;
        private string patente;
        private string hora;
        private string estimado;
        private string tipolavado;
        private string monto;
        private string descripcion;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Patente { get => patente; set => patente = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Estimado { get => estimado; set => estimado = value; }
        public string Tipolavado { get => tipolavado; set => tipolavado = value; }
        public string Monto { get => monto; set => monto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
