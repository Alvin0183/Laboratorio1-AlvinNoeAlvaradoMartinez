using LABORATORIO1_AlvinNoeAlvaradoMartinez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1_AlvinNoeAlvaradoMartinez.Negocio
{
    public class ClsPersona
    {

        public string CalcularIMC(Persona pes)
        {

            double pespo = pes.Peso / Math.Pow(pes.Altura, 2);

            if (pespo < 25)
            {
                return "Peso Ideal ";

            }
            else
            {
                return "Tiene sobrepeso ";
            }


        }

        public string EsMayorDeEdad(Persona ed)
        {
            if (ed.Edad >= 18)
            {
                return "Es mayor de edad ";
            }
            else
            {
                return "Es menor de edad";
            }

        }
    }
}


