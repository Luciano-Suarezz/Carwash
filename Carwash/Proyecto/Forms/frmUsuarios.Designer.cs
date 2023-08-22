
namespace Proyecto
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTipos = new System.Windows.Forms.ComboBox();
            this.btnRegistrarr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNombreApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnUsuariosCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNombreUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClaveR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtConfirmaClave = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(75, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(75, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(75, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(75, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(75, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirme contraseña";
            // 
            // comboTipos
            // 
            this.comboTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipos.ForeColor = System.Drawing.Color.Black;
            this.comboTipos.FormattingEnabled = true;
            this.comboTipos.Location = new System.Drawing.Point(276, 114);
            this.comboTipos.Name = "comboTipos";
            this.comboTipos.Size = new System.Drawing.Size(242, 21);
            this.comboTipos.TabIndex = 1;
            // 
            // btnRegistrarr
            // 
            this.btnRegistrarr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegistrarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegistrarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarr.BorderRadius = 7;
            this.btnRegistrarr.ButtonText = "Registrar";
            this.btnRegistrarr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarr.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistrarr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrarr.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarr.Iconimage")));
            this.btnRegistrarr.Iconimage_right = null;
            this.btnRegistrarr.Iconimage_right_Selected = null;
            this.btnRegistrarr.Iconimage_Selected = null;
            this.btnRegistrarr.IconMarginLeft = 0;
            this.btnRegistrarr.IconMarginRight = 0;
            this.btnRegistrarr.IconRightVisible = true;
            this.btnRegistrarr.IconRightZoom = 0D;
            this.btnRegistrarr.IconVisible = true;
            this.btnRegistrarr.IconZoom = 60D;
            this.btnRegistrarr.IsTab = false;
            this.btnRegistrarr.Location = new System.Drawing.Point(347, 356);
            this.btnRegistrarr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarr.Name = "btnRegistrarr";
            this.btnRegistrarr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegistrarr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegistrarr.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrarr.selected = false;
            this.btnRegistrarr.Size = new System.Drawing.Size(140, 40);
            this.btnRegistrarr.TabIndex = 6;
            this.btnRegistrarr.Text = "Registrar";
            this.btnRegistrarr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarr.Textcolor = System.Drawing.Color.White;
            this.btnRegistrarr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarr.Click += new System.EventHandler(this.btnRegistrarr_Click);
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.txtNombreApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombreApellido.HintText = "";
            this.txtNombreApellido.isPassword = false;
            this.txtNombreApellido.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreApellido.LineIdleColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombreApellido.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreApellido.LineThickness = 3;
            this.txtNombreApellido.Location = new System.Drawing.Point(276, 64);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(242, 45);
            this.txtNombreApellido.TabIndex = 0;
            this.txtNombreApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUsuariosCancelar
            // 
            this.btnUsuariosCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.btnUsuariosCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnUsuariosCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuariosCancelar.BorderRadius = 7;
            this.btnUsuariosCancelar.ButtonText = "Cancelar";
            this.btnUsuariosCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuariosCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuariosCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuariosCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuariosCancelar.Iconimage")));
            this.btnUsuariosCancelar.Iconimage_right = null;
            this.btnUsuariosCancelar.Iconimage_right_Selected = null;
            this.btnUsuariosCancelar.Iconimage_Selected = null;
            this.btnUsuariosCancelar.IconMarginLeft = 0;
            this.btnUsuariosCancelar.IconMarginRight = 0;
            this.btnUsuariosCancelar.IconRightVisible = true;
            this.btnUsuariosCancelar.IconRightZoom = 0D;
            this.btnUsuariosCancelar.IconVisible = true;
            this.btnUsuariosCancelar.IconZoom = 65D;
            this.btnUsuariosCancelar.IsTab = false;
            this.btnUsuariosCancelar.Location = new System.Drawing.Point(79, 356);
            this.btnUsuariosCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuariosCancelar.Name = "btnUsuariosCancelar";
            this.btnUsuariosCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnUsuariosCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.btnUsuariosCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuariosCancelar.selected = true;
            this.btnUsuariosCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnUsuariosCancelar.TabIndex = 5;
            this.btnUsuariosCancelar.Text = "Cancelar";
            this.btnUsuariosCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsuariosCancelar.Textcolor = System.Drawing.Color.White;
            this.btnUsuariosCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosCancelar.Click += new System.EventHandler(this.btnUsuariosCancelar_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombreUsuario.HintText = "";
            this.txtNombreUsuario.isPassword = false;
            this.txtNombreUsuario.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreUsuario.LineIdleColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombreUsuario.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreUsuario.LineThickness = 3;
            this.txtNombreUsuario.Location = new System.Drawing.Point(276, 145);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(242, 45);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtClaveR
            // 
            this.txtClaveR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClaveR.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClaveR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClaveR.HintForeColor = System.Drawing.Color.Empty;
            this.txtClaveR.HintText = "";
            this.txtClaveR.isPassword = true;
            this.txtClaveR.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtClaveR.LineIdleColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtClaveR.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtClaveR.LineThickness = 3;
            this.txtClaveR.Location = new System.Drawing.Point(276, 199);
            this.txtClaveR.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtClaveR.Name = "txtClaveR";
            this.txtClaveR.Size = new System.Drawing.Size(242, 45);
            this.txtClaveR.TabIndex = 3;
            this.txtClaveR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClaveR.OnValueChanged += new System.EventHandler(this.txtClaveR_OnValueChanged);
            // 
            // txtConfirmaClave
            // 
            this.txtConfirmaClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmaClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmaClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmaClave.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmaClave.HintText = "";
            this.txtConfirmaClave.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtConfirmaClave.isPassword = true;
            this.txtConfirmaClave.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtConfirmaClave.LineIdleColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtConfirmaClave.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtConfirmaClave.LineThickness = 3;
            this.txtConfirmaClave.Location = new System.Drawing.Point(276, 251);
            this.txtConfirmaClave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConfirmaClave.Name = "txtConfirmaClave";
            this.txtConfirmaClave.Size = new System.Drawing.Size(242, 45);
            this.txtConfirmaClave.TabIndex = 4;
            this.txtConfirmaClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmaClave.OnValueChanged += new System.EventHandler(this.txtConfirmaClave_OnValueChanged);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 698);
            this.Controls.Add(this.txtConfirmaClave);
            this.Controls.Add(this.txtClaveR);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnUsuariosCancelar);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.btnRegistrarr);
            this.Controls.Add(this.comboTipos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipos;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrarr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreApellido;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuariosCancelar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClaveR;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmaClave;
    }
}