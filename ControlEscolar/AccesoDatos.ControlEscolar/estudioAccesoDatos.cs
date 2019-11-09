using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ControlEscolar;
using System.Data;

namespace AccesoDatos.ControlEscolar
{
    public class estudioAccesoDatos
    {
        coneccionAccesoDatos conexion;
        public estudioAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(Estudios estudios)
        {
            if (estudios.Idestudio == 0)
            {
                //insertar
                string consulta = string.Format("insert into estudios values(null,'{0}','{1}','{2}')",
                estudios.Estudio, estudios.Documento, estudios.Fkprofesor);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int Idestudio)
        {
            //eliminar
            string consulta = string.Format("delete from estudios where Idestudio = {0}", Idestudio);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<Estudios> GetEstudios(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listestudios = new List<Estudios>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from estudios where fkprofesor = '"+filtro+"'";
            ds = conexion.Obtenerdatos(consulta, "estudios");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var estudios = new Estudios
                {
                    Idestudio = Convert.ToInt32(row["Idestudio"]),
                    Estudio = row["estudios"].ToString(),
                    Documento = row["documento"].ToString(),
                    Fkprofesor = row["fkprofesor"].ToString()
                };
                listestudios.Add(estudios);
            }
            //HardCodear
            //lenar lista
            return listestudios;
        }
        public List<profesores> GetProfesores(ComboBox combo)
        {
            var listprofesores = new List<profesores>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from profesores";
            ds = conexion.Obtenerdatos(consulta, "profesores");
            combo.DataSource = ds.Tables[0];
            combo.DisplayMember = "nombre";
            //combo.ValueMember = "Idestudio";
            //combo.DataSource = dt;
            var dt = new DataTable();
            dt = ds.Tables[0];
            //combo.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //combo.Items.Add(datos);
                var profesores = new profesores
                {
                    Nombre = row["nombre"].ToString(),
                };
                listprofesores.Add(profesores);
            }
            //lenar lista
            return listprofesores;
        }
    }
}
