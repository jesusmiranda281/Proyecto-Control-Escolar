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
    public partial class Alumnos : Form
    {
        private Alumnomanejador _alumnoManejador;
        private Entidades.ControlEscolar.Alumnos _alumnos;
        public Alumnos()
        {
            InitializeComponent();
            _alumnoManejador = new Alumnomanejador();
            _alumnos = new Entidades.ControlEscolar.Alumnos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true);
            controlcajas(true);
            txtnocontrol.Focus();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
           
            BuscarAlumnos("");
            controlbotones(true, false, false, true);
            controlcajas(false);
            limpiar();
            estadoManejador _estadoManejador = new estadoManejador();
            _estadoManejador.GetEstados(cmbEstado);
            
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
        }
        private void controlcajas(bool activar)
        {
            txtNombre.Enabled = activar;
            txtAppaterno.Enabled = activar;
            txtApmatero.Enabled = activar;
            txtnocontrol.Enabled = activar;
            txtemail.Enabled = activar;
            txtdomicilio.Enabled = activar;
            dtpFecha.Enabled = activar;
            cmbSexo.Enabled = activar;
            cmbEstado.Enabled = activar;
            cmbCiudad.Enabled = activar;
            
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtAppaterno.Text = "";
            txtApmatero.Text = "";
            txtnocontrol.Text = "";
            txtemail.Text = "";
            txtdomicilio.Text = "";
            dtpFecha.Text = "";
            cmbSexo.Text = "";
            lblId.Text = "0";
            cmbEstado.Text = "";
            cmbCiudad.Text = "";
        }
        private void BuscarAlumnos(string filtro)
        {
            dtgAlumnos.DataSource = _alumnoManejador.GetAlumnos(filtro);
        }
        private void guardaralumnos()
        {
            _alumnoManejador.Guardar(new Entidades.ControlEscolar.Alumnos
            {
                Idalumnos = Convert.ToInt32(lblId.Text),
                Nombre = txtNombre.Text,
                Apellidopaterno = txtAppaterno.Text,
                Apellidomaterno = txtApmatero.Text,
                Numerocontrol = txtnocontrol.Text,
                Fechanacimiento = dtpFecha.Text,
                Domicilio = txtdomicilio.Text,
                Email = txtemail.Text,
                Sexo = cmbSexo.Text,
                Estado = cmbEstado.Text,
                Ciudad = cmbCiudad.Text
            });
        }
        private bool validaralumno()
        {
            var tupla = _alumnoManejador.validaralumno(_alumnos);
            var valido = tupla.Item1;
            var mensaje = tupla.Item2;
            if (!valido)
            {
                MessageBox.Show(mensaje, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargaralumnos();
            try
            {
                controlbotones(true, false, false, true);
                controlcajas(false);
                if (validaralumno())
                {
                    guardaralumnos();
                    BuscarAlumnos("");
                    limpiar();
                    //para guardar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cargaralumnos()
        {
            _alumnos.Idalumnos = Convert.ToInt32(lblId.Text);
            _alumnos.Numerocontrol = txtnocontrol.Text;
            _alumnos.Nombre = txtNombre.Text;
            _alumnos.Apellidopaterno = txtAppaterno.Text;
            _alumnos.Apellidomaterno = txtApmatero.Text;
            _alumnos.Fechanacimiento = dtpFecha.Text;
            _alumnos.Domicilio = txtdomicilio.Text;
            _alumnos.Email = txtemail.Text;
            _alumnos.Sexo = cmbSexo.Text;
            _alumnos.Estado = cmbEstado.Text;
            _alumnos.Ciudad = cmbCiudad.Text;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true);
            controlcajas(false);
            limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlumnos(txtBuscar.Text);
        }
        private void eliminar()
        {
            var Idalumno = dtgAlumnos.CurrentRow.Cells["Idalumnos"].Value;
            _alumnoManejador.Eliminar(Convert.ToInt32(Idalumno));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    BuscarAlumnos("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Modificar()
        {
            controlcajas(true);
            controlbotones(false, true, true, false);
            lblId.Text = dtgAlumnos.CurrentRow.Cells["Idalumnos"].Value.ToString();
            txtnocontrol.Text = dtgAlumnos.CurrentRow.Cells["numerocontrol"].Value.ToString();
            txtNombre.Text = dtgAlumnos.CurrentRow.Cells["nombre"].Value.ToString();
            txtAppaterno.Text = dtgAlumnos.CurrentRow.Cells["apellidopaterno"].Value.ToString();
            txtApmatero.Text = dtgAlumnos.CurrentRow.Cells["apellidomaterno"].Value.ToString();
            dtpFecha.Text = dtgAlumnos.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            txtdomicilio.Text = dtgAlumnos.CurrentRow.Cells["domicilio"].Value.ToString();
            txtemail.Text = dtgAlumnos.CurrentRow.Cells["email"].Value.ToString();
            cmbSexo.Text = dtgAlumnos.CurrentRow.Cells["sexo"].Value.ToString();
            cmbEstado.Text = dtgAlumnos.CurrentRow.Cells["estado"].Value.ToString();
            cmbCiudad.Text = dtgAlumnos.CurrentRow.Cells["ciudad"].Value.ToString();
        }

        private void dtgAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                BuscarAlumnos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudadesManejador _ciudadesManejador = new ciudadesManejador();
            _ciudadesManejador.GetCiudades(cmbCiudad, cmbEstado);
        }
        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {  
        }
        private void cmbEstado_StyleChanged(object sender, EventArgs e)
        {          
        }

        private void dtgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                BuscarAlumnos(" ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
