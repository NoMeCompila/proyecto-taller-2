
namespace ProyectoTallerII
{
    partial class Form_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_home));
            this.card_inicio = new Bunifu.Framework.UI.BunifuCards();
            this.card_textoinicio = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_card_inicio = new Bunifu.UI.WinForms.BunifuLabel();
            this.pb_inicio = new System.Windows.Forms.PictureBox();
            this.card_usuarios = new Bunifu.Framework.UI.BunifuCards();
            this.card_textousuarios = new Bunifu.UI.WinForms.BunifuLabel();
            this.pb_usuarios = new System.Windows.Forms.PictureBox();
            this.lbl_card_usuarios = new Bunifu.UI.WinForms.BunifuLabel();
            this.card_stock = new Bunifu.Framework.UI.BunifuCards();
            this.card_textostock = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_card_stock = new Bunifu.UI.WinForms.BunifuLabel();
            this.pb_stock = new System.Windows.Forms.PictureBox();
            this.card_backup = new Bunifu.Framework.UI.BunifuCards();
            this.card_textobackup = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_card_backup = new Bunifu.UI.WinForms.BunifuLabel();
            this.pb_backup = new System.Windows.Forms.PictureBox();
            this.lbl_inicio = new Bunifu.UI.WinForms.BunifuLabel();
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
            this.card_usuarios.Controls.Add(this.card_textousuarios);
            this.card_usuarios.Controls.Add(this.pb_usuarios);
            this.card_usuarios.Controls.Add(this.lbl_card_usuarios);
            this.card_usuarios.LeftSahddow = false;
            this.card_usuarios.Location = new System.Drawing.Point(411, 116);
            this.card_usuarios.Name = "card_usuarios";
            this.card_usuarios.RightSahddow = true;
            this.card_usuarios.ShadowDepth = 20;
            this.card_usuarios.Size = new System.Drawing.Size(295, 164);
            this.card_usuarios.TabIndex = 1;
            // 
            // card_textousuarios
            // 
            this.card_textousuarios.AllowParentOverrides = false;
            this.card_textousuarios.AutoEllipsis = false;
            this.card_textousuarios.CursorType = null;
            this.card_textousuarios.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.card_textousuarios.Location = new System.Drawing.Point(5, 80);
            this.card_textousuarios.Name = "card_textousuarios";
            this.card_textousuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_textousuarios.Size = new System.Drawing.Size(277, 51);
            this.card_textousuarios.TabIndex = 4;
            this.card_textousuarios.Text = "En este apartado se puede administrar a todos\r\n los usuarios del sistema \r\ny otor" +
    "garle distintos perfiles segun su rol.";
            this.card_textousuarios.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.card_textousuarios.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            // lbl_card_usuarios
            // 
            this.lbl_card_usuarios.AllowParentOverrides = false;
            this.lbl_card_usuarios.AutoEllipsis = false;
            this.lbl_card_usuarios.CursorType = null;
            this.lbl_card_usuarios.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_card_usuarios.Location = new System.Drawing.Point(145, 33);
            this.lbl_card_usuarios.Name = "lbl_card_usuarios";
            this.lbl_card_usuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_card_usuarios.Size = new System.Drawing.Size(63, 16);
            this.lbl_card_usuarios.TabIndex = 4;
            this.lbl_card_usuarios.Text = "USUARIOS";
            this.lbl_card_usuarios.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_card_usuarios.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            // card_textostock
            // 
            this.card_textostock.AllowParentOverrides = false;
            this.card_textostock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.card_textostock.AutoEllipsis = false;
            this.card_textostock.CursorType = null;
            this.card_textostock.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.card_textostock.Location = new System.Drawing.Point(16, 102);
            this.card_textostock.Name = "card_textostock";
            this.card_textostock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_textostock.Size = new System.Drawing.Size(237, 51);
            this.card_textostock.TabIndex = 4;
            this.card_textostock.Text = "Gestor de stock que permite alta, baja \r\ny modificaciones de productos para\r\ntene" +
    "r un control digitalizadodel negocio.";
            this.card_textostock.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.card_textostock.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lbl_card_stock.Size = new System.Drawing.Size(42, 16);
            this.lbl_card_stock.TabIndex = 4;
            this.lbl_card_stock.Text = "STOCK";
            this.lbl_card_stock.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_card_stock.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pb_stock
            // 
            this.pb_stock.Image = global::ProyectoTallerII.Properties.Resources.diamond;
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
            this.card_backup.Controls.Add(this.lbl_card_backup);
            this.card_backup.Controls.Add(this.pb_backup);
            this.card_backup.LeftSahddow = false;
            this.card_backup.Location = new System.Drawing.Point(411, 349);
            this.card_backup.Name = "card_backup";
            this.card_backup.RightSahddow = true;
            this.card_backup.ShadowDepth = 20;
            this.card_backup.Size = new System.Drawing.Size(295, 164);
            this.card_backup.TabIndex = 1;
            // 
            // card_textobackup
            // 
            this.card_textobackup.AllowParentOverrides = false;
            this.card_textobackup.AutoEllipsis = false;
            this.card_textobackup.CursorType = null;
            this.card_textobackup.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.card_textobackup.Location = new System.Drawing.Point(15, 102);
            this.card_textobackup.Name = "card_textobackup";
            this.card_textobackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.card_textobackup.Size = new System.Drawing.Size(233, 51);
            this.card_textobackup.TabIndex = 5;
            this.card_textobackup.Text = "Realizar un respaldo de seguridad para\r\nmantener la integridad de los datos del \r" +
    "\nnegocio.  ";
            this.card_textobackup.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.card_textobackup.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_card_backup
            // 
            this.lbl_card_backup.AllowParentOverrides = false;
            this.lbl_card_backup.AutoEllipsis = false;
            this.lbl_card_backup.CursorType = null;
            this.lbl_card_backup.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_card_backup.Location = new System.Drawing.Point(145, 39);
            this.lbl_card_backup.Name = "lbl_card_backup";
            this.lbl_card_backup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_card_backup.Size = new System.Drawing.Size(51, 16);
            this.lbl_card_backup.TabIndex = 5;
            this.lbl_card_backup.Text = "BACKUP";
            this.lbl_card_backup.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_card_backup.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pb_backup
            // 
            this.pb_backup.Image = global::ProyectoTallerII.Properties.Resources.BDD__1_;
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
            this.lbl_inicio.Location = new System.Drawing.Point(324, 55);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_inicio.Size = new System.Drawing.Size(103, 44);
            this.lbl_inicio.TabIndex = 2;
            this.lbl_inicio.Text = "INICIO";
            this.lbl_inicio.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_inicio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form_home
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
            this.Name = "Form_home";
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
        private Bunifu.UI.WinForms.BunifuLabel card_textousuarios;
        private System.Windows.Forms.PictureBox pb_usuarios;
        private Bunifu.UI.WinForms.BunifuLabel lbl_card_usuarios;
        private Bunifu.UI.WinForms.BunifuLabel card_textostock;
        private Bunifu.UI.WinForms.BunifuLabel lbl_card_stock;
        private System.Windows.Forms.PictureBox pb_stock;
        private Bunifu.UI.WinForms.BunifuLabel card_textobackup;
        private Bunifu.UI.WinForms.BunifuLabel lbl_card_backup;
        private System.Windows.Forms.PictureBox pb_backup;
    }
}