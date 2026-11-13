namespace CybersecurityChatbotGUI
{
    partial class ChatbotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            {
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabChat = new TabPage();
            tabTasks = new TabPage();
            lblTaskStatus = new Label();
            btnReFreshTasks = new Button();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            dgvTasks = new DataGridView();
            btnAddTask = new Button();
            dtpReminder = new DateTimePicker();
            chkUseReminder = new CheckBox();
            txtTaskDescription = new TextBox();
            txtTaskTitle = new TextBox();
            tabQuiz = new TabPage();
            lblQuizScore = new Label();
            lblQuizFeedback = new Label();
            btnNextQuestion = new Button();
            btnSubmitAnswer = new Button();
            btnStartQuiz = new Button();
            rdoD = new RadioButton();
            rdoC = new RadioButton();
            rdoB = new RadioButton();
            rdoA = new RadioButton();
            lblQuestion = new Label();
            lblQuestionNumber = new Label();
            tabActivity = new TabPage();
            btnShowMore = new Button();
            btnRefreshActivity = new Button();
            lstActivity = new ListBox();
            tabMain.SuspendLayout();
            tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabQuiz.SuspendLayout();
            tabActivity.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabChat);
            tabMain.Controls.Add(tabTasks);
            tabMain.Controls.Add(tabQuiz);
            tabMain.Controls.Add(tabActivity);
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1588, 665);
            tabMain.TabIndex = 0;
            // 
            // tabChat
            // 
            tabChat.Location = new Point(4, 34);
            tabChat.Name = "tabChat";
            tabChat.Padding = new Padding(3);
            tabChat.Size = new Size(1580, 627);
            tabChat.TabIndex = 0;
            tabChat.Text = "Chat";
            tabChat.UseVisualStyleBackColor = true;
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(lblTaskStatus);
            tabTasks.Controls.Add(btnReFreshTasks);
            tabTasks.Controls.Add(btnDeleteTask);
            tabTasks.Controls.Add(btnCompleteTask);
            tabTasks.Controls.Add(dgvTasks);
            tabTasks.Controls.Add(btnAddTask);
            tabTasks.Controls.Add(dtpReminder);
            tabTasks.Controls.Add(chkUseReminder);
            tabTasks.Controls.Add(txtTaskDescription);
            tabTasks.Controls.Add(txtTaskTitle);
            tabTasks.Location = new Point(4, 34);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(1580, 627);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Tasks";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // lblTaskStatus
            // 
            lblTaskStatus.AutoSize = true;
            lblTaskStatus.Location = new Point(6, 526);
            lblTaskStatus.Name = "lblTaskStatus";
            lblTaskStatus.Size = new Size(0, 25);
            lblTaskStatus.TabIndex = 9;
            // 
            // btnReFreshTasks
            // 
            btnReFreshTasks.Location = new Point(8, 570);
            btnReFreshTasks.Name = "btnReFreshTasks";
            btnReFreshTasks.Size = new Size(112, 34);
            btnReFreshTasks.TabIndex = 8;
            btnReFreshTasks.Text = "Refresh";
            btnReFreshTasks.UseVisualStyleBackColor = true;
            btnReFreshTasks.Click += btnRefreshTasks_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(176, 530);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(112, 34);
            btnDeleteTask.TabIndex = 7;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(6, 530);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(164, 34);
            btnCompleteTask.TabIndex = 6;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = true;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(8, 255);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.Size = new Size(846, 269);
            dgvTasks.TabIndex = 5;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(8, 206);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(6, 159);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(300, 31);
            dtpReminder.TabIndex = 3;
            // 
            // chkUseReminder
            // 
            chkUseReminder.AutoSize = true;
            chkUseReminder.Location = new Point(8, 107);
            chkUseReminder.Name = "chkUseReminder";
            chkUseReminder.Size = new Size(143, 29);
            chkUseReminder.TabIndex = 2;
            chkUseReminder.Text = "Set Reminder";
            chkUseReminder.UseVisualStyleBackColor = true;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(6, 58);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(263, 43);
            txtTaskDescription.TabIndex = 1;
            txtTaskDescription.Text = "Description";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(8, 6);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(159, 31);
            txtTaskTitle.TabIndex = 0;
            txtTaskTitle.Text = "Title";
            // 
            // tabQuiz
            // 
            tabQuiz.Controls.Add(lblQuizScore);
            tabQuiz.Controls.Add(lblQuizFeedback);
            tabQuiz.Controls.Add(btnNextQuestion);
            tabQuiz.Controls.Add(btnSubmitAnswer);
            tabQuiz.Controls.Add(btnStartQuiz);
            tabQuiz.Controls.Add(rdoD);
            tabQuiz.Controls.Add(rdoC);
            tabQuiz.Controls.Add(rdoB);
            tabQuiz.Controls.Add(rdoA);
            tabQuiz.Controls.Add(lblQuestion);
            tabQuiz.Controls.Add(lblQuestionNumber);
            tabQuiz.Location = new Point(4, 34);
            tabQuiz.Name = "tabQuiz";
            tabQuiz.Padding = new Padding(3);
            tabQuiz.Size = new Size(1580, 627);
            tabQuiz.TabIndex = 2;
            tabQuiz.Text = "Quiz";
            tabQuiz.UseVisualStyleBackColor = true;
            // 
            // lblQuizScore
            // 
            lblQuizScore.AutoSize = true;
            lblQuizScore.Location = new Point(16, 395);
            lblQuizScore.Name = "lblQuizScore";
            lblQuizScore.Size = new Size(49, 25);
            lblQuizScore.TabIndex = 10;
            lblQuizScore.Text = "0/12";
            // 
            // lblQuizFeedback
            // 
            lblQuizFeedback.AutoSize = true;
            lblQuizFeedback.Location = new Point(16, 357);
            lblQuizFeedback.Name = "lblQuizFeedback";
            lblQuizFeedback.Size = new Size(0, 25);
            lblQuizFeedback.TabIndex = 9;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Location = new Point(320, 299);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(161, 36);
            btnNextQuestion.TabIndex = 8;
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Location = new Point(127, 299);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(178, 34);
            btnSubmitAnswer.TabIndex = 7;
            btnSubmitAnswer.Text = "Submit Answer";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(0, 299);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(112, 34);
            btnStartQuiz.TabIndex = 6;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // rdoD
            // 
            rdoD.AutoSize = true;
            rdoD.Location = new Point(8, 194);
            rdoD.Name = "rdoD";
            rdoD.Size = new Size(192, 29);
            rdoD.TabIndex = 5;
            rdoD.Text = "Foward it to friends";
            rdoD.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            rdoC.AutoSize = true;
            rdoC.Location = new Point(8, 159);
            rdoC.Name = "rdoC";
            rdoC.Size = new Size(200, 29);
            rdoC.TabIndex = 4;
            rdoC.Text = "Report it as phishing";
            rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            rdoB.AutoSize = true;
            rdoB.Location = new Point(8, 124);
            rdoB.Name = "rdoB";
            rdoB.Size = new Size(237, 29);
            rdoB.TabIndex = 3;
            rdoB.Text = "Click the link immediately";
            rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            rdoA.AutoSize = true;
            rdoA.Checked = true;
            rdoA.Location = new Point(8, 89);
            rdoA.Name = "rdoA";
            rdoA.Size = new Size(230, 29);
            rdoA.TabIndex = 2;
            rdoA.TabStop = true;
            rdoA.Text = "Reply with the password";
            rdoA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(8, 43);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(542, 25);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "An unexpected email asks for your password.What should you do?";
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(8, 8);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(131, 25);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "Question1of12";
            // 
            // tabActivity
            // 
            tabActivity.Controls.Add(btnShowMore);
            tabActivity.Controls.Add(btnRefreshActivity);
            tabActivity.Controls.Add(lstActivity);
            tabActivity.Location = new Point(4, 34);
            tabActivity.Name = "tabActivity";
            tabActivity.Padding = new Padding(3);
            tabActivity.Size = new Size(1580, 627);
            tabActivity.TabIndex = 3;
            tabActivity.Text = "ActivityLog";
            tabActivity.UseVisualStyleBackColor = true;
            // 
            // btnShowMore
            // 
            btnShowMore.Location = new Point(16, 251);
            btnShowMore.Name = "btnShowMore";
            btnShowMore.Size = new Size(112, 34);
            btnShowMore.TabIndex = 2;
            btnShowMore.Text = "Show More";
            btnShowMore.TextAlign = ContentAlignment.MiddleRight;
            btnShowMore.UseVisualStyleBackColor = true;
            btnShowMore.Click += btnShowMore_Click;
            // 
            // btnRefreshActivity
            // 
            btnRefreshActivity.Location = new Point(147, 251);
            btnRefreshActivity.Name = "btnRefreshActivity";
            btnRefreshActivity.Size = new Size(112, 34);
            btnRefreshActivity.TabIndex = 1;
            btnRefreshActivity.Text = "Refresh Activity";
            btnRefreshActivity.UseVisualStyleBackColor = true;
            btnRefreshActivity.Click += btnRefreshActivity_Click;
            // 
            // lstActivity
            // 
            lstActivity.FormattingEnabled = true;
            lstActivity.ItemHeight = 25;
            lstActivity.Location = new Point(8, 8);
            lstActivity.Name = "lstActivity";
            lstActivity.Size = new Size(251, 204);
            lstActivity.TabIndex = 0;
            // 
            // ChatbotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 714);
            Controls.Add(tabMain);
            Name = "ChatbotForm";
            Text = "Form1";
            tabMain.ResumeLayout(false);
            tabTasks.ResumeLayout(false);
            tabTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabQuiz.ResumeLayout(false);
            tabQuiz.PerformLayout();
            tabActivity.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabChat;
        private TabPage tabTasks;
        private TabPage tabQuiz;
        private TabPage tabActivity;
        private Label lblTaskStatus;
        private Button btnReFreshTasks;
        private Button btnDeleteTask;
        private Button btnCompleteTask;
        private DataGridView dgvTasks;
        private Button btnAddTask;
        private DateTimePicker dtpReminder;
        private CheckBox chkUseReminder;
        private TextBox txtTaskDescription;
        private TextBox txtTaskTitle;
        private Button btnStartQuiz;
        private RadioButton rdoD;
        private RadioButton rdoC;
        private RadioButton rdoB;
        private RadioButton rdoA;
        private Label lblQuestion;
        private Label lblQuestionNumber;
        private Label lblQuizScore;
        private Label lblQuizFeedback;
        private Button btnNextQuestion;
        private Button btnSubmitAnswer;
        private Button btnShowMore;
        private Button btnRefreshActivity;
        private ListBox lstActivity;
    }
}