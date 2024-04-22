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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
         

            var Marca = cbox_Marca.SelectedItem;

            var articulo = new Articulos()
            {
                Codigo = text_CodArticulo.Text,



            };
        }

        private void cbox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = cbox_Marca.SelectedIndex;


        }
    }
}
