
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
using UTNBusiness.Interfaces;
using UTNBusiness.Models;
using UTNBusiness.Module;


namespace UTNFormsApP
{
    public partial class FrmAgregar : Form
    {
        
     
      
        public FrmAgregar()
        {
            InitializeComponent();


            InicializarSelectMarcas();
            InicializarSelectCategorias();

        }


        private async void InicializarSelectMarcas()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            MarcasModule marcaModule = new MarcasModule(connectionString);
            try
            {
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
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            CategoriaModule marcaModule = new CategoriaModule(connectionString);
            try
            {
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

        private async void btn_Guardar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule articuloModule = new ArticulosModule(connectionString);

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






            // Mostrar un mensaje de éxito
            MessageBox.Show("Artículo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los controles
            LimpiarControles();

            // Cerrar el formulario
            //this.Close();
            
        
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

        private void cbox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbox_Marca.SelectedIndex;


        }



            // Cerrar el formulario
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes|*.jpg; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Title = "Seleccionar imagen";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            { pbImagen.Image = Image.FromFile(openFileDialog.FileName); }
        }
    }
}
