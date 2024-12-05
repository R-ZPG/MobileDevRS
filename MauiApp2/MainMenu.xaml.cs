namespace MauiApp2
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }

        private void OnShopClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShopMenu());
        }

        private void OnPlayClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlayMenu());
        }

        private void OnRateClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RateMenu());
        }
        private void OnMakeQuestClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MakeQuest());
        }
    }
}