
namespace ProyectoTallerII
{
    partial class GerenteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenteVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbl_ventas_historial = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtg_ventas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnl_gerente_auditoria = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbl_gerente_csv = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_gerente_json = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_gerente_excel = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_gerente_exportar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.rb_gerente_csv = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rb_gerente_json = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rb_gerente_excel = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.lbl_gerente_buscaru_apellido = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_gerente_buscardni = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_gerente_buscar_dni = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuDatePicker2 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verfactura = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ventas)).BeginInit();
            this.pnl_gerente_auditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ventas_historial
            // 
            this.lbl_ventas_historial.AllowParentOverrides = false;
            this.lbl_ventas_historial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ventas_historial.AutoEllipsis = false;
            this.lbl_ventas_historial.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ventas_historial.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ventas_historial.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ventas_historial.Location = new System.Drawing.Point(235, 66);
            this.lbl_ventas_historial.Name = "lbl_ventas_historial";
            this.lbl_ventas_historial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ventas_historial.Size = new System.Drawing.Size(354, 44);
            this.lbl_ventas_historial.TabIndex = 5;
            this.lbl_ventas_historial.Text = "HISTORIAL DE VENTAS";
            this.lbl_ventas_historial.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ventas_historial.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtg_ventas
            // 
            this.dtg_ventas.AllowCustomTheming = false;
            this.dtg_ventas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dtg_ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.dtg_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_ventas.ColumnHeadersHeight = 40;
            this.dtg_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vendedor,
            this.Nombre_Cliente,
            this.Apellido_Cliente,
            this.DNI,
            this.tipo_pago,
            this.Id_cabecera,
            this.subtotal,
            this.Fecha,
            this.verfactura});
            this.dtg_ventas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dtg_ventas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_ventas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_ventas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dtg_ventas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_ventas.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dtg_ventas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dtg_ventas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dtg_ventas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_ventas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_ventas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dtg_ventas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_ventas.CurrentTheme.Name = null;
            this.dtg_ventas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dtg_ventas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_ventas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_ventas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dtg_ventas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_ventas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_ventas.EnableHeadersVisualStyles = false;
            this.dtg_ventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dtg_ventas.HeaderBackColor = System.Drawing.Color.Navy;
            this.dtg_ventas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_ventas.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_ventas.Location = new System.Drawing.Point(12, 342);
            this.dtg_ventas.Name = "dtg_ventas";
            this.dtg_ventas.ReadOnly = true;
            this.dtg_ventas.RowHeadersVisible = false;
            this.dtg_ventas.RowTemplate.Height = 40;
            this.dtg_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ventas.Size = new System.Drawing.Size(778, 186);
            this.dtg_ventas.TabIndex = 26;
            this.dtg_ventas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dtg_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ventas_CellContentClick);
            // 
            // pnl_gerente_auditoria
            // 
            this.pnl_gerente_auditoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_gerente_auditoria.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnl_gerente_auditoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_gerente_auditoria.BackgroundImage")));
            this.pnl_gerente_auditoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_gerente_auditoria.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_gerente_auditoria.BorderRadius = 3;
            this.pnl_gerente_auditoria.BorderThickness = 1;
            this.pnl_gerente_auditoria.Controls.Add(this.bunifuLabel1);
            this.pnl_gerente_auditoria.Controls.Add(this.bunifuLabel2);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_csv);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_json);
            this.pnl_gerente_auditoria.Controls.Add(this.bunifuDatePicker2);
            this.pnl_gerente_auditoria.Controls.Add(this.bunifuDatePicker1);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_excel);
            this.pnl_gerente_auditoria.Controls.Add(this.btn_gerente_exportar);
            this.pnl_gerente_auditoria.Controls.Add(this.rb_gerente_csv);
            this.pnl_gerente_auditoria.Controls.Add(this.rb_gerente_json);
            this.pnl_gerente_auditoria.Controls.Add(this.rb_gerente_excel);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_buscaru_apellido);
            this.pnl_gerente_auditoria.Controls.Add(this.txt_gerente_buscardni);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_buscar_dni);
            this.pnl_gerente_auditoria.Location = new System.Drawing.Point(36, 110);
            this.pnl_gerente_auditoria.Name = "pnl_gerente_auditoria";
            this.pnl_gerente_auditoria.ShowBorders = true;
            this.pnl_gerente_auditoria.Size = new System.Drawing.Size(728, 192);
            this.pnl_gerente_auditoria.TabIndex = 27;
            this.pnl_gerente_auditoria.Click += new System.EventHandler(this.pnl_gerente_auditoria_Click);
            // 
            // lbl_gerente_csv
            // 
            this.lbl_gerente_csv.AllowParentOverrides = false;
            this.lbl_gerente_csv.AutoEllipsis = false;
            this.lbl_gerente_csv.CursorType = null;
            this.lbl_gerente_csv.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_csv.Location = new System.Drawing.Point(676, 32);
            this.lbl_gerente_csv.Name = "lbl_gerente_csv";
            this.lbl_gerente_csv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_csv.Size = new System.Drawing.Size(29, 21);
            this.lbl_gerente_csv.TabIndex = 11;
            this.lbl_gerente_csv.Text = "CSV";
            this.lbl_gerente_csv.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_csv.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_gerente_json
            // 
            this.lbl_gerente_json.AllowParentOverrides = false;
            this.lbl_gerente_json.AutoEllipsis = false;
            this.lbl_gerente_json.CursorType = null;
            this.lbl_gerente_json.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_json.Location = new System.Drawing.Point(610, 32);
            this.lbl_gerente_json.Name = "lbl_gerente_json";
            this.lbl_gerente_json.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_json.Size = new System.Drawing.Size(39, 21);
            this.lbl_gerente_json.TabIndex = 10;
            this.lbl_gerente_json.Text = "JSON";
            this.lbl_gerente_json.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_json.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_gerente_excel
            // 
            this.lbl_gerente_excel.AllowParentOverrides = false;
            this.lbl_gerente_excel.AutoEllipsis = false;
            this.lbl_gerente_excel.CursorType = null;
            this.lbl_gerente_excel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_excel.Location = new System.Drawing.Point(555, 32);
            this.lbl_gerente_excel.Name = "lbl_gerente_excel";
            this.lbl_gerente_excel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_excel.Size = new System.Drawing.Size(34, 21);
            this.lbl_gerente_excel.TabIndex = 9;
            this.lbl_gerente_excel.Text = "Excel";
            this.lbl_gerente_excel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_excel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_gerente_exportar
            // 
            this.btn_gerente_exportar.AllowAnimations = true;
            this.btn_gerente_exportar.AllowMouseEffects = true;
            this.btn_gerente_exportar.AllowToggling = false;
            this.btn_gerente_exportar.AnimationSpeed = 200;
            this.btn_gerente_exportar.AutoGenerateColors = false;
            this.btn_gerente_exportar.AutoRoundBorders = false;
            this.btn_gerente_exportar.AutoSizeLeftIcon = true;
            this.btn_gerente_exportar.AutoSizeRightIcon = true;
            this.btn_gerente_exportar.BackColor = System.Drawing.Color.Transparent;
            this.btn_gerente_exportar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_gerente_exportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gerente_exportar.BackgroundImage")));
            this.btn_gerente_exportar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gerente_exportar.ButtonText = "Exportar Datos";
            this.btn_gerente_exportar.ButtonTextMarginLeft = 0;
            this.btn_gerente_exportar.ColorContrastOnClick = 45;
            this.btn_gerente_exportar.ColorContrastOnHover = 45;
            this.btn_gerente_exportar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_gerente_exportar.CustomizableEdges = borderEdges3;
            this.btn_gerente_exportar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_gerente_exportar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_gerente_exportar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_gerente_exportar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_gerente_exportar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_gerente_exportar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerente_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_gerente_exportar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gerente_exportar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_gerente_exportar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_gerente_exportar.IconMarginLeft = 11;
            this.btn_gerente_exportar.IconPadding = 10;
            this.btn_gerente_exportar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gerente_exportar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_gerente_exportar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_gerente_exportar.IconSize = 25;
            this.btn_gerente_exportar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_gerente_exportar.IdleBorderRadius = 1;
            this.btn_gerente_exportar.IdleBorderThickness = 1;
            this.btn_gerente_exportar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_gerente_exportar.IdleIconLeftImage = null;
            this.btn_gerente_exportar.IdleIconRightImage = null;
            this.btn_gerente_exportar.IndicateFocus = false;
            this.btn_gerente_exportar.Location = new System.Drawing.Point(555, 88);
            this.btn_gerente_exportar.Name = "btn_gerente_exportar";
            this.btn_gerente_exportar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_gerente_exportar.OnDisabledState.BorderRadius = 1;
            this.btn_gerente_exportar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gerente_exportar.OnDisabledState.BorderThickness = 1;
            this.btn_gerente_exportar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_gerente_exportar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_gerente_exportar.OnDisabledState.IconLeftImage = null;
            this.btn_gerente_exportar.OnDisabledState.IconRightImage = null;
            this.btn_gerente_exportar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_gerente_exportar.onHoverState.BorderRadius = 1;
            this.btn_gerente_exportar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gerente_exportar.onHoverState.BorderThickness = 1;
            this.btn_gerente_exportar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_gerente_exportar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_gerente_exportar.onHoverState.IconLeftImage = null;
            this.btn_gerente_exportar.onHoverState.IconRightImage = null;
            this.btn_gerente_exportar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_gerente_exportar.OnIdleState.BorderRadius = 1;
            this.btn_gerente_exportar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gerente_exportar.OnIdleState.BorderThickness = 1;
            this.btn_gerente_exportar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_gerente_exportar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_gerente_exportar.OnIdleState.IconLeftImage = null;
            this.btn_gerente_exportar.OnIdleState.IconRightImage = null;
            this.btn_gerente_exportar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_gerente_exportar.OnPressedState.BorderRadius = 1;
            this.btn_gerente_exportar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gerente_exportar.OnPressedState.BorderThickness = 1;
            this.btn_gerente_exportar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_gerente_exportar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_gerente_exportar.OnPressedState.IconLeftImage = null;
            this.btn_gerente_exportar.OnPressedState.IconRightImage = null;
            this.btn_gerente_exportar.Size = new System.Drawing.Size(150, 39);
            this.btn_gerente_exportar.TabIndex = 8;
            this.btn_gerente_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_gerente_exportar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_gerente_exportar.TextMarginLeft = 0;
            this.btn_gerente_exportar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_gerente_exportar.UseDefaultRadiusAndThickness = true;
            // 
            // rb_gerente_csv
            // 
            this.rb_gerente_csv.AllowBindingControlLocation = false;
            this.rb_gerente_csv.BackColor = System.Drawing.Color.Transparent;
            this.rb_gerente_csv.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rb_gerente_csv.BorderThickness = 1;
            this.rb_gerente_csv.Checked = false;
            this.rb_gerente_csv.Location = new System.Drawing.Point(683, 61);
            this.rb_gerente_csv.Name = "rb_gerente_csv";
            this.rb_gerente_csv.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rb_gerente_csv.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_gerente_csv.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rb_gerente_csv.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rb_gerente_csv.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_gerente_csv.Size = new System.Drawing.Size(21, 21);
            this.rb_gerente_csv.TabIndex = 7;
            this.rb_gerente_csv.Text = null;
            // 
            // rb_gerente_json
            // 
            this.rb_gerente_json.AllowBindingControlLocation = false;
            this.rb_gerente_json.BackColor = System.Drawing.Color.Transparent;
            this.rb_gerente_json.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rb_gerente_json.BorderThickness = 1;
            this.rb_gerente_json.Checked = false;
            this.rb_gerente_json.Location = new System.Drawing.Point(619, 61);
            this.rb_gerente_json.Name = "rb_gerente_json";
            this.rb_gerente_json.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rb_gerente_json.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_gerente_json.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rb_gerente_json.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rb_gerente_json.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_gerente_json.Size = new System.Drawing.Size(21, 21);
            this.rb_gerente_json.TabIndex = 6;
            this.rb_gerente_json.Text = null;
            // 
            // rb_gerente_excel
            // 
            this.rb_gerente_excel.AllowBindingControlLocation = false;
            this.rb_gerente_excel.BackColor = System.Drawing.Color.Transparent;
            this.rb_gerente_excel.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rb_gerente_excel.BorderThickness = 1;
            this.rb_gerente_excel.Checked = true;
            this.rb_gerente_excel.Location = new System.Drawing.Point(555, 61);
            this.rb_gerente_excel.Name = "rb_gerente_excel";
            this.rb_gerente_excel.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rb_gerente_excel.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_gerente_excel.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rb_gerente_excel.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rb_gerente_excel.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_gerente_excel.Size = new System.Drawing.Size(21, 21);
            this.rb_gerente_excel.TabIndex = 5;
            this.rb_gerente_excel.Text = null;
            // 
            // lbl_gerente_buscaru_apellido
            // 
            this.lbl_gerente_buscaru_apellido.AllowParentOverrides = false;
            this.lbl_gerente_buscaru_apellido.AutoEllipsis = false;
            this.lbl_gerente_buscaru_apellido.CursorType = null;
            this.lbl_gerente_buscaru_apellido.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_buscaru_apellido.Location = new System.Drawing.Point(12, 88);
            this.lbl_gerente_buscaru_apellido.Name = "lbl_gerente_buscaru_apellido";
            this.lbl_gerente_buscaru_apellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_buscaru_apellido.Size = new System.Drawing.Size(179, 21);
            this.lbl_gerente_buscaru_apellido.TabIndex = 2;
            this.lbl_gerente_buscaru_apellido.Text = "Filtrar por rango de fecha:";
            this.lbl_gerente_buscaru_apellido.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_buscaru_apellido.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_gerente_buscardni
            // 
            this.txt_gerente_buscardni.AcceptsReturn = false;
            this.txt_gerente_buscardni.AcceptsTab = false;
            this.txt_gerente_buscardni.AnimationSpeed = 200;
            this.txt_gerente_buscardni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_gerente_buscardni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_gerente_buscardni.BackColor = System.Drawing.Color.Transparent;
            this.txt_gerente_buscardni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_gerente_buscardni.BackgroundImage")));
            this.txt_gerente_buscardni.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_gerente_buscardni.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_gerente_buscardni.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_gerente_buscardni.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_gerente_buscardni.BorderRadius = 1;
            this.txt_gerente_buscardni.BorderThickness = 1;
            this.txt_gerente_buscardni.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_gerente_buscardni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gerente_buscardni.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_gerente_buscardni.DefaultText = "";
            this.txt_gerente_buscardni.FillColor = System.Drawing.Color.White;
            this.txt_gerente_buscardni.HideSelection = true;
            this.txt_gerente_buscardni.IconLeft = null;
            this.txt_gerente_buscardni.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gerente_buscardni.IconPadding = 10;
            this.txt_gerente_buscardni.IconRight = null;
            this.txt_gerente_buscardni.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gerente_buscardni.Lines = new string[0];
            this.txt_gerente_buscardni.Location = new System.Drawing.Point(181, 16);
            this.txt_gerente_buscardni.MaxLength = 32767;
            this.txt_gerente_buscardni.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_gerente_buscardni.Modified = false;
            this.txt_gerente_buscardni.Multiline = false;
            this.txt_gerente_buscardni.Name = "txt_gerente_buscardni";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscardni.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_gerente_buscardni.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscardni.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscardni.OnIdleState = stateProperties12;
            this.txt_gerente_buscardni.Padding = new System.Windows.Forms.Padding(3);
            this.txt_gerente_buscardni.PasswordChar = '\0';
            this.txt_gerente_buscardni.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_gerente_buscardni.PlaceholderText = "";
            this.txt_gerente_buscardni.ReadOnly = false;
            this.txt_gerente_buscardni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gerente_buscardni.SelectedText = "";
            this.txt_gerente_buscardni.SelectionLength = 0;
            this.txt_gerente_buscardni.SelectionStart = 0;
            this.txt_gerente_buscardni.ShortcutsEnabled = true;
            this.txt_gerente_buscardni.Size = new System.Drawing.Size(260, 37);
            this.txt_gerente_buscardni.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_gerente_buscardni.TabIndex = 1;
            this.txt_gerente_buscardni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_gerente_buscardni.TextMarginBottom = 0;
            this.txt_gerente_buscardni.TextMarginLeft = 3;
            this.txt_gerente_buscardni.TextMarginTop = 0;
            this.txt_gerente_buscardni.TextPlaceholder = "";
            this.txt_gerente_buscardni.UseSystemPasswordChar = false;
            this.txt_gerente_buscardni.WordWrap = true;
            // 
            // lbl_gerente_buscar_dni
            // 
            this.lbl_gerente_buscar_dni.AllowParentOverrides = false;
            this.lbl_gerente_buscar_dni.AutoEllipsis = false;
            this.lbl_gerente_buscar_dni.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_gerente_buscar_dni.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_gerente_buscar_dni.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_buscar_dni.Location = new System.Drawing.Point(12, 32);
            this.lbl_gerente_buscar_dni.Name = "lbl_gerente_buscar_dni";
            this.lbl_gerente_buscar_dni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_buscar_dni.Size = new System.Drawing.Size(163, 21);
            this.lbl_gerente_buscar_dni.TabIndex = 0;
            this.lbl_gerente_buscar_dni.Text = "Buscar por Nro Factura:";
            this.lbl_gerente_buscar_dni.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_buscar_dni.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(125, 139);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(0, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(113, 32);
            this.bunifuDatePicker1.TabIndex = 12;
            this.bunifuDatePicker1.Value = new System.DateTime(2021, 10, 1, 10, 24, 0, 0);
            // 
            // bunifuDatePicker2
            // 
            this.bunifuDatePicker2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker2.BorderRadius = 1;
            this.bunifuDatePicker2.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker2.DisplayWeekNumbers = false;
            this.bunifuDatePicker2.DPHeight = 0;
            this.bunifuDatePicker2.FillDatePicker = false;
            this.bunifuDatePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatePicker2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker2.Icon")));
            this.bunifuDatePicker2.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker2.LeftTextMargin = 5;
            this.bunifuDatePicker2.Location = new System.Drawing.Point(328, 139);
            this.bunifuDatePicker2.MinimumSize = new System.Drawing.Size(0, 32);
            this.bunifuDatePicker2.Name = "bunifuDatePicker2";
            this.bunifuDatePicker2.Size = new System.Drawing.Size(113, 32);
            this.bunifuDatePicker2.TabIndex = 28;
            this.bunifuDatePicker2.Value = new System.DateTime(2021, 10, 1, 10, 24, 0, 0);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.bunifuLabel1.Location = new System.Drawing.Point(51, 149);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(51, 22);
            this.bunifuLabel1.TabIndex = 12;
            this.bunifuLabel1.Text = "Desde:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.bunifuLabel2.Location = new System.Drawing.Point(261, 149);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(47, 22);
            this.bunifuLabel2.TabIndex = 29;
            this.bunifuLabel2.Text = "Hasta:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.HeaderText = "Nombre Cliente";
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            this.Nombre_Cliente.ReadOnly = true;
            // 
            // Apellido_Cliente
            // 
            this.Apellido_Cliente.HeaderText = "Apellido Cliente";
            this.Apellido_Cliente.Name = "Apellido_Cliente";
            this.Apellido_Cliente.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // tipo_pago
            // 
            this.tipo_pago.HeaderText = "Tipo de Pago";
            this.tipo_pago.Name = "tipo_pago";
            this.tipo_pago.ReadOnly = true;
            // 
            // Id_cabecera
            // 
            this.Id_cabecera.HeaderText = "ID Cabecera";
            this.Id_cabecera.Name = "Id_cabecera";
            this.Id_cabecera.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // verfactura
            // 
            this.verfactura.HeaderText = "Ver Factura";
            this.verfactura.Name = "verfactura";
            this.verfactura.ReadOnly = true;
            // 
            // Form_ventas_gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 527);
            this.Controls.Add(this.pnl_gerente_auditoria);
            this.Controls.Add(this.dtg_ventas);
            this.Controls.Add(this.lbl_ventas_historial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ventas_gerente";
            this.Text = "Form_ventas_gerente";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ventas)).EndInit();
            this.pnl_gerente_auditoria.ResumeLayout(false);
            this.pnl_gerente_auditoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbl_ventas_historial;
        private Bunifu.UI.WinForms.BunifuDataGridView dtg_ventas;
        private Bunifu.UI.WinForms.BunifuPanel pnl_gerente_auditoria;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_csv;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_json;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_excel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_gerente_exportar;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_gerente_csv;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_gerente_json;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_gerente_excel;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_buscaru_apellido;
        private Bunifu.UI.WinForms.BunifuTextBox txt_gerente_buscardni;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_buscar_dni;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewButtonColumn verfactura;
    }
}