namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string user = UsernameEntry.Text;
            string pass = PassEntry.Text;

            if (user == "123" && pass == "123")
            {
                Navigation.PushAsync(new MainMenu());
                //LoginBtn.Text = "Correct";
            }
            else
            {
                LoginBtn.Text = "Incorrect";
                UsernameEntry.Text = "";
                PassEntry.Text = "";
            }
           
        }

    }

}
