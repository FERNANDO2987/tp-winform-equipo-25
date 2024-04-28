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
using UTNBusiness.Models;
using UTNBusiness.Module;

namespace UTNFormsApP
{
    public partial class FrmModificar : Form
    {

        private DataTable dataTable;
        public FrmModificar()
        {
            InitializeComponent();

            InitializeTextBoxes();

           

        }

        private void InitializeTextBoxes()
        {
            SetPlaceholder(text_Modificar, "Ingrese cualquier criterio para Buscar el Articulo a Modificar");


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

            ArticulosModule result = new ArticulosModule(connectionString);
            try
            {
                var criterio = text_Modificar.Text;
                if (!string.IsNullOrWhiteSpace(criterio))
                {


                    var articulos = await result.ObtenerDatosModificar(criterio);

                    if (articulos.Any()) // Verifica si se encontraron artículos
                    {
                        // Agrega cada artículo individualmente al DataGridView
                        dataGridView_Modificar.DataSource = articulos;

                        dataGridView_Modificar.Columns["ID"].Visible = false;
                        dataGridView_Modificar.Columns["ID"].ReadOnly = true;
                        dataGridView_Modificar.Columns["ID"].DefaultCellStyle.SelectionBackColor = dataGridView_Modificar.DefaultCellStyle.BackColor;

                        dataGridView_Modificar.Columns["IdMarca"].Visible = false;
                        dataGridView_Modificar.Columns["IdMarca"].ReadOnly = true;
                        dataGridView_Modificar.Columns["IdMarca"].DefaultCellStyle.SelectionBackColor = dataGridView_Modificar.DefaultCellStyle.BackColor;

                        //dataGridView_Modificar.Columns["IdCategoria"].Visible = false;
                        dataGridView_Modificar.Columns["IdCategoria"].ReadOnly = true;
                        dataGridView_Modificar.Columns["IdCategoria"].DefaultCellStyle.SelectionBackColor = dataGridView_Modificar.DefaultCellStyle.BackColor;
                    }
                    else
                    {
                        // Mostrar un mensaje si no se encontraron resultados
                        MessageBox.Show("Debe agregar un criterio en la búsqueda.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Agrega cada artículo individualmente al DataGridView


                }
                else
                {
                    // Mostrar un mensaje si el campo está vacío
                    MessageBox.Show("Debe completar el TextBox antes de realizar la búsqueda.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

       

        private void LimpiarControles()
        {
            // Limpiar TextBox
            text_Modificar.Text = "";

        }

        private async void btn_ModificarArticulo_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionStringUTN"];

            ArticulosModule result = new ArticulosModule(connectionString);
            ImagenesModule imagenesModule = new ImagenesModule(connectionString);
            CategoriaModule categoriaModule = new CategoriaModule(connectionString);
            MarcasModule  marcasModule = new MarcasModule(connectionString);

            try
            {
                // Recorrer las filas del DataGridView
                foreach (DataGridViewRow row in dataGridView_Modificar.Rows)
                {
                    // Obtener el identificador único del artículo
                    int idArticulo = Convert.ToInt32(row.Cells["ID"].Value); // Ajusta "ID" al nombre de la columna que contiene el ID del artículo

                    // Obtener el nuevo valor modificado para la Columna Codigo
                    string nuevoCodigo = row.Cells["Codigo"].Value.ToString();

                    // Obtener el nuevo valor modificado para la Columna Nombre
                    string nuevoValor = row.Cells["Nombre"].Value.ToString();

                    // Obtener el nuevo valor modificado para la Columna Descripcion
                    string nuevoDescripcion = row.Cells["Descripcion"].Value.ToString();


                    // Obtener el nuevo valor modificado para la Columna Descripcion de la Marca
                    string nuevaMarca = row.Cells["Marca"].Value.ToString();

                 

                    int NuevoIdMarca = Convert.ToInt32(row.Cells["IdMarca"].Value);

                    int NuevoIdCategoria = Convert.ToInt32(row.Cells["IdCategoria"].Value);

                    // Obtener el nuevo valor modificado para la Columna Precio
                    decimal nuevoPrecio = Convert.ToDecimal(row.Cells["Precio"].Value);

                   

                    // Actualizar el artículo en la base de datos
               

                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    string nuevaUrl = row.Cells["ImagenUrl"].Value.ToString();

             

                

                 
                    // Obtener el nuevo valor modificado para la Columna Descripcion de la Categoria
                    string nuevaCategoria = row.Cells["Categoria"].Value.ToString();

                    //Pregunta que Categoria es?

                    if (nuevaCategoria == "CELULARES" || nuevaCategoria == "Celulares")
                    {
                        var categoria = new Categoria
                        {
                            Id = 1,
                            Descripcion = nuevaCategoria

                        };
                        await categoriaModule.AgregarCategoria(categoria);

                        if(nuevaMarca == "Samsung" || nuevaMarca == "SAMSUNG")
                        {
                            var marca = new Marca
                            {
                                Id = 1,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }


                        if (nuevaMarca == "Apple" || nuevaMarca == "APPLE")
                        {
                            var marca = new Marca
                            {
                                Id = 2,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Sony" || nuevaMarca == "SONY")
                        {
                            var marca = new Marca
                            {
                                Id = 3,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Huawei" || nuevaMarca == "HUAWEI")
                        {
                            var marca = new Marca
                            {
                                Id = 4,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Motorola" || nuevaMarca == "MOTOROLA")
                        {
                            var marca = new Marca
                            {
                                Id = 5,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);



                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);
                        }

                    }
                    else if (nuevaCategoria == "TELEVISORES" || nuevaCategoria == "Televisores")
                    {
                        var categoria = new Categoria
                        {
                            Id = 2,
                            Descripcion = nuevaCategoria

                        };
                        await categoriaModule.AgregarCategoria(categoria);


                        if (nuevaMarca == "Samsung" || nuevaMarca == "SAMSUNG")
                        {
                            var marca = new Marca
                            {
                                Id = 1,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }


                        if (nuevaMarca == "Apple" || nuevaMarca == "APPLE")
                        {
                            var marca = new Marca
                            {
                                Id = 2,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Sony" || nuevaMarca == "SONY")
                        {
                            var marca = new Marca
                            {
                                Id = 3,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Huawei" || nuevaMarca == "HUAWEI")
                        {
                            var marca = new Marca
                            {
                                Id = 4,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Motorola" || nuevaMarca == "MOTOROLA")
                        {
                            var marca = new Marca
                            {
                                Id = 5,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);



                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);
                        }

                    }
                    else if (nuevaCategoria == "MEDIA" || nuevaCategoria == "Media")
                    {
                        var categoria = new Categoria
                        {
                            Id = 3,
                            Descripcion = nuevaCategoria

                        };
                        await categoriaModule.AgregarCategoria(categoria);


                        if (nuevaMarca == "Samsung" || nuevaMarca == "SAMSUNG")
                        {
                            var marca = new Marca
                            {
                                Id = 1,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }


                        if (nuevaMarca == "Apple" || nuevaMarca == "APPLE")
                        {
                            var marca = new Marca
                            {
                                Id = 2,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Sony" || nuevaMarca == "SONY")
                        {
                            var marca = new Marca
                            {
                                Id = 3,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Huawei" || nuevaMarca == "HUAWEI")
                        {
                            var marca = new Marca
                            {
                                Id = 4,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Motorola" || nuevaMarca == "MOTOROLA")
                        {
                            var marca = new Marca
                            {
                                Id = 5,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);



                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);
                        }

                    }

                    else if (nuevaCategoria == "AUDIO" || nuevaCategoria == "Audio")
                    {
                        var categoria = new Categoria
                        {
                            Id = 4,
                            Descripcion = nuevaCategoria

                        };
                        await categoriaModule.AgregarCategoria(categoria);


                        if (nuevaMarca == "Samsung" || nuevaMarca == "SAMSUNG")
                        {
                            var marca1 = new Marca
                            {
                                Id = 1,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca1);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca1.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }


                        if (nuevaMarca == "Apple" || nuevaMarca == "APPLE")
                        {
                            var marca2 = new Marca
                            {
                                Id = 2,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca2);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca2.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Sony" || nuevaMarca == "SONY")
                        {
                            var marca3 = new Marca
                            {
                                Id = 3,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca3);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca3.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Huawei" || nuevaMarca == "HUAWEI")
                        {
                            var marca4 = new Marca
                            {
                                Id = 4,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca4);


                            var articulo = new Articulos
                            {
                                Id = idArticulo,
                                Codigo = nuevoCodigo,
                                Nombre = nuevoValor,
                                Descripcion = nuevoDescripcion,
                                IdMarca = marca4.Id,

                                IdCategoria = categoria.Id,

                                Precio = nuevoPrecio


                            };

                            await result.ModificarArticulos(articulo);

                            var imagen = new Imagenes
                            {
                                Id = id,
                                IdArticulo = articulo.Id,
                                ImagenURL = nuevaUrl


                            };

                            //Modifica la Imagen
                            await imagenesModule.ModificarImagen(imagen);

                        }

                        if (nuevaMarca == "Motorola" || nuevaMarca == "MOTOROLA")
                        {
                            var marca = new Marca
                            {
                                Id = 5,
                                Descripcion = nuevaMarca

                            };
                            await marcasModule.AgregarMarca(marca);

                            if (nuevaMarca == "Samsung" || nuevaMarca == "SAMSUNG")
                            {
                                var marca5 = new Marca
                                {
                                    Id = 1,
                                    Descripcion = nuevaMarca

                                };
                                await marcasModule.AgregarMarca(marca5);


                                var articulo = new Articulos
                                {
                                    Id = idArticulo,
                                    Codigo = nuevoCodigo,
                                    Nombre = nuevoValor,
                                    Descripcion = nuevoDescripcion,
                                    IdMarca = marca5.Id,

                                    IdCategoria = categoria.Id,

                                    Precio = nuevoPrecio


                                };

                                await result.ModificarArticulos(articulo);

                                var imagen = new Imagenes
                                {
                                    Id = id,
                                    IdArticulo = articulo.Id,
                                    ImagenURL = nuevaUrl


                                };

                                //Modifica la Imagen
                                await imagenesModule.ModificarImagen(imagen);

                            }


                            if (nuevaMarca == "Apple" || nuevaMarca == "APPLE")
                            {
                                var marca6 = new Marca
                                {
                                    Id = 2,
                                    Descripcion = nuevaMarca

                                };
                                await marcasModule.AgregarMarca(marca6);


                                var articulo = new Articulos
                                {
                                    Id = idArticulo,
                                    Codigo = nuevoCodigo,
                                    Nombre = nuevoValor,
                                    Descripcion = nuevoDescripcion,
                                    IdMarca = marca6.Id,

                                    IdCategoria = categoria.Id,

                                    Precio = nuevoPrecio


                                };

                                await result.ModificarArticulos(articulo);

                                var imagen = new Imagenes
                                {
                                    Id = id,
                                    IdArticulo = articulo.Id,
                                    ImagenURL = nuevaUrl


                                };

                                //Modifica la Imagen
                                await imagenesModule.ModificarImagen(imagen);

                            }

                            if (nuevaMarca == "Sony" || nuevaMarca == "SONY")
                            {
                                var marca7 = new Marca
                                {
                                    Id = 3,
                                    Descripcion = nuevaMarca

                                };
                                await marcasModule.AgregarMarca(marca7);


                                var articulo = new Articulos
                                {
                                    Id = idArticulo,
                                    Codigo = nuevoCodigo,
                                    Nombre = nuevoValor,
                                    Descripcion = nuevoDescripcion,
                                    IdMarca = marca7.Id,

                                    IdCategoria = categoria.Id,

                                    Precio = nuevoPrecio


                                };

                                await result.ModificarArticulos(articulo);

                                var imagen = new Imagenes
                                {
                                    Id = id,
                                    IdArticulo = articulo.Id,
                                    ImagenURL = nuevaUrl


                                };

                                //Modifica la Imagen
                                await imagenesModule.ModificarImagen(imagen);

                            }

                            if (nuevaMarca == "Huawei" || nuevaMarca == "HUAWEI")
                            {
                                var marca8 = new Marca
                                {
                                    Id = 4,
                                    Descripcion = nuevaMarca

                                };
                                await marcasModule.AgregarMarca(marca8);


                                var articulo = new Articulos
                                {
                                    Id = idArticulo,
                                    Codigo = nuevoCodigo,
                                    Nombre = nuevoValor,
                                    Descripcion = nuevoDescripcion,
                                    IdMarca = marca8.Id,

                                    IdCategoria = categoria.Id,

                                    Precio = nuevoPrecio


                                };

                                await result.ModificarArticulos(articulo);

                                var imagen = new Imagenes
                                {
                                    Id = id,
                                    IdArticulo = articulo.Id,
                                    ImagenURL = nuevaUrl


                                };

                                //Modifica la Imagen
                                await imagenesModule.ModificarImagen(imagen);

                            }

                            if (nuevaMarca == "Motorola" || nuevaMarca == "MOTOROLA")
                            {
                                var marca9 = new Marca
                                {
                                    Id = 5,
                                    Descripcion = nuevaMarca

                                };
                                await marcasModule.AgregarMarca(marca9);



                                var articulo = new Articulos
                                {
                                    Id = idArticulo,
                                    Codigo = nuevoCodigo,
                                    Nombre = nuevoValor,
                                    Descripcion = nuevoDescripcion,
                                    IdMarca = marca9.Id,

                                    IdCategoria = categoria.Id,

                                    Precio = nuevoPrecio


                                };

                                await result.ModificarArticulos(articulo);

                                var imagen = new Imagenes
                                {
                                    Id = id,
                                    IdArticulo = articulo.Id,
                                    ImagenURL = nuevaUrl


                                };

                                //Modifica la Imagen
                                await imagenesModule.ModificarImagen(imagen);
                            }



                        }

                    }

                  






                }

                // Mostrar un mensaje de éxito al usuario
                MessageBox.Show("Los cambios se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView_Modificar.DataSource = null;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el proceso de guardado
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView asignándole null como origen de datos
            dataGridView_Modificar.DataSource = null;
        }

   

        private void dataGridModificar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Verificar si la celda editada no es la columna de ID
            if (e.ColumnIndex != 0) // Suponiendo que la columna de ID tiene el índice 0
            {
                // Obtener el valor de la celda editada
                string nuevoValor = dataGridView_Modificar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Modificar el valor de la celda si es necesario
                // Por ejemplo, puedes convertir el valor a mayúsculas
                dataGridView_Modificar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nuevoValor.ToUpper();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
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
    }
}
