﻿
namespace ProyectoTallerII
{
    partial class AdminVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVentas));
            this.lbl_inicio = new Bunifu.UI.WinForms.BunifuLabel();
            this.joyeriaDataSet = new ProyectoTallerII.JoyeriaDataSet();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDetalleTableAdapter = new ProyectoTallerII.JoyeriaDataSetTableAdapters.VentaDetalleTableAdapter();
            this.tableAdapterManager = new ProyectoTallerII.JoyeriaDataSetTableAdapters.TableAdapterManager();
            this.ventaTableAdapter = new ProyectoTallerII.JoyeriaDataSetTableAdapters.VentaTableAdapter();
            this.ventaDetalleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ventaDetalleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.joyeriaDataSet1 = new ProyectoTallerII.JoyeriaDataSet1();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new ProyectoTallerII.JoyeriaDataSet1TableAdapters.VentasTableAdapter();
            this.tableAdapterManager1 = new ProyectoTallerII.JoyeriaDataSet1TableAdapters.TableAdapterManager();
            this.ventaDetalleTableAdapter1 = new ProyectoTallerII.JoyeriaDataSet1TableAdapters.VentaDetalleTableAdapter();
            this.ventasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDetalleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingNavigator)).BeginInit();
            this.ventaDetalleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AllowParentOverrides = false;
            this.lbl_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_inicio.AutoEllipsis = false;
            this.lbl_inicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_inicio.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_inicio.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_inicio.Location = new System.Drawing.Point(315, 70);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_inicio.Size = new System.Drawing.Size(151, 17);
            this.lbl_inicio.TabIndex = 2;
            this.lbl_inicio.Text = "HISTORIAL DE VENTAS";
            this.lbl_inicio.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_inicio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // joyeriaDataSet
            // 
            this.joyeriaDataSet.DataSetName = "JoyeriaDataSet";
            this.joyeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataMember = "VentaDetalle";
            this.ventaDetalleBindingSource.DataSource = this.joyeriaDataSet;
            // 
            // ventaDetalleTableAdapter
            // 
            this.ventaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.TipoPagoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoTallerII.JoyeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VentaDetalleTableAdapter = this.ventaDetalleTableAdapter;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // ventaDetalleBindingNavigator
            // 
            this.ventaDetalleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventaDetalleBindingNavigator.BindingSource = this.ventaDetalleBindingSource;
            this.ventaDetalleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventaDetalleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventaDetalleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ventaDetalleBindingNavigatorSaveItem});
            this.ventaDetalleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ventaDetalleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventaDetalleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventaDetalleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventaDetalleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventaDetalleBindingNavigator.Name = "ventaDetalleBindingNavigator";
            this.ventaDetalleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventaDetalleBindingNavigator.Size = new System.Drawing.Size(812, 25);
            this.ventaDetalleBindingNavigator.TabIndex = 3;
            this.ventaDetalleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ventaDetalleBindingNavigatorSaveItem
            // 
            this.ventaDetalleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventaDetalleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDetalleBindingNavigatorSaveItem.Image")));
            this.ventaDetalleBindingNavigatorSaveItem.Name = "ventaDetalleBindingNavigatorSaveItem";
            this.ventaDetalleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventaDetalleBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ventaDetalleBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventaDetalleBindingNavigatorSaveItem_Click);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "FK__Venta__id_v_deta__5629CD9C";
            this.ventaBindingSource.DataSource = this.ventaDetalleBindingSource;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel4.Location = new System.Drawing.Point(736, 323);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(64, 21);
            this.bunifuLabel4.TabIndex = 10;
            this.bunifuLabel4.Text = "Cabecera";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel5.Location = new System.Drawing.Point(752, 565);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(48, 21);
            this.bunifuLabel5.TabIndex = 11;
            this.bunifuLabel5.Text = "Detalle";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // joyeriaDataSet1
            // 
            this.joyeriaDataSet1.DataSetName = "JoyeriaDataSet1";
            this.joyeriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.joyeriaDataSet1;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriaTableAdapter = null;
            this.tableAdapterManager1.ClienteTableAdapter = null;
            this.tableAdapterManager1.PerfilTableAdapter = null;
            this.tableAdapterManager1.ProductoTableAdapter = null;
            this.tableAdapterManager1.TipoPagoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ProyectoTallerII.JoyeriaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuarioTableAdapter = null;
            this.tableAdapterManager1.VentaDetalleTableAdapter = this.ventaDetalleTableAdapter1;
            this.tableAdapterManager1.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // ventaDetalleTableAdapter1
            // 
            this.ventaDetalleTableAdapter1.ClearBeforeFill = true;
            // 
            // ventasDataGridView
            // 
            this.ventasDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ventasDataGridView.AutoGenerateColumns = false;
            this.ventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ventasDataGridView.DataSource = this.ventasBindingSource;
            this.ventasDataGridView.Location = new System.Drawing.Point(19, 295);
            this.ventasDataGridView.Name = "ventasDataGridView";
            this.ventasDataGridView.Size = new System.Drawing.Size(621, 160);
            this.ventasDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_vendedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_vendedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_tpago";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_tpago";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ventaDetalleBindingSource1
            // 
            this.ventaDetalleBindingSource1.DataMember = "FK__Venta__id_v_deta__5629CD9C";
            this.ventaDetalleBindingSource1.DataSource = this.ventasBindingSource;
            // 
            // ventaDetalleDataGridView
            // 
            this.ventaDetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ventaDetalleDataGridView.AutoGenerateColumns = false;
            this.ventaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.ventaDetalleDataGridView.DataSource = this.ventaDetalleBindingSource1;
            this.ventaDetalleDataGridView.Location = new System.Drawing.Point(19, 551);
            this.ventaDetalleDataGridView.Name = "ventaDetalleDataGridView";
            this.ventaDetalleDataGridView.Size = new System.Drawing.Size(621, 160);
            this.ventaDetalleDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_detalle";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_detalle";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_venta";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_venta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_producto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn10.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn11.HeaderText = "precio";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "sub_total";
            this.dataGridViewTextBoxColumn12.HeaderText = "sub_total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // AdminVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 724);
            this.Controls.Add(this.ventaDetalleDataGridView);
            this.Controls.Add(this.ventasDataGridView);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.ventaDetalleBindingNavigator);
            this.Controls.Add(this.lbl_inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminVentas";
            this.Text = "Form_home";
            this.Load += new System.EventHandler(this.AdminVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingNavigator)).EndInit();
            this.ventaDetalleBindingNavigator.ResumeLayout(false);
            this.ventaDetalleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyeriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lbl_inicio;
        private JoyeriaDataSet joyeriaDataSet;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
        private JoyeriaDataSetTableAdapters.VentaDetalleTableAdapter ventaDetalleTableAdapter;
        private JoyeriaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventaDetalleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ventaDetalleBindingNavigatorSaveItem;
        private JoyeriaDataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private JoyeriaDataSet1 joyeriaDataSet1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private JoyeriaDataSet1TableAdapters.VentasTableAdapter ventasTableAdapter;
        private JoyeriaDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private JoyeriaDataSet1TableAdapters.VentaDetalleTableAdapter ventaDetalleTableAdapter1;
        private System.Windows.Forms.DataGridView ventasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource1;
        private System.Windows.Forms.DataGridView ventaDetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}