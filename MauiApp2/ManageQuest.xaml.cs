namespace MauiApp2;

public partial class ManageQuest : ContentPage
{
	public ManageQuest()
	{
		InitializeComponent();
	}

    private void OnMakeQuestClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MakeQuest());
    }
}