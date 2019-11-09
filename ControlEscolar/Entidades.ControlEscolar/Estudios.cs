using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Estudios
    {
        private int idestudio;
        private string estudio;
        private string documento;
        private string fkprofesor;

        public int Idestudio { get => idestudio; set => idestudio = value; }
        public string Estudio { get => estudio; set => estudio = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Fkprofesor { get => fkprofesor; set => fkprofesor = value; }
    }
}
