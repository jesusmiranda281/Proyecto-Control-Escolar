using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Text.RegularExpressions;
using AccesoDatos.ControlEscolar;

namespace LogicaNegocio.ControlEscolar
{
    public class Alumnomanejador
    {
        private AlumnoAccesoDatos _alumnoAccesoDatos = new AlumnoAccesoDatos();
        private bool numerodecontrolvalido(string numero)
        {
            var regex = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");//Para validar campos de texto.
            var match = regex.Match(numero);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool nombrevalido(string nombre)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");//Para validar campos de texto.
            var match = regex.Match(nombre);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool apellidopaternovalido(string paterno)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");//Para validar campos de texto.
            var match = regex.Match(paterno);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool apellidomaternovalido(string materno)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");//Para validar campos de texto.
            var match = regex.Match(materno);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool domiciliovalido(string domicilio)
        {
            var regex = new Regex(@"^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$");//Para validar campos de texto.
            var match = regex.Match(domicilio);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool emailvalido(string email)
        {
            var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");//Para validar campos de texto.
            var match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public Tuple<bool, string> validaralumno(Alumnos alumno)
        {
            string mensaje = "";
            bool valido = true;
            if (alumno.Numerocontrol.Length == 0)
            {
                mensaje = mensaje + "El numero de control es necesario \n";
                valido = false;
            }
            else if (alumno.Numerocontrol.Length > 10)
            {
                mensaje = mensaje + "El numero de control solo permite un maximo de 10 caracteres \n";
                valido = false;
            }
            else if (!numerodecontrolvalido(alumno.Numerocontrol))
            {
                mensaje = mensaje + "Escribe un formato valido para el numero de control \n";
                valido = false;
            }
            if (alumno.Nombre.Length == 0)
            {
                mensaje = mensaje + "El nombre del alumno es necesario \n";
                valido = false;
            }
            else if (alumno.Nombre.Length > 20)
            {
                mensaje = mensaje + "El nombre del alumno solo permite un maximo de 20 caracteres \n";
                valido = false;
            }
            else if (!nombrevalido(alumno.Nombre))
            {
                mensaje = mensaje + "Escribe un formato valido para el nombre del alumno \n";
                valido = false;
            }
            if (alumno.Apellidopaterno.Length == 0)
            {
                mensaje = mensaje + "El Apellido paterno es necesario \n";
                valido = false;
            }
            else if (!apellidopaternovalido(alumno.Apellidopaterno))
            {
                mensaje = mensaje + "Escribe un formato valido para el Apellido Paterno \n";
                valido = false;
            }
            else if (alumno.Apellidopaterno.Length > 20)
            {
                mensaje = mensaje + "El Apellido paterno solo permite un maximo de 20 caracteres \n";
                valido = false;
            }
            if (alumno.Apellidomaterno.Length == 0)
            {
                mensaje = mensaje + "El Apellido materno es necesario \n";
                valido = false;
            }
            else if (!apellidomaternovalido(alumno.Apellidomaterno))
            {
                mensaje = mensaje + "Escribe un formato valido para el Apellido materno \n";
                valido = false;
            }
            else if (alumno.Apellidomaterno.Length > 20)
            {
                mensaje = mensaje + "El Apellido materno solo permite un maximo de 20 caracteres \n";
                valido = false;
            }
            if (alumno.Domicilio.Length == 0)
            {
                mensaje = mensaje + "El Domicilio es necesario \n";
                valido = false;
            }
            else if (!domiciliovalido(alumno.Domicilio))
            {
                mensaje = mensaje + "Escribe un formato valido para el Domicilio \n";
                valido = false;
            }
            if (alumno.Email.Length == 0)
            {
                mensaje = mensaje + "El Email es necesario \n";
                valido = false;
            }
            else if (!emailvalido(alumno.Email))
            {
                mensaje = mensaje + "Escribe un formato valido para el email \n";
                valido = false;
            }

            return Tuple.Create(valido, mensaje);
        }
        public void Guardar(Alumnos alumnos)
        {
            _alumnoAccesoDatos.Guardar(alumnos);
        }
        public void Eliminar(int Idalumnos)
        {
            //eliminar
            _alumnoAccesoDatos.Eliminar(Idalumnos);
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            var listalumno = _alumnoAccesoDatos.GetAlumnos(filtro);
            //lenar lista
            return listalumno;
        }
    }
}
