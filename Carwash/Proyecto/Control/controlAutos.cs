using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class controlAutos
    {
        public string crtlRegistroSocios(Autos socio)
        {
            modeloAutos modelo = new modeloAutos();
            string rta = "";
            if ((string.IsNullOrEmpty(socio.Patente)) ||
            (string.IsNullOrEmpty(socio.Marca)) ||
            (string.IsNullOrEmpty(socio.Modelo)) ||
            (string.IsNullOrEmpty(socio.Año)) ||
            (string.IsNullOrEmpty(socio.Dni)))
                rta = "Datos Incompletos";
            else if (modelo.existePatente(socio)) rta = "La patente " + socio.Patente + " ya se encuentra registrada!";
            else
            {
                modelo.registrarSocio(socio);
                rta = "Auto registrado con éxito";
            }
            return rta;
        }
    }
}
