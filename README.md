# COMP-60: GUI Application Development with C#.NET

## Project Overview
This repository contains my **final project** for GUI Application Development (COMP 60) at St. Lawrence College. The project, **Pixel Quest**, is a Windows Forms-based text adventure game built using **C# and .NET**. The game allows players to make choices using text-based input, dynamically affecting the adventure’s progression.

## Learning Objectives
This project demonstrates:
- **C# Programming**: Using classes, objects, and structured programming.
- **Object-Oriented Programming (OOP)**: Implementing encapsulation, inheritance, and polymorphism.
- **Windows Forms Development**: Creating an interactive text-based adventure with GUI elements.
- **Event Handling**: Capturing and processing player choices dynamically.
- **State Management**: Using a `GameState` class to track progress and transitions.
- **String Manipulation**: Extracting user input and interpreting commands.

## Project Features
- **Interactive Character Creation**: Players select their name, race, and class using text-based input.
- **Dynamic Narration & Responses**: The game provides customized responses based on player input.
- **Game State Management**: Tracks player choices and transitions between different scenes.
- **Windows Forms UI**: Uses text boxes, labels, and buttons to create an engaging experience.

## Repository Structure
```
COMP-60-GUI-CSharp/
│── README.md                  # Project Overview
│── .gitattributes              # Git attributes file
│── .gitignore                  # Git ignore settings
│── App.config                  # Configuration file
│── PixelQuest.sln              # Visual Studio solution file
│── PixelQuest.csproj           # C# project file
│── packages.config             # NuGet package management
│── Properties/                 # Project properties and settings
│── Resources/                  # Game resources (images, etc.)
│── Dice.cs                     # Dice rolling mechanics
│── Form1.Designer.cs           # UI designer file for Form1
│── Form1.cs                    # Additional form logic
│── Form1.resx                  # Resource file for Form1
│── GameForm.Designer.cs        # UI designer file for the game form
│── GameForm.cs                 # Main game logic and user interactions
│── GameForm.resx               # Resource file for game form
│── GameState.cs                # Manages game states and transitions
│── MainGameForm.Designer.cs    # UI designer file for the main game
│── MainGameForm.cs             # Handles main gameplay elements
│── MainGameForm.resx           # Resource file for main game form
│── MainMenuForm.Designer.cs    # UI designer file for main menu
│── MainMenuForm.cs             # Main menu logic and interactions
│── MainMenuForm.resx           # Resource file for main menu
│── PixelQuest.Designer.cs      # Designer file for PixelQuest class
│── PixelQuest.cs               # Core game class
│── PixelQuest.resx             # Resource file for PixelQuest
│── Player.cs                   # Player character attributes and logic
│── Program.cs                  # Application entry point
```

## How to Run the Application
1. Clone the repository:
   ```bash
   git clone https://github.com/tayjoleo/COMP-60-GUI-CSharp.git
   ```
2. Open `PixelQuest.sln` in **Visual Studio**.
3. Build and run the project from within **Visual Studio**.

## Future Improvements
- Expand the story with **additional choices and branching narratives**.
- Improve **input handling** for more flexible player interactions.
- Enhance the UI with **animations and graphical elements**.

## Author
Taylor Evans | Contact: **taylor.evans@student.sl.on.ca**
