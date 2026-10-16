# PROG6221 Part 2 - Cybersecurity Awareness Chatbot

Name:[Thikolweli]
Student Number:[ST10498479]

## Project Overview
This is my Part 2 submission for PROG6221. It takes the console chatbot I built in Part 1 and turns it into a Windows Forms application. The bot now runs in a proper window with a text box and a Send button. It also has new features like keyword recognition, random responses, memory, sentiment detection and conversation flow.

## Features
- Plays a voice greeting when the app opens
- Shows a title and a banner at the top of the window
- Recognises keywords like password, scam, privacy and phishing
- Gives a different tip each time you ask about the same topic
- Remembers your name and favourite topic and uses them later
- Detects if you sound worried, curious or frustrated and adjusts its reply
- Handles blank or unknown input without crashing
- Code is split into separate classes so it stays readable

##window Layout
- lblTitle - shows the title at the top
- rtbChatHistory - shows the full conversation
- txtUserInput - where you type your message
- btnSend - sends your message to the bot

## How to Run the Project
1. Open the .sln file in Visual Studio 2022.
2. In Solution Explorer, right-click CybersecurityChatbotGUI and click Set as Startup Project.
3. Press Ctrl + Shift + B to build. The Error List should say "Build succeeded".
4. Press Ctrl + F5 to run the application.
5. The window opens, the voice greeting plays, and you can type your message and click Send.

## Project Structure
- Program.cs - starts the app
- ChatbotForm.cs - the GUI window
- Chatbot.cs - main conversation logic
- KeywordResponder.cs - handles topics and random responses
- MemoryStore.cs - remembers user details
- SentimentDetector.cs - detects the user's mood
- VoiceGreeting.cs - plays the WAV greeting
- Assets/greeting.wav - the voice file

## GitHub Actions

## Video Presentation
https://youtu.be/KMaCoSZXuFI