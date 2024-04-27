
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTNBusiness.Interfaces;
using UTNBusiness.Models;
using UTNBusiness.Module;
using System.Drawing;

namespace UTNFormsApP
{
    public partial class FrmAgregar : Form
    {

        public bool Multiselect { get; set; }

        public FrmAgregar()
        {
            InitializeComponent();

            //Inicililizar Marcas
            InicializarSelectMarcas();

            //Inicializar Categorias
            InicializarSelectCategorias();

            //Inicializar TextBox
            InitializeTextBoxes();
            //Inicializar ComoboBox
            InitializeComboBoxes();

            // Deshabilitar el botón de guardar al inicio
            btn_Guardar.Enabled = true;

            // Asociar evento de cambio a todos los controles que necesitas
            text_CodArticulo.TextChanged += Campos_TextChanged;
            textNombre.TextChanged += Campos_TextChanged;
            text_Descripcion.TextChanged += Campos_TextChanged;
            text_Precio.TextChanged += Campos_TextChanged;
            cbox_Marca.SelectedIndexChanged += Campos_SelectedIndexChanged;
            cbox_Categoria.SelectedIndexChanged += Campos_SelectedIndexChanged;
            





        }


        private List<string> selectedImagePaths = new List<string>();

        //Metodo para poner nombre a los textBox
        private void InitializeTextBoxes()
        {
            SetPlaceholder(text_CodArticulo, "Código de artículo");
            SetPlaceholder(textNombre, "Nombre de Articulo");
            SetPlaceholder(text_Descripcion, "Descripcion de Articulo");
            SetPlaceholder(text_Precio, "Preio de Articulo");
           
        }

        //Metodo para poner nombre a los ComboBox
        private void InitializeComboBoxes()
        {
            SetPlaceholderComboBox(cbox_Marca, "Seleccionar Marca");
            SetPlaceholderComboBox(cbox_Categoria, "Seleccionar Categoría");
         
        }


        
        //Establece marcador posición en Textbox.
        private void SetPlaceholderComboBox(ComboBox comboBox, string placeholder)
        {
            comboBox.ForeColor = SystemColors.GrayText;
            comboBox.Text = placeholder;
            comboBox.Enter += (sender, e) =>
            {
                if (comboBox.Text == placeholder)
                {
                    comboBox.Text = "";
                    comboBox.ForeColor = SystemColors.WindowText;
                }
            };
            comboBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    comboBox.ForeColor = SystemColors.GrayText;
                    comboBox.Text = placeholder;
                }
            };
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox.SelectedItem != null && comboBox.SelectedItem.ToString() == placeholder)
                {
                    comboBox.ForeColor = SystemColors.WindowText;
                }
            };
        }



        //Establece marcador posición en ComboBox
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

        private async void InicializarSelectMarcas()
        {
            //Llama a ConexionString dese el App.Config 
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            //Crea instancia de MarcasModule.
            MarcasModule marcaModule = new MarcasModule(connectionString);
            try
            {
                //Obtiene las Marcas
                var marcas = await marcaModule.ObtenerMarcas();
                // Agrega cada marca individualmente al ComboBox
                foreach (var marca in marcas)
                {
                    // Concatenamos el ID y la descripción para mostrarlos juntos en el ComboBox
                    string descripcionYId = $"{marca.Id} - {marca.Descripcion}";
                    cbox_Marca.Items.Add(descripcionYId);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void InicializarSelectCategorias()
        {
            //Llama a ConexionString dese el App.Config 
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            //Crea una instancia de CategoriaModule
            CategoriaModule marcaModule = new CategoriaModule(connectionString);
            try
            {
                //Obtiene las Categorias
                var categorias = await marcaModule.ObtenerCategorias();
                // Agrega cada marca individualmente al ComboBox
                foreach (var categoria in categorias)
                {
                    // Concatenamos el ID y la descripción para mostrarlos juntos en el ComboBox
                    string descripcionYId = $"{categoria.Id} - {categoria.Descripcion}";
                    cbox_Categoria.Items.Add(descripcionYId);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        // Método para obtener el ID de la cadena seleccionada en el ComboBox
        private int ObtenerIdSeleccionado(string selectedItem)
        {
            // Dividir la cadena en espacio para obtener el ID
            string[] partes = selectedItem.Split(' ');
            // El ID está en la primera parte de la cadena
            return Convert.ToInt32(partes[0]);
        }

        /// <summary>
        /// Guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Validar si todos los campos están completos
            if (CamposCompletos())
            {
                try
                {
                    string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

                    ArticulosModule articuloModule = new ArticulosModule(connectionString);
                    ImagenesModule imagenesModule = new ImagenesModule(connectionString);

                    var articulo = new Articulos
                    {
                        Codigo = text_CodArticulo.Text,
                        Nombre = textNombre.Text,
                        Descripcion = text_Descripcion.Text,
                        IdMarca = ObtenerIdSeleccionado(cbox_Marca.SelectedItem.ToString()),
                        IdCategoria = ObtenerIdSeleccionado(cbox_Categoria.SelectedItem.ToString()),
                        Precio = Convert.ToDecimal(text_Precio.Text)
                    };

                    await articuloModule.AgregarArticulos(articulo);

                    foreach (var item in selectedImagePaths)
                    {
                        var imagen = new Imagenes
                        {
                            IdArticulo = articulo.Id,
                            ImagenURL = item // guarda las imágenes
                        };

                        // llama al método agregar Imagen
                        await imagenesModule.AgregarImagen(imagen);
                    }

                    // Limpia la lista de imágenes seleccionadas después de guardarlas
                    selectedImagePaths.Clear();

                    // Mostrar un mensaje de éxito si todo se guardó correctamente
                    MessageBox.Show("Artículo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los controles
                    LimpiarControles();

                    // Volver a establecer los marcadores de posición
                    InitializeTextBoxes();
                    InitializeComboBoxes();
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje en caso de error
                    MessageBox.Show($"Error al guardar el artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje si los campos no están completos
                MessageBox.Show("Por favor complete todos los campos antes de guardar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para habilitar o deshabilitar el botón de guardar según el estado de los campos
        private void ActualizarEstadoBotonGuardar()
        {
            btn_Guardar.Enabled = CamposCompletos();
        }

        // Método para verificar si al menos un campo está completado
        private bool CamposCompletos()
        {
            return !string.IsNullOrWhiteSpace(text_CodArticulo.Text) &&
                   !string.IsNullOrWhiteSpace(textNombre.Text) &&
                   !string.IsNullOrWhiteSpace(text_Descripcion.Text) &&
                   cbox_Marca.SelectedItem != null &&
                   cbox_Categoria.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(text_Precio.Text);
        }

        // Evento para los cambios de texto en los campos de entrada
        private void Campos_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGuardar();
            ActualizarEstadoBotonSeleccionar();
        }

        // Evento para los cambios de selección en los ComboBox
        private void Campos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonGuardar();
        }


        private void LimpiarControles()
        {
            // Limpiar TextBox
            text_CodArticulo.Text = "";
            textNombre.Text = "";
            text_Descripcion.Text = "";
            text_Precio.Text = "";

            // Limpiar ComboBox
            cbox_Marca.SelectedIndex = -1;
            cbox_Categoria.SelectedIndex = -1;
        }



        // Método para habilitar o deshabilitar el botón de selección de imágenes según el estado de los campos
        private void ActualizarEstadoBotonSeleccionar()
        {
            btn_Selecionar.Enabled = CamposCompletos();
            btn_Guardar.Enabled = CamposCompletos();
        }

       

        //Evento para seleccionar Imagenes
        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            if (CamposCompletos())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imágenes|*.jpg;*.png";
                openFileDialog.Multiselect = true; // Permitir la selección múltiple de archivos
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Title = "Seleccionar imágenes";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        selectedImagePaths.Add(fileName); // Agrega la ruta del archivo seleccionado a la lista
                    }

                    MostrarImagenesEnFlowLayoutPanel(); // Muestra las imágenes en el flowLayoutPanel1
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos antes de seleccionar imágenes.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarImagenesEnFlowLayoutPanel()
        {
            // Limpiar el flowLayoutPanel1 antes de agregar nuevas imágenes
            flowLayoutPanel1.Controls.Clear();

            foreach (string imagePath in selectedImagePaths)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = imagePath;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar la imagen al tamaño del PictureBox
                pictureBox.Width = 100; // Establecer el ancho del PictureBox 
                pictureBox.Height = 100; // Establecer la altura del PictureBox

                flowLayoutPanel1.Controls.Add(pictureBox); // Agregar el PictureBox al flowLayoutPanel1
            }
        }

        private void text_CodArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se inserte el carácter de retorno de carro en el TextBox
                textNombre.Focus(); // Mueve el foco al siguiente TextBox
            }
        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                text_Descripcion.Focus();
            }
        }

        private void text_Descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cbox_Marca.Focus();
            }
        }


        private void text_Marca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cbox_Marca.Focus();
            }
        }

        private void text_Categoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cbox_Categoria.Focus();
            }
        }

        private void text_Precio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                text_Precio.Focus();
            }
        }

      

    }
}
