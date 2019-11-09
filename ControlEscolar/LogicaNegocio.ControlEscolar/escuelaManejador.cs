using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Threading.Tasks;
using System.Data;

namespace LogicaNegocio.ControlEscolar
{
    public class escuelaManejador
    {
        private escuelaAccesoaDatos _escuelaAccesoaDatos = new escuelaAccesoaDatos();
        public void Guardar(Escuela escuela)
        {
            _escuelaAccesoaDatos.Guardar(escuela);
        }
        public void Eliminar()
        {
            //eliminar
            _escuelaAccesoaDatos.Eliminar();
        }
        public List<Escuela> GetEscuela()
        {
            var listescuela = _escuelaAccesoaDatos.GetEscuela();
            //lenar lista
            return listescuela;
        }
        public DataSet datos()
        {
            var ds = _escuelaAccesoaDatos.datos();
            return ds;
        }
    }
}
