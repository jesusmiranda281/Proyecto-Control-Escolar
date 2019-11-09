using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class ciudades
    {
        private int _codigociudad;
        private string _nombre;
        private string _fkestado;

        public int Codigociudad { get => _codigociudad; set => _codigociudad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Fkestado { get => _fkestado; set => _fkestado = value; }
    }
}
