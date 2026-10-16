using System;
using System.Drawing;
using System.Windows.Forms;

namespace CybersecurityChatbotGUI
{
    public partial class ChatbotForm : Form
    {
        private TextBox chatBox;
        private TextBox inputBox;
        private Button sendButton;
        private Button exitButton;
        private string userName = "";

        public ChatbotForm()
        {
            Text = "Cybersecurity Awareness Chatbot";
            Size = new Size(850, 680);
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(650, 500);

            // Chat display
            chatBox = new TextBox();
            chatBox.Multiline = true;
            chatBox.ReadOnly = true;
            chatBox.ScrollBars = ScrollBars.Vertical;
            chatBox.WordWrap = false;
            chatBox.Font = new Font("Consolas", 11);
            chatBox.Location = new Point(20, 20);
            chatBox.Size = new Size(790, 510);
            chatBox.Anchor = AnchorStyles.Top |
                             AnchorStyles.Bottom |
                             AnchorStyles.Left |
                             AnchorStyles.Right;

            // User input
            inputBox = new TextBox();
            inputBox.Font = new Font("Arial", 12);
            inputBox.Location = new Point(20, 550);
            inputBox.Size = new Size(570, 35);
            inputBox.Anchor = AnchorStyles.Bottom |
                              AnchorStyles.Left |
                              AnchorStyles.Right;

            // Send button
            sendButton = new Button();
            sendButton.Text = "Send";
            sendButton.Location = new Point(605, 548);
            sendButton.Size = new Size(95, 38);
            sendButton.Anchor = AnchorStyles.Bottom |
                                AnchorStyles.Right;
            sendButton.Click += SendButton_Click;

            // Exit button
            exitButton = new Button();
            exitButton.Text = "Exit";
            exitButton.Location = new Point(710, 548);
            exitButton.Size = new Size(100, 38);
            exitButton.Anchor = AnchorStyles.Bottom |
                                AnchorStyles.Right;
            exitButton.Click += ExitButton_Click;

            // Press Enter to send
            inputBox.KeyDown += InputBox_KeyDown;

            Controls.Add(chatBox);
            Controls.Add(inputBox);
            Controls.Add(sendButton);
            Controls.Add(exitButton);

            // ASCII art and welcome message
            chatBox.Text =

chatBox.Text =
    "============================================================\r\n" +
    "____      _                                        _ _          \r\n" +
    " / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _  \r\n" +
    "| |  | | | | '_ \\ / _ \\ '__/ __|/ _ \\/ __| | | | '__| | __| | | | \r\n" +
    "| |__| |_| | |_) |  __/ |  \\__ \\  __/ (__| |_| | |  | | |_| |_| | \r\n" +
    " \\____\\__, |_.__/ \\___|_|  |___/\\___|\\___|\\__,_|_|  |_|\\__|\\__, | \r\n" +
    "      |___/                                                |___/\r\n" +
    "============================================================\r\n" +
    "                 CYBERSECURITY CHATBOT\r\n" +
    "============================================================\r\n\r\n" +
    "Welcome! I am your Cybersecurity Awareness Assistant.\r\n" +
    "What is your name?\r\n\r\n";
            inputBox.Focus();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = inputBox.Text.Trim();

            if (message.Length == 0)
                return;

            chatBox.AppendText("You: " + message + "\r\n");
            inputBox.Clear();

            // Ask for the user's name first
            if (userName == "")
            {
                userName = message;

                chatBox.AppendText(
                    "\r\nAssistant: Hello, " + userName + "!\r\n" +
                    "Welcome to the Cybersecurity Awareness Chatbot.\r\n\r\n" +
                    "You can ask me about:\r\n" +
                    "  1. Password Safety\r\n" +
                    "  2. Phishing\r\n" +
                    "  3. Scams\r\n" +
                    "  4. Privacy\r\n" +
                    "  5. Malware\r\n\r\n" +
                    "Type a topic or ask me a question.\r\n\r\n");

                return;
            }

            string question = message.ToLowerInvariant();
            string response;

            if (question.Contains("password"))
            {
                response =
                    "PASSWORD SAFETY\r\n" +
                    "Use long, strong and unique passwords for every account. " +
                    "Use a password manager and enable multi-factor authentication.";
            }
            else if (question.Contains("phishing"))
            {
                response =
                    "PHISHING\r\n" +
                    "Phishing messages try to steal your information. " +
                    "Check the sender and website address carefully. " +
                    "Never click suspicious links or open unexpected attachments.";
            }
            else if (question.Contains("scam"))
            {
                response =
                    "ONLINE SCAMS\r\n" +
                    "Be careful with unexpected prizes, urgent payment requests " +
                    "and offers that seem too good to be true. Verify before paying.";
            }
            else if (question.Contains("privacy"))
            {
                response =
                    "ONLINE PRIVACY\r\n" +
                    "Protect your personal information. Review privacy settings " +
                    "and avoid sharing passwords, banking details or sensitive data.";
            }
            else if (question.Contains("malware") ||
                     question.Contains("virus"))
            {
                response =
                    "MALWARE\r\n" +
                    "Malware is software designed to harm or access devices " +
                    "without permission. Keep software updated and download " +
                    "files only from trusted sources.";
            }
            else if (question.Contains("help") ||
                     question.Contains("topics"))
            {
                response =
                    "You can ask me about Password Safety, Phishing, Scams, " +
                    "Privacy or Malware.";
            }
            else if (question.Contains("thank"))
            {
                response =
                    "You're welcome, " + userName +
                    "! Stay alert and stay safe online.";
            }
            else if (question.Contains("hello") ||
                     question == "hi" ||
                     question.Contains("how are you"))
            {
                response =
                    "Hello, " + userName +
                    "! I'm ready to help you stay safe online. " +
                    "Which cybersecurity topic interests you?";
            }
            else
            {
                response =
                    "I'm not sure about that question yet, " + userName +
                    ". Please ask about passwords, phishing, scams, privacy " +
                    "or malware.";
            }

            chatBox.AppendText(
                "Assistant: " + response + "\r\n\r\n");
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendButton_Click(sender, EventArgs.Empty);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the chatbot?",
                "Exit Cybersecurity Chatbot",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}