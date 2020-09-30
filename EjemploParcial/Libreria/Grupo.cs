using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Grupo
    {
        private string nombre;
        private static ETipoManada tipo;
        private List<Mascota> manada;

        static ETipoManada Tipo
        {
            set { Grupo.tipo = value; }
        }

        static Grupo()
        {
            Grupo.tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
           this.manada = new List<Mascota>();

        }

        public Grupo(string nombre)
        {
            this.nombre = nombre;

        }

        private Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;

        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota item in g.manada)
            {


            }
           
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }





    }
}
