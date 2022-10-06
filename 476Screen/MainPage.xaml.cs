namespace _476Screen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NexePage());
        }
    }
}