using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class controlTurnos
    {
        public string ctrlRegistroTurnos(Turnos turno)
        {
            modeloTurnos modelo = new modeloTurnos();
            string rta = "";
            if ((string.IsNullOrEmpty(turno.Estimado)) ||
            (string.IsNullOrEmpty(turno.Patente)) ||
            (string.IsNullOrEmpty(turno.Hora)) ||
            (string.IsNullOrEmpty(turno.Monto) ||
            (string.IsNullOrEmpty(turno.Tipolavado) ||
            (string.IsNullOrEmpty(turno.Descripcion)))))
                rta = "Datos incompletos";
            else if (modelo.existePatenteFecha(turno)) rta = "La Patente " +turno.Patente + " con esta fecha " + turno.Fecha.ToString("yyyy-MM-dd") + " ya está registrada.";
            else
            {
                modelo.registrarTurnoo(turno);
                rta = "Auto registrado con éxito";
            }
            return rta;
        }
    }
}
