namespace ppadillaExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = "estudiante2024";
        string contraseña = "uisrael2024";
        string usuario2 = "examen1";
        string contraseña2 = "parcial1";
        string usuario3 = "ppadilla";
        string contraseña3 = "2024";

        if (txtUsuario.Text == usuario && txtContrasena.Text == contraseña)
        {
            string mensajeBienvenida = "¡Bienvenido, " + usuario + "!";
            DisplayAlert("Bienvenida", mensajeBienvenida, "Aceptar");
            Navigation.PushAsync(new Registros(usuario));
        }
        else if (txtUsuario.Text == usuario2 && txtContrasena.Text == contraseña2)
        {
            string mensajeBienvenida = "¡Bienvenida, " + usuario2 + "!";
            DisplayAlert("Bienvenida", mensajeBienvenida, "Aceptar");
            Navigation.PushAsync(new Registros(usuario2));
        }
        else if (txtUsuario.Text == usuario3 && txtContrasena.Text == contraseña3)
        {
            string mensajeBienvenida = "¡Bienvenido, " + usuario3 + "!";
            DisplayAlert("Bienvenida", mensajeBienvenida, "Aceptar");
            Navigation.PushAsync(new Registros(usuario3));
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO/CONTRASEÑA INCORRECTOS", "CANCELAR");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        string nombre = "Paul Padilla";
        string nivel = "Octavo A";
        string institucion = "Universidad Israel";

        string mensaje = $"Nombre: {nombre}\nNivel: {nivel}\nInstitución: {institucion}";

        DisplayAlert("Información", mensaje, "Aceptar");
    }
}