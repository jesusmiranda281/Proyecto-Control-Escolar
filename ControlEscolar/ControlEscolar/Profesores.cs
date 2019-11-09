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
using System.IO;

namespace ControlEscolar
{
    public partial class Profesores : Form
    {
        private OpenFileDialog _archivopdf;
        private profesorManejador _profesorManejador;
        estudiosManejador _estudioManejador;
        private string _ruta2;
        //private string maestros;
        public Profesores()
        {
            InitializeComponent();
            _profesorManejador = new profesorManejador();
            _estudioManejador = new estudiosManejador();
            _archivopdf = new OpenFileDialog();
           // maestros = txtNombre.Text;
             _ruta2 = Application.StartupPath + "\\DOCUMENTOS GUARDADOS DE MAESTROS\\";
            
            //_ruta2 = Path.GetDirectoryName(txtnocontrol.Text);
        }

        private void Profesores_Load(object sender, EventArgs e)
        {     
            gpbEstudios.Visible = false;
            BuscarProfesores("");
            controlbotones(true, false, false, true,false,false);
            controlcajas(false);
            limpiar();
            estadoManejador _estadoManejador = new estadoManejador();
            _estadoManejador.GetEstados(cmbEstado);   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true,true, true);
            controlcajas(true);
            txtnocontrol.Focus();
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar, bool mas, bool agregar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
            btnMas.Enabled = mas;
            
        }
        private void controlcajas(bool activar)
        {
            txtNombre.Enabled = activar;
            txtAppaterno.Enabled = activar;
            txtApmatero.Enabled = activar;
            txtnocontrol.Enabled = activar;
            txtTitulo.Enabled = activar;
            txtdomicilio.Enabled = activar;
            dtpFecha.Enabled = activar;
            txtCedula.Enabled = activar;
            cmbEstado.Enabled = activar;
            cmbCiudad.Enabled = activar;
            
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtAppaterno.Text = "";
            txtApmatero.Text = "";
            txtnocontrol.Text = "";
            txtTitulo.Text = "";
            txtdomicilio.Text = "";
            dtpFecha.Text = "";
            txtCedula.Text = "";
            lblId.Text = "0";
            cmbEstado.Text = "";
            cmbCiudad.Text = "";
            //cmbEstudios.Text = "";
            //listEstudio.Text = "";
        }
        private void BuscarProfesores(string filtro)
        {
            dtgProfesores.DataSource = _profesorManejador.GetProfesores(filtro);
            dtgProfesores.AutoResizeColumns();
        }
        private void guardarprofesores()
        {
            _profesorManejador.recuperardato(txtnocontrol.Text);
            _profesorManejador.Guardar(new Entidades.ControlEscolar.profesores
            {
                Idprofesor = Convert.ToInt32(lblId.Text),
                Numerocontrol = txtnocontrol.Text,
                Nombre = txtNombre.Text,
                Apellidopaterno = txtAppaterno.Text,
                Apellidomaterno = txtApmatero.Text,
                Domicilio = txtdomicilio.Text,
                Estado = cmbEstado.Text,
                Ciudad = cmbCiudad.Text,
                Numerocedula = txtCedula.Text,
                Titulo = txtTitulo.Text,
                Fechanacimiento = dtpFecha.Text         
            });
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true, false, false);
            controlcajas(false);
            try
            {   
                    guardarprofesores();
                    BuscarProfesores("");
                    limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true, false,false);
            controlcajas(false);
            limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProfesores(txtBuscar.Text);
        }
        private void eliminar()
        {
            var Idprofesores = dtgProfesores.CurrentRow.Cells["Idprofesor"].Value;
            _profesorManejador.Eliminar(Convert.ToInt32(Idprofesores));
        }
        private void eliminarestudios()
        {
            var Idestudios = dtgEstudios.CurrentRow.Cells["Idestudio"].Value;
            _estudioManejador.Eliminar(Convert.ToInt32(Idestudios));
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    BuscarProfesores("");
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
            controlbotones(false, true, true, false, true,true);
            lblId.Text = dtgProfesores.CurrentRow.Cells["Idprofesor"].Value.ToString();
            txtnocontrol.Text = dtgProfesores.CurrentRow.Cells["numerocontrol"].Value.ToString();
            txtNombre.Text = dtgProfesores.CurrentRow.Cells["nombre"].Value.ToString();
            txtAppaterno.Text = dtgProfesores.CurrentRow.Cells["apellidopaterno"].Value.ToString();
            txtApmatero.Text = dtgProfesores.CurrentRow.Cells["apellidomaterno"].Value.ToString();           
            txtdomicilio.Text = dtgProfesores.CurrentRow.Cells["domicilio"].Value.ToString();
            cmbEstado.Text = dtgProfesores.CurrentRow.Cells["estado"].Value.ToString();
            cmbCiudad.Text = dtgProfesores.CurrentRow.Cells["ciudad"].Value.ToString();
            txtCedula.Text = dtgProfesores.CurrentRow.Cells["numerocedula"].Value.ToString();
            txtTitulo.Text = dtgProfesores.CurrentRow.Cells["titulo"].Value.ToString();          
            dtpFecha.Text = dtgProfesores.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            //listEstudio.Text = dtgProfesores.CurrentRow.Cells["fkestudios"].Value.ToString();
        }

        private void dtgProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dtgEstudios.DataSource = _estudioManejador.GetEstudios();
            try
            {
                Modificar();
                BuscarProfesores("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudadesManejador _ciudadesManejador = new ciudadesManejador();
            _ciudadesManejador.GetCiudades(cmbCiudad, cmbEstado);
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            txtEstudio.Text = "";
            txtDocumento.Text = "";
            gpbEstudios.Visible = true;
            dtgEstudios.DataSource = _estudioManejador.GetEstudios(txtNombre.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
          
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }
        private void guardarestudios()
        {
            _estudioManejador.Guardar(new Estudios
            {
                Idestudio = Convert.ToInt32(lblds.Text),
                Estudio = txtEstudio.Text,
                Documento = txtDocumento.Text,
                Fkprofesor = txtNombre.Text
            });
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            GuardarArchivoPdf();
            guardarestudios();
            dtgEstudios.DataSource = _estudioManejador.GetEstudios(txtNombre.Text);
        }

        private void gpbEstudios_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gpbEstudios.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EliminarArchivoPDF();
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminarestudios();
                    dtgEstudios.DataSource = _estudioManejador.GetEstudios(txtNombre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarArchivopdf();
        }
        private void cargarArchivopdf()
        {
            _archivopdf.Filter = "Archivo tipo (*.pdf)|*.pdf";
            _archivopdf.Title = "Cargar Archivo Pdf";
            _archivopdf.ShowDialog();
            if (_archivopdf.FileName != "")
            {
                var archivo = new FileInfo(_archivopdf.FileName);
                txtDocumento.Text = archivo.Name;
            }
        }

        private void btnGuardarPdf_Click(object sender, EventArgs e)
        {
            
        }
        private void GuardarArchivoPdf()
        {
            if (_archivopdf.FileName != null)
            {
                if (_archivopdf.FileName != "")
                {
                    var archivo = new FileInfo(_archivopdf.FileName);
                    if (Directory.Exists(_ruta2))
                    {

                        var optenerArchivos2 = Directory.GetFiles(_ruta2, "*.pdf");
                        FileInfo archivoAnterior2;
                        if (optenerArchivos2.Length != 0)
                        {

                            archivoAnterior2 = new FileInfo(optenerArchivos2[0]);
                            if (archivoAnterior2.Exists)
                            { 
                                archivo.CopyTo(_ruta2 + archivo.Name);
                            }
                        }
                        else
                        {
                            archivo.CopyTo(_ruta2 + archivo.Name);
                        }

                    }
                    else
                    {
                        Directory.CreateDirectory(_ruta2);
                        archivo.CopyTo(_ruta2 + archivo.Name);
                    }
                }
            }
        }

        private void btnEliminarPdf_Click(object sender, EventArgs e)
        {
            EliminarArchivoPDF();
        }
        private void EliminarArchivoPDF()
        {
            string rutapdf = @"D:\5to. Semestre\Taller de base de datos\ControlEscolar\ControlEscolar\bin\Debug\DOCUMENTOS GUARDADOS DE MAESTROS\"+txtDocumento.Text+"";
            if (MessageBox.Show("Estas Seguro De Eliminar Archivo Pdf", "Eliminar PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                /*var obtenerArchivos2 = Directory.GetFiles(_ruta2, "*.pdf");
                FileInfo archivoAnterior2;
                
                if (obtenerArchivos2.Length != 0)
                {
                    archivoAnterior2 = new FileInfo(obtenerArchivos2[0]);
                    if (archivoAnterior2.Exists)
                    {
                        archivoAnterior2.Delete();
                    }
                    
                }*/
                if (File.Exists(rutapdf))
                {
                    File.Delete(rutapdf);
                }
            }
        }
        private void CargarDatos()
        {
            lblds.Text = dtgEstudios.CurrentRow.Cells["Idestudio"].Value.ToString();
            txtEstudio.Text = dtgEstudios.CurrentRow.Cells["Estudio"].Value.ToString();
            txtDocumento.Text = dtgEstudios.CurrentRow.Cells["Documento"].Value.ToString();
            
        }

        private void dtgEstudios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatos();
        }
    }
}
