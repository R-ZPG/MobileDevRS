namespace MauiApp2;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        var stack = Shell.Current.Navigation.NavigationStack.ToArray();
        for (int i = stack.Length - 1; i > 0; i--)
        {
            Shell.Current.Navigation.RemovePage(stack[i]);
        }
    }
}