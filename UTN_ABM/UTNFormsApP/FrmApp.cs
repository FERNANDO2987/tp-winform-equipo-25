using NPOI.SS.Formula.Functions;
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
using UTNBusiness.Module;
namespace UTNFormsApP
{
    public partial class FrmApp : Form
    {
        private readonly IArticulosModule _articulosModule;
        private readonly string _sqlconString;
        public FrmApp()
        {
            InitializeComponent();

            // Cargar la cadena de conexión desde el archivo de configuración
            _sqlconString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            // Inicializa el módulo de artículos con la cadena de conexión
            // _articulosModule = new ArticulosModule(_sqlconString);
        }






        //Cerrar Ventana
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas agregar
            FrmAgregar formularioAgregarArticulo = new FrmAgregar();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioAgregarArticulo.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioAgregarArticulo);

            // Mostrar el formulario en el panelContenedor
            formularioAgregarArticulo.Show();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario que deseas agregar
            FrmModificar formularioModificar = new FrmModificar();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioModificar.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioModificar);

            // Mostrar el formulario en el panelContenedor
            formularioModificar.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas agregar
            FrmEliminar formularioEliminar = new FrmEliminar();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioEliminar.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioEliminar);

            // Mostrar el formulario en el panelContenedor
            formularioEliminar.Show();

        }

        private void btn_Detalle_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas agregar
            FrmDetalle formularioDetalle = new FrmDetalle();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioDetalle.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioDetalle);

            // Mostrar el formulario en el panelContenedor
            formularioDetalle.Show();

        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas agregar
            FrmListar formularioListar = new FrmListar();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioListar.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioListar);

            // Mostrar el formulario en el panelContenedor
            formularioListar.Show();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas agregar
            FrmBuscar formularioBuscar = new FrmBuscar();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioBuscar.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioBuscar);

            // Mostrar el formulario en el panelContenedor
            formularioBuscar.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas agregar
            FrmInicio formularioInicio = new FrmInicio();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            formularioInicio.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(formularioInicio);

            // Mostrar el formulario en el panelContenedor
            formularioInicio.Show();

        }
    }
}

