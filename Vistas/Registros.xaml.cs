namespace ppadillaExamen.Vistas;

public partial class Registros : ContentPage
{
	public Registros(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO " + usuario ;
    }

    private void btnPago_Clicked(object sender, EventArgs e)
    {
        double monto = Convert.ToDouble(txtMontoInicial.Text);
        double pagoMensual = (CalcularMensual(monto));

        txtPagoMensual.Text = Convert.ToString(pagoMensual);
    }

    private double CalcularMensual(double monto)
    {
        double pagoMensual = (1500 - monto) / 4 + (0.04 * 1500);
        return pagoMensual;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string fecha = datePicker.Date.ToString("d");
        string pais = pickerPais.SelectedItem?.ToString();
        string ciudad = pickerCiudad.SelectedItem?.ToString();
        string montoInicial = txtMontoInicial.Text;
        string pagoMensual = txtPagoMensual.Text;

        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        double montoTotal = CalcularTotal(Convert.ToDouble(txtMontoInicial.Text));

        string mensaje = $"DATOS:\n\n" +
                     $"Nombre: {nombre}\n" +
                     $"Apellido: {apellido}\n" +
                     $"Edad: {edad}\n\n" +
                     $"Fecha: {fecha}\n" +
                     $"Ciudad: {ciudad}\n" +
                     $"País: {pais}\n" +
                     $"Monto Inicial: {montoInicial}\n" +
                     $"Pago Mensual: {pagoMensual}\n" +
                      $"Pago Total: {montoTotal}\n";

        DisplayAlert("RESUMEN", mensaje, "OK");
    }

    private double CalcularTotal(double monto)
    {
        double pagoMensual = (1500 - monto) / 4 + (0.04 * 1500);
        double pagoTotal = (pagoMensual * 4) + monto;
        return pagoTotal;
    }
}