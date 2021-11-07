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
    public partial class AdminVentas : Form
    {
        public AdminVentas()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ventaDetalleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaDetalleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joyeriaDataSet);

        }

        private void AdminVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.joyeriaDataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet.VentaDetalle' Puede moverla o quitarla según sea necesario.
            this.ventaDetalleTableAdapter.Fill(this.joyeriaDataSet.VentaDetalle);

        }
    }
}
