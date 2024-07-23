namespace CloseMauiAppTest;

public partial class MainPage : ContentPage
{
	//public delegate void NoArgumentsEventHandler();
	//public event NoArgumentsEventHandler?	DoneEvent;

	public MainPage()
	{
		InitializeComponent();
		//DoneEvent += Close;
	}

	private void OnTestlicked(object sender, EventArgs e)
	{
		_ = Task.Run(() => LongTask());
	}

	private void OnCloseClicked(object sender, EventArgs e)
	{
		Close();
	}

	private void Close()
	{
		Application.Current?.Quit();
	}

	private void LongTask()
	{
		Thread.Sleep(2000);
		//DoneEvent?.Invoke();
	}

	private void Label_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
	{
		Label label = sender as Label;
		if (label.Text == "Done.")
		{
			Close();
		}
	}
}
