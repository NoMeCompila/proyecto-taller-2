using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerII
{
    public partial class Form_gerente_reportes : Form
    {
        public Form_gerente_reportes()
        {
            InitializeComponent();
        }

        private void Form_gerente_reportes_Load(object sender, EventArgs e)
        {
            chart_ventas.Series["Ventas"].Points.AddXY("Alianzas", "25");
            chart_ventas.Series["Ventas"].Points.AddXY("Joyas", "32");
            chart_ventas.Series["Ventas"].Points.AddXY("Collares", "20");
            chart_ventas.Series["Ventas"].Points.AddXY("Relojes", "7");
        }
    }
}
