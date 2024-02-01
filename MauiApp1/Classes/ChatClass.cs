using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Classes
{
    public record ChatClass(string ProfilePicture, string ProfileName, DateTime LastMessageAt, string LastMessage)
    {
       // public string LastMessageAtDisplay = $"{LastMessageAt:hh:mm}";
    }
}
