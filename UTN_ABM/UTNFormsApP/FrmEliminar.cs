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
    public partial class FrmEliminar : Form
    {

  
        public FrmEliminar()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }


        private void InitializeTextBoxes()
        {
            SetPlaceholder(text_EliminarArticulo, "Ingrese un Id Articulo para Eliminar");


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
                var id = text_EliminarArticulo.Text;

                if (int.TryParse(id, out int idNumero))
                {
                    var articulos = await marcaModule.ObtenerArticulos(idNumero);
                    if (articulos.Any()) // Verifica si se encontraron artículos
                    {

                       
                        // Agrega cada artículo individualmente al DataGridView
                       dataGridView_Eliminar.DataSource = articulos;


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
                    MessageBox.Show("Debe completar el Campo antes de realizar la búsqueda.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return !string.IsNullOrWhiteSpace(text_EliminarArticulo.Text);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Antes de Buscar debe escribir un Id de Articulo.", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimpiarControles()
        {
            // Limpiar TextBox
            text_EliminarArticulo.Text = "";

        }

        private async void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule articuloModule = new ArticulosModule(connectionString);

            try
            {
                // Verificar si hay una fila seleccionada
                if (dataGridView_Eliminar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar el artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                // Obtener la fila seleccionada
                var idArticulo = Convert.ToInt32(dataGridView_Eliminar.SelectedRows[0].Cells["Id"].Value);

                bool eliminado = await articuloModule.EliminarArticulos(idArticulo);

                if (eliminado)
                {
                    MessageBox.Show("El artículo se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_Eliminar.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Hubo un problema al intentar eliminar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la inicialización
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
            }

        }
    }
}
