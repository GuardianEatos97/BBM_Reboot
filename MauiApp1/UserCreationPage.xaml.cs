namespace MauiApp1;

public partial class UserCreationPage : ContentPage
{
	public UserCreationPage()
	{
		InitializeComponent();
    }


    private void NewLogInBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}