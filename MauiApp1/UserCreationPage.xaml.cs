namespace MauiApp1;

public partial class UserCreationPage : ContentPage
{
	public UserCreationPage()
	{
		InitializeComponent();
        Navigation.PushAsync(new MainPage());
    }


    private void NewLogInBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}