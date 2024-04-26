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
