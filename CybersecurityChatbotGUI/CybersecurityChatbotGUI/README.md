PROG6221 Cybersecurity Awareness Chatbot - Final POE
## Student Information
Name: [Thikolweli]
Student Number: [St10498479]
Module: PROG6221 Programming 2A

## Project Overview
This application is a GUI-based Cybersecurity Awareness Assistant that combines the functionality developed in Parts 1, 2 and 3. It helps users manage cybersecurity tasks, test their knowledge with a quiz, and learn about safe online practices.

## Final Features
### Part 1 & 2
- GUI interaction with ASCII art
- Keyword recognition and sentiment detection
- Memory and recall (remembers the last topic discussed)

### Part 3
- MySQL Task Assistant (Add, View, Complete, Delete)
- Optional reminders
- Cybersecurity quiz (12 questions with immediate feedback and score)
- NLP simulation using string/phrase detection
- Activity Log (tracks recent actions)

## Database Setup
To run this application, you must have MySQL installed.
1. Run the `database_setup.sql` script in MySQL to create the database.
2. Open the `DatabaseConfig.cs` file.
3. Replace `YOUR_PASSWORD` with your local MySQL password.
4. Run the application.

## How to Use
- **Chat tab:** Type cybersecurity questions or commands like "start quiz", "show tasks", or "I hate scams". 
- **Tasks tab:** Create tasks and click "Add Task". Select a task in the grid to complete or delete it.
- **Quiz tab:** Click "Start Quiz", select an answer, and click "Submit Answer". 
- **Activity Log tab:** Click "Refresh Activity" to see recent actions.

## Video Presentation
https://youtu.be/fig2nng5Nio