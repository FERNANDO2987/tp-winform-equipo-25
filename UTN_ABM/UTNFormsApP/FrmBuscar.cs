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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
           // InicializarSelectArticulos();
        }

        
        private async void InicializarSelectArticulos()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule marcaModule = new ArticulosModule(connectionString);
            try
            {
                var valor = text_Buscar.Text;

                var articulos = await marcaModule.BuscarArticuloPorCriterio(valor);
                // Agrega cada artículo individualmente al DataGridView
                dataGridView_Buscar.DataSource = articulos;

            }
            catch (Exception)
            {

                throw;
            }
        }


        private async void btn_Buscar_Click(object sender, EventArgs e)
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
