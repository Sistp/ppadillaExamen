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

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}