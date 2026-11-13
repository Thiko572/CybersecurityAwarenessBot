using System.Collections.Generic;
using System.Linq;
namespace CybersecurityChatbotGUI
{
    public class ActivityLogger
    {
        private readonly List<ActivityEntry> entries = new List<ActivityEntry>();
        public void Log(string description) => entries.Add(new ActivityEntry { Description = description });
        public List<ActivityEntry> GetRecent(int count) => entries.OrderByDescending(x => x.Time).Take(count).ToList();
    }
}