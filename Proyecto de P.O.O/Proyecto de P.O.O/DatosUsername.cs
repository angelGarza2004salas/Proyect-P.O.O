using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_P.O.O
{
    internal class DatosUsername
    {
        //nombre de las variables se usa camelcase
        private string nameUsuario;
        private string password;

        public string NombreUsuario
        {
            get { return nameUsuario; }
            set { nameUsuario = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
