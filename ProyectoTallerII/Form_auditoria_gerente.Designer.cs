
namespace ProyectoTallerII
{
    partial class Form_auditoria_gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_auditoria_gerente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbl_audi = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtg_auditoria = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnl_gerente_auditoria = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbl_gerente_csv = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_gerente_json = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_gerente_excel = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_gerente_exportar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.rb_gerente_csv = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rb_gerente_json = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rb_gerente_excel = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.txt_gerente_buscarusuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_gerente_buscarusuario = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_gerente_buscardni = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_gerente_buscardni = new Bunifu.UI.WinForms.BunifuLabel();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo_ing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_auditoria)).BeginInit();
            this.pnl_gerente_auditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_audi
            // 
            this.lbl_audi.AllowParentOverrides = false;
            this.lbl_audi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_audi.AutoEllipsis = false;
            this.lbl_audi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_audi.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_audi.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_audi.Location = new System.Drawing.Point(327, 57);
            this.lbl_audi.Name = "lbl_audi";
            this.lbl_audi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_audi.Size = new System.Drawing.Size(177, 44);
            this.lbl_audi.TabIndex = 3;
            this.lbl_audi.Text = "AUDITORIA";
            this.lbl_audi.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_audi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtg_auditoria
            // 
            this.dtg_auditoria.AllowCustomTheming = false;
            this.dtg_auditoria.AllowUserToAddRows = false;
            this.dtg_auditoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtg_auditoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_auditoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_auditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_auditoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.dtg_auditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_auditoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_auditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_auditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_auditoria.ColumnHeadersHeight = 40;
            this.dtg_auditoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.usuario,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Tel,
            this.fecha_alta,
            this.primer_ingreso,
            this.ultimo_ing,
            this.hora});
            this.dtg_auditoria.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dtg_auditoria.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_auditoria.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_auditoria.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dtg_auditoria.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_auditoria.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dtg_auditoria.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dtg_auditoria.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dtg_auditoria.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_auditoria.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_auditoria.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dtg_auditoria.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_auditoria.CurrentTheme.Name = null;
            this.dtg_auditoria.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dtg_auditoria.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_auditoria.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_auditoria.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dtg_auditoria.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_auditoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_auditoria.EnableHeadersVisualStyles = false;
            this.dtg_auditoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dtg_auditoria.HeaderBackColor = System.Drawing.Color.Navy;
            this.dtg_auditoria.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_auditoria.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_auditoria.Location = new System.Drawing.Point(12, 255);
            this.dtg_auditoria.Name = "dtg_auditoria";
            this.dtg_auditoria.ReadOnly = true;
            this.dtg_auditoria.RowHeadersVisible = false;
            this.dtg_auditoria.RowTemplate.Height = 40;
            this.dtg_auditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_auditoria.Size = new System.Drawing.Size(778, 280);
            this.dtg_auditoria.TabIndex = 24;
            this.dtg_auditoria.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
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
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_csv);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_json);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_excel);
            this.pnl_gerente_auditoria.Controls.Add(this.btn_gerente_exportar);
            this.pnl_gerente_auditoria.Controls.Add(this.rb_gerente_csv);
            this.pnl_gerente_auditoria.Controls.Add(this.rb_gerente_json);
            this.pnl_gerente_auditoria.Controls.Add(this.rb_gerente_excel);
            this.pnl_gerente_auditoria.Controls.Add(this.txt_gerente_buscarusuario);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_buscarusuario);
            this.pnl_gerente_auditoria.Controls.Add(this.txt_gerente_buscardni);
            this.pnl_gerente_auditoria.Controls.Add(this.lbl_gerente_buscardni);
            this.pnl_gerente_auditoria.Location = new System.Drawing.Point(37, 117);
            this.pnl_gerente_auditoria.Name = "pnl_gerente_auditoria";
            this.pnl_gerente_auditoria.ShowBorders = true;
            this.pnl_gerente_auditoria.Size = new System.Drawing.Size(728, 132);
            this.pnl_gerente_auditoria.TabIndex = 25;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_gerente_exportar.CustomizableEdges = borderEdges1;
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
            // txt_gerente_buscarusuario
            // 
            this.txt_gerente_buscarusuario.AcceptsReturn = false;
            this.txt_gerente_buscarusuario.AcceptsTab = false;
            this.txt_gerente_buscarusuario.AnimationSpeed = 200;
            this.txt_gerente_buscarusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_gerente_buscarusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_gerente_buscarusuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_gerente_buscarusuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_gerente_buscarusuario.BackgroundImage")));
            this.txt_gerente_buscarusuario.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_gerente_buscarusuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_gerente_buscarusuario.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_gerente_buscarusuario.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_gerente_buscarusuario.BorderRadius = 1;
            this.txt_gerente_buscarusuario.BorderThickness = 1;
            this.txt_gerente_buscarusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_gerente_buscarusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gerente_buscarusuario.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_gerente_buscarusuario.DefaultText = "";
            this.txt_gerente_buscarusuario.FillColor = System.Drawing.Color.White;
            this.txt_gerente_buscarusuario.HideSelection = true;
            this.txt_gerente_buscarusuario.IconLeft = null;
            this.txt_gerente_buscarusuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gerente_buscarusuario.IconPadding = 10;
            this.txt_gerente_buscarusuario.IconRight = null;
            this.txt_gerente_buscarusuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gerente_buscarusuario.Lines = new string[0];
            this.txt_gerente_buscarusuario.Location = new System.Drawing.Point(153, 74);
            this.txt_gerente_buscarusuario.MaxLength = 32767;
            this.txt_gerente_buscarusuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_gerente_buscarusuario.Modified = false;
            this.txt_gerente_buscarusuario.Multiline = false;
            this.txt_gerente_buscarusuario.Name = "txt_gerente_buscarusuario";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscarusuario.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_gerente_buscarusuario.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscarusuario.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscarusuario.OnIdleState = stateProperties4;
            this.txt_gerente_buscarusuario.Padding = new System.Windows.Forms.Padding(3);
            this.txt_gerente_buscarusuario.PasswordChar = '\0';
            this.txt_gerente_buscarusuario.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_gerente_buscarusuario.PlaceholderText = "";
            this.txt_gerente_buscarusuario.ReadOnly = false;
            this.txt_gerente_buscarusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gerente_buscarusuario.SelectedText = "";
            this.txt_gerente_buscarusuario.SelectionLength = 0;
            this.txt_gerente_buscarusuario.SelectionStart = 0;
            this.txt_gerente_buscarusuario.ShortcutsEnabled = true;
            this.txt_gerente_buscarusuario.Size = new System.Drawing.Size(260, 37);
            this.txt_gerente_buscarusuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_gerente_buscarusuario.TabIndex = 3;
            this.txt_gerente_buscarusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_gerente_buscarusuario.TextMarginBottom = 0;
            this.txt_gerente_buscarusuario.TextMarginLeft = 3;
            this.txt_gerente_buscarusuario.TextMarginTop = 0;
            this.txt_gerente_buscarusuario.TextPlaceholder = "";
            this.txt_gerente_buscarusuario.UseSystemPasswordChar = false;
            this.txt_gerente_buscarusuario.WordWrap = true;
            // 
            // lbl_gerente_buscarusuario
            // 
            this.lbl_gerente_buscarusuario.AllowParentOverrides = false;
            this.lbl_gerente_buscarusuario.AutoEllipsis = false;
            this.lbl_gerente_buscarusuario.CursorType = null;
            this.lbl_gerente_buscarusuario.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_buscarusuario.Location = new System.Drawing.Point(12, 90);
            this.lbl_gerente_buscarusuario.Name = "lbl_gerente_buscarusuario";
            this.lbl_gerente_buscarusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_buscarusuario.Size = new System.Drawing.Size(135, 21);
            this.lbl_gerente_buscarusuario.TabIndex = 2;
            this.lbl_gerente_buscarusuario.Text = "Buscar por Usuario:";
            this.lbl_gerente_buscarusuario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_buscarusuario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.txt_gerente_buscardni.Location = new System.Drawing.Point(126, 23);
            this.txt_gerente_buscardni.MaxLength = 32767;
            this.txt_gerente_buscardni.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_gerente_buscardni.Modified = false;
            this.txt_gerente_buscardni.Multiline = false;
            this.txt_gerente_buscardni.Name = "txt_gerente_buscardni";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscardni.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_gerente_buscardni.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscardni.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_gerente_buscardni.OnIdleState = stateProperties8;
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
            // lbl_gerente_buscardni
            // 
            this.lbl_gerente_buscardni.AllowParentOverrides = false;
            this.lbl_gerente_buscardni.AutoEllipsis = false;
            this.lbl_gerente_buscardni.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_gerente_buscardni.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_gerente_buscardni.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_gerente_buscardni.Location = new System.Drawing.Point(12, 32);
            this.lbl_gerente_buscardni.Name = "lbl_gerente_buscardni";
            this.lbl_gerente_buscardni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gerente_buscardni.Size = new System.Drawing.Size(108, 21);
            this.lbl_gerente_buscardni.TabIndex = 0;
            this.lbl_gerente_buscardni.Text = "Buscar por DNI:";
            this.lbl_gerente_buscardni.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_gerente_buscardni.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // fecha_alta
            // 
            this.fecha_alta.HeaderText = "Fecha de Alta";
            this.fecha_alta.Name = "fecha_alta";
            this.fecha_alta.ReadOnly = true;
            // 
            // primer_ingreso
            // 
            this.primer_ingreso.HeaderText = "1er Ingreso";
            this.primer_ingreso.Name = "primer_ingreso";
            this.primer_ingreso.ReadOnly = true;
            // 
            // ultimo_ing
            // 
            this.ultimo_ing.HeaderText = "Ultimo Ingreso";
            this.ultimo_ing.Name = "ultimo_ing";
            this.ultimo_ing.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora ultimo ingreso";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // Form_auditoria_gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 527);
            this.Controls.Add(this.pnl_gerente_auditoria);
            this.Controls.Add(this.dtg_auditoria);
            this.Controls.Add(this.lbl_audi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_auditoria_gerente";
            this.Text = "Form_auditoria_gerente";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_auditoria)).EndInit();
            this.pnl_gerente_auditoria.ResumeLayout(false);
            this.pnl_gerente_auditoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbl_audi;
        private Bunifu.UI.WinForms.BunifuDataGridView dtg_auditoria;
        private Bunifu.UI.WinForms.BunifuPanel pnl_gerente_auditoria;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_buscardni;
        private Bunifu.UI.WinForms.BunifuTextBox txt_gerente_buscarusuario;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_buscarusuario;
        private Bunifu.UI.WinForms.BunifuTextBox txt_gerente_buscardni;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_csv;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_json;
        private Bunifu.UI.WinForms.BunifuLabel lbl_gerente_excel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_gerente_exportar;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_gerente_csv;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_gerente_json;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_gerente_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo_ing;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
}