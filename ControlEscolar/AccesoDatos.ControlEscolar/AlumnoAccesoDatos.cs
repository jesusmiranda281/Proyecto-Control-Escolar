using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;

namespace AccesoDatos.ControlEscolar
{
    public class AlumnoAccesoDatos
    {
        coneccionAccesoDatos conexion;
        public AlumnoAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(Alumnos alumnos)
        {
            if (alumnos.Idalumnos == 0)
            {
                //insertar
                string consulta = string.Format("insert into alumnos values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                alumnos.Numerocontrol, alumnos.Nombre, alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fechanacimiento, alumnos.Domicilio,
                alumnos.Email, alumnos.Sexo, alumnos.Estado, alumnos.Ciudad);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                //update o que lo modifique
                string consulta = string.Format("Update alumnos set numerocontrol = '{0}', nombre = '{1}', apellidopaterno = '{2}', apellidomaterno = '{3}', fechanacimiento = '{4}', domicilio = '{5}', email = '{6}', sexo = '{7}', estado = '{8}', ciudad = '{9}' where Idalumnos = {10}",
                alumnos.Numerocontrol, alumnos.Nombre, alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fechanacimiento,
                alumnos.Domicilio, alumnos.Email, alumnos.Sexo, alumnos.Estado, alumnos.Ciudad, alumnos.Idalumnos);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int Idalumnos)
        {
            //eliminar
            string consulta = string.Format("delete from alumnos where Idalumnos = {0}", Idalumnos);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listalumnos = new List<Alumnos>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from alumnos where nombre like '%" + filtro + "%'";
            ds = conexion.Obtenerdatos(consulta, "alumnos");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var alumnos = new Alumnos
                {
                    Idalumnos = Convert.ToInt32(row["Idalumnos"]),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidopaterno"].ToString(),
                    Apellidomaterno = row["apellidomaterno"].ToString(),
                    Fechanacimiento = row["fechanacimiento"].ToString(),
                    Domicilio = row["domicilio"].ToString(),
                    Email = row["email"].ToString(),
                    Sexo = row["sexo"].ToString(),
                    Estado = row["estado"].ToString(),
                    Ciudad = row["ciudad"].ToString()
                };
                listalumnos.Add(alumnos);
            }
            //HardCodear
            //lenar lista
            return listalumnos;
        }
    }
}
