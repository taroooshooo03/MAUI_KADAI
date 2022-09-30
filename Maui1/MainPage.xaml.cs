namespace Maui1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
		labelCount.Text = $"{count}";
		count++;
		labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
	}
}

