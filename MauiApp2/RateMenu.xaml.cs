namespace MauiApp2;

public partial class RateMenu : ContentPage
{
	public RateMenu()
	{
		InitializeComponent();
	}

    private void OnRateClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RatePhoto());
    }
}