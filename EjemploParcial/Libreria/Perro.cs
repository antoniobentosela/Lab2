using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro (string nombre, string raza)
            :base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            :base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;

        }

        protected override string Ficha()
        {
            if(esAlfa == true)
            {
                return "Perro" + base.DatosCompletos() + ", alfa de la manada, edad" + this.edad;

            }
            else
            {
                return "Perro" + base.DatosCompletos() + ", edad" + this.edad;
            }

        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            if((Mascota)p1 == (Mascota)p2 && p1.edad == p2.edad)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return Ficha();
        }




    }
}
