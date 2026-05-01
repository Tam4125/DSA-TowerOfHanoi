# Tower of Hanoi - Interactive & Auto-Solver

## 📖 Project Description

This project is a comprehensive Windows Forms (WinForms) application built in C# that simulates the classic **Tower of Hanoi** mathematical puzzle. It was developed as a Final Project for the Data Structures and Algorithms course at the University of Economics Ho Chi Minh City (UEH). 

Instead of relying on built-in C# collection classes, this application demonstrates core DSA concepts by utilizing a proprietary, from-scratch `Stack` data structure to manage game state and memory.

The application features three main navigation screens and two distinct core modes:
* **Interactive Mode:** A fully playable version of the puzzle where users can manually move disks between rods. It strictly enforces the rules of Hanoi and features a robust Undo system powered by our custom stack.
* **Auto-Solver Mode:** An automated visualizer that uses a recursive algorithm to solve the puzzle from start to finish. It includes real-time UI updates, a step counter, a live timer, and a log export feature.

---

## 📂 Folder Structure

The codebase is organized cleanly to separate the core logic, data structures, and the user interface. Here is the breakdown of the project directories:
```text
📁 TowerOfHanoi
├── 📁 Algorithms
│   ├── HanoiEngine.cs        # Contains the main engine and recursive algorithm for the Auto-Solver.
│   └── InteractiveEngine.cs  # Handles the logic, validation, and rod updates for the manual Interactive Mode.
├── 📁 DataStructures
│   ├── MyStack.cs            # Custom implementation of a Stack data structure (Using singly Linkedlist) for general data handling.
│   └── StackNode.cs          # The node architecture used to build the custom stack.
├── 📁 Models
│   ├── Disk.cs               # Object definition for the puzzle disks (size, placement).
│   ├── Tower.cs              # Object definition for the rods holding the disks.
│   └── MoveRecord.cs         # Object used to track history for the Undo feature.
├── 📁 Resource
│   └──                       # Contains all local image assets, icons, and backgrounds used in the application.
├── 📁 UI
│   └── HanoiRenderer.cs      # The custom GDI+ graphics engine responsible for drawing the UI (rods, disks, sky, grass).
├── 📄 AutoSolver.cs          # The Windows Form for the automated algorithm visualizer screen.
├── 📄 HomeScreen.cs          # The Windows Form for the main navigation menu and landing page.
├── 📄 InteractiveForm.cs     # The Windows Form for the playable manual game screen.
└── 📄 Program.cs             # The main entry point that runs the program and launches the Home Screen.

## 🚀 How to Run

Follow these steps to run the application locally on your machine:

### Prerequisites
* **Visual Studio** (2019 or newer recommended)
* **.NET Framework** (Make sure the .NET desktop development workload is installed)

### Installation & Execution
1. **Clone the repository** to your local machine using Git:
   ```bash
   git clone [https://github.com/yourusername/TowerOfHanoi-DSA.git](https://github.com/yourusername/TowerOfHanoi-DSA.git)

2. Open the Solution: Navigate to the cloned folder and double-click the TowerOfHanoiSolution.sln file to open it in Visual Studio.

3. Restore Dependencies: Wait a moment for Visual Studio to load the project. If prompted, allow NuGet to restore any necessary packages.

4. Set Startup Project: Ensure that the TowerOfHanoi project is set as the active startup project (it should be bolded in your Solution Explorer).

5. Run the Application: Press F5 on your keyboard, or click the green Start button at the top of Visual Studio.

6. The Main Menu will launch, allowing you to choose between Auto-Solver Mode and Interactive Mode!
