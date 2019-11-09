using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class profesores
    {
        private int _idprofesor;
        private string _numerocontrol;
        private string _nombre;
        private string _apellidopaterno;
        private string _apellidomaterno;
        private string _domicilio;
        private string _estado;
        private string _ciudad;
        private string _numerocedula;
        private string _titulo;
        private string _fechanacimiento;
        public int Idprofesor { get => _idprofesor; set => _idprofesor = value; }
        public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string Numerocedula { get => _numerocedula; set => _numerocedula = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
    }
}
