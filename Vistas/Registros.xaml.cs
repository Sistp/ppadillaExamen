namespace ppadillaExamen.Vistas;

public partial class Registros : ContentPage
{
	public Registros(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO " + usuario;
    }
}