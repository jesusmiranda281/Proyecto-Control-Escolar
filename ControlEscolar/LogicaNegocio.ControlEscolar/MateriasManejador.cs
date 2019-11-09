using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio.ControlEscolar
{
    public class MateriasManejador
    {
        private MateriasAccesoaDatos _materiasAccesoaDatos = new MateriasAccesoaDatos();
        public void Guardar(Materias materias)
        {
            _materiasAccesoaDatos.Guardar(materias);
        }
        public void Eliminar(int Idmateria)
        {
            //eliminar
            _materiasAccesoaDatos.Eliminar(Idmateria);
        }
        public List<Materias> GetMaterias()
        {
            var listmaterias = _materiasAccesoaDatos.GetMaterias();
            //lenar lista
            return listmaterias;
        }
        public List<Materias> Combomaterias(ComboBox combo)
        {
            var listmaterias = _materiasAccesoaDatos.Combomaterias(combo);
            //lenar lista
            return listmaterias;
        }
    }
}
