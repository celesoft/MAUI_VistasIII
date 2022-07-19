namespace VistasC;

public partial class VistasIII : ContentPage
{
	public VistasIII()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Una.IsChecked = true;
        dos.IsChecked = true;
        Tres.IsChecked = true;
        Cuatro.IsChecked = true;    
        Activo.IsToggled = true;
    }
}