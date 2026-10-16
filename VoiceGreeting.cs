using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CybersecurityChatbotGUI
{
    public class VoiceGreeting
    {
        public void Play()
        {
            string file = Path.Combine(
                Application.StartupPath, "Greeting.wav");

            if (File.Exists(file))
            {
                SoundPlayer player = new SoundPlayer(file);
                player.Play();
            }
        }
    }
}