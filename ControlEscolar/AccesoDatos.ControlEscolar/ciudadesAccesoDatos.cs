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
    public class ciudadesAccesoDatos
    {      
        coneccionAccesoDatos conexion;
        public ciudadesAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public List<ciudades> GetCiudades(ComboBox li, ComboBox estado)
        {
            var listciudades = new List<ciudades>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "SELECT Nombre FROM ciudades WHERE fkestado = '" + estado.Text + "'";
            ds = conexion.Obtenerdatos(consulta, "ciudades");
            li.DataSource = ds.Tables[0];
            li.DisplayMember = "nombre";
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //li.Items.Add(datos);
                var ciudades = new ciudades
                {
                    //Codigociudad = Convert.ToInt32(row["codigociudad"]),
                    Nombre = row["Nombre"].ToString(),
                    //Fkestado = row["fkestado"].ToString()
                };
                listciudades.Add(ciudades);
            }
            //lenar lista
            return listciudades;
        }
    }
}
