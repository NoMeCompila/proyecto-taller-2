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
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet2.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter1.Fill(this.joyeriaDataSet2.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet2.VentaDetalle' Puede moverla o quitarla según sea necesario.
            this.ventaDetalleTableAdapter2.Fill(this.joyeriaDataSet2.VentaDetalle);
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet1.VentaDetalle' Puede moverla o quitarla según sea necesario.
            //this.ventaDetalleTableAdapter1.Fill(this.joyeriaDataSet1.VentaDetalle);
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet1.Ventas' Puede moverla o quitarla según sea necesario.
            //this.ventasTableAdapter.Fill(this.joyeriaDataSet1.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet.Venta' Puede moverla o quitarla según sea necesario.
            //this.ventaTableAdapter.Fill(this.joyeriaDataSet1.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'joyeriaDataSet.VentaDetalle' Puede moverla o quitarla según sea necesario.
            //this.ventaDetalleTableAdapter.Fill(this.joyeriaDataSet.VentaDetalle);

        }
    }
}
