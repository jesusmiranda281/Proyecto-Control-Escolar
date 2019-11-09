using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ControlEscolar;
using LogicaNegocio.ControlEscolar;

namespace ControlEscolar
{
    public partial class FrmUsuarios : Form
    {
        private UsuarioManejador _usuarioManejador;
        private Usuario _usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
            _usuarioManejador = new UsuarioManejador();
            _usuario = new Usuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarUsuarios("");//aqui se carga todo, no se especifica nada, para que no haga filtro.
            controlbotones(true, false, false, true);
            controlcajas(false);
            limpiar();
        }
        private void BuscarUsuarios(string filtro)
        {
            dtgUsuario.DataSource = _usuarioManejador.GetUsuarios(filtro);
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true);
            controlcajas(true);
            txtNombre.Focus();
        }
        private bool validarusuario()
        {
            var tupla = _usuarioManejador.validarusuario(_usuario);
            var valido = tupla.Item1;
            var mensaje = tupla.Item2;
            if (!valido)
            {
                MessageBox.Show(mensaje,"Error de validacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return valido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarusuario();
            try
            {
                controlbotones(true, false, false, true);
                controlcajas(false);
                if (validarusuario())
                {
                    guardarusuario();
                    BuscarUsuarios("");
                    limpiar();
                    //para guardar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cargarusuario()
        {
            _usuario.Idusuario = Convert.ToInt32(lblId.Text);
            _usuario.Nombre = txtNombre.Text;
            _usuario.Apellidopaterno = txtAppaterno.Text;
            _usuario.Apellidomaterno = txtApmatero.Text;
            _usuario.Contrasenia = txtContrasenia.Text;
        }
        private void guardarusuario()
        {
            _usuarioManejador.Guardar(_usuario);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, false);
            controlcajas(false);
            limpiar();
        }
        private void controlcajas(bool activar)
        {
            txtNombre.Enabled = activar;
            txtAppaterno.Enabled = activar;
            txtApmatero.Enabled = activar;
            txtContrasenia.Enabled = activar;
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtAppaterno.Text = "";
            txtApmatero.Text = "";
            txtContrasenia.Text = "";
            lblId.Text = "0";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    BuscarUsuarios("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void eliminar()
        {
            var Idusuario = dtgUsuario.CurrentRow.Cells["Idusuario"].Value;
            _usuarioManejador.Eliminar(Convert.ToInt32(Idusuario));
        }

        private void dtgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                BuscarUsuarios("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Modificar()
        {
            controlcajas(true);
            controlbotones(false, true, true, false);
            lblId.Text = dtgUsuario.CurrentRow.Cells["Idusuario"].Value.ToString();
            txtNombre.Text = dtgUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
            txtAppaterno.Text = dtgUsuario.CurrentRow.Cells["Apellidopaterno"].Value.ToString();
            txtApmatero.Text = dtgUsuario.CurrentRow.Cells["Apellidomaterno"].Value.ToString();
            txtContrasenia.Text = dtgUsuario.CurrentRow.Cells["contrasenia"].Value.ToString();
        }
    }
}
