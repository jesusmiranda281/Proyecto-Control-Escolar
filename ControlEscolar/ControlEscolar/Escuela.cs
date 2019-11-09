using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using LogicaNegocio.ControlEscolar;
using System.Windows.Forms;
using System.IO;

namespace ControlEscolar
{
    public partial class Escuela : Form
    {
        private Image nothing = null;
        private escuelaManejador _escuelaManejador;
        private Entidades.ControlEscolar.Escuela _escuela;
        private string _ruta;
        OpenFileDialog buscarimagen;
        
        public Escuela()
        {
            InitializeComponent();
            _escuelaManejador = new escuelaManejador();
            _escuela = new Entidades.ControlEscolar.Escuela();
            buscarimagen = new OpenFileDialog();
            _ruta = Application.StartupPath + "\\LOGO\\";
            
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false,true, true, true,true);
            controlcajas(true);
            txtxNombre.Focus();
            limpiar();
            
        }

        private void Escuela_Load(object sender, EventArgs e)
        {
            //Modificar();
            btnEliminarImagen.Enabled = false;
            datos();
            BuscarEscuela();
            controlbotones(true, false, false, true, false);
            controlcajas(false);
            //limpiar();
            dtgEscuela.Visible = false;
            txtLogo.Enabled = false;
            var logo = dtgEscuela.CurrentRow.Cells["logo"].Value.ToString();
            string direccion = _ruta + logo;
            ptbLogo.ImageLocation = direccion;
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            //dtgEscuela.RowCount = 1;
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar, bool mas)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
            btnLogo.Enabled = mas;
        }
        private void controlcajas(bool activar)
        {
            txtxNombre.Enabled = activar;
            txtDirector.Enabled = activar;
            txtDomicilio.Enabled = activar;
            txtEmail.Enabled = activar;
            txtRFC.Enabled = activar;
            txtWeb.Enabled = activar;
            txtTelefono.Enabled = activar;
            ptbLogo.Enabled = activar;
           // txtLogo.Enabled = activar;
        }
        private void limpiar()
        {
            txtxNombre.Text = "";
            txtDirector.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtRFC.Text = "";
            txtWeb.Text = "";
            txtTelefono.Text = "";
            txtLogo.Text="";
        }
        private void BuscarEscuela()
        {
            dtgEscuela.DataSource = _escuelaManejador.GetEscuela();
            dtgEscuela.AutoResizeColumns();
        }
        private void guardarescuela()
        {
            _escuelaManejador.Guardar(new Entidades.ControlEscolar.Escuela
            {
                Idescuela = Convert.ToInt32(lblId.Text),
                Nombre = txtxNombre.Text,
                Rfc = txtRFC.Text,
                Domicilio = txtDomicilio.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Web = txtWeb.Text,
                Director = txtDirector.Text,
                Logo = txtLogo.Text
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true, false);
            controlcajas(false);
            try
            {
                guardarescuela();
                GuardarImagen();
                BuscarEscuela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            ds = _escuelaManejador.datos();
            controlbotones(true, false, false, true,false);
            controlcajas(false);
            datos();
            //ptbLogo.Image = nothing;
            //txtLogo.Text = "";
            //var logo = ds.Tables[0].Rows[0]["logo"].ToString();
            //string direccion = _ruta + logo;
            //ptbLogo.ImageLocation = direccion;
            //ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void eliminar()
        {
            Eliminarimagen();
            _escuelaManejador.Eliminar();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    BuscarEscuela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void datos()
        {
            controlcajas(true);
            controlbotones(false, true, true, true, true);
            var ds = new DataSet();
            ds = _escuelaManejador.datos();
            lblId.Text = ds.Tables[0].Rows[0]["Idescuela"].ToString();
            txtxNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtRFC.Text = ds.Tables[0].Rows[0]["rfc"].ToString();
            txtDomicilio.Text = ds.Tables[0].Rows[0]["domicilio"].ToString();
            txtTelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            txtWeb.Text = ds.Tables[0].Rows[0]["pagina"].ToString();
            txtDirector.Text = ds.Tables[0].Rows[0]["director"].ToString();
            txtLogo.Text = ds.Tables[0].Rows[0]["logo"].ToString();
            var logo = ds.Tables[0].Rows[0]["logo"].ToString();
            string direccion = _ruta + logo;
            ptbLogo.ImageLocation = direccion;
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Modificar()
        {

            controlcajas(true);
            controlbotones(false, true, true, true, true);
            
            lblId.Text = dtgEscuela.CurrentRow.Cells["Idescuela"].Value.ToString();
            txtxNombre.Text = dtgEscuela.CurrentRow.Cells["nombre"].Value.ToString();
            txtRFC.Text = dtgEscuela.CurrentRow.Cells["rfc"].Value.ToString();
            txtDomicilio.Text = dtgEscuela.CurrentRow.Cells["domicilio"].Value.ToString();
            txtTelefono.Text = dtgEscuela.CurrentRow.Cells["telefono"].Value.ToString();
            txtEmail.Text = dtgEscuela.CurrentRow.Cells["email"].Value.ToString();
            txtWeb.Text = dtgEscuela.CurrentRow.Cells["web"].Value.ToString();
            txtDirector.Text = dtgEscuela.CurrentRow.Cells["director"].Value.ToString();
            txtLogo.Text = dtgEscuela.CurrentRow.Cells["logo"].Value.ToString();
            var logo = dtgEscuela.CurrentRow.Cells["logo"].Value.ToString();
            string direccion = _ruta + logo;
            ptbLogo.ImageLocation = direccion;
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            //listEstudio.Text = dtgProfesores.CurrentRow.Cells["fkestudios"].Value.ToString();
        }

        private void dtgEscuela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                BuscarEscuela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            buscarimagen.Filter = "Imagen tipo (*.jpg)|*.jpg| Imagen tipo (*.png)|*.png| Imagen tipo (*.tif)|*.tif";
            buscarimagen.Title = "Cargar imagen";
            buscarimagen.InitialDirectory = "C:\\";
            buscarimagen.Multiselect = false;
            if (buscarimagen.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(buscarimagen.FileName);
                //var bytes = file.Length.ToString();
                var MG = (file.Length/1024f)/1024f;
                if (MG <= 5.0)
                {
                    txtLogo.Text = buscarimagen.SafeFileName;
                    ptbLogo.ImageLocation = buscarimagen.FileName;
                    ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("No se permiten imagenes mayores a 5 MG");
                }       
            }
        }
        private void GuardarImagen()
        {
            if (buscarimagen.FileName != null)
            {
                if (buscarimagen.FileName != "")
                {
                    var archivo = new FileInfo(buscarimagen.FileName);
                    if (Directory.Exists(_ruta))
                    {

                        var optenerArchivos2 = Directory.GetFiles(_ruta, "*.jpg");
                        FileInfo archivoAnterior2;
                        if (optenerArchivos2.Length != 0)
                        {

                            archivoAnterior2 = new FileInfo(optenerArchivos2[0]);
                            if (archivoAnterior2.Exists)
                            {
                                archivoAnterior2.Delete();
                                archivo.CopyTo(_ruta + archivo.Name);
                            }
                        }
                        else
                        {
                            archivo.CopyTo(_ruta + archivo.Name);
                        }

                    }
                    else
                    {
                        Directory.CreateDirectory(_ruta);
                        archivo.CopyTo(_ruta + archivo.Name);
                    }
                }
            }
        }
        private void Eliminarimagen()
        {
            string rutajpg = @"D:\5to. Semestre\Taller de base de datos\ControlEscolar\ControlEscolar\bin\Debug\LOGO\" + txtLogo.Text + "";
            if (MessageBox.Show("Estas Seguro De Eliminar Archivo JPG", "Eliminar JPG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                if (File.Exists(rutajpg))
                {
                    File.Delete(rutajpg);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminarImagen.Enabled = true;
            try
            {
                datos();
                //Modificar();
                BuscarEscuela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            txtLogo.Text = "";
            ptbLogo.Image = null;
        }
    }
}
