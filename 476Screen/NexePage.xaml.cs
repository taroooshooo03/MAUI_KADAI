namespace _476Screen;

public partial class NexePage : ContentPage
{
	public NexePage()
	{
		InitializeComponent();
	}

	private void OnPrevClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}