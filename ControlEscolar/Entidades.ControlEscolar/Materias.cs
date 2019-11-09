using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Materias
    {
        private int _id;
        private string _idmateria;
        private string _nombre;
        private int _horasteoria;
        private int _horaspractica;
        private string _fkrelantes;
        private string _fkreldespues;
        private string _semestre;
        private int _total;

        public int Id { get => _id; set => _id = value; }
        public string Idmateria { get => _idmateria; set => _idmateria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Horasteoria { get => _horasteoria; set => _horasteoria = value; }
        public int Horaspractica { get => _horaspractica; set => _horaspractica = value; }
        public string Fkrelantes { get => _fkrelantes; set => _fkrelantes = value; }
        public string Fkreldespues { get => _fkreldespues; set => _fkreldespues = value; }
        public string Semestre { get => _semestre; set => _semestre = value; }
        public int Total { get => _total; set => _total = value; }
    }
}
