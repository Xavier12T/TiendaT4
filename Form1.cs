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
    public partial class Form1 : Form
    {
        aviso P;
        public Form1()
        {
            InitializeComponent();
            P = new aviso();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios obj = new Usuarios();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P.Show();
        }
    }
}
