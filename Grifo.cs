using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Grifo
    {
        public List<Usuario> Usuarios { get; set; }

        public Grifo() { 
            Usuarios = new List<Usuario>();
        }  

        public void MostrarUsuarios()
        {
            foreach (var usuario in Usuarios)
            {
                usuario.MostrarInformacion();
            }
        }
    }

}
