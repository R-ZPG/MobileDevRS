namespace MauiApp2;

public partial class PhotoMadeMenu : ContentPage
{
	public PhotoMadeMenu()
	{
		InitializeComponent();
	}

    private void OnSendPhotoClicked(object sender, EventArgs e)
    {
        SendBtn.Text = "Photo Sent!";
    }

    private void OnRemakePhotoClicked(object sender, EventArgs e)
    {
        RemakePhotoBtn.Text = "(reopens camera or photo library)";
    }
}