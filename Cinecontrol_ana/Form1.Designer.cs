using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Cinecontrol_ana
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblPelicula = new Label();
            cmbPelicula = new ComboBox();
            lblFuncion = new Label();
            cmbFuncion = new ComboBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblPantalla = new Label();
            lblLeyenda = new Label();
            lblCantidadTexto = new Label();
            lblCantidad = new Label();
            lblTotalTexto = new Label();
            lblTotal = new Label();
            btnLimpiar = new Button();
            btnFacturar = new Button();
            lblFactura = new Label();
            rtbFactura = new RichTextBox();
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnA4 = new Button();
            btnA5 = new Button();
            btnA6 = new Button();
            btnA7 = new Button();
            btnA8 = new Button();
            btnA9 = new Button();
            btnA10 = new Button();
            btnA11 = new Button();
            btnA12 = new Button();
            btnA13 = new Button();
            btnA14 = new Button();
            btnA15 = new Button();
            btnA16 = new Button();
            btnA17 = new Button();
            btnA18 = new Button();
            btnA19 = new Button();
            btnA20 = new Button();
            SuspendLayout();
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(20, 20);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(62, 20);
            lblPelicula.TabIndex = 0;
            lblPelicula.Text = "Película:";
            // 
            // cmbPelicula
            // 
            cmbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPelicula.Location = new Point(20, 38);
            cmbPelicula.Name = "cmbPelicula";
            cmbPelicula.Size = new Size(210, 28);
            cmbPelicula.TabIndex = 1;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(245, 20);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(63, 20);
            lblFuncion.TabIndex = 2;
            lblFuncion.Text = "Función:";
            // 
            // cmbFuncion
            // 
            cmbFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncion.Location = new Point(245, 38);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(110, 28);
            cmbFuncion.TabIndex = 3;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(370, 20);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(142, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Nombre del Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(370, 38);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(400, 27);
            txtCliente.TabIndex = 5;
            // 
            // lblPantalla
            // 
            lblPantalla.BackColor = Color.Black;
            lblPantalla.ForeColor = Color.Yellow;
            lblPantalla.Location = new Point(20, 90);
            lblPantalla.Name = "lblPantalla";
            lblPantalla.Size = new Size(435, 30);
            lblPantalla.TabIndex = 6;
            lblPantalla.Text = "P A N T A L L A";
            lblPantalla.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.ForeColor = Color.DarkSlateGray;
            lblLeyenda.Location = new Point(50, 410);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(390, 20);
            lblLeyenda.TabIndex = 7;
            lblLeyenda.Text = "Verde: Disponible  |  Azul: Seleccionado  |  Rojo: Ocupado";
            // 
            // lblCantidadTexto
            // 
            lblCantidadTexto.AutoSize = true;
            lblCantidadTexto.Location = new Point(485, 90);
            lblCantidadTexto.Name = "lblCantidadTexto";
            lblCantidadTexto.Size = new Size(167, 20);
            lblCantidadTexto.TabIndex = 28;
            lblCantidadTexto.Text = "Asientos Seleccionados:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(485, 110);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(77, 20);
            lblCantidad.TabIndex = 29;
            lblCantidad.Text = "0 Asientos";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Location = new Point(485, 145);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(98, 20);
            lblTotalTexto.TabIndex = 30;
            lblTotalTexto.Text = "Total a Pagar:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.DarkGreen;
            lblTotal.Location = new Point(485, 165);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 20);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "$0 COP";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(485, 205);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 35);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.Navy;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(620, 205);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(150, 35);
            btnFacturar.TabIndex = 33;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(485, 260);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(128, 20);
            lblFactura.TabIndex = 34;
            lblFactura.Text = "Detalle del Ticket:";
            // 
            // rtbFactura
            // 
            rtbFactura.Location = new Point(485, 285);
            rtbFactura.Name = "rtbFactura";
            rtbFactura.Size = new Size(285, 215);
            rtbFactura.TabIndex = 35;
            rtbFactura.Text = "";
            // 
            // btnA1
            // 
            btnA1.BackColor = Color.Lime;
            btnA1.Location = new Point(30, 140);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(75, 41);
            btnA1.TabIndex = 36;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = false;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.Lime;
            btnA2.Location = new Point(115, 140);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(75, 41);
            btnA2.TabIndex = 37;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = false;
            // 
            // btnA3
            // 
            btnA3.BackColor = Color.Lime;
            btnA3.Location = new Point(200, 140);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(75, 41);
            btnA3.TabIndex = 38;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = false;
            // 
            // btnA4
            // 
            btnA4.BackColor = Color.Lime;
            btnA4.Location = new Point(285, 140);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(75, 41);
            btnA4.TabIndex = 39;
            btnA4.Text = "A4";
            btnA4.UseVisualStyleBackColor = false;
            // 
            // btnA5
            // 
            btnA5.BackColor = Color.Lime;
            btnA5.Location = new Point(370, 140);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(75, 41);
            btnA5.TabIndex = 40;
            btnA5.Text = "A5";
            btnA5.UseVisualStyleBackColor = false;
            // 
            // btnA6
            // 
            btnA6.BackColor = Color.Lime;
            btnA6.Location = new Point(370, 195);
            btnA6.Name = "btnA6";
            btnA6.Size = new Size(75, 41);
            btnA6.TabIndex = 45;
            btnA6.Text = "A6";
            btnA6.UseVisualStyleBackColor = false;
            // 
            // btnA7
            // 
            btnA7.BackColor = Color.Lime;
            btnA7.Location = new Point(285, 195);
            btnA7.Name = "btnA7";
            btnA7.Size = new Size(75, 41);
            btnA7.TabIndex = 44;
            btnA7.Text = "A7";
            btnA7.UseVisualStyleBackColor = false;
            // 
            // btnA8
            // 
            btnA8.BackColor = Color.Lime;
            btnA8.Location = new Point(200, 195);
            btnA8.Name = "btnA8";
            btnA8.Size = new Size(75, 41);
            btnA8.TabIndex = 43;
            btnA8.Text = "A8";
            btnA8.UseVisualStyleBackColor = false;
            // 
            // btnA9
            // 
            btnA9.BackColor = Color.Lime;
            btnA9.Location = new Point(115, 195);
            btnA9.Name = "btnA9";
            btnA9.Size = new Size(75, 41);
            btnA9.TabIndex = 42;
            btnA9.Text = "A9";
            btnA9.UseVisualStyleBackColor = false;
            // 
            // btnA10
            // 
            btnA10.BackColor = Color.Lime;
            btnA10.Location = new Point(30, 195);
            btnA10.Name = "btnA10";
            btnA10.Size = new Size(75, 41);
            btnA10.TabIndex = 41;
            btnA10.Text = "A10";
            btnA10.UseVisualStyleBackColor = false;
            // 
            // btnA11
            // 
            btnA11.BackColor = Color.Lime;
            btnA11.Location = new Point(370, 250);
            btnA11.Name = "btnA11";
            btnA11.Size = new Size(75, 41);
            btnA11.TabIndex = 50;
            btnA11.Text = "A11";
            btnA11.UseVisualStyleBackColor = false;
            // 
            // btnA12
            // 
            btnA12.BackColor = Color.Lime;
            btnA12.Location = new Point(285, 250);
            btnA12.Name = "btnA12";
            btnA12.Size = new Size(75, 41);
            btnA12.TabIndex = 49;
            btnA12.Text = "A12";
            btnA12.UseVisualStyleBackColor = false;
            // 
            // btnA13
            // 
            btnA13.BackColor = Color.Lime;
            btnA13.Location = new Point(200, 250);
            btnA13.Name = "btnA13";
            btnA13.Size = new Size(75, 41);
            btnA13.TabIndex = 48;
            btnA13.Text = "A13";
            btnA13.UseVisualStyleBackColor = false;
            // 
            // btnA14
            // 
            btnA14.BackColor = Color.Lime;
            btnA14.Location = new Point(115, 250);
            btnA14.Name = "btnA14";
            btnA14.Size = new Size(75, 41);
            btnA14.TabIndex = 47;
            btnA14.Text = "A14";
            btnA14.UseVisualStyleBackColor = false;
            // 
            // btnA15
            // 
            btnA15.BackColor = Color.Lime;
            btnA15.Location = new Point(30, 250);
            btnA15.Name = "btnA15";
            btnA15.Size = new Size(75, 41);
            btnA15.TabIndex = 46;
            btnA15.Text = "A15";
            btnA15.UseVisualStyleBackColor = false;
            // 
            // btnA16
            // 
            btnA16.BackColor = Color.Lime;
            btnA16.Location = new Point(370, 309);
            btnA16.Name = "btnA16";
            btnA16.Size = new Size(75, 41);
            btnA16.TabIndex = 55;
            btnA16.Text = "A16";
            btnA16.UseVisualStyleBackColor = false;
            // 
            // btnA17
            // 
            btnA17.BackColor = Color.Lime;
            btnA17.Location = new Point(285, 309);
            btnA17.Name = "btnA17";
            btnA17.Size = new Size(75, 41);
            btnA17.TabIndex = 54;
            btnA17.Text = "A17";
            btnA17.UseVisualStyleBackColor = false;
            // 
            // btnA18
            // 
            btnA18.BackColor = Color.Lime;
            btnA18.Location = new Point(200, 309);
            btnA18.Name = "btnA18";
            btnA18.Size = new Size(75, 41);
            btnA18.TabIndex = 53;
            btnA18.Text = "A18";
            btnA18.UseVisualStyleBackColor = false;
            // 
            // btnA19
            // 
            btnA19.BackColor = Color.Lime;
            btnA19.Location = new Point(115, 309);
            btnA19.Name = "btnA19";
            btnA19.Size = new Size(75, 41);
            btnA19.TabIndex = 52;
            btnA19.Text = "A19";
            btnA19.UseVisualStyleBackColor = false;
            // 
            // btnA20
            // 
            btnA20.BackColor = Color.Lime;
            btnA20.Location = new Point(30, 309);
            btnA20.Name = "btnA20";
            btnA20.Size = new Size(75, 41);
            btnA20.TabIndex = 51;
            btnA20.Text = "A20";
            btnA20.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 530);
            Controls.Add(btnA16);
            Controls.Add(btnA17);
            Controls.Add(btnA18);
            Controls.Add(btnA19);
            Controls.Add(btnA20);
            Controls.Add(btnA11);
            Controls.Add(btnA12);
            Controls.Add(btnA13);
            Controls.Add(btnA14);
            Controls.Add(btnA15);
            Controls.Add(btnA6);
            Controls.Add(btnA7);
            Controls.Add(btnA8);
            Controls.Add(btnA9);
            Controls.Add(btnA10);
            Controls.Add(btnA5);
            Controls.Add(btnA4);
            Controls.Add(btnA3);
            Controls.Add(btnA2);
            Controls.Add(btnA1);
            Controls.Add(lblPelicula);
            Controls.Add(cmbPelicula);
            Controls.Add(lblFuncion);
            Controls.Add(cmbFuncion);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(lblPantalla);
            Controls.Add(lblLeyenda);
            Controls.Add(lblCantidadTexto);
            Controls.Add(lblCantidad);
            Controls.Add(lblTotalTexto);
            Controls.Add(lblTotal);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFacturar);
            Controls.Add(lblFactura);
            Controls.Add(rtbFactura);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineControl - Sistema de Taquilla";
            ResumeLayout(false);
            PerformLayout();
        }

        // Método auxiliar estático para que el diseñador pinte directamente las propiedades en tiempo de diseño
        private void ConfigurarBotonExplici(System.Windows.Forms.Button btn, string name, string text, int x, int y)
        {
            btn.Name = name;
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(70, 50);
            btn.BackColor = System.Drawing.Color.Green;
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            btn.UseVisualStyleBackColor = false;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        #endregion

        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblCantidadTexto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.RichTextBox rtbFactura;
        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnA4;
        private Button btnA5;
        private Button btnA6;
        private Button btnA7;
        private Button btnA8;
        private Button btnA9;
        private Button btnA10;
        private Button btnA11;
        private Button btnA12;
        private Button btnA13;
        private Button btnA14;
        private Button btnA15;
        private Button btnA16;
        private Button btnA17;
        private Button btnA18;
        private Button btnA19;
        private Button btnA20;
    }
}