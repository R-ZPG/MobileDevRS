namespace MauiApp2;

public partial class PlayMenu : ContentPage
{
	public PlayMenu()
	{
		InitializeComponent();
	}

    private void OnMakePhotoClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PhotoMadeMenu());
    }
}