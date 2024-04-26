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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
            InicializarSelectArticulos();
        }

        private void dataGridView_Listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private async void InicializarSelectArticulos()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule marcaModule = new ArticulosModule(connectionString);
            try
            {


                var articulos = await marcaModule.ListarArticulos();
                // Agrega cada artículo individualmente al DataGridView
                dataGridView_Listar.DataSource = articulos;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
