namespace VistasC;

public partial class VistasII : ContentPage
{
	public VistasII()
	{
		InitializeComponent();
	}

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        Busqueda.Text = busccador.Text;
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _rotationLabel.Rotation = value;
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        rotatingLabelSlider.Rotation = value;
    }
}