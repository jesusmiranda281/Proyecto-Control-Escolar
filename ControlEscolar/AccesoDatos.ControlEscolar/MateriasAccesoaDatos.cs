using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.ControlEscolar;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.ControlEscolar
{
    public class MateriasAccesoaDatos
    {
        coneccionAccesoDatos conexion;
        public MateriasAccesoaDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(Materias materias)
        {
            //insertar
            if (materias.Id == 0)
            {
                string consulta = string.Format("insert into materias values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                materias.Idmateria, materias.Nombre, materias.Horasteoria, materias.Horaspractica, materias.Fkrelantes,
                materias.Fkreldespues, materias.Semestre);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                string consulta = string.Format("Update materias set Idmateria = '{0}', nombre = '{1}', horasteoria = '{2}', horaspractica = '{3}', fkrelantes = '{4}', fkreldespues = '{5}', semestre = '{6}' where Id = {7}",
                materias.Idmateria, materias.Nombre, materias.Horasteoria, materias.Horaspractica, materias.Fkrelantes,
                materias.Fkreldespues, materias.Semestre, materias.Id);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int id)
        {
            //eliminar
            string consulta = string.Format("delete from materias where Id = '{0}'",id);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<Materias> GetMaterias()
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listmaterias = new List<Materias>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from v_materias";
            ds = conexion.Obtenerdatos(consulta, "materias");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var materias = new Materias
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Idmateria = row["Clavedemateria"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Horasteoria = Convert.ToInt32(row["Horasdeteoria"]),
                    Horaspractica = Convert.ToInt32(row["Horasdepractica"]),
                    Fkrelantes = row["MateriaAnterior"].ToString(),
                    Fkreldespues = row["Materiaquesigue"].ToString(),
                    Semestre = row["semestre"].ToString(),
                    Total = Convert.ToInt32(row["Creditos"])
                };
                listmaterias.Add(materias);
            }
            //HardCodear
            //lenar lista
            return listmaterias;
        }
        public List<Materias> Combomaterias(ComboBox combo)
        {
            var listmaterias = new List<Materias>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select Clavedemateria from v_materias";
            ds = conexion.Obtenerdatos(consulta, "materias");
            combo.DataSource = ds.Tables[0];
            combo.DisplayMember = "Clavedemateria";
            //combo.ValueMember = "Idestudio";
            //combo.DataSource = dt;
            var dt = new DataTable();
            dt = ds.Tables[0];
            //combo.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //combo.Items.Add(datos);
                var materias = new Materias
                {
                    //Nombre = row["nombre"].ToString(),
                };
                listmaterias.Add(materias);
            }
            //lenar lista
            return listmaterias;
        }
    }
}
