using System.Windows.Input;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
               /* BBMPage = new NavigationPage(new BBMPage());
            await Navigation.PushAsync(new BBMPage());*/

            SemanticScreenReader.Announce(SignInBtn.Text);
        }
    }

}
