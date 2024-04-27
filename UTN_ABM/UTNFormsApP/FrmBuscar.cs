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
            InitializeTextBoxes();
            

        }


        private void InitializeTextBoxes()
        {
            SetPlaceholder(text_Buscar, "Ingrese cualquier criterio para Buscar un Articulo");


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

        private async void InicializarSelectArticulos()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule marcaModule = new ArticulosModule(connectionString);
            try
            {
                var valor = text_Buscar.Text;

                if (!string.IsNullOrWhiteSpace(valor))
                {
                    var articulos = await marcaModule.BuscarArticuloPorCriterio(valor);
                    if (articulos.Any()) // Verifica si se encontraron artículos
                    {
                        // Agrega cada artículo individualmente al DataGridView
                        dataGridView_Buscar.DataSource = articulos;

                        
                    }
                    else
                    {
                        // Mostrar un mensaje si no se encontraron resultados
                        MessageBox.Show("Debe agregar un criterio en la búsqueda.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Mostrar un mensaje si el campo está vacío
                    MessageBox.Show("Debe completar el TextBox antes de realizar la búsqueda.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la inicialización
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
            }
        }

        private bool CampoCompleto()
        {
            return !string.IsNullOrWhiteSpace(text_Buscar.Text);

        }

      

      
        private async void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (CampoCompleto() ==true)
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
            }

        }

        private void LimpiarControles()
        {
            // Limpiar TextBox
            text_Buscar.Text = "";

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView asignándole null como origen de datos
            dataGridView_Buscar.DataSource = null;
        }
    }
}
