
namespace ProyectoTallerII
{
    partial class Form_listar_productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_listar_productos));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dtg_stock = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_buscador = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_pbuckup = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_username = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_stock_title = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_buscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel_stock = new Bunifu.UI.WinForms.BunifuPanel();
            this.txt_stock = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pb_producto_imagen = new System.Windows.Forms.PictureBox();
            this.drd_productos_categoria = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txt_producto_cod = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_producto_nombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_stock_agregar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stock)).BeginInit();
            this.pnl_buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_pbuckup)).BeginInit();
            this.panel_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_stock
            // 
            this.dtg_stock.AllowCustomTheming = false;
            this.dtg_stock.AllowUserToAddRows = false;
            this.dtg_stock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtg_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.dtg_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_stock.ColumnHeadersHeight = 40;
            this.dtg_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nombre_producto,
            this.stock,
            this.percio_costo,
            this.precio_venta,
            this.categoria,
            this.img,
            this.Eliminar});
            this.dtg_stock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dtg_stock.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_stock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_stock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dtg_stock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_stock.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dtg_stock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dtg_stock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dtg_stock.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_stock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_stock.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dtg_stock.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_stock.CurrentTheme.Name = null;
            this.dtg_stock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dtg_stock.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_stock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_stock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dtg_stock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_stock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_stock.EnableHeadersVisualStyles = false;
            this.dtg_stock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dtg_stock.HeaderBackColor = System.Drawing.Color.Navy;
            this.dtg_stock.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_stock.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_stock.Location = new System.Drawing.Point(12, 300);
            this.dtg_stock.Name = "dtg_stock";
            this.dtg_stock.ReadOnly = true;
            this.dtg_stock.RowHeadersVisible = false;
            this.dtg_stock.RowTemplate.Height = 40;
            this.dtg_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_stock.Size = new System.Drawing.Size(778, 192);
            this.dtg_stock.TabIndex = 26;
            this.dtg_stock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // cod
            // 
            this.cod.HeaderText = "Cod. Producto";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // percio_costo
            // 
            this.percio_costo.HeaderText = "Precio Costo";
            this.percio_costo.Name = "percio_costo";
            this.percio_costo.ReadOnly = true;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio Venta";
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // img
            // 
            this.img.HeaderText = "Imágen";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // pnl_buscador
            // 
            this.pnl_buscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_buscador.Controls.Add(this.button1);
            this.pnl_buscador.Controls.Add(this.lbl_pbuckup);
            this.pnl_buscador.Controls.Add(this.lbl_username);
            this.pnl_buscador.Controls.Add(this.lbl_stock_title);
            this.pnl_buscador.Controls.Add(this.txt_buscar);
            this.pnl_buscador.Location = new System.Drawing.Point(33, 34);
            this.pnl_buscador.Name = "pnl_buscador";
            this.pnl_buscador.Size = new System.Drawing.Size(741, 63);
            this.pnl_buscador.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProyectoTallerII.Properties.Resources.search_1__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_pbuckup
            // 
            this.lbl_pbuckup.AllowFocused = false;
            this.lbl_pbuckup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pbuckup.AutoSizeHeight = true;
            this.lbl_pbuckup.BorderRadius = 24;
            this.lbl_pbuckup.Image = ((System.Drawing.Image)(resources.GetObject("lbl_pbuckup.Image")));
            this.lbl_pbuckup.IsCircle = true;
            this.lbl_pbuckup.Location = new System.Drawing.Point(680, 7);
            this.lbl_pbuckup.Name = "lbl_pbuckup";
            this.lbl_pbuckup.Size = new System.Drawing.Size(49, 49);
            this.lbl_pbuckup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_pbuckup.TabIndex = 3;
            this.lbl_pbuckup.TabStop = false;
            this.lbl_pbuckup.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_username
            // 
            this.lbl_username.AllowParentOverrides = false;
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoEllipsis = false;
            this.lbl_username.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_username.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_username.Location = new System.Drawing.Point(601, 13);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_username.Size = new System.Drawing.Size(73, 20);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Vendedor1";
            this.lbl_username.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_username.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_stock_title
            // 
            this.lbl_stock_title.AllowParentOverrides = false;
            this.lbl_stock_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_stock_title.AutoEllipsis = false;
            this.lbl_stock_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_stock_title.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_stock_title.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_stock_title.Location = new System.Drawing.Point(349, 12);
            this.lbl_stock_title.Name = "lbl_stock_title";
            this.lbl_stock_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_stock_title.Size = new System.Drawing.Size(145, 21);
            this.lbl_stock_title.TabIndex = 9;
            this.lbl_stock_title.Text = "LISTAR PRODUCTOS";
            this.lbl_stock_title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_stock_title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_buscar
            // 
            this.txt_buscar.AcceptsReturn = false;
            this.txt_buscar.AcceptsTab = false;
            this.txt_buscar.AnimationSpeed = 200;
            this.txt_buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_buscar.BackColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_buscar.BackgroundImage")));
            this.txt_buscar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_buscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_buscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_buscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_buscar.BorderRadius = 1;
            this.txt_buscar.BorderThickness = 1;
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_buscar.DefaultText = "";
            this.txt_buscar.FillColor = System.Drawing.Color.White;
            this.txt_buscar.HideSelection = true;
            this.txt_buscar.IconLeft = null;
            this.txt_buscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar.IconPadding = 10;
            this.txt_buscar.IconRight = null;
            this.txt_buscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar.Lines = new string[0];
            this.txt_buscar.Location = new System.Drawing.Point(53, 12);
            this.txt_buscar.MaxLength = 32767;
            this.txt_buscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_buscar.Modified = false;
            this.txt_buscar.Multiline = false;
            this.txt_buscar.Name = "txt_buscar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_buscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_buscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_buscar.OnIdleState = stateProperties4;
            this.txt_buscar.Padding = new System.Windows.Forms.Padding(3);
            this.txt_buscar.PasswordChar = '\0';
            this.txt_buscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_buscar.PlaceholderText = "Buscar...";
            this.txt_buscar.ReadOnly = false;
            this.txt_buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_buscar.SelectedText = "";
            this.txt_buscar.SelectionLength = 0;
            this.txt_buscar.SelectionStart = 0;
            this.txt_buscar.ShortcutsEnabled = true;
            this.txt_buscar.Size = new System.Drawing.Size(248, 37);
            this.txt_buscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscar.TextMarginBottom = 0;
            this.txt_buscar.TextMarginLeft = 3;
            this.txt_buscar.TextMarginTop = 0;
            this.txt_buscar.TextPlaceholder = "Buscar...";
            this.txt_buscar.UseSystemPasswordChar = false;
            this.txt_buscar.WordWrap = true;
            // 
            // panel_stock
            // 
            this.panel_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_stock.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_stock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_stock.BackgroundImage")));
            this.panel_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_stock.BorderColor = System.Drawing.Color.Transparent;
            this.panel_stock.BorderRadius = 3;
            this.panel_stock.BorderThickness = 1;
            this.panel_stock.Controls.Add(this.txt_stock);
            this.panel_stock.Controls.Add(this.pb_producto_imagen);
            this.panel_stock.Controls.Add(this.drd_productos_categoria);
            this.panel_stock.Controls.Add(this.txt_producto_cod);
            this.panel_stock.Controls.Add(this.txt_producto_nombre);
            this.panel_stock.Controls.Add(this.btn_stock_agregar);
            this.panel_stock.Location = new System.Drawing.Point(39, 103);
            this.panel_stock.Name = "panel_stock";
            this.panel_stock.ShowBorders = true;
            this.panel_stock.Size = new System.Drawing.Size(715, 181);
            this.panel_stock.TabIndex = 25;
            // 
            // txt_stock
            // 
            this.txt_stock.AcceptsReturn = false;
            this.txt_stock.AcceptsTab = false;
            this.txt_stock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_stock.AnimationSpeed = 200;
            this.txt_stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_stock.BackColor = System.Drawing.Color.Transparent;
            this.txt_stock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_stock.BackgroundImage")));
            this.txt_stock.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_stock.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_stock.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_stock.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_stock.BorderRadius = 1;
            this.txt_stock.BorderThickness = 1;
            this.txt_stock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stock.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_stock.DefaultText = "";
            this.txt_stock.FillColor = System.Drawing.Color.White;
            this.txt_stock.HideSelection = true;
            this.txt_stock.IconLeft = null;
            this.txt_stock.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stock.IconPadding = 10;
            this.txt_stock.IconRight = null;
            this.txt_stock.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stock.Lines = new string[0];
            this.txt_stock.Location = new System.Drawing.Point(281, 69);
            this.txt_stock.MaxLength = 32767;
            this.txt_stock.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_stock.Modified = false;
            this.txt_stock.Multiline = false;
            this.txt_stock.Name = "txt_stock";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_stock.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_stock.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_stock.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_stock.OnIdleState = stateProperties8;
            this.txt_stock.Padding = new System.Windows.Forms.Padding(3);
            this.txt_stock.PasswordChar = '\0';
            this.txt_stock.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_stock.PlaceholderText = "Descripción";
            this.txt_stock.ReadOnly = false;
            this.txt_stock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stock.SelectedText = "";
            this.txt_stock.SelectionLength = 0;
            this.txt_stock.SelectionStart = 0;
            this.txt_stock.ShortcutsEnabled = true;
            this.txt_stock.Size = new System.Drawing.Size(198, 38);
            this.txt_stock.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_stock.TabIndex = 26;
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_stock.TextMarginBottom = 0;
            this.txt_stock.TextMarginLeft = 3;
            this.txt_stock.TextMarginTop = 0;
            this.txt_stock.TextPlaceholder = "Descripción";
            this.txt_stock.UseSystemPasswordChar = false;
            this.txt_stock.WordWrap = true;
            // 
            // pb_producto_imagen
            // 
            this.pb_producto_imagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_producto_imagen.Image = global::ProyectoTallerII.Properties.Resources.imagen_nuestra;
            this.pb_producto_imagen.Location = new System.Drawing.Point(538, 12);
            this.pb_producto_imagen.Name = "pb_producto_imagen";
            this.pb_producto_imagen.Size = new System.Drawing.Size(139, 104);
            this.pb_producto_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_producto_imagen.TabIndex = 25;
            this.pb_producto_imagen.TabStop = false;
            // 
            // drd_productos_categoria
            // 
            this.drd_productos_categoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.drd_productos_categoria.BackColor = System.Drawing.Color.Transparent;
            this.drd_productos_categoria.BackgroundColor = System.Drawing.Color.White;
            this.drd_productos_categoria.BorderColor = System.Drawing.Color.Silver;
            this.drd_productos_categoria.BorderRadius = 1;
            this.drd_productos_categoria.Color = System.Drawing.Color.Silver;
            this.drd_productos_categoria.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drd_productos_categoria.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drd_productos_categoria.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drd_productos_categoria.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drd_productos_categoria.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drd_productos_categoria.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drd_productos_categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drd_productos_categoria.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drd_productos_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drd_productos_categoria.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drd_productos_categoria.FillDropDown = true;
            this.drd_productos_categoria.FillIndicator = false;
            this.drd_productos_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drd_productos_categoria.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drd_productos_categoria.ForeColor = System.Drawing.Color.Black;
            this.drd_productos_categoria.FormattingEnabled = true;
            this.drd_productos_categoria.Icon = null;
            this.drd_productos_categoria.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drd_productos_categoria.IndicatorColor = System.Drawing.Color.Gray;
            this.drd_productos_categoria.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drd_productos_categoria.ItemBackColor = System.Drawing.Color.White;
            this.drd_productos_categoria.ItemBorderColor = System.Drawing.Color.White;
            this.drd_productos_categoria.ItemForeColor = System.Drawing.Color.Black;
            this.drd_productos_categoria.ItemHeight = 26;
            this.drd_productos_categoria.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drd_productos_categoria.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drd_productos_categoria.Items.AddRange(new object[] {
            "Joyas",
            "Alajas",
            "Alianzas",
            "Relojes"});
            this.drd_productos_categoria.ItemTopMargin = 3;
            this.drd_productos_categoria.Location = new System.Drawing.Point(281, 25);
            this.drd_productos_categoria.Name = "drd_productos_categoria";
            this.drd_productos_categoria.Size = new System.Drawing.Size(198, 32);
            this.drd_productos_categoria.TabIndex = 19;
            this.drd_productos_categoria.Text = "Categoría";
            this.drd_productos_categoria.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drd_productos_categoria.TextLeftMargin = 5;
            // 
            // txt_producto_cod
            // 
            this.txt_producto_cod.AcceptsReturn = false;
            this.txt_producto_cod.AcceptsTab = false;
            this.txt_producto_cod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_producto_cod.AnimationSpeed = 200;
            this.txt_producto_cod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_producto_cod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_producto_cod.BackColor = System.Drawing.Color.Transparent;
            this.txt_producto_cod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_producto_cod.BackgroundImage")));
            this.txt_producto_cod.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_producto_cod.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_producto_cod.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_producto_cod.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_producto_cod.BorderRadius = 1;
            this.txt_producto_cod.BorderThickness = 1;
            this.txt_producto_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_producto_cod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto_cod.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_producto_cod.DefaultText = "";
            this.txt_producto_cod.FillColor = System.Drawing.Color.White;
            this.txt_producto_cod.HideSelection = true;
            this.txt_producto_cod.IconLeft = null;
            this.txt_producto_cod.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto_cod.IconPadding = 10;
            this.txt_producto_cod.IconRight = null;
            this.txt_producto_cod.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto_cod.Lines = new string[0];
            this.txt_producto_cod.Location = new System.Drawing.Point(37, 25);
            this.txt_producto_cod.MaxLength = 16;
            this.txt_producto_cod.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_producto_cod.Modified = false;
            this.txt_producto_cod.Multiline = false;
            this.txt_producto_cod.Name = "txt_producto_cod";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_producto_cod.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_producto_cod.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_producto_cod.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_producto_cod.OnIdleState = stateProperties12;
            this.txt_producto_cod.Padding = new System.Windows.Forms.Padding(3);
            this.txt_producto_cod.PasswordChar = '\0';
            this.txt_producto_cod.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_producto_cod.PlaceholderText = "Cod. Producto";
            this.txt_producto_cod.ReadOnly = false;
            this.txt_producto_cod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_producto_cod.SelectedText = "";
            this.txt_producto_cod.SelectionLength = 0;
            this.txt_producto_cod.SelectionStart = 0;
            this.txt_producto_cod.ShortcutsEnabled = true;
            this.txt_producto_cod.Size = new System.Drawing.Size(198, 38);
            this.txt_producto_cod.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_producto_cod.TabIndex = 1;
            this.txt_producto_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_producto_cod.TextMarginBottom = 0;
            this.txt_producto_cod.TextMarginLeft = 3;
            this.txt_producto_cod.TextMarginTop = 0;
            this.txt_producto_cod.TextPlaceholder = "Cod. Producto";
            this.txt_producto_cod.UseSystemPasswordChar = false;
            this.txt_producto_cod.WordWrap = true;
            // 
            // txt_producto_nombre
            // 
            this.txt_producto_nombre.AcceptsReturn = false;
            this.txt_producto_nombre.AcceptsTab = false;
            this.txt_producto_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_producto_nombre.AnimationSpeed = 200;
            this.txt_producto_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_producto_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_producto_nombre.BackColor = System.Drawing.Color.Transparent;
            this.txt_producto_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_producto_nombre.BackgroundImage")));
            this.txt_producto_nombre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_producto_nombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_producto_nombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_producto_nombre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_producto_nombre.BorderRadius = 1;
            this.txt_producto_nombre.BorderThickness = 1;
            this.txt_producto_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_producto_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto_nombre.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_producto_nombre.DefaultText = "";
            this.txt_producto_nombre.FillColor = System.Drawing.Color.White;
            this.txt_producto_nombre.HideSelection = true;
            this.txt_producto_nombre.IconLeft = null;
            this.txt_producto_nombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto_nombre.IconPadding = 10;
            this.txt_producto_nombre.IconRight = null;
            this.txt_producto_nombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto_nombre.Lines = new string[0];
            this.txt_producto_nombre.Location = new System.Drawing.Point(37, 69);
            this.txt_producto_nombre.MaxLength = 32767;
            this.txt_producto_nombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_producto_nombre.Modified = false;
            this.txt_producto_nombre.Multiline = false;
            this.txt_producto_nombre.Name = "txt_producto_nombre";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_producto_nombre.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_producto_nombre.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_producto_nombre.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_producto_nombre.OnIdleState = stateProperties16;
            this.txt_producto_nombre.Padding = new System.Windows.Forms.Padding(3);
            this.txt_producto_nombre.PasswordChar = '\0';
            this.txt_producto_nombre.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_producto_nombre.PlaceholderText = "Nombre Producto";
            this.txt_producto_nombre.ReadOnly = false;
            this.txt_producto_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_producto_nombre.SelectedText = "";
            this.txt_producto_nombre.SelectionLength = 0;
            this.txt_producto_nombre.SelectionStart = 0;
            this.txt_producto_nombre.ShortcutsEnabled = true;
            this.txt_producto_nombre.Size = new System.Drawing.Size(198, 38);
            this.txt_producto_nombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_producto_nombre.TabIndex = 2;
            this.txt_producto_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_producto_nombre.TextMarginBottom = 0;
            this.txt_producto_nombre.TextMarginLeft = 3;
            this.txt_producto_nombre.TextMarginTop = 0;
            this.txt_producto_nombre.TextPlaceholder = "Nombre Producto";
            this.txt_producto_nombre.UseSystemPasswordChar = false;
            this.txt_producto_nombre.WordWrap = true;
            // 
            // btn_stock_agregar
            // 
            this.btn_stock_agregar.AllowAnimations = true;
            this.btn_stock_agregar.AllowMouseEffects = true;
            this.btn_stock_agregar.AllowToggling = false;
            this.btn_stock_agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_stock_agregar.AnimationSpeed = 200;
            this.btn_stock_agregar.AutoGenerateColors = false;
            this.btn_stock_agregar.AutoRoundBorders = false;
            this.btn_stock_agregar.AutoSizeLeftIcon = true;
            this.btn_stock_agregar.AutoSizeRightIcon = true;
            this.btn_stock_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_stock_agregar.BackColor1 = System.Drawing.Color.BlueViolet;
            this.btn_stock_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stock_agregar.BackgroundImage")));
            this.btn_stock_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_stock_agregar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stock_agregar.ButtonText = "Buscar";
            this.btn_stock_agregar.ButtonTextMarginLeft = 0;
            this.btn_stock_agregar.ColorContrastOnClick = 45;
            this.btn_stock_agregar.ColorContrastOnHover = 45;
            this.btn_stock_agregar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_stock_agregar.CustomizableEdges = borderEdges1;
            this.btn_stock_agregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stock_agregar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stock_agregar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stock_agregar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stock_agregar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_stock_agregar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_stock_agregar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock_agregar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stock_agregar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_stock_agregar.IconMarginLeft = 11;
            this.btn_stock_agregar.IconPadding = 10;
            this.btn_stock_agregar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stock_agregar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stock_agregar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_stock_agregar.IconSize = 25;
            this.btn_stock_agregar.IdleBorderColor = System.Drawing.Color.BlueViolet;
            this.btn_stock_agregar.IdleBorderRadius = 1;
            this.btn_stock_agregar.IdleBorderThickness = 1;
            this.btn_stock_agregar.IdleFillColor = System.Drawing.Color.BlueViolet;
            this.btn_stock_agregar.IdleIconLeftImage = global::ProyectoTallerII.Properties.Resources.search_1__1_;
            this.btn_stock_agregar.IdleIconRightImage = null;
            this.btn_stock_agregar.IndicateFocus = false;
            this.btn_stock_agregar.Location = new System.Drawing.Point(538, 132);
            this.btn_stock_agregar.Name = "btn_stock_agregar";
            this.btn_stock_agregar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stock_agregar.OnDisabledState.BorderRadius = 1;
            this.btn_stock_agregar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stock_agregar.OnDisabledState.BorderThickness = 1;
            this.btn_stock_agregar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stock_agregar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stock_agregar.OnDisabledState.IconLeftImage = null;
            this.btn_stock_agregar.OnDisabledState.IconRightImage = null;
            this.btn_stock_agregar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_stock_agregar.onHoverState.BorderRadius = 1;
            this.btn_stock_agregar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stock_agregar.onHoverState.BorderThickness = 1;
            this.btn_stock_agregar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_stock_agregar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_stock_agregar.onHoverState.IconLeftImage = null;
            this.btn_stock_agregar.onHoverState.IconRightImage = null;
            this.btn_stock_agregar.OnIdleState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btn_stock_agregar.OnIdleState.BorderRadius = 1;
            this.btn_stock_agregar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stock_agregar.OnIdleState.BorderThickness = 1;
            this.btn_stock_agregar.OnIdleState.FillColor = System.Drawing.Color.BlueViolet;
            this.btn_stock_agregar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_stock_agregar.OnIdleState.IconLeftImage = global::ProyectoTallerII.Properties.Resources.search_1__1_;
            this.btn_stock_agregar.OnIdleState.IconRightImage = null;
            this.btn_stock_agregar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_stock_agregar.OnPressedState.BorderRadius = 1;
            this.btn_stock_agregar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stock_agregar.OnPressedState.BorderThickness = 1;
            this.btn_stock_agregar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_stock_agregar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_stock_agregar.OnPressedState.IconLeftImage = null;
            this.btn_stock_agregar.OnPressedState.IconRightImage = null;
            this.btn_stock_agregar.Size = new System.Drawing.Size(150, 39);
            this.btn_stock_agregar.TabIndex = 11;
            this.btn_stock_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_stock_agregar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stock_agregar.TextMarginLeft = 0;
            this.btn_stock_agregar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_stock_agregar.UseDefaultRadiusAndThickness = true;
            // 
            // Form_listar_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 527);
            this.Controls.Add(this.dtg_stock);
            this.Controls.Add(this.panel_stock);
            this.Controls.Add(this.pnl_buscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_listar_productos";
            this.Text = "Form_listar_productos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stock)).EndInit();
            this.pnl_buscador.ResumeLayout(false);
            this.pnl_buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_pbuckup)).EndInit();
            this.panel_stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtg_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn percio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private Bunifu.UI.WinForms.BunifuPanel panel_stock;
        private Bunifu.UI.WinForms.BunifuTextBox txt_stock;
        private System.Windows.Forms.PictureBox pb_producto_imagen;
        private Bunifu.UI.WinForms.BunifuDropdown drd_productos_categoria;
        private Bunifu.UI.WinForms.BunifuTextBox txt_producto_cod;
        private Bunifu.UI.WinForms.BunifuTextBox txt_producto_nombre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_stock_agregar;
        private System.Windows.Forms.Panel pnl_buscador;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuPictureBox lbl_pbuckup;
        private Bunifu.UI.WinForms.BunifuLabel lbl_username;
        private Bunifu.UI.WinForms.BunifuLabel lbl_stock_title;
        private Bunifu.UI.WinForms.BunifuTextBox txt_buscar;
    }
}