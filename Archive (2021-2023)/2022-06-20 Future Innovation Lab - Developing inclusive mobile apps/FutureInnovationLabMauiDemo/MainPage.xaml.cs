namespace FutureInnovationLabMauiDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        var uri = "https://twitter.com/therachelkang";
        await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
}

