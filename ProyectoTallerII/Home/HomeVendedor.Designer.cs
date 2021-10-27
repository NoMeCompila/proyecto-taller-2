
namespace ProyectoTallerII
{
    partial class Form_vendedor_init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_vendedor_init));
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.lbl_bienvenida = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnl_cabecera = new System.Windows.Forms.Panel();
            this.pb_restaurado = new System.Windows.Forms.PictureBox();
            this.pb_maximizar = new System.Windows.Forms.PictureBox();
            this.pb_minimizar = new System.Windows.Forms.PictureBox();
            this.pb_cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_username = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_sidevar = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clientes_gerente = new System.Windows.Forms.Button();
            this.btn_ventas_gerente = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btn_inicio_gerente = new System.Windows.Forms.Button();
            this.lbl_titulo = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnl_contenido.SuspendLayout();
            this.pnl_cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restaurado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).BeginInit();
            this.pnl_sidevar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_contenido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_contenido.Controls.Add(this.lbl_bienvenida);
            this.pnl_contenido.Location = new System.Drawing.Point(184, 0);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(741, 561);
            this.pnl_contenido.TabIndex = 2;
            this.pnl_contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_contenido_Paint);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AllowParentOverrides = false;
            this.lbl_bienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_bienvenida.AutoEllipsis = false;
            this.lbl_bienvenida.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_bienvenida.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_bienvenida.Location = new System.Drawing.Point(70, 236);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_bienvenida.Size = new System.Drawing.Size(604, 60);
            this.lbl_bienvenida.TabIndex = 12;
            this.lbl_bienvenida.Text = "Bienvenido al Sistema- Perfil Vendedor";
            this.lbl_bienvenida.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_bienvenida.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnl_cabecera
            // 
            this.pnl_cabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.pnl_cabecera.Controls.Add(this.pb_restaurado);
            this.pnl_cabecera.Controls.Add(this.pb_maximizar);
            this.pnl_cabecera.Controls.Add(this.pb_minimizar);
            this.pnl_cabecera.Controls.Add(this.pb_cerrar);
            this.pnl_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabecera.Location = new System.Drawing.Point(184, 0);
            this.pnl_cabecera.Name = "pnl_cabecera";
            this.pnl_cabecera.Size = new System.Drawing.Size(741, 41);
            this.pnl_cabecera.TabIndex = 3;
            this.pnl_cabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cabecera_Paint);
            // 
            // pb_restaurado
            // 
            this.pb_restaurado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_restaurado.Image = global::ProyectoTallerII.Properties.Resources.restaurar;
            this.pb_restaurado.Location = new System.Drawing.Point(589, 0);
            this.pb_restaurado.Name = "pb_restaurado";
            this.pb_restaurado.Size = new System.Drawing.Size(49, 34);
            this.pb_restaurado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_restaurado.TabIndex = 6;
            this.pb_restaurado.TabStop = false;
            this.pb_restaurado.Visible = false;
            this.pb_restaurado.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb_maximizar
            // 
            this.pb_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_maximizar.Image = global::ProyectoTallerII.Properties.Resources.maxi;
            this.pb_maximizar.Location = new System.Drawing.Point(589, 0);
            this.pb_maximizar.Name = "pb_maximizar";
            this.pb_maximizar.Size = new System.Drawing.Size(49, 34);
            this.pb_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_maximizar.TabIndex = 5;
            this.pb_maximizar.TabStop = false;
            this.pb_maximizar.Click += new System.EventHandler(this.pb_full_screen_Click);
            // 
            // pb_minimizar
            // 
            this.pb_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimizar.Image = global::ProyectoTallerII.Properties.Resources.minimizar;
            this.pb_minimizar.Location = new System.Drawing.Point(635, 0);
            this.pb_minimizar.Name = "pb_minimizar";
            this.pb_minimizar.Size = new System.Drawing.Size(49, 34);
            this.pb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimizar.TabIndex = 4;
            this.pb_minimizar.TabStop = false;
            this.pb_minimizar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_cerrar
            // 
            this.pb_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_cerrar.Image = global::ProyectoTallerII.Properties.Resources.cerrar;
            this.pb_cerrar.Location = new System.Drawing.Point(680, 0);
            this.pb_cerrar.Name = "pb_cerrar";
            this.pb_cerrar.Size = new System.Drawing.Size(49, 34);
            this.pb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cerrar.TabIndex = 3;
            this.pb_cerrar.TabStop = false;
            this.pb_cerrar.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AllowParentOverrides = false;
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoEllipsis = false;
            this.lbl_username.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_username.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_username.Location = new System.Drawing.Point(589, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_username.Size = new System.Drawing.Size(69, 20);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Juan Perez";
            this.lbl_username.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_username.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 39);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Location = new System.Drawing.Point(0, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 39);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.BlueViolet;
            this.panel5.Location = new System.Drawing.Point(0, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 39);
            this.panel5.TabIndex = 11;
            // 
            // pnl_sidevar
            // 
            this.pnl_sidevar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.pnl_sidevar.Controls.Add(this.bunifuLabel1);
            this.pnl_sidevar.Controls.Add(this.button1);
            this.pnl_sidevar.Controls.Add(this.panel1);
            this.pnl_sidevar.Controls.Add(this.panel5);
            this.pnl_sidevar.Controls.Add(this.btn_clientes_gerente);
            this.pnl_sidevar.Controls.Add(this.btn_ventas_gerente);
            this.pnl_sidevar.Controls.Add(this.panel4);
            this.pnl_sidevar.Controls.Add(this.bunifuSeparator1);
            this.pnl_sidevar.Controls.Add(this.panel2);
            this.pnl_sidevar.Controls.Add(this.btn_inicio_gerente);
            this.pnl_sidevar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidevar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidevar.Name = "pnl_sidevar";
            this.pnl_sidevar.Size = new System.Drawing.Size(184, 561);
            this.pnl_sidevar.TabIndex = 0;
            this.pnl_sidevar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sidevar_Paint);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(173, 60);
            this.bunifuLabel1.TabIndex = 14;
            this.bunifuLabel1.Text = "Perle Joyas";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProyectoTallerII.Properties.Resources.diamond;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Productos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 39);
            this.panel1.TabIndex = 12;
            // 
            // btn_clientes_gerente
            // 
            this.btn_clientes_gerente.FlatAppearance.BorderSize = 0;
            this.btn_clientes_gerente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btn_clientes_gerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes_gerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_clientes_gerente.ForeColor = System.Drawing.Color.White;
            this.btn_clientes_gerente.Image = global::ProyectoTallerII.Properties.Resources.user__1_;
            this.btn_clientes_gerente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes_gerente.Location = new System.Drawing.Point(9, 159);
            this.btn_clientes_gerente.Name = "btn_clientes_gerente";
            this.btn_clientes_gerente.Size = new System.Drawing.Size(172, 39);
            this.btn_clientes_gerente.TabIndex = 10;
            this.btn_clientes_gerente.Text = "Clientes";
            this.btn_clientes_gerente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clientes_gerente.UseVisualStyleBackColor = true;
            this.btn_clientes_gerente.Click += new System.EventHandler(this.btn_clientes_gerente_Click);
            // 
            // btn_ventas_gerente
            // 
            this.btn_ventas_gerente.FlatAppearance.BorderSize = 0;
            this.btn_ventas_gerente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ventas_gerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas_gerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_ventas_gerente.ForeColor = System.Drawing.Color.White;
            this.btn_ventas_gerente.Image = global::ProyectoTallerII.Properties.Resources.ventas__2_;
            this.btn_ventas_gerente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas_gerente.Location = new System.Drawing.Point(9, 215);
            this.btn_ventas_gerente.Name = "btn_ventas_gerente";
            this.btn_ventas_gerente.Size = new System.Drawing.Size(172, 39);
            this.btn_ventas_gerente.TabIndex = 9;
            this.btn_ventas_gerente.Text = "Facturación";
            this.btn_ventas_gerente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ventas_gerente.UseVisualStyleBackColor = true;
            this.btn_ventas_gerente.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 74);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(184, 14);
            this.bunifuSeparator1.TabIndex = 8;
            // 
            // btn_inicio_gerente
            // 
            this.btn_inicio_gerente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio_gerente.FlatAppearance.BorderSize = 0;
            this.btn_inicio_gerente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btn_inicio_gerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio_gerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_inicio_gerente.ForeColor = System.Drawing.Color.White;
            this.btn_inicio_gerente.Image = global::ProyectoTallerII.Properties.Resources.casa__1_1;
            this.btn_inicio_gerente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio_gerente.Location = new System.Drawing.Point(7, 103);
            this.btn_inicio_gerente.Name = "btn_inicio_gerente";
            this.btn_inicio_gerente.Size = new System.Drawing.Size(177, 39);
            this.btn_inicio_gerente.TabIndex = 1;
            this.btn_inicio_gerente.Text = "Inicio";
            this.btn_inicio_gerente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inicio_gerente.UseVisualStyleBackColor = true;
            this.btn_inicio_gerente.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AllowParentOverrides = false;
            this.lbl_titulo.AutoEllipsis = false;
            this.lbl_titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_titulo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(3, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_titulo.Size = new System.Drawing.Size(173, 60);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Perle Joyas";
            this.lbl_titulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form_vendedor_init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.pnl_cabecera);
            this.Controls.Add(this.pnl_contenido);
            this.Controls.Add(this.pnl_sidevar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_vendedor_init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario 2";
            this.pnl_contenido.ResumeLayout(false);
            this.pnl_contenido.PerformLayout();
            this.pnl_cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_restaurado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).EndInit();
            this.pnl_sidevar.ResumeLayout(false);
            this.pnl_sidevar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_contenido;
        private System.Windows.Forms.Panel pnl_cabecera;
        private System.Windows.Forms.PictureBox pb_cerrar;
        private System.Windows.Forms.PictureBox pb_maximizar;
        private System.Windows.Forms.PictureBox pb_restaurado;
        private System.Windows.Forms.PictureBox pb_minimizar;
        private Bunifu.UI.WinForms.BunifuLabel lbl_username;
        private System.Windows.Forms.Button btn_inicio_gerente;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ventas_gerente;
        private System.Windows.Forms.Button btn_clientes_gerente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_sidevar;
        private Bunifu.UI.WinForms.BunifuLabel lbl_titulo;
        private Bunifu.UI.WinForms.BunifuLabel lbl_bienvenida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}