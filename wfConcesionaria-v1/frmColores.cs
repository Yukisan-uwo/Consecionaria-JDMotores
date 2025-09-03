using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    public partial class frmColores : Form
    {
        //static bdConcesionaria concesionaria = new bdConcesionaria("CARLOS", "ConcesionariaPrueba", "User", "12345");
        Vehiculo Vehiculo;
        public frmColores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Vehiculo = new Vehiculo();
            Vehiculo.Agrega_colordata(txtNuevocolor.Text, txtColorRGB.Text);
            this.Close();
        }
    }
}
