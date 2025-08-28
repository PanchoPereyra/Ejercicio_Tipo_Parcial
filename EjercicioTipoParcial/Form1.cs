using System.IO;
namespace EjercicioTipoParcial
{
    public partial class Form1 : Form
    {
        Presupuesto pedido = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarPre_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            pedido = new Presupuesto(nombre, direccion);
        }

        private void btnCerrarPre_Click(object sender, EventArgs e)
        {
            if (pedido != null)
            {
                string[] lista = pedido.Resumen();  //informa
                Form2 fVer = new Form2();
                foreach (string linea in lista)
                {
                    fVer.listBox1.Items.Add(linea); //lleno el listBox
                }
                fVer.ShowDialog();
                cbProducto.Items.Clear();
                pedido = null;
            }
            else
            {
                MessageBox.Show("Cree el presupuesto");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /*para borrer el producto seleccionado en el comboBox*/
            if (cbProducto.SelectedItem != null)
            {
                int codigo = Convert.ToInt32(cbProducto.SelectedItem);
                pedido.QuitarProducto(codigo);
                cbProducto.Items.Remove(cbProducto.SelectedItem);
                cbProducto.Text = "";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precioBase = Convert.ToDouble(tbPrecio.Text);
            double largo = Convert.ToDouble(tbLargo.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);

            Producto nuevo = null;
            if (rbBanco.Checked)
            {
                nuevo = new Banco(precioBase, largo);
                nuevo.Codigo = codigo;
            }
            else if (rbMesa.Checked)
            {
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor = Convert.ToDouble(tbGrosor.Text);
                nuevo = new Mesa(precioBase, largo, ancho, grosor);
                nuevo.Codigo = codigo;
            }

            if (pedido != null)
            {
                if (nuevo != null)
                {
                    pedido.AgregarProducto(nuevo);
                    cbProducto.Items.Add(codigo);

                }
                else
                {
                    MessageBox.Show("Sellecione el presupuesto");
                }
            }
        }

        private void rbMesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de texto |*.txt|Todos los archivos|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string contenido = File.ReadAllText(openFile.FileName);
                    tbContenido.Text = contenido;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer archivo: " + ex.Message);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivos de teto|*.txt|Todos los archivos|*.*";
            if(saveFile.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFile.FileName, tbContenido.Text);
                    MessageBox.Show("Archivo guardado correctamente.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al guardar archivo: " + ex.Message);
                }
            }
        }
    }
}
