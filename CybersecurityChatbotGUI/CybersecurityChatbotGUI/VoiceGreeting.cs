using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CybersecurityChatbotGUI
{
    public static class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "greeting.wav");

                if (!File.Exists(path))
                {
                    MessageBox.Show("WAV not found: " + path);
                    return;
                }

                SoundPlayer player = new SoundPlayer(path);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Audio error: " + ex.Message);
            }
        }
    }
}