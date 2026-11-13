using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CybersecurityChatbotGUI
{
    public partial class ChatbotForm : Form
    {
        // --- Class Instances ---
        private readonly QuizManager quizManager = new QuizManager();
        private readonly TaskRepository taskRepository = new TaskRepository();
        private readonly ActivityLogger activityLogger = new ActivityLogger();
        private readonly NlpProcessor nlpProcessor = new NlpProcessor();

        // --- Chat UI Variables ---
        private TextBox chatBox = null!;
        private TextBox inputBox = null!;
        private Button sendButton = null!;

        // --- MEMORY VARIABLE ---
        private string lastTopic = "nothing yet";

        public ChatbotForm()
        {
            InitializeComponent();
            SetupChatUI();
            tabMain.SelectedTab = tabChat; // Start on Chat tab
        }

        private void ChatbotForm_Load(object sender, EventArgs e)
        {
            LoadTasks();
            DisplayRecentActivity(5);
        }

        // ==========================================
        // CHAT & NLP INTEGRATION LOGIC
        // ==========================================
        private void SetupChatUI()
        {
            // 1. Create the chat display box
            chatBox = new TextBox();
            chatBox.Multiline = true;
            chatBox.ReadOnly = true;
            chatBox.ScrollBars = ScrollBars.Vertical;
            chatBox.Location = new Point(10, 10);
            chatBox.Size = new Size(800, 280);
            chatBox.BackColor = Color.White;
            chatBox.ForeColor = Color.Black;
            chatBox.Font = new Font("Consolas", 10); // Consolas makes the ASCII art align perfectly

            // 2. Create the input box
            inputBox = new TextBox();
            inputBox.Location = new Point(10, 300);
            inputBox.Size = new Size(690, 25);
            inputBox.Font = new Font("Segoe UI", 10);
            inputBox.Text = "ask about passwords, phishing, privacy, malware, safe browsing or 2FA.";
            inputBox.ForeColor = Color.Gray;

            inputBox.Enter += (s, e) => {
                if (inputBox.Text == "ask about passwords, phishing, privacy, malware, safe browsing or 2FA.")
                {
                    inputBox.Text = "";
                    inputBox.ForeColor = Color.Black;
                }
            };

            inputBox.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) sendButton.PerformClick(); };

            // 3. Create the Send button
            sendButton = new Button();
            sendButton.Text = "Send";
            sendButton.Location = new Point(710, 298);
            sendButton.Size = new Size(100, 30);
            sendButton.Click += SendButton_Click;

            // 4. Add them to the Chat Tab
            tabChat.Controls.Add(chatBox);
            tabChat.Controls.Add(inputBox);
            tabChat.Controls.Add(sendButton);

            // 5. Add the ASCII Art
            string asciiArt = @"
      _____      _                                        _ _          
     / ____|    | |                                      (_) |         
    | |    _   _| |__   ___ _ __ ___  ___  ___ _   _ _ __ _| |_ _   _  
    | |   | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | | 
    | |___| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| | 
     \_____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | 
            __/ |                                                __/ | 
           |___/                                                |___/ 
";

            chatBox.Text = asciiArt + "\r\nAssistant: Hello! I am your Cybersecurity Awareness Assistant. How can I help you today?\r\n\r\n";
        }

        private void SendButton_Click(object? sender, EventArgs e)
        {
            string message = inputBox.Text.Trim();
            if (message == "" || message == "ask about passwords, phishing, privacy, malware, safe browsing or 2FA.") return;

            chatBox.AppendText("YOU: " + message + Environment.NewLine);
            activityLogger.Log("Chat message sent");
            inputBox.Clear();
            inputBox.ForeColor = Color.Black;

            // 1. Check for Part 3 commands (Tasks, Quiz, Activity Log)
            IntentResult result = nlpProcessor.DetectIntent(message);
            string botResponse = "";

            switch (result.Intent)
            {
                case UserIntent.StartQuiz:
                    tabMain.SelectedTab = tabQuiz;
                    btnStartQuiz.PerformClick();
                    activityLogger.Log("Quiz started through chatbot");
                    botResponse = "Sure. I have opened the cybersecurity quiz.";
                    break;

                case UserIntent.ShowTasks:
                    tabMain.SelectedTab = tabTasks;
                    LoadTasks();
                    activityLogger.Log("Tasks viewed through chatbot");
                    botResponse = "Here are your saved cybersecurity tasks.";
                    break;

                case UserIntent.ShowActivityLog:
                    tabMain.SelectedTab = tabActivity;
                    DisplayRecentActivity(5);
                    activityLogger.Log("Activity log requested through chatbot");
                    botResponse = "Here are your most recent actions.";
                    break;

                case UserIntent.AddTask:
                    botResponse = AddTaskFromChat(result.TaskTitle, null);
                    break;

                case UserIntent.AddTaskWithReminder:
                    botResponse = AddTaskFromChat(result.TaskTitle, result.ReminderDate);
                    break;

                default:
                    // 2. SMART KEYWORD RESPONDER & MEMORY
                    string lowerMsg = message.ToLower();

                    // MEMORY RECALL CHECK
                    if (lowerMsg.Contains("what was i talking about") || lowerMsg.Contains("what were we talking about") || lowerMsg.Contains("do you remember"))
                    {
                        if (lastTopic == "nothing yet")
                        {
                            botResponse = "We haven't talked about anything specific yet. Try asking me about phishing or passwords!";
                        }
                        else
                        {
                            botResponse = $"We were just talking about {lastTopic}!";
                        }
                    }
                    // KEYWORD RECOGNITION (Also saves to memory)
                    else if (lowerMsg.Contains("phishing") || lowerMsg.Contains("email") || lowerMsg.Contains("link"))
                    {
                        lastTopic = "phishing";
                        botResponse = "Phishing messages try to steal your information. Check the sender and website address carefully. Never click suspicious links or open unexpected attachments.";
                    }
                    else if (lowerMsg.Contains("scam") || lowerMsg.Contains("hate"))
                    {
                        lastTopic = "scams";
                        botResponse = "Online scams can be very convincing. Be careful with unexpected prizes, urgent payment requests, and offers that seem too good to be true. Report suspected scams immediately.";
                    }
                    else if (lowerMsg.Contains("password") || lowerMsg.Contains("login"))
                    {
                        lastTopic = "passwords";
                        botResponse = "Create a strong password! Use a long mix of uppercase, lowercase, numbers, and symbols. Never reuse the same password on different accounts.";
                    }
                    else if (lowerMsg.Contains("privacy") || lowerMsg.Contains("personal"))
                    {
                        lastTopic = "privacy";
                        botResponse = "Protect your personal information. Review your privacy settings and avoid sharing passwords, banking details, or sensitive data online.";
                    }
                    else if (lowerMsg.Contains("malware") || lowerMsg.Contains("virus"))
                    {
                        lastTopic = "malware";
                        botResponse = "Malware is dangerous software that can harm your device. Keep your antivirus software updated and never download files from untrusted sources.";
                    }
                    else if (lowerMsg.Contains("2fa") || lowerMsg.Contains("authentication"))
                    {
                        lastTopic = "two-factor authentication (2FA)";
                        botResponse = "Two-factor authentication (2FA) adds an extra layer of security. Even if someone gets your password, they can't log in without the second verification step.";
                    }
                    else if (lowerMsg.Contains("hello") || lowerMsg.Contains("hi") || lowerMsg.Contains("hey"))
                    {
                        botResponse = "Hello! I am your Cybersecurity Awareness Assistant. What would you like to learn about today?";
                    }
                    else if (lowerMsg.Contains("safe") || lowerMsg.Contains("browsing"))
                    {
                        lastTopic = "safe browsing";
                        botResponse = "For safe browsing, always look for 'https://' in the URL, avoid clicking on pop-ups, and keep your browser updated.";
                    }
                    else
                    {
                        botResponse = "I am still learning about that specific topic. Try asking me about passwords, phishing, scams, malware, or privacy!";
                    }
                    break;
            }

            chatBox.AppendText("BOT: " + botResponse + Environment.NewLine + Environment.NewLine);
            chatBox.SelectionStart = chatBox.Text.Length;
            chatBox.ScrollToCaret();

            DisplayRecentActivity(5);
        }

        private string AddTaskFromChat(string taskTitle, DateTime? reminderDate)
        {
            if (taskTitle.Trim() == "") return "I recognised that you want to add a task, but I need the task details. Try: 'add a task to review privacy settings'.";

            CyberTask task = new CyberTask
            {
                Title = taskTitle,
                Description = "Task created from chatbot conversation.",
                ReminderDate = reminderDate,
                IsCompleted = false
            };

            try
            {
                taskRepository.AddTask(task);
                activityLogger.Log("Task added through chatbot: " + taskTitle);
                LoadTasks();

                if (reminderDate.HasValue) return "Task added: " + taskTitle + ". Reminder set for " + reminderDate.Value.ToShortDateString() + ".";
                return "Task added: " + taskTitle + ". You can open the Tasks tab to add a reminder.";
            }
            catch (Exception ex)
            {
                return "I could not save that task: " + ex.Message;
            }
        }

        // ==========================================
        // TASK ASSISTANT LOGIC
        // ==========================================
        private void LoadTasks()
        {
            try
            {
                dgvTasks.DataSource = null;
                dgvTasks.DataSource = taskRepository.GetAllTasks();
                if (dgvTasks.Columns["TaskId"] != null)
                    dgvTasks.Columns["TaskId"].Visible = false;
            }
            catch (Exception ex)
            {
                lblTaskStatus.Text = "Could not load tasks: " + ex.Message;
            }
        }

        private CyberTask? GetSelectedTask()
        {
            if (dgvTasks.CurrentRow == null) return null;
            return dgvTasks.CurrentRow.DataBoundItem as CyberTask;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text.Trim();
            string description = txtTaskDescription.Text.Trim();

            if (title == "" || description == "")
            {
                lblTaskStatus.Text = "Please enter both a task title and description.";
                return;
            }

            CyberTask task = new CyberTask
            {
                Title = title,
                Description = description,
                ReminderDate = chkUseReminder.Checked ? dtpReminder.Value : null,
                IsCompleted = false
            };

            try
            {
                int newTaskId = taskRepository.AddTask(task);
                lblTaskStatus.Text = "Task added successfully. ID: " + newTaskId;
                activityLogger.Log("Task added: " + title);
                DisplayRecentActivity(5);

                txtTaskTitle.Clear();
                txtTaskDescription.Clear();
                chkUseReminder.Checked = false;
                LoadTasks();
            }
            catch (Exception ex)
            {
                lblTaskStatus.Text = "Task could not be saved: " + ex.Message;
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            CyberTask? task = GetSelectedTask();
            if (task == null) { lblTaskStatus.Text = "Please select a task first."; return; }

            try
            {
                taskRepository.MarkTaskCompleted(task.TaskId);
                lblTaskStatus.Text = "Task marked as completed.";
                activityLogger.Log("Task completed: " + task.Title);
                DisplayRecentActivity(5);
                LoadTasks();
            }
            catch (Exception ex) { lblTaskStatus.Text = "Could not complete task: " + ex.Message; }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            CyberTask? task = GetSelectedTask();
            if (task == null) { lblTaskStatus.Text = "Please select a task first."; return; }

            DialogResult answer = MessageBox.Show("Delete this task?\n\n" + task.Title, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes) return;

            try
            {
                taskRepository.DeleteTask(task.TaskId);
                lblTaskStatus.Text = "Task deleted.";
                activityLogger.Log("Task deleted: " + task.Title);
                DisplayRecentActivity(5);
                LoadTasks();
            }
            catch (Exception ex) { lblTaskStatus.Text = "Could not delete task: " + ex.Message; }
        }

        private void btnRefreshTasks_Click(object sender, EventArgs e)
        {
            LoadTasks();
            lblTaskStatus.Text = "Task list refreshed from MySQL.";
        }


        // ==========================================
        // QUIZ LOGIC
        // ==========================================
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            quizManager.StartQuiz();
            activityLogger.Log("Quiz started");
            lblQuizFeedback.Text = "";
            btnSubmitAnswer.Enabled = true;
            btnNextQuestion.Enabled = false;
            DisplayCurrentQuestion();
            DisplayRecentActivity(5);
        }

        private void DisplayCurrentQuestion()
        {
            QuizQuestion question = quizManager.CurrentQuestion;
            lblQuestionNumber.Text = $"Question {quizManager.CurrentIndex + 1} of {quizManager.TotalQuestions}";
            lblQuestion.Text = question.QuestionText;

            RadioButton[] buttons = { rdoA, rdoB, rdoC, rdoD };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Checked = false;
                if (i < question.Options.Count)
                {
                    buttons[i].Text = question.Options[i];
                    buttons[i].Visible = true;
                }
                else
                {
                    buttons[i].Visible = false;
                }
            }
            lblQuizScore.Text = $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";
        }

        private int GetSelectedQuizOption()
        {
            if (rdoA.Checked) return 0;
            if (rdoB.Checked) return 1;
            if (rdoC.Checked) return 2;
            if (rdoD.Checked) return 3;
            return -1;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedQuizOption();
            if (selectedIndex == -1)
            {
                lblQuizFeedback.Text = "Please select an answer.";
                return;
            }

            QuizAnswerResult result = quizManager.CheckAnswer(selectedIndex);
            lblQuizFeedback.Text = result.Feedback;
            lblQuizScore.Text = $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";
            activityLogger.Log("Quiz answer submitted");

            btnSubmitAnswer.Enabled = false;
            btnNextQuestion.Enabled = true;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (quizManager.MoveNext())
            {
                lblQuizFeedback.Text = "";
                btnSubmitAnswer.Enabled = true;
                btnNextQuestion.Enabled = false;
                DisplayCurrentQuestion();
            }
            else
            {
                lblQuizFeedback.Text = $"Quiz complete! Final score: {quizManager.Score}/{quizManager.TotalQuestions}";
                activityLogger.Log($"Quiz completed - score {quizManager.Score}/{quizManager.TotalQuestions}");
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = false;
                DisplayRecentActivity(5);
            }
        }


        // ==========================================
        // ACTIVITY LOG LOGIC
        // ==========================================
        private void DisplayRecentActivity(int count)
        {
            lstActivity.Items.Clear();
            List<ActivityEntry> recent = activityLogger.GetRecent(count);

            if (recent.Count == 0)
            {
                lstActivity.Items.Add("No activity recorded yet.");
                return;
            }

            foreach (ActivityEntry entry in recent)
            {
                lstActivity.Items.Add(entry.ToString());
            }
        }

        private void btnRefreshActivity_Click(object sender, EventArgs e)
        {
            DisplayRecentActivity(5);
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            DisplayRecentActivity(10);
        }
    }
}