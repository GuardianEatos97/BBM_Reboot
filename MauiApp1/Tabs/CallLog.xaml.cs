namespace MauiApp1.Tabs;

public partial class CallLog : ContentPage
{
	public CallLog()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Contacts());
    }
}