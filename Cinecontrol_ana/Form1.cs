using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinecontrol_ana
{
    public partial class Form1 : Form
    {
        private int cantidadAsientos = 0;
        private decimal totalPagar = 0m;

        public Form1()
        {
            InitializeComponent();
            CargarCombos();
            AsignarEventosBotones();
        }

        private void CargarCombos()
        {
            cmbPelicula.Items.Clear();
            cmbPelicula.Items.Add("El Regreso de la Estrella");
            cmbPelicula.Items.Add("Misión Espacial");
            cmbPelicula.Items.Add("Función de Honora");
            if (cmbPelicula.Items.Count > 0) cmbPelicula.SelectedIndex = 0;

            cmbFuncion.Items.Clear();
            cmbFuncion.Items.Add("16:00");
            cmbFuncion.Items.Add("19:00");
            cmbFuncion.Items.Add("19:30");
            cmbFuncion.Items.Add("21:30");
            if (cmbFuncion.Items.Count > 0) cmbFuncion.SelectedIndex = 0;
        }

        private void AsignarEventosBotones()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("btn") && btn != btnLimpiar && btn != btnFacturar)
                {
                    btn.Click += Asiento_Click;
                }
            }
        }

        private void Asiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

          
            if (btn.BackColor == Color.Red)
            {
                return;
            }

            if (btn.BackColor == Color.Lime)
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                cantidadAsientos++;
                totalPagar += ObtenerPrecio(btn.Text);
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Lime;
                btn.ForeColor = Color.Black;
                cantidadAsientos--;
                totalPagar -= ObtenerPrecio(btn.Text);
            }

            ActualizarResumen();
        }

        private decimal ObtenerPrecio(string asiento)
        {
            if (asiento.StartsWith("A") || asiento.StartsWith("B"))
                return 12000m;
            else if (asiento.StartsWith("C") || asiento.StartsWith("D"))
                return 18000m;

            return 0m;
        }

        private void ActualizarResumen()
        {
            lblCantidad.Text = $"{cantidadAsientos} Asientos";
            lblTotal.Text = $"${totalPagar:N0} COP";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cantidadAsientos = 0;
            totalPagar = 0m;
            ActualizarResumen();
            txtCliente.Clear();
            rtbFactura.Clear();

            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("btn") && btn != btnLimpiar && btn != btnFacturar)
                {
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Lime;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.", "Validación");
                txtCliente.Focus();
                return;
            }

            if (cantidadAsientos == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un asiento para facturar.");
                return;
            }

            string listaAsientos = "";

            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.Blue)
                {
                    listaAsientos += btn.Text + ", ";
                    btn.BackColor = Color.Red; 
                    btn.ForeColor = Color.White;
                }
            }

            // Generar factura
            rtbFactura.Clear();
            rtbFactura.AppendText("================================\n");
            rtbFactura.AppendText("         CINE CONTROL           \n");
            rtbFactura.AppendText("================================\n");
            rtbFactura.AppendText($"Factura N°: 1\n");
            rtbFactura.AppendText($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}\n");
            rtbFactura.AppendText($"Cliente: {txtCliente.Text.Trim()}\n");
            rtbFactura.AppendText($"Película: {cmbPelicula.SelectedItem}\n");
            rtbFactura.AppendText($"Función: {cmbFuncion.SelectedItem}\n");
            rtbFactura.AppendText("--------------------------------\n");
            rtbFactura.AppendText($"Asientos: {listaAsientos.TrimEnd(' ', ',')}\n");
            rtbFactura.AppendText("--------------------------------\n");
            rtbFactura.AppendText($"TOTAL A PAGAR: ${totalPagar:N0} COP\n");
            rtbFactura.AppendText("================================\n");
            rtbFactura.AppendText("     ¡Disfrute su función!      \n");

            
            cantidadAsientos = 0;
            totalPagar = 0m;
            ActualizarResumen();
        }
    }
}