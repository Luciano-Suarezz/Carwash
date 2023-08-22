
namespace Proyecto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnDashboardPersona = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBienvenidaUsuario = new System.Windows.Forms.Label();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.btnDashboardUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboardTurnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVersion = new System.Windows.Forms.Label();
            this.btnDashboardSocios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Label();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.wrapper = new System.Windows.Forms.Panel();
            this.txtBienvenidoo = new System.Windows.Forms.Label();
            this.txtElegi = new System.Windows.Forms.Label();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.sideBar.Controls.Add(this.btnDashboardPersona);
            this.sideBar.Controls.Add(this.txtBienvenidaUsuario);
            this.sideBar.Controls.Add(this.flecha);
            this.sideBar.Controls.Add(this.btnDashboardUsuarios);
            this.sideBar.Controls.Add(this.btnDashboardTurnos);
            this.sideBar.Controls.Add(this.pictureBox1);
            this.sideBar.Controls.Add(this.txtVersion);
            this.sideBar.Controls.Add(this.btnDashboardSocios);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(240, 720);
            this.sideBar.TabIndex = 5;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar_Paint);
            // 
            // btnDashboardPersona
            // 
            this.btnDashboardPersona.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboardPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboardPersona.BorderRadius = 0;
            this.btnDashboardPersona.ButtonText = "Socios";
            this.btnDashboardPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardPersona.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboardPersona.Font = new System.Drawing.Font("Gobold Uplow", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashboardPersona.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboardPersona.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboardPersona.Iconimage")));
            this.btnDashboardPersona.Iconimage_right = null;
            this.btnDashboardPersona.Iconimage_right_Selected = null;
            this.btnDashboardPersona.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnDashboardPersona.Iconimage_Selected")));
            this.btnDashboardPersona.IconMarginLeft = 0;
            this.btnDashboardPersona.IconMarginRight = 0;
            this.btnDashboardPersona.IconRightVisible = true;
            this.btnDashboardPersona.IconRightZoom = 0D;
            this.btnDashboardPersona.IconVisible = true;
            this.btnDashboardPersona.IconZoom = 100D;
            this.btnDashboardPersona.IsTab = true;
            this.btnDashboardPersona.Location = new System.Drawing.Point(12, 327);
            this.btnDashboardPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboardPersona.Name = "btnDashboardPersona";
            this.btnDashboardPersona.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboardPersona.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboardPersona.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(175)))));
            this.btnDashboardPersona.selected = false;
            this.btnDashboardPersona.Size = new System.Drawing.Size(208, 48);
            this.btnDashboardPersona.TabIndex = 13;
            this.btnDashboardPersona.Text = "Socios";
            this.btnDashboardPersona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboardPersona.Textcolor = System.Drawing.Color.White;
            this.btnDashboardPersona.TextFont = new System.Drawing.Font("Gobold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardPersona.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // txtBienvenidaUsuario
            // 
            this.txtBienvenidaUsuario.AutoSize = true;
            this.txtBienvenidaUsuario.Font = new System.Drawing.Font("Gobold Thin", 15F);
            this.txtBienvenidaUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBienvenidaUsuario.Location = new System.Drawing.Point(5, 130);
            this.txtBienvenidaUsuario.Name = "txtBienvenidaUsuario";
            this.txtBienvenidaUsuario.Size = new System.Drawing.Size(147, 39);
            this.txtBienvenidaUsuario.TabIndex = 12;
            this.txtBienvenidaUsuario.Text = "Bienvenido";
            this.txtBienvenidaUsuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // flecha
            // 
            this.flecha.Image = ((System.Drawing.Image)(resources.GetObject("flecha.Image")));
            this.flecha.Location = new System.Drawing.Point(205, 327);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(35, 35);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 10;
            this.flecha.TabStop = false;
            // 
            // btnDashboardUsuarios
            // 
            this.btnDashboardUsuarios.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboardUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboardUsuarios.BorderRadius = 0;
            this.btnDashboardUsuarios.ButtonText = "Usuarios";
            this.btnDashboardUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboardUsuarios.Font = new System.Drawing.Font("Gobold Uplow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboardUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboardUsuarios.Iconimage")));
            this.btnDashboardUsuarios.Iconimage_right = null;
            this.btnDashboardUsuarios.Iconimage_right_Selected = null;
            this.btnDashboardUsuarios.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnDashboardUsuarios.Iconimage_Selected")));
            this.btnDashboardUsuarios.IconMarginLeft = 0;
            this.btnDashboardUsuarios.IconMarginRight = 0;
            this.btnDashboardUsuarios.IconRightVisible = true;
            this.btnDashboardUsuarios.IconRightZoom = 0D;
            this.btnDashboardUsuarios.IconVisible = true;
            this.btnDashboardUsuarios.IconZoom = 100D;
            this.btnDashboardUsuarios.IsTab = true;
            this.btnDashboardUsuarios.Location = new System.Drawing.Point(12, 501);
            this.btnDashboardUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboardUsuarios.Name = "btnDashboardUsuarios";
            this.btnDashboardUsuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboardUsuarios.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboardUsuarios.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(175)))));
            this.btnDashboardUsuarios.selected = false;
            this.btnDashboardUsuarios.Size = new System.Drawing.Size(228, 48);
            this.btnDashboardUsuarios.TabIndex = 2;
            this.btnDashboardUsuarios.Text = "Usuarios";
            this.btnDashboardUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboardUsuarios.Textcolor = System.Drawing.Color.White;
            this.btnDashboardUsuarios.TextFont = new System.Drawing.Font("Gobold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardUsuarios.Click += new System.EventHandler(this.btnDashboardUsuarios_Click);
            // 
            // btnDashboardTurnos
            // 
            this.btnDashboardTurnos.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboardTurnos.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboardTurnos.BorderRadius = 0;
            this.btnDashboardTurnos.ButtonText = "Turnos";
            this.btnDashboardTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardTurnos.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboardTurnos.Font = new System.Drawing.Font("Gobold Uplow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardTurnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboardTurnos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboardTurnos.Iconimage")));
            this.btnDashboardTurnos.Iconimage_right = null;
            this.btnDashboardTurnos.Iconimage_right_Selected = null;
            this.btnDashboardTurnos.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnDashboardTurnos.Iconimage_Selected")));
            this.btnDashboardTurnos.IconMarginLeft = 0;
            this.btnDashboardTurnos.IconMarginRight = 0;
            this.btnDashboardTurnos.IconRightVisible = true;
            this.btnDashboardTurnos.IconRightZoom = 0D;
            this.btnDashboardTurnos.IconVisible = true;
            this.btnDashboardTurnos.IconZoom = 100D;
            this.btnDashboardTurnos.IsTab = true;
            this.btnDashboardTurnos.Location = new System.Drawing.Point(12, 443);
            this.btnDashboardTurnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboardTurnos.Name = "btnDashboardTurnos";
            this.btnDashboardTurnos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboardTurnos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboardTurnos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(175)))));
            this.btnDashboardTurnos.selected = false;
            this.btnDashboardTurnos.Size = new System.Drawing.Size(208, 48);
            this.btnDashboardTurnos.TabIndex = 1;
            this.btnDashboardTurnos.Text = "Turnos";
            this.btnDashboardTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboardTurnos.Textcolor = System.Drawing.Color.White;
            this.btnDashboardTurnos.TextFont = new System.Drawing.Font("Gobold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardTurnos.Click += new System.EventHandler(this.btnDashboardTurnos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Gobold Thin", 14F);
            this.txtVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVersion.Location = new System.Drawing.Point(42, 26);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(195, 37);
            this.txtVersion.TabIndex = 6;
            this.txtVersion.Text = "Lavadero v1.07";
            this.txtVersion.Click += new System.EventHandler(this.txtVersion_Click);
            // 
            // btnDashboardSocios
            // 
            this.btnDashboardSocios.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboardSocios.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboardSocios.BorderRadius = 0;
            this.btnDashboardSocios.ButtonText = "Autos";
            this.btnDashboardSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardSocios.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboardSocios.Font = new System.Drawing.Font("Gobold Uplow", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashboardSocios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboardSocios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboardSocios.Iconimage")));
            this.btnDashboardSocios.Iconimage_right = null;
            this.btnDashboardSocios.Iconimage_right_Selected = null;
            this.btnDashboardSocios.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnDashboardSocios.Iconimage_Selected")));
            this.btnDashboardSocios.IconMarginLeft = 0;
            this.btnDashboardSocios.IconMarginRight = 0;
            this.btnDashboardSocios.IconRightVisible = true;
            this.btnDashboardSocios.IconRightZoom = 0D;
            this.btnDashboardSocios.IconVisible = true;
            this.btnDashboardSocios.IconZoom = 150D;
            this.btnDashboardSocios.IsTab = true;
            this.btnDashboardSocios.Location = new System.Drawing.Point(12, 385);
            this.btnDashboardSocios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboardSocios.Name = "btnDashboardSocios";
            this.btnDashboardSocios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboardSocios.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboardSocios.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(175)))));
            this.btnDashboardSocios.selected = false;
            this.btnDashboardSocios.Size = new System.Drawing.Size(179, 48);
            this.btnDashboardSocios.TabIndex = 0;
            this.btnDashboardSocios.Text = "Autos";
            this.btnDashboardSocios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboardSocios.Textcolor = System.Drawing.Color.White;
            this.btnDashboardSocios.TextFont = new System.Drawing.Font("Gobold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardSocios.Click += new System.EventHandler(this.btnDashboardSocios_Click);
            // 
            // header
            // 
            this.header.Controls.Add(this.dashboard);
            this.header.Controls.Add(this.imgSalir);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(240, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1040, 63);
            this.header.TabIndex = 6;
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Gobold Lowplus", 15F);
            this.dashboard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dashboard.Location = new System.Drawing.Point(6, 13);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(155, 43);
            this.dashboard.TabIndex = 5;
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgSalir
            // 
            this.imgSalir.Image = global::Proyecto.Properties.Resources.salir;
            this.imgSalir.Location = new System.Drawing.Point(986, 19);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(37, 37);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSalir.TabIndex = 4;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            // 
            // wrapper
            // 
            this.wrapper.Controls.Add(this.txtBienvenidoo);
            this.wrapper.Controls.Add(this.txtElegi);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(240, 63);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(1040, 657);
            this.wrapper.TabIndex = 7;
            this.wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.wrapper_Paint);
            // 
            // txtBienvenidoo
            // 
            this.txtBienvenidoo.AutoSize = true;
            this.txtBienvenidoo.Font = new System.Drawing.Font("Gobold Thin", 20F);
            this.txtBienvenidoo.Location = new System.Drawing.Point(172, 207);
            this.txtBienvenidoo.Name = "txtBienvenidoo";
            this.txtBienvenidoo.Size = new System.Drawing.Size(210, 52);
            this.txtBienvenidoo.TabIndex = 1;
            this.txtBienvenidoo.Text = "Bienvenido,";
            // 
            // txtElegi
            // 
            this.txtElegi.AutoSize = true;
            this.txtElegi.Font = new System.Drawing.Font("Gobold Thin", 20F);
            this.txtElegi.Location = new System.Drawing.Point(172, 264);
            this.txtElegi.Name = "txtElegi";
            this.txtElegi.Size = new System.Drawing.Size(471, 52);
            this.txtElegi.TabIndex = 0;
            this.txtElegi.Text = "Por favor elegí una opción";
            this.txtElegi.Click += new System.EventHandler(this.txtElegi_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.wrapper);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sideBar);
            this.Font = new System.Drawing.Font("Gobold Thin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtVersion;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboardSocios;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboardTurnos;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboardUsuarios;
        private System.Windows.Forms.PictureBox flecha;
        private System.Windows.Forms.Label txtBienvenidaUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboardPersona;
        private System.Windows.Forms.Label txtBienvenidoo;
        private System.Windows.Forms.Label txtElegi;
    }
}