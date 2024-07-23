namespace CloseMauiAppTest;

public partial class SecondPage : ContentPage
{

	public SecondPage()
	{
		InitializeComponent();
	}

	private void OnTestlicked(object sender, EventArgs e)
	{
		Thread.Sleep(5000);
		Application.Current?.Quit();
	}

	private void OnCloseClicked(object sender, EventArgs e)
	{
		Application.Current?.Quit();
	}
}
