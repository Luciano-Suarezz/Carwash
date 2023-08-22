
namespace Proyecto.Forms
{
    partial class frmSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuccess));
            this.esclarecerForm = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCerrar = new System.Windows.Forms.Label();
            this.txtCerrar2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelarAviso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // esclarecerForm
            // 
            this.esclarecerForm.Delay = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 228);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gobold Extra2", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 94);
            this.label2.TabIndex = 1;
            this.label2.Text = "AVISO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCerrar
            // 
            this.txtCerrar.AutoSize = true;
            this.txtCerrar.Font = new System.Drawing.Font("Gobold Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerrar.Location = new System.Drawing.Point(12, 257);
            this.txtCerrar.Name = "txtCerrar";
            this.txtCerrar.Size = new System.Drawing.Size(340, 27);
            this.txtCerrar.TabIndex = 1;
            this.txtCerrar.Text = "¿Esta seguro de que quiere cerrar?";
            this.txtCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCerrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCerrar2
            // 
            this.txtCerrar2.AutoSize = true;
            this.txtCerrar2.Font = new System.Drawing.Font("Gobold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerrar2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCerrar2.Location = new System.Drawing.Point(23, 303);
            this.txtCerrar2.Name = "txtCerrar2";
            this.txtCerrar2.Size = new System.Drawing.Size(329, 21);
            this.txtCerrar2.TabIndex = 2;
            this.txtCerrar2.Text = "Por favor, confirmá tu decisión haciendo click";
            this.txtCerrar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCerrar2.Click += new System.EventHandler(this.txtCerrar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gobold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(88, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "en los botones de abajo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Aceptar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Gobold Thin Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 55D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(13, 428);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(165, 58);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Aceptar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnCancelarAviso
            // 
            this.btnCancelarAviso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.btnCancelarAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnCancelarAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarAviso.BorderRadius = 7;
            this.btnCancelarAviso.ButtonText = "Cancelar";
            this.btnCancelarAviso.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCancelarAviso.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelarAviso.Font = new System.Drawing.Font("Gobold Thin Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAviso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelarAviso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelarAviso.Iconimage")));
            this.btnCancelarAviso.Iconimage_right = null;
            this.btnCancelarAviso.Iconimage_right_Selected = null;
            this.btnCancelarAviso.Iconimage_Selected = null;
            this.btnCancelarAviso.IconMarginLeft = 0;
            this.btnCancelarAviso.IconMarginRight = 0;
            this.btnCancelarAviso.IconRightVisible = true;
            this.btnCancelarAviso.IconRightZoom = 0D;
            this.btnCancelarAviso.IconVisible = true;
            this.btnCancelarAviso.IconZoom = 60D;
            this.btnCancelarAviso.IsTab = false;
            this.btnCancelarAviso.Location = new System.Drawing.Point(190, 428);
            this.btnCancelarAviso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarAviso.Name = "btnCancelarAviso";
            this.btnCancelarAviso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnCancelarAviso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.btnCancelarAviso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelarAviso.selected = false;
            this.btnCancelarAviso.Size = new System.Drawing.Size(167, 58);
            this.btnCancelarAviso.TabIndex = 1;
            this.btnCancelarAviso.Text = "Cancelar";
            this.btnCancelarAviso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAviso.Textcolor = System.Drawing.Color.White;
            this.btnCancelarAviso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAviso.UseWaitCursor = true;
            this.btnCancelarAviso.Click += new System.EventHandler(this.btnCancelarAviso_Click);
            // 
            // frmSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 500);
            this.Controls.Add(this.btnCancelarAviso);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCerrar2);
            this.Controls.Add(this.txtCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuccess";
            this.Load += new System.EventHandler(this.frmSuccess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition esclarecerForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label txtCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtCerrar2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelarAviso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}