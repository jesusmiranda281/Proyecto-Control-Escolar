using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Windows.Forms;

namespace LogicaNegocio.ControlEscolar
{
    public class estudiosManejador
    {
        private estudioAccesoDatos _estudioAccesoDatos = new estudioAccesoDatos();
        public void Guardar(Estudios estudios)
        {
            _estudioAccesoDatos.Guardar(estudios);
        }
        public void Eliminar(int Idestudios)
        {
            //eliminar
            _estudioAccesoDatos.Eliminar(Idestudios);
        }
        public List<Estudios> GetEstudios(string filtro)
        {
            var listestudio = _estudioAccesoDatos.GetEstudios(filtro);
            //lenar lista
            return listestudio;
        }
        public List<profesores> GetProfesores(ComboBox combo)
        {
            var listestudio = _estudioAccesoDatos.GetProfesores(combo);
            //lenar lista
            return listestudio;
        }

    }
}
