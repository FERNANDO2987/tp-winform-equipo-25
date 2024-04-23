using Microsoft.Extensions.Configuration;
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
        private readonly IArticulosModule _articulosModule;
     
      
        public FrmAgregar()
        {
            InitializeComponent();


            
          
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            int CodArticulo = int.Parse(text_CodArticulo.Text); // Convertir el valor a entero
            string descripcion = text_Descripcion.Text;
            string precio = text_Precio.Text;
            string marca = cbox_Marca.Text;
            string categoria = cbox_Categoria.Text;

            // Obtener el ID de la marca seleccionada
            int idMarca = int.Parse(marca.Split('-')[0].Trim()); // Obtener el ID de la marca seleccionada
            int idCategoria = int.Parse(categoria.Split('-')[0].Trim()); // Obtener el ID de la marca seleccionada

            // Crear un nuevo objeto de tipo Articulo
            Articulos articulo = new Articulos
            {
                Descripcion = descripcion,
                Precio = decimal.Parse(precio),
                IdMarca = idMarca,
                IdCategoria = idCategoria
            };

            // Guardar el nuevo artículo en la base de datos.
            // falta terminar de implementar. para fer

            IArticulosModule.(articulo);

            // Mostrar un mensaje de éxito
            MessageBox.Show("Artículo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario
            this.Close();
            
        
        }

        private void cbox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbox_Marca.SelectedIndex;


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario
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
