using System.Windows.Input;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        

        public MainPage()
        {
            InitializeComponent();
            Navigation.PushAsync(new UserCreationPage());
            Navigation.PushAsync(new BBMPage());
            BindingContext = this;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new BBMPage());
           
        }

        private void CreateIDBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserCreationPage());

        }
    }

}
