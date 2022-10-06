namespace _478OpenURL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            var url = "https://www.shuwasystem.co.jp";
            await Browser.OpenAsync(url);
        }
    }
}