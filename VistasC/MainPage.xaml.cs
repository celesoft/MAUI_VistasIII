namespace VistasC;

public partial class MainPage : ContentPage
{
	int count = 0;
    String Nombre = "Juan";
    DateTime ahora = new DateTime();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        entNombre.Text = "Jose";
        entApellidos.Text = "Gonzalez";
        Observaciones.Text = "Algunos de sus  amigos lo llaman cele";
        Coche.IsChecked = true;
        Tren.IsChecked = true;

    }

    private void entNombre_TextChanged(object sender, TextChangedEventArgs e)
    {
		Label.Text = entNombre.Text;
    }

    private void entApellidos_TextChanged(object sender, TextChangedEventArgs e)
    {
		
    }

    private void entApellidos_Completed(object sender, EventArgs e)
    {
        Label.Text = Label.Text + " " + entApellidos.Text;
    }

    private void entNombre_Completed(object sender, EventArgs e)
    {
		entApellidos.Focus();
    }

    private void btnImage_Clicked(object sender, EventArgs e)
    {
       Label.Text = Nombre;
    }

    private void btnImage_Pressed(object sender, EventArgs e)
    {
        ahora = DateTime.Now;
    }

    private void btnImage_Released(object sender, EventArgs e)
    {
       DateTime fin = DateTime.Now;

        if ((fin - ahora).Seconds > 5) 
        {
            Nombre = "Jose";
        }

    }

    private void Ligero_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        String Ligeros = ((RadioButton)sender).Value.ToString();
        Label.Text = Ligeros;
    }

    private void Pesado_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        String pesados = ((RadioButton)sender).Value.ToString();
        Label.Text = pesados;
    }
}

