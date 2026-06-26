using PryEstacionamiento.Vehiculo;

namespace PryEstacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtHoras.Text, out int horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de horas válida y mayor a cero.");
                return;
            }

            string tipoVehiculo = cbTipo.SelectedItem?.ToString();
            vehiculo vehiculo = null;

            
            if (tipoVehiculo == "Motocicleta")
            {
                // Integrante B: Instanciar clase Motocicleta y asignar propiedades
            }
            else if (tipoVehiculo == "Automóvil")
            {
                vehiculo = new Automovil
                {
                    HorasEstancia = horas,
                    Placa = ""
                };
            }
            else if (tipoVehiculo == "Camioneta")
            {
                // Integrante D: Instanciar clase Camioneta y asignar propiedades
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de vehículo válido.");
                return;
            }

            if (vehiculo != null)
            {
                vehiculo.HorasEstancia = horas;
                decimal total = vehiculo.CalcularTarifa();
                MessageBox.Show($"El total a cobrar es: ${total:F2}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Clear();

            cbTipo.Items.Add("Motocicleta");
            cbTipo.Items.Add("Automovil");
            cbTipo.Items.Add("Camioneta");


            cbTipo.SelectedIndex = 0;
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
