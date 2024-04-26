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
            dataGridView_Detalles.CellClick += dataGridView_Detalles_CellDoubleClick;
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

                var articulos = await marcaModule.BuscarDetallePorArticulo(criterio);
                // Agrega cada artículo individualmente al DataGridView
                dataGridView_Detalles.DataSource = articulos;



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_BuscarDetalle_Click(object sender, EventArgs e)
        {

            try
            {
                // Llamar al método para inicializar la búsqueda de artículos
                InicializarSelectArticulos();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la inicialización
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
            }

        }
    }
}
