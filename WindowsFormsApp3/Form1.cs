using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BProducto negocio = new BProducto();
            dgvProducts.DataSource = negocio.Mostrar(textNombre.Text);

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                BProducto negocio = new BProducto();
                Producto producto = new Producto();
                producto.Nombre = txtNombre.Text;
                producto.Codigo = txtCodigo.Text;
                negocio.Insertar(producto);

                MessageBox.Show("Registro exitoso");
            }catch(Exception)
            {
                MessageBox.Show("Error");
            }
           

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BProducto negocio = new BProducto();
                Producto producto = new Producto();
                producto.Nombre = txtUpdateNombre.Text;
                producto.Codigo = txtUpdateCodigo.Text;
                producto.IdProducto = txtIdProduct.Text;

                negocio.Actualizar(producto);

                MessageBox.Show("Actualizacion exitosa");
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
