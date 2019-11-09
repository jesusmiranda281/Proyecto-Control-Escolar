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
    public class ciudadesManejador
    {
        private ciudadesAccesoDatos _ciudadesAccesoDatos = new ciudadesAccesoDatos();

        public List<ciudades> GetCiudades(ComboBox li, ComboBox estado)
        {
            var listciudades = _ciudadesAccesoDatos.GetCiudades(li, estado);
            //llenar lista
            return listciudades;
        }
    }
}
