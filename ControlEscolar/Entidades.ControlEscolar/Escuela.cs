using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Escuela
    {
        private int _idescuela;
        private string _nombre;
        private string _rfc;
        private string _domicilio;
        private string _telefono;
        private string _email;
        private string _web;
        private string _director;
        private string _logo;

        public int Idescuela { get => _idescuela; set => _idescuela = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public string Web { get => _web; set => _web = value; }
        public string Director { get => _director; set => _director = value; }
        public string Logo { get => _logo; set => _logo = value; }
       
    }
}
