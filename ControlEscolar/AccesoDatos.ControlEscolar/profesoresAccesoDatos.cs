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
    public class profesoresAccesoDatos
    {
        coneccionAccesoDatos conexion;
        public profesoresAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public string ultimonumero, rr, recuperarnm, datosdeconsulta0, d2, d3, nuevonumero;
        public string filtro2;
        public int numero;
        public void recuperarDato(string filtro)
        {
            var ds0 = new DataSet();
            var dt0 = new DataTable();
            var ds = new DataSet();
            var dt = new DataTable();
            filtro2 = filtro;
            string consulta0 = string.Format("select numerocontrol from profesores where numerocontrol like '%" + "D" + filtro + "%' ");
            ds0 = conexion.Obtenerdatos(consulta0, "profesores");
            dt0 = ds0.Tables[0];
            foreach (DataRow row in dt0.Rows)
            {
                datosdeconsulta0 = row["numerocontrol"].ToString();
            }
            string consulta1 = string.Format("select numerocontrol from profesores where numerocontrol like '%" + "D" + filtro + "%' order by Idprofesor desc limit 1;");
            ds = conexion.Obtenerdatos(consulta1, "profesores");
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                ultimonumero = row["numerocontrol"].ToString();
            }
            if (datosdeconsulta0 == null)
            {
                d3 = "D" + filtro;
                numero = 0;
                nuevonumero = d3 + numero;
            }
            else
            {
                d2 = datosdeconsulta0;
                d3 = datosdeconsulta0.Substring(0, 5);

                if ("D" + filtro == d3)
                {
                    rr = ultimonumero;
                    recuperarnm = ultimonumero.Substring(5);
                    numero = Convert.ToInt32(recuperarnm) + 1;
                    nuevonumero = "D" + filtro + numero;
                }
                else
                {
                    numero = 0;
                    nuevonumero = "D" + filtro + numero;
                }
            }
            //MessageBox.Show(nuevonumero);
        }
        public void Guardar(profesores profesores)
        {
            //if (var != dtg.CurrentRow.Cells["numerocontrol"].Value.ToString())
            //{
                if (profesores.Idprofesor == 0)
                {
                    //insertar
                    string consulta = string.Format("insert into profesores values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                   nuevonumero, profesores.Nombre, profesores.Apellidopaterno, profesores.Apellidomaterno, profesores.Domicilio,
                    profesores.Estado, profesores.Ciudad, profesores.Numerocedula, profesores.Titulo, profesores.Fechanacimiento);
                    conexion.Ejecutarconsulta(consulta);
                }
                else
                {
                    //update o que lo modifique
                    string consulta = string.Format("Update profesores set numerocontrol = '{0}', nombre = '{1}', apellidopaterno = '{2}', apellidomaterno = '{3}', domicilio = '{4}', estado = '{5}', ciudad = '{6}', numerocedula = '{7}', titulo = '{8}', fechanacimiento = '{9}'  where Idprofesor = {10}",
                    nuevonumero, profesores.Nombre, profesores.Apellidopaterno, profesores.Apellidomaterno, profesores.Domicilio,
                    profesores.Estado, profesores.Ciudad, profesores.Numerocedula, profesores.Titulo, profesores.Fechanacimiento, profesores.Idprofesor);
                    conexion.Ejecutarconsulta(consulta);
                }
              //  i++;
            //}
            //else if(var == dtg.CurrentRow.Cells["numerocontrol"].Value.ToString())
              //i++;
        }
        public void Eliminar(int Idprofesor)
        {
            //eliminar
            string consulta = string.Format("delete from profesores where Idprofesor = {0}", Idprofesor);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<profesores> GetProfesores(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listprofesores = new List<profesores>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from profesores where nombre like '%" + filtro + "%'";
            ds = conexion.Obtenerdatos(consulta, "profesores");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var profesores = new profesores
                {
                    Idprofesor = Convert.ToInt32(row["Idprofesor"]),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidopaterno"].ToString(),
                    Apellidomaterno = row["apellidomaterno"].ToString(),
                    Domicilio = row["domicilio"].ToString(),
                    Estado = row["estado"].ToString(),
                    Ciudad = row["ciudad"].ToString(),
                    Numerocedula = row["numerocedula"].ToString(),
                    Titulo = row["titulo"].ToString(),
                    Fechanacimiento = row["fechanacimiento"].ToString()
                };
                listprofesores.Add(profesores);
            }
            //HardCodear
            //lenar lista
            return listprofesores;
        }
    }
}
