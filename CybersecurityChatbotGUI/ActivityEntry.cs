using System;
namespace CybersecurityChatbotGUI
{
    public class ActivityEntry
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public string Description { get; set; } = "";
        public override string ToString() => $"{Time:HH:mm} - {Description}";
    }
}