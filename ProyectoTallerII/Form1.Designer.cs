
namespace ProyectoTallerII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.Panel();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_show_pass = new System.Windows.Forms.Panel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.lbl_foot_login = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.chk_show_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.pb_login);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(500, 550);
            this.sidebar.TabIndex = 1;
            // 
            // pb_login
            // 
            this.pb_login.Image = global::ProyectoTallerII.Properties.Resources.login_fondo;
            this.pb_login.Location = new System.Drawing.Point(0, 0);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(500, 550);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 0;
            this.pb_login.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chk_show_pass);
            this.panel1.Controls.Add(this.lbl_foot_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 550);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoTallerII.Properties.Resources.remove_ico__1_;
            this.pictureBox1.Location = new System.Drawing.Point(448, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chk_show_pass
            // 
            this.chk_show_pass.Controls.Add(this.pictureBox2);
            this.chk_show_pass.Controls.Add(this.btn_entrar);
            this.chk_show_pass.Controls.Add(this.txt_pass);
            this.chk_show_pass.Controls.Add(this.txt_user);
            this.chk_show_pass.Controls.Add(this.lbl_bienvenida);
            this.chk_show_pass.Location = new System.Drawing.Point(127, 12);
            this.chk_show_pass.Name = "chk_show_pass";
            this.chk_show_pass.Size = new System.Drawing.Size(272, 448);
            this.chk_show_pass.TabIndex = 1;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(86, 350);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(85, 37);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txt_pass.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass.Location = new System.Drawing.Point(18, 278);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(238, 29);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.Text = "Contraseña";
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txt_user.ForeColor = System.Drawing.Color.Silver;
            this.txt_user.Location = new System.Drawing.Point(18, 209);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(238, 29);
            this.txt_user.TabIndex = 4;
            this.txt_user.Text = "Usuario";
            this.txt_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenida.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_bienvenida.Location = new System.Drawing.Point(3, 162);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(264, 13);
            this.lbl_bienvenida.TabIndex = 2;
            this.lbl_bienvenida.Text = "¡Bienvenido de nuevo! Por favor ingrese su cuenta";
            // 
            // lbl_foot_login
            // 
            this.lbl_foot_login.AutoSize = true;
            this.lbl_foot_login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foot_login.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_foot_login.Location = new System.Drawing.Point(191, 528);
            this.lbl_foot_login.Name = "lbl_foot_login";
            this.lbl_foot_login.Size = new System.Drawing.Size(137, 13);
            this.lbl_foot_login.TabIndex = 0;
            this.lbl_foot_login.Text = "Sistema de Ventas Joyeria";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.chk_show_pass.ResumeLayout(false);
            this.chk_show_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel chk_show_pass;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Label lbl_foot_login;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

