using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.ControlEscolar;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AccesoDatos.ControlEscolar
{
    public class escuelaAccesoaDatos
    {
        coneccionAccesoDatos conexion;

        public escuelaAccesoaDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        /*public void datos(Escuela e, TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7, TextBox t8)
        {
            t1.Text = e.Nombre;
            t2.Text = 
        }*/
        public string obtenerconsulta;
        public void Guardar(Escuela escuela)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            string consultaa = string.Format("select Idescuela from escuela");
            ds = conexion.Obtenerdatos(consultaa, "escuela");
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                obtenerconsulta = row["Idescuela"].ToString();
            }
            if (obtenerconsulta == null)
            {


                //insertar
                string consulta = string.Format("insert into escuela values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                escuela.Nombre, escuela.Rfc, escuela.Domicilio, escuela.Telefono, escuela.Email, escuela.Web, escuela.Director,
                escuela.Logo);
                conexion.Ejecutarconsulta(consulta);
            }
            else if (escuela.Idescuela != 0)
            {
                //update o que lo modifique
                string consulta = string.Format("Update escuela set nombre = '{0}', rfc = '{1}', domicilio = '{2}', telefono = '{3}', email = '{4}', pagina = '{5}', director = '{6}', logo = '{7}' where Idescuela = {8}",
                escuela.Nombre, escuela.Rfc, escuela.Domicilio, escuela.Telefono, escuela.Email, escuela.Web, escuela.Director,
                escuela.Logo, escuela.Idescuela);
                conexion.Ejecutarconsulta(consulta);
            }
            else 
            {
                MessageBox.Show("Inadmitido!!! Solo se permite un valor");
            }
        }
        public void Eliminar()
        {
            //eliminar
            string consulta = string.Format("delete from escuela");
            conexion.Ejecutarconsulta(consulta);
        }
        public DataSet datos()
        {
            var ds = new DataSet();
            string consulta = "Select * from escuela";
            ds = conexion.Obtenerdatos(consulta, "escuela");
            return ds;
        }
        public List<Escuela> GetEscuela()
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listescuela = new List<Escuela>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from escuela";
            ds = conexion.Obtenerdatos(consulta, "escuela");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var escuela = new Escuela
                {
                    Idescuela = Convert.ToInt32(row["Idescuela"]),
                    Nombre = row["nombre"].ToString(),
                    Rfc = row["rfc"].ToString(),
                    Domicilio = row["domicilio"].ToString(),
                    Telefono = row["telefono"].ToString(),
                    Email = row["email"].ToString(),
                    Web = row["pagina"].ToString(),
                    Director = row["director"].ToString(),
                    Logo = row["logo"].ToString()
                };
                listescuela.Add(escuela);
            }
            //HardCodear
            //lenar lista
            return listescuela;
        }
    }
}
