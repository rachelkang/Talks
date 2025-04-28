using Xamarin.Essentials;
using Xamarin.Forms;

namespace FutureInnovationLabDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void Button_Clicked(System.Object sender, System.EventArgs e)
		{
			var uri = "https://twitter.com/therachelkang";
			await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		}
	}
}
