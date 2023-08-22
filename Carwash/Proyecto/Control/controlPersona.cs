using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class controlPersona
    {
        public string crtlRegistroPersona(Persona persona)
        {
            modeloPersona modelo = new modeloPersona();
            string rta = "";
            if ((string.IsNullOrEmpty(persona.Nombre)) ||
            (string.IsNullOrEmpty(persona.Telefono)) ||
            (string.IsNullOrEmpty(persona.Dni)))
                rta = "Datos Incompletos";
            else
                if (modelo.existeDni(persona))
                rta = "La persona con el número de dni " + persona.Dni + " ya se encuentra registrada!";
            else
            {
                modelo.registrarPersona(persona);
                rta = "Persona registrada con éxito";
            }
            return rta;
        }
    }
}
