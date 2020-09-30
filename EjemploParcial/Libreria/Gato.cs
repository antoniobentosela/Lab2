using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Gato : Mascota
    {

        public Gato(string nombre, string raza)
            :base(nombre, raza)
        {

        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            if ((Mascota)g1 == (Mascota)g2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return Ficha();
        }

    }
}
