using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Text.RegularExpressions;
namespace LogicaNegocio.ControlEscolar
{
    public class UsuarioManejador
    {
        private UsuarioAccesoDatos _usuarioAccesoDatos = new UsuarioAccesoDatos();
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
        public Tuple<bool, string> validarusuario(Usuario usuario)
        {
            string mensaje = "";
            bool valido = true;
            if (usuario.Nombre.Length == 0)
            {
                mensaje = mensaje + "El nombre de usuario es necesario \n";
                valido = false;
            }
            else if (usuario.Nombre.Length > 20)
            {
                mensaje = mensaje + "El nombre de usuario solo permite un maximo de 20 caracteres \n";
                valido = false;
            }
            else if (!nombrevalido(usuario.Nombre))
            {
                mensaje = mensaje + "Escribe un formato valido para el nombre de Usuario \n";
                valido = false;
            }
            if (usuario.Apellidopaterno.Length == 0)
            {
                mensaje = mensaje + "El Apellido paterno es necesario \n";
                valido = false;
            }
            else if (!apellidopaternovalido(usuario.Apellidopaterno))
            {
                mensaje = mensaje + "Escribe un formato valido para el Apellido Paterno \n";
                valido = false;
            }
            else if (usuario.Apellidopaterno.Length > 20)
            {
                mensaje = mensaje + "El Apellido paterno solo permite un maximo de 20 caracteres \n";
                valido = false;
            }
            if (usuario.Apellidomaterno.Length == 0)
            {
                mensaje = mensaje + "El Apellido materno de usuario es necesario \n";
                valido = false;
            }
            else if (!apellidomaternovalido(usuario.Apellidomaterno))
            {
                mensaje = mensaje + "Escribe un formato valido para el Apellido Materno \n";
                valido = false;
            }
            else if (usuario.Apellidomaterno.Length > 20)
            {
                mensaje = mensaje + "El Apellido Materno solo permite un maximo de 20 caracteres \n";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
        public void Guardar(Usuario usuario)
        {
            _usuarioAccesoDatos.Guardar(usuario);
        }
        public void Eliminar(int Idusuario)
        {
            //eliminar
            _usuarioAccesoDatos.Eliminar(Idusuario);
        }
        public List<Usuario> GetUsuarios(string filtro)
        {
            var listusuario = _usuarioAccesoDatos.GetUsuarios(filtro);
            //lenar lista
            return listusuario;
        }
    }
}
