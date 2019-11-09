using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.ControlEscolar
{
    public class estadosAccesoDatos
    {
        
        coneccionAccesoDatos conexion;
        public estadosAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public List<estados> GetEstados(ComboBox combo)
        {
            var listestados = new List<estados>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from estados";
            ds = conexion.Obtenerdatos(consulta, "estados");
            combo.DataSource = ds.Tables[0];
            combo.DisplayMember = "codigo";
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //combo.Items.Add(datos);
                var estados = new estados
                {
                    Codigo = row["codigo"].ToString(),
                    Nombre = row["nombre"].ToString(),
                };
                listestados.Add(estados);
            }
            //lenar lista
            return listestados;
        }
    }
}
