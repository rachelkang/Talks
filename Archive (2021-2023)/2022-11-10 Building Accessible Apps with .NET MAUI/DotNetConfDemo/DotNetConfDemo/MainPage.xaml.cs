namespace DotNetConfDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        //OnCounterLabelClicked();
        ModifyTabNavigation();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    //private void OnCounterLabelClicked()
    //{
    //    var tapGestureRecognizer = new TapGestureRecognizer();
    //    tapGestureRecognizer.Tapped += (s, e) =>
    //    {
    //        count++;

    //        if (count == 1)
    //            CounterLbl.Text = $"Clicked {count} time";
    //        else
    //            CounterLbl.Text = $"Clicked {count} times";

    //        SemanticScreenReader.Announce(CounterLbl.Text);
    //    };
    //    CounterLbl.GestureRecognizers.Add(tapGestureRecognizer);
    //}

    void ModifyTabNavigation()
    {
        Microsoft.Maui.Handlers.LayoutHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if WINDOWS
                        handler.PlatformView.TabFocusNavigation = Microsoft.UI.Xaml.Input.KeyboardNavigationMode.Cycle;
#endif
        });
    }
}

