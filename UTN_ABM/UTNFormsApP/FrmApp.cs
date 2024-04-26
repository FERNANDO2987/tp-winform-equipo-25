
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using UTNBusiness.Interfaces;
using UTNBusiness.Module;
namespace UTNFormsApP
{
    public partial class FrmApp : Form
    {
        private readonly IArticulosModule _articulosModule;
        private readonly IMarcasModule _marcasModule; 
     

        private bool mouseDown;
        private Point lastLocation;
        public FrmApp()
        {
            InitializeComponent();

            // Mostrar el label_Inicio al inicializar el formulario
            label_Inicio.Visible = true;


        }





        //Cerrar Ventana
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario elige "Sí" en el cuadro de diálogo de confirmación.
            }
            // Si el usuario elige "No", la ventana permanecerá abierta.
        }



        private async void btn_Agregar_Click(object sender, EventArgs e)
        {

          
            FrmAgregar frmAgregar = new FrmAgregar();

            // Establecer TopLevel en false para que se pueda agregar al panelContenedor
            frmAgregar.TopLevel = false;

            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Agregar el formulario al panelContenedor
            panelContenedor.Controls.Add(frmAgregar);

            // Mostrar el formulario en el panelContenedor
            frmAgregar.Show();
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
            // Limpiar los controles existentes en el panelContenedor
            panelContenedor.Controls.Clear();

            // Crear un nuevo label para mostrar "Inicio"
            Label labelInicio = new Label();
            labelInicio.Text = "Inicio:";
            labelInicio.AutoSize = true; // Para que el tamaño del label se ajuste automáticamente al texto
            labelInicio.Location = new Point(10, 10); // Puedes ajustar las coordenadas según tu diseño

            // Agregar el label al panelContenedor
            panelContenedor.Controls.Add(labelInicio);

            // Mostrar el panelContenedor
            panelContenedor.Visible = true;
        }



        private void panelMovimiento_Paint(object sender, PaintEventArgs e)
        {
            panelMovimiento.MouseMove += PanelMovimiento_MouseMove;
            panelMovimiento.MouseDown += PanelMovimiento_MouseDown;
            panelMovimiento.MouseUp += PanelMovimiento_MouseUp;
        }

        private void PanelMovimiento_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PanelMovimiento_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PanelMovimiento_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

