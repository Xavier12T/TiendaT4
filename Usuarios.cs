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
    public partial class Usuarios : Form
    {
        aviso P;
        
        public Usuarios()
        {
            InitializeComponent();
            P = new aviso();
        }
        public struct Datos
        {
            public string nombre;
            public string contra;
            public List<string> lista;

        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            Datos info;
            info.nombre = txtusuariocreado.Text;
            info.contra = txtcontracreada.Text;
            info.lista = new List<string>(new string[] { txtusuariocreado.Text, txtcontracreada.Text });
            string usuario = txtusuariocreado.Text;
            string contraseña= txtcontracreada.Text;

            escribir(usuario, contraseña);

            Ingresarcs oj = new Ingresarcs(info);
            oj.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P.Show();
        }
        public void escribir(string usuario, string contraseña)

        {
            


            try
            {
                StreamWriter sw = new StreamWriter("Usuarios.txt");
                sw.WriteLine("Usuario:" + usuario + "-" + "Contreseña:" + contraseña  );
                sw.Flush();
                sw.Close();
                


            }
            catch (Exception e)
            {
                MessageBox.Show("error:" + e.Message);
            }
        }
    }
}
