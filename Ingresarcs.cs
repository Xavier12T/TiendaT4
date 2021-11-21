using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4
{
    public partial class Ingresarcs : Form
    {
        aviso P;
        public Ingresarcs(Usuarios.Datos info)
        {
            InitializeComponent();
            txtusuario.Text = info.nombre;
            txtcontrase.Text = info.contra;

            P = new aviso();
        }
       

        private void btnIniciarE_Click(object sender, EventArgs e)
        {
            

            
            Programa obj = new Programa();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            P.Show();
        }

        

       
    }
}
