
namespace ProyectoTallerII
{
    partial class Form_home_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_home_empleado));
            this.card_inicio = new Bunifu.Framework.UI.BunifuCards();
            this.card_textoinicio = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_card_inicio = new Bunifu.UI.WinForms.BunifuLabel();
            this.pb_inicio = new System.Windows.Forms.PictureBox();
            this.card_usuarios = new Bunifu.Framework.UI.BunifuCards();
            this.pb_usuarios = new System.Windows.Forms.PictureBox();
            this.card_stock = new Bunifu.Framework.UI.BunifuCards();
            this.pb_stock = new System.Windows.Forms.PictureBox();
            this.card_backup = new Bunifu.Framework.UI.BunifuCards();
            this.pb_backup = new System.Windows.Forms.PictureBox();
            this.lbl_inicio = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_card_stock = new Bunifu.UI.WinForms.BunifuLabel();
            this.card_textostock = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.card_textobackup = new Bunifu.UI.WinForms.BunifuLabel();
            this.card_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inicio)).BeginInit();
            this.card_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usuarios)).BeginInit();
            this.card_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stock)).BeginInit();
            this.card_backup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backup)).BeginInit();
            this.SuspendLayout();
            // 
            // card_inicio
            // 
            this.card_inicio.BackColor = System.Drawing.Color.White;
            this.card_inicio.BorderRadius = 5;
            this.card_inicio.BottomSahddow = true;
            this.card_inicio.color = System.Drawing.Color.DarkViolet;
            this.card_inicio.Controls.Add(this.card_textoinicio);
            this.card_inicio.Controls.Add(this.lbl_card_inicio);
            this.card_inicio.Controls.Add(this.pb_inicio);
            this.card_inicio.LeftSahddow = false;
            this.card_inicio.Location = new System.Drawing.Point(40, 116);
            this.card_inicio.Name = "card_inicio";
            this.card_inicio.RightSahddow = true;
            this.card_inicio.ShadowDepth = 20;
            this.card_inicio.Size = new System.Drawing.Size(295, 164);
            this.card_inicio.TabIndex = 0;
            this.card_inicio.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // card_textoinicio
            // 
            this.card_textoinicio.AllowParentOverrides = false;
            this.card_textoinicio.AutoEllipsis = false;
            this.card_textoinicio.CursorType = null;
            this.card_textoinicio.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.card_textoinicio.Location = new System.Drawing.Point(13, 96);
            this.card_textoinicio.Name = "card_textoinicio";
            this.card_textoinicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_textoinicio.Size = new System.Drawing.Size(267, 34);
            this.card_textoinicio.TabIndex = 3;
            this.card_textoinicio.Text = "Descripción general de cada área del sistema \r\ny para que sirven.";
            this.card_textoinicio.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.card_textoinicio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.card_textoinicio.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // lbl_card_inicio
            // 
            this.lbl_card_inicio.AllowParentOverrides = false;
            this.lbl_card_inicio.AutoEllipsis = false;
            this.lbl_card_inicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_card_inicio.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_card_inicio.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_card_inicio.Location = new System.Drawing.Point(136, 33);
            this.lbl_card_inicio.Name = "lbl_card_inicio";
            this.lbl_card_inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_card_inicio.Size = new System.Drawing.Size(41, 16);
            this.lbl_card_inicio.TabIndex = 2;
            this.lbl_card_inicio.Text = "INICIO";
            this.lbl_card_inicio.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_card_inicio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pb_inicio
            // 
            this.pb_inicio.Image = global::ProyectoTallerII.Properties.Resources.casa__1_1;
            this.pb_inicio.Location = new System.Drawing.Point(16, 18);
            this.pb_inicio.Name = "pb_inicio";
            this.pb_inicio.Size = new System.Drawing.Size(77, 44);
            this.pb_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_inicio.TabIndex = 1;
            this.pb_inicio.TabStop = false;
            // 
            // card_usuarios
            // 
            this.card_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.card_usuarios.BackColor = System.Drawing.Color.White;
            this.card_usuarios.BorderRadius = 5;
            this.card_usuarios.BottomSahddow = true;
            this.card_usuarios.color = System.Drawing.Color.DarkViolet;
            this.card_usuarios.Controls.Add(this.bunifuLabel2);
            this.card_usuarios.Controls.Add(this.bunifuLabel1);
            this.card_usuarios.Controls.Add(this.pb_usuarios);
            this.card_usuarios.LeftSahddow = false;
            this.card_usuarios.Location = new System.Drawing.Point(448, 116);
            this.card_usuarios.Name = "card_usuarios";
            this.card_usuarios.RightSahddow = true;
            this.card_usuarios.ShadowDepth = 20;
            this.card_usuarios.Size = new System.Drawing.Size(295, 164);
            this.card_usuarios.TabIndex = 1;
            // 
            // pb_usuarios
            // 
            this.pb_usuarios.Image = global::ProyectoTallerII.Properties.Resources.user__1_;
            this.pb_usuarios.Location = new System.Drawing.Point(15, 18);
            this.pb_usuarios.Name = "pb_usuarios";
            this.pb_usuarios.Size = new System.Drawing.Size(77, 44);
            this.pb_usuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usuarios.TabIndex = 4;
            this.pb_usuarios.TabStop = false;
            // 
            // card_stock
            // 
            this.card_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card_stock.BackColor = System.Drawing.Color.White;
            this.card_stock.BorderRadius = 5;
            this.card_stock.BottomSahddow = true;
            this.card_stock.color = System.Drawing.Color.DarkViolet;
            this.card_stock.Controls.Add(this.card_textostock);
            this.card_stock.Controls.Add(this.lbl_card_stock);
            this.card_stock.Controls.Add(this.pb_stock);
            this.card_stock.LeftSahddow = false;
            this.card_stock.Location = new System.Drawing.Point(40, 349);
            this.card_stock.Name = "card_stock";
            this.card_stock.RightSahddow = true;
            this.card_stock.ShadowDepth = 20;
            this.card_stock.Size = new System.Drawing.Size(295, 164);
            this.card_stock.TabIndex = 1;
            // 
            // pb_stock
            // 
            this.pb_stock.Image = global::ProyectoTallerII.Properties.Resources.ventas__2_;
            this.pb_stock.Location = new System.Drawing.Point(16, 25);
            this.pb_stock.Name = "pb_stock";
            this.pb_stock.Size = new System.Drawing.Size(77, 44);
            this.pb_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_stock.TabIndex = 4;
            this.pb_stock.TabStop = false;
            // 
            // card_backup
            // 
            this.card_backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.card_backup.BackColor = System.Drawing.Color.White;
            this.card_backup.BorderRadius = 5;
            this.card_backup.BottomSahddow = true;
            this.card_backup.color = System.Drawing.Color.DarkViolet;
            this.card_backup.Controls.Add(this.card_textobackup);
            this.card_backup.Controls.Add(this.bunifuLabel3);
            this.card_backup.Controls.Add(this.pb_backup);
            this.card_backup.LeftSahddow = false;
            this.card_backup.Location = new System.Drawing.Point(448, 349);
            this.card_backup.Name = "card_backup";
            this.card_backup.RightSahddow = true;
            this.card_backup.ShadowDepth = 20;
            this.card_backup.Size = new System.Drawing.Size(295, 164);
            this.card_backup.TabIndex = 1;
            // 
            // pb_backup
            // 
            this.pb_backup.Image = global::ProyectoTallerII.Properties.Resources.diamond;
            this.pb_backup.Location = new System.Drawing.Point(15, 25);
            this.pb_backup.Name = "pb_backup";
            this.pb_backup.Size = new System.Drawing.Size(77, 44);
            this.pb_backup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_backup.TabIndex = 5;
            this.pb_backup.TabStop = false;
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AllowParentOverrides = false;
            this.lbl_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_inicio.AutoEllipsis = false;
            this.lbl_inicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_inicio.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_inicio.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_inicio.Location = new System.Drawing.Point(189, 40);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_inicio.Size = new System.Drawing.Size(404, 44);
            this.lbl_inicio.TabIndex = 2;
            this.lbl_inicio.Text = "INICIO PERFIL VENDEDOR";
            this.lbl_inicio.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_inicio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(149, 33);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(59, 16);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "CLIENTES";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.bunifuLabel2.Location = new System.Drawing.Point(3, 84);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(282, 68);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "En este apartado se puede administrar a todos\r\nlos clientes de la empresa.\r\nEl op" +
    "erario sólo podrá dar de ALTA o Modificar \r\ndicho cliente.\r\n";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_card_stock
            // 
            this.lbl_card_stock.AllowParentOverrides = false;
            this.lbl_card_stock.AutoEllipsis = false;
            this.lbl_card_stock.CursorType = null;
            this.lbl_card_stock.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_card_stock.Location = new System.Drawing.Point(136, 39);
            this.lbl_card_stock.Name = "lbl_card_stock";
            this.lbl_card_stock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_card_stock.Size = new System.Drawing.Size(92, 16);
            this.lbl_card_stock.TabIndex = 5;
            this.lbl_card_stock.Text = "FACTURACIÓN";
            this.lbl_card_stock.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_card_stock.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // card_textostock
            // 
            this.card_textostock.AllowParentOverrides = false;
            this.card_textostock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card_textostock.AutoEllipsis = false;
            this.card_textostock.CursorType = null;
            this.card_textostock.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.card_textostock.Location = new System.Drawing.Point(13, 107);
            this.card_textostock.Name = "card_textostock";
            this.card_textostock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_textostock.Size = new System.Drawing.Size(263, 34);
            this.card_textostock.TabIndex = 6;
            this.card_textostock.Text = "Facturación permite registrar las ventas de la \r\nempresa.\r\n";
            this.card_textostock.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.card_textostock.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(130, 39);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(78, 16);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "PRODUCTOS";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // card_textobackup
            // 
            this.card_textobackup.AllowParentOverrides = false;
            this.card_textobackup.AutoEllipsis = false;
            this.card_textobackup.CursorType = null;
            this.card_textobackup.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.card_textobackup.Location = new System.Drawing.Point(15, 107);
            this.card_textobackup.Name = "card_textobackup";
            this.card_textobackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_textobackup.Size = new System.Drawing.Size(260, 34);
            this.card_textobackup.TabIndex = 7;
            this.card_textobackup.Text = "Permite realizar un reporte de que producto\r\nse encuetra disponible para la venta" +
    ". ";
            this.card_textobackup.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.card_textobackup.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form_home_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 527);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.card_backup);
            this.Controls.Add(this.card_stock);
            this.Controls.Add(this.card_usuarios);
            this.Controls.Add(this.card_inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_home_empleado";
            this.Text = "Form_home";
            this.card_inicio.ResumeLayout(false);
            this.card_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inicio)).EndInit();
            this.card_usuarios.ResumeLayout(false);
            this.card_usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usuarios)).EndInit();
            this.card_stock.ResumeLayout(false);
            this.card_stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stock)).EndInit();
            this.card_backup.ResumeLayout(false);
            this.card_backup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards card_inicio;
        private Bunifu.Framework.UI.BunifuCards card_usuarios;
        private Bunifu.Framework.UI.BunifuCards card_stock;
        private Bunifu.Framework.UI.BunifuCards card_backup;
        private Bunifu.UI.WinForms.BunifuLabel lbl_inicio;
        private System.Windows.Forms.PictureBox pb_inicio;
        private Bunifu.UI.WinForms.BunifuLabel lbl_card_inicio;
        private Bunifu.UI.WinForms.BunifuLabel card_textoinicio;
        private System.Windows.Forms.PictureBox pb_usuarios;
        private System.Windows.Forms.PictureBox pb_stock;
        private System.Windows.Forms.PictureBox pb_backup;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel card_textostock;
        private Bunifu.UI.WinForms.BunifuLabel lbl_card_stock;
        private Bunifu.UI.WinForms.BunifuLabel card_textobackup;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}