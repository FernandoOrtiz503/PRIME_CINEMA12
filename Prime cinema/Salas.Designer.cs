namespace Prime_cinema
{
    partial class Salas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comPelicula = new System.Windows.Forms.ComboBox();
            this.comSucursal = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Prime_cinema.Properties.Resources.textura;
            this.panel1.Controls.Add(this.comPelicula);
            this.panel1.Controls.Add(this.comSucursal);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtHorario);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnAgragar);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 668);
            this.panel1.TabIndex = 0;
            // 
            // comPelicula
            // 
            this.comPelicula.FormattingEnabled = true;
            this.comPelicula.Location = new System.Drawing.Point(29, 291);
            this.comPelicula.Name = "comPelicula";
            this.comPelicula.Size = new System.Drawing.Size(754, 23);
            this.comPelicula.TabIndex = 44;
            this.comPelicula.Text = "Pelicula:";
            // 
            // comSucursal
            // 
            this.comSucursal.FormattingEnabled = true;
            this.comSucursal.Location = new System.Drawing.Point(29, 232);
            this.comSucursal.Name = "comSucursal";
            this.comSucursal.Size = new System.Drawing.Size(754, 23);
            this.comSucursal.TabIndex = 43;
            this.comSucursal.Text = "Sucursal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 209);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.Color.White;
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtHorario.Location = new System.Drawing.Point(29, 343);
            this.txtHorario.Multiline = true;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(754, 28);
            this.txtHorario.TabIndex = 33;
            this.txtHorario.Text = "Horario:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNumero.Location = new System.Drawing.Point(29, 166);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(754, 28);
            this.txtNumero.TabIndex = 30;
            this.txtNumero.Text = "Numero de sala:";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::Prime_cinema.Properties.Resources.boton_amarillo;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = global::Prime_cinema.Properties.Resources.borrar2;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(201, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 42);
            this.button7.TabIndex = 26;
            this.button7.Text = "Eliminar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnAgragar
            // 
            this.btnAgragar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgragar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgragar.BackgroundImage = global::Prime_cinema.Properties.Resources.boton_amarillo;
            this.btnAgragar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgragar.FlatAppearance.BorderSize = 0;
            this.btnAgragar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgragar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgragar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragar.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgragar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgragar.Image = global::Prime_cinema.Properties.Resources.añadir1;
            this.btnAgragar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgragar.Location = new System.Drawing.Point(14, 413);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(181, 42);
            this.btnAgragar.TabIndex = 25;
            this.btnAgragar.Text = "Agregar";
            this.btnAgragar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgragar.UseVisualStyleBackColor = false;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Prime_cinema.Properties.Resources._3;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(821, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 177);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(401, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Administrar Salas";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Prime_cinema.Properties.Resources.textos;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(14, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(784, 53);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Prime_cinema.Properties.Resources.textos;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(14, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(784, 53);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Prime_cinema.Properties.Resources.textos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(784, 53);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Prime_cinema.Properties.Resources.textos;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(14, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(784, 53);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salas";
            this.Text = "Salas";
            this.Load += new System.EventHandler(this.Salas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button7;
        private Button btnAgragar;
        private TextBox txtHorario;
        private TextBox txtNumero;
        private DataGridView dataGridView1;
        private ComboBox comSucursal;
        private ComboBox comPelicula;
        private Button button2;
    }
}