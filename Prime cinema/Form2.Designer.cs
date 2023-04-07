namespace Prime_cinema
{
    partial class Form2
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
            this.button5 = new System.Windows.Forms.Button();
            this.regis = new System.Windows.Forms.Panel();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.btnRegristrar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.regis.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::Prime_cinema.Properties.Resources.botn;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(2061, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 71);
            this.button5.TabIndex = 4;
            this.button5.Text = "INICIAR SECION";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // regis
            // 
            this.regis.BackgroundImage = global::Prime_cinema.Properties.Resources.textura;
            this.regis.Controls.Add(this.btnLimpiarC);
            this.regis.Controls.Add(this.txtContraseña);
            this.regis.Controls.Add(this.txtCorreo);
            this.regis.Controls.Add(this.txtTelefono);
            this.regis.Controls.Add(this.txtDireccion);
            this.regis.Controls.Add(this.txtDui);
            this.regis.Controls.Add(this.txtNombre);
            this.regis.Controls.Add(this.button13);
            this.regis.Controls.Add(this.btnRegristrar);
            this.regis.Controls.Add(this.button6);
            this.regis.Controls.Add(this.button3);
            this.regis.Controls.Add(this.button4);
            this.regis.Controls.Add(this.button2);
            this.regis.Controls.Add(this.button5);
            this.regis.Location = new System.Drawing.Point(-2, 29);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(1246, 625);
            this.regis.TabIndex = 1;
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpiarC.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarC.BackgroundImage = global::Prime_cinema.Properties.Resources.btn22;
            this.btnLimpiarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarC.FlatAppearance.BorderSize = 0;
            this.btnLimpiarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarC.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarC.Location = new System.Drawing.Point(414, 530);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(241, 56);
            this.btnLimpiarC.TabIndex = 22;
            this.btnLimpiarC.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarC.UseVisualStyleBackColor = false;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContraseña.Location = new System.Drawing.Point(414, 450);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(554, 21);
            this.txtContraseña.TabIndex = 21;
            this.txtContraseña.Text = "Contraseña:";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCorreo.Location = new System.Drawing.Point(414, 402);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(554, 21);
            this.txtCorreo.TabIndex = 20;
            this.txtCorreo.Text = "Correo:";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTelefono.Location = new System.Drawing.Point(414, 348);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(554, 21);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.Text = "Telefono:";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDireccion.Location = new System.Drawing.Point(414, 290);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(554, 21);
            this.txtDireccion.TabIndex = 18;
            this.txtDireccion.Text = "Direccion:";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.Color.White;
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDui.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDui.Location = new System.Drawing.Point(414, 234);
            this.txtDui.Multiline = true;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(554, 21);
            this.txtDui.TabIndex = 17;
            this.txtDui.Text = "Dui:";
            this.txtDui.Enter += new System.EventHandler(this.txtDui_Enter);
            this.txtDui.Leave += new System.EventHandler(this.txtDui_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombre.Location = new System.Drawing.Point(414, 175);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(554, 21);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImage = global::Prime_cinema.Properties.Resources.btn22;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(1124, 27);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(102, 57);
            this.button13.TabIndex = 15;
            this.button13.Text = "VOLVER";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnRegristrar
            // 
            this.btnRegristrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegristrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegristrar.BackgroundImage = global::Prime_cinema.Properties.Resources.btn22;
            this.btnRegristrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegristrar.FlatAppearance.BorderSize = 0;
            this.btnRegristrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegristrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegristrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegristrar.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegristrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegristrar.Location = new System.Drawing.Point(682, 530);
            this.btnRegristrar.Name = "btnRegristrar";
            this.btnRegristrar.Size = new System.Drawing.Size(353, 56);
            this.btnRegristrar.TabIndex = 9;
            this.btnRegristrar.Text = "REGISTRARSE";
            this.btnRegristrar.UseVisualStyleBackColor = false;
            this.btnRegristrar.Click += new System.EventHandler(this.btnRegristrar_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Prime_cinema.Properties.Resources.registrarse;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(547, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(317, 30);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Prime_cinema.Properties.Resources.palomita;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1056, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 234);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Prime_cinema.Properties.Resources.bac;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(350, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(775, 338);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Prime_cinema.Properties.Resources.chica;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 593);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Prime_cinema.Properties.Resources.barra;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cerrar);
            this.panel2.Controls.Add(this.max);
            this.panel2.Controls.Add(this.minimizar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 34);
            this.panel2.TabIndex = 16;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Prime_cinema.Properties.Resources.eliminar25;
            this.button8.Location = new System.Drawing.Point(1205, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 35);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Prime_cinema.Properties.Resources.m25;
            this.button9.Location = new System.Drawing.Point(1164, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 35);
            this.button9.TabIndex = 5;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::Prime_cinema.Properties.Resources.menos25;
            this.button10.Location = new System.Drawing.Point(1123, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(41, 35);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Prime_cinema.Properties.Resources.cinemaal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 17);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = global::Prime_cinema.Properties.Resources.eliminar25;
            this.cerrar.Location = new System.Drawing.Point(3340, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(41, 35);
            this.cerrar.TabIndex = 3;
            this.cerrar.UseVisualStyleBackColor = true;
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.FlatAppearance.BorderSize = 0;
            this.max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max.Image = global::Prime_cinema.Properties.Resources.m25;
            this.max.Location = new System.Drawing.Point(3299, 0);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(41, 35);
            this.max.TabIndex = 2;
            this.max.UseVisualStyleBackColor = true;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = global::Prime_cinema.Properties.Resources.menos25;
            this.minimizar.Location = new System.Drawing.Point(3258, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(41, 35);
            this.minimizar.TabIndex = 1;
            this.minimizar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 661);
            this.panel3.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.regis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.regis.ResumeLayout(false);
            this.regis.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button5;
        private Panel regis;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button btnRegristrar;
        private Button button13;
        private Panel panel2;
        private Button button1;
        private Button cerrar;
        private Button max;
        private Button minimizar;
        private Panel panel3;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox txtContraseña;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDui;
        private TextBox txtNombre;
        private Button btnLimpiarC;
    }
}