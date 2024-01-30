using System.Windows.Input;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        // Launcher.OpenAsync is provided by Essentials.
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
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
