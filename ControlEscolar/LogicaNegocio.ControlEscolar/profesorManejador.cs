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
    public class profesorManejador
    {
        private profesoresAccesoDatos _profesorAccesoDatos = new profesoresAccesoDatos();
        public void recuperardato(string filtro)
        {
            _profesorAccesoDatos.recuperarDato(filtro);
        }
        public void Guardar(profesores profesor)
        {
            _profesorAccesoDatos.Guardar(profesor);
        }
        public void Eliminar(int Idprofesor)
        {
            //eliminar
            _profesorAccesoDatos.Eliminar(Idprofesor);
        }
        public List<profesores> GetProfesores(string filtro)
        {
            var listprofesor = _profesorAccesoDatos.GetProfesores(filtro);
            //lenar lista
            return listprofesor;
        }
    }
}
