using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTNBusiness.Module;

namespace UTNFormsApP
{
    public partial class FrmDetalle : Form
    {
        public FrmDetalle()
        {
            InitializeComponent();
            InitializeTextBoxes();
            dataGridView_Detalles.CellClick += dataGridView_Detalles_CellDoubleClick;
        }


        private void InitializeTextBoxes()
        {
            SetPlaceholder(text_BuscarDetalle, "Ingrese cualquier criterio para Buscar el Detalle del Articulo");


        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = placeholder;
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = SystemColors.GrayText;
                    textBox.Text = placeholder;
                }
            };
        }

        // Método para manejar el evento CellDoubleClick del DataGridView
        private void dataGridView_Detalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo doble clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si la celda corresponde a la columna de la imagen
                if (dataGridView_Detalles.Columns[e.ColumnIndex].Name == "ImagenUrl")
                {
                    try
                    {
                        // Obtener la URL de la imagen de la celda seleccionada
                        string imageUrl = dataGridView_Detalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                        // Abrir una ventana o cuadro de diálogo para mostrar la imagen
                        MostrarImagen(imageUrl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir la imagen: " + ex.Message);
                    }
                }
            }
        }

        private void MostrarImagen(string imageUrl)
        {
            // Crear un formulario para mostrar la imagen
            Form frmImagen = new Form();
            PictureBox pictureBox = new PictureBox();
            // Ajustar la imagen para que se vea completa dentro del PictureBox
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
            frmImagen.Controls.Add(pictureBox);

            // Cargar la imagen de la URL
            pictureBox.ImageLocation = imageUrl;

            // Configurar el formulario
            frmImagen.Text = "Imagen";
            // Deshabilitar botones de minimizar, agrandar y cerrar
            frmImagen.ControlBox = false; 
            // Centrar el formulario en la pantalla
            frmImagen.StartPosition = FormStartPosition.CenterScreen;

            // Tamaño en píxeles equivalente a 7 cm x 7 cm
            int tamanoEnPixeles = (int)(7 * 96 / 2.54);

            // Establecer el tamaño del PictureBox
            pictureBox.Size = new Size(tamanoEnPixeles, tamanoEnPixeles);

            // Centrar el PictureBox en el formulario
            pictureBox.Location = new Point((frmImagen.ClientSize.Width - pictureBox.Width) / 2, (frmImagen.ClientSize.Height - pictureBox.Height) / 2);

            // Agregar evento de clic al PictureBox para cerrar el formulario al hacer clic en la imagen
            pictureBox.Click += (sender, e) =>
            {
                frmImagen.Close();
            };

            // Mostrar el formulario
            frmImagen.ShowDialog();
        }



        private async void InicializarSelectArticulos()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule marcaModule = new ArticulosModule(connectionString);
            try
            {
                var criterio = text_BuscarDetalle.Text;
                if (!string.IsNullOrWhiteSpace(criterio))
                {
                    

                    var articulos = await marcaModule.BuscarDetallePorArticulo(criterio);

                    if (articulos.Any()) // Verifica si se encontraron artículos
                    {
                        // Agrega cada artículo individualmente al DataGridView
                        dataGridView_Detalles.DataSource = articulos;

                        dataGridView_Detalles.Columns["IdCategoria"].Visible = false;
                        dataGridView_Detalles.Columns["IdCategoria"].ReadOnly = true;
                        dataGridView_Detalles.Columns["IdCategoria"].DefaultCellStyle.SelectionBackColor = dataGridView_Detalles.DefaultCellStyle.BackColor;

                        dataGridView_Detalles.Columns["IdMarca"].Visible = false;
                        dataGridView_Detalles.Columns["IdMarca"].ReadOnly = true;
                        dataGridView_Detalles.Columns["IdMarca"].DefaultCellStyle.SelectionBackColor = dataGridView_Detalles.DefaultCellStyle.BackColor;

                        dataGridView_Detalles.Columns["IdImagen"].Visible = false;
                        dataGridView_Detalles.Columns["IdImagen"].ReadOnly = true;
                        dataGridView_Detalles.Columns["IdImagen"].DefaultCellStyle.SelectionBackColor = dataGridView_Detalles.DefaultCellStyle.BackColor;


                    }
                    else
                    {
                        // Mostrar un mensaje si no se encontraron resultados
                        MessageBox.Show("Debe agregar un criterio en la búsqueda.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Agrega cada artículo individualmente al DataGridView
                   

                }
                else
                {
                    // Mostrar un mensaje si el campo está vacío
                    MessageBox.Show("Debe completar el TextBox antes de realizar la búsqueda.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool CampoCompleto()
        {
            return !string.IsNullOrWhiteSpace(text_BuscarDetalle.Text);

        }

        private void btn_BuscarDetalle_Click(object sender, EventArgs e)
        {

            if (CampoCompleto() == true)
            {

                try
                {
                    // Llamar al método para inicializar la búsqueda de artículos
                    InicializarSelectArticulos();
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra durante la inicialización
                    MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                }
            }
            else
            {
                // Mostrar un mensaje si los campos no están completos
                MessageBox.Show("Antes de Buscar debe escribir un Criterio.", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControles();
            }

        }

        private void LimpiarControles()
        {
            // Limpiar TextBox
            text_BuscarDetalle.Text = "";
        
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView asignándole null como origen de datos
            dataGridView_Detalles.DataSource = null;

        }
    }
}
