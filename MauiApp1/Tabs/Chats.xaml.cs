using System.Collections.ObjectModel;
using MauiApp1.Classes;

namespace MauiApp1.Tabs;

public partial class Chats : ContentPage
{
    public Chats()
    {
        InitializeComponent();

        Chats_ = new ObservableCollection<ChatClass>(LoadChats_());
        BindingContext = this;
    }


    public ObservableCollection<ChatClass> Chats_ { get; set; }
    private static IEnumerable<ChatClass> LoadChats_()
    {
        return new List<ChatClass>
        {
            new ChatClass(("adam.jpg"),"Adam", DateTime.Now.AddDays(1), "We still on for tonight?"),
            new ChatClass(("aria.jpg"), "Ariiii<3", DateTime.Now.AddMinutes(-2), "You're good babe?"),
            new ChatClass(("dean.jpeg"), "Deany", DateTime.Now.AddDays(-2), "Ok see you soon"),
            new ChatClass(("jasmin.jpeg"), "Jasmin", DateTime.Now.AddMinutes(1), "Hey girl! We still on for...."),
            new ChatClass(("neo.jpeg"), "Neo", DateTime.Now.AddDays(1), "sent"),
        };

    }

}
