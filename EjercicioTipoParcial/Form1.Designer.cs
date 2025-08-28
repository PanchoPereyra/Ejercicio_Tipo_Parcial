namespace EjercicioTipoParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarPre = new Button();
            btnCerrarPre = new Button();
            btnBorrar = new Button();
            label1 = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            cbProducto = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbBanco = new RadioButton();
            rbMesa = new RadioButton();
            btnAgregar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbGrosor = new TextBox();
            tbLargo = new TextBox();
            tbCodigo = new TextBox();
            tbAncho = new TextBox();
            tbPrecio = new TextBox();
            btnImportar = new Button();
            btnExportar = new Button();
            tbContenido = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciarPre
            // 
            btnIniciarPre.Location = new Point(9, 115);
            btnIniciarPre.Name = "btnIniciarPre";
            btnIniciarPre.Size = new Size(100, 49);
            btnIniciarPre.TabIndex = 0;
            btnIniciarPre.Text = "Iniciar Presupuesto";
            btnIniciarPre.UseVisualStyleBackColor = true;
            btnIniciarPre.Click += btnIniciarPre_Click;
            // 
            // btnCerrarPre
            // 
            btnCerrarPre.Location = new Point(135, 115);
            btnCerrarPre.Name = "btnCerrarPre";
            btnCerrarPre.Size = new Size(93, 49);
            btnCerrarPre.TabIndex = 1;
            btnCerrarPre.Text = "Cerrar Presupuesto";
            btnCerrarPre.UseVisualStyleBackColor = true;
            btnCerrarPre.Click += btnCerrarPre_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(153, 187);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Dirección:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(69, 22);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(159, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(69, 60);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(159, 23);
            tbDireccion.TabIndex = 6;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(9, 187);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(121, 23);
            cbProducto.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(cbProducto);
            groupBox1.Controls.Add(btnIniciarPre);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(btnCerrarPre);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 230);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbBanco);
            groupBox2.Controls.Add(rbMesa);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbGrosor);
            groupBox2.Controls.Add(tbLargo);
            groupBox2.Controls.Add(tbCodigo);
            groupBox2.Controls.Add(tbAncho);
            groupBox2.Controls.Add(tbPrecio);
            groupBox2.Location = new Point(269, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 174);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            // 
            // rbBanco
            // 
            rbBanco.AutoSize = true;
            rbBanco.Location = new Point(296, 110);
            rbBanco.Name = "rbBanco";
            rbBanco.Size = new Size(58, 19);
            rbBanco.TabIndex = 12;
            rbBanco.TabStop = true;
            rbBanco.Text = "Banco";
            rbBanco.UseVisualStyleBackColor = true;
            // 
            // rbMesa
            // 
            rbMesa.AutoSize = true;
            rbMesa.Location = new Point(208, 110);
            rbMesa.Name = "rbMesa";
            rbMesa.Size = new Size(53, 19);
            rbMesa.TabIndex = 11;
            rbMesa.TabStop = true;
            rbMesa.Text = "Mesa";
            rbMesa.UseVisualStyleBackColor = true;
            rbMesa.CheckedChanged += rbMesa_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 135);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(321, 30);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agergar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 78);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 9;
            label7.Text = "Grosor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 43);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 8;
            label6.Text = "Largo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 112);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 78);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Ancho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 43);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio B:";
            // 
            // tbGrosor
            // 
            tbGrosor.Location = new Point(254, 70);
            tbGrosor.Name = "tbGrosor";
            tbGrosor.Size = new Size(100, 23);
            tbGrosor.TabIndex = 4;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(254, 35);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(100, 23);
            tbLargo.TabIndex = 3;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(83, 104);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 2;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(83, 70);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 1;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(83, 35);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(100, 23);
            tbPrecio.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(269, 199);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(178, 43);
            btnImportar.TabIndex = 10;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(499, 199);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(178, 43);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // tbContenido
            // 
            tbContenido.Location = new Point(15, 272);
            tbContenido.Multiline = true;
            tbContenido.Name = "tbContenido";
            tbContenido.Size = new Size(662, 67);
            tbContenido.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 369);
            Controls.Add(tbContenido);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarPre;
        private Button btnCerrarPre;
        private Button btnBorrar;
        private Label label1;
        private Label label2;
        private TextBox tbNombre;
        private TextBox tbDireccion;
        private ComboBox cbProducto;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbGrosor;
        private TextBox tbLargo;
        private TextBox tbCodigo;
        private TextBox tbAncho;
        private TextBox tbPrecio;
        private Button btnImportar;
        private Button btnExportar;
        private RadioButton rbBanco;
        private RadioButton rbMesa;
        private TextBox tbContenido;
    }
}
