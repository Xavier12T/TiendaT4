using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4
{
    public partial class Programa : Form
    {
        aviso P;
        List<Productos> lista = new List<Productos>();
        

        double suma = 0;
       
        public Programa()
        {
            InitializeComponent();
            P = new aviso();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            P.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                validar();
            }
            else
            {


                Productos obj = new Productos();
                string Producto = txtproducto.Text;
                double Precio = double.Parse(txtprecio.Text);
                int Cantidad = int.Parse(txtcantidad.Text);
                obj.Producto = Producto;
                obj.Precio = Precio;
                obj.Cantidad = Cantidad;
                double total = Precio * Cantidad;

                suma = suma + Convert.ToDouble(total);
                txtresultado.Text = Convert.ToString(suma);

                lista.Add(obj);
                lb1.Items.Add(obj.Cantidad + " de " + obj.Producto + " a S/" + obj.Precio + " c/u  son  S/" + total);

                grilla();
                string producto = txtproducto.Text;
                double precio = double.Parse(txtprecio.Text);
                double cantidad = double.Parse(txtcantidad.Text);

                escribir(producto, precio, cantidad);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dt1.SelectedRows)
                {
                    dt1.Rows.RemoveAt(row.Index);
                }

            }
            catch (Exception)
            {

            }
        }

        public void grilla()
        {
            int n = dt1.Rows.Add();
            Productos obj = new Productos();
            dt1.Rows[n].Cells[0].Value = txtproducto.Text;
            dt1.Rows[n].Cells[1].Value = txtcantidad.Text;
            dt1.Rows[n].Cells[2].Value = txtprecio.Text;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lb1.Items.RemoveAt(lb1.SelectedIndex);
            }
            catch (Exception)
            {

            }
        }
        public bool validar()
        {
            bool ok = true;
            if (txtproducto.Text == "")
            {
                ok = false;
                ep.SetError(txtproducto, "Ingresar Producto");
            }
            else { ep.Clear(); }

            if (txtcantidad.Text == "")
            {
                ok = false;
                ep1.SetError(txtcantidad, "Ingresar Cantidad");
            }
            else { ep1.Clear(); }

            if (txtprecio.Text == "")
            {
                ok = false;
                ep2.SetError(txtprecio, "Ingresar Precio");
            }
            else { ep2.Clear(); }



            return ok;
        }

        private void txtproducto_Validating(object sender, CancelEventArgs e)
        {

            bool error = false;
            foreach (char caracter in txtproducto.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;

                    break;
                }

            }
            if (error)
            {
                ep.SetError(txtproducto, "No se admiten numeros");
            }
            else
            {
                ep.Clear();
            }
        }

        private void txtprecio_Validating(object sender, CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(txtprecio.Text, out num))
            {
                ep2.SetError(txtprecio, "Ingrese Un Precio Valido");
            }
            else
            {
                ep2.SetError(txtprecio, "");
            }

        }

        private void txtcantidad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtcantidad.Text, out num))
            {
                ep1.SetError(txtcantidad, "Ingrese Una Cantidad Valida");
            }
            else
            {
                ep1.SetError(txtcantidad, "");
            }
        }
        public void escribir(string producto, double precio, double cantidad)

        {
            double t;


            t = precio * cantidad;


            try
            {

                StreamWriter sw = new StreamWriter("ListaDeProductos.txt");
                sw.WriteLine("Producto:" + producto + "-" + "Precio:" + precio + "-" + "Cantidad:" + cantidad + "-" + "Total:" + t);
                sw.Flush();
                sw.Close();
                


            }
            catch (Exception e)
            {
                MessageBox.Show("error:" + e.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pbxRegresar_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {  
            double n = int.Parse(txtnumero.Text);
            Metodos facto = new Metodos();
            double total = Metodos.factorial(n);
            txtrsultado.Text = Convert.ToString(total);
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            int potenc = int.Parse(txtpotencia.Text);
            int n = int.Parse(txtnumero.Text);
            Metodos po = new Metodos();
            int total = Metodos.potencia(n, potenc);
            txtrsultado.Text = Convert.ToString(total);
        }

        private void btnfbonaci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnumero.Text);
            Metodos fibo = new Metodos();
            int total = Metodos.fibonacci(n);
            txtrsultado.Text = Convert.ToString(total);

        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            tb1.Visible = true;

            p1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb1.Visible = false;

            p1.Visible = true;
        }

        private void txtnumero_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtnumero.Text, out num))
            {
                ep3.SetError(txtnumero, "Ingrese Un Numero Valido");
            }
            else
            {
                ep3.SetError(txtnumero, "");
            }
        }

        private void txtpotencia_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtnumero.Text, out num))
            {
                ep4.SetError(txtpotencia, "Ingrese Un Numero Valido");
            }
            else
            {
                ep4.SetError(txtpotencia, "");
            }
        }
    }
}
