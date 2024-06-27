# Rock, Paper, Scissors Game

This project is a simple console-based implementation of the classic Rock, Paper, Scissors game. The game allows a player to play against the computer (AI), and it keeps track of the scores for both the player and the AI.

## Features

- Player vs AI gameplay
- Random AI move generation
- Score tracking
- Best of 3 rounds
- Input validation

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- Visual Studio or any other C# development environment

### Running the Game

1. Clone the repository:
    ```sh
    git clone https://github.com/jafarramadan/RPS_Game2.git
    ```
2. Open the project in your development environment.
3. Build the solution to restore the necessary packages.
4. Run the project. The game will start in the console.

## Usage

1. When prompted, enter your move (`rock`, `paper`, or `scissors`).
2. The AI will randomly select its move.
3. The game will compare the moves, update the scores, and display the results.
4. The game continues for 3 rounds, and the final winner is declared based on the scores.

## Code Overview

### RPSGame Class

This class contains the core logic for the game:
- `AIMove()`: Generates a random move for the AI.
- `Compare(string playerOneMove, string playerTwoMove, Player playerOne, Player AI)`: Compares the moves of the player and the AI, updates scores, and displays the results.

### Player Class

This class represents a player in the game:
- `Name`: The name of the player.
- `Score`: The score of the player.
- `ChooseMove()`: Prompts the player to enter their move and validates the input.

### Program Class

This is the entry point of the game. It initializes the players, runs the game rounds, and handles exceptions.

### Unit Tests

The `RPSGameTests` namespace contains unit tests for the game:
- `TestRoundWinnerName`: Tests if the correct winner is identified based on the moves.
- `TestRoundWinnerScore`: Tests if the correct score is updated based on the moves.

