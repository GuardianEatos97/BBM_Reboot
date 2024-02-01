using System.Windows.Input;

namespace MauiApp1.Tabs;

public partial class StatusUpdates : ContentPage
{

    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

	public StatusUpdates()
	{
		InitializeComponent();
        BindingContext = this;
}
}