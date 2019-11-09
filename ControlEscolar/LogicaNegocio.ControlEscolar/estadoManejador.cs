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
    
    public class estadoManejador
    {
        private estadosAccesoDatos _estadoAccesoDatos = new estadosAccesoDatos();
        
        public List<estados> GetEstados(ComboBox combo)
        {
            
            var listestados = _estadoAccesoDatos.GetEstados(combo);          
            //llenar lista
            return listestados;
        }
    }
}
