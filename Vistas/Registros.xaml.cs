namespace ppadillaExamen.Vistas;

public partial class Registros : ContentPage
{
	public Registros(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO " + usuario;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }
}