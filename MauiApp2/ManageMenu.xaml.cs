namespace MauiApp2;

public partial class ManageMenu : ContentPage
{
	public ManageMenu()
	{
		InitializeComponent();
	}

    private void OnManageQuestsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ManageQuest());
    }

    private void OnManageUsersClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ManageUsers());
    }
}