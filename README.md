# Unity Model View Presenter (MVP) Pattern


## Overview

This Unity project demonstrates a simple implementation of the Model-View-Presenter (MVP) design pattern. The project includes a Cube that has attributes such as Value, Score, and Health. The Cube's attributes can be updated through user interactions with a UI.

## Components

### CubeModel

The `CubeModel` class represents the model in the MVP pattern. It manages the Cube's state, including its value, score, and health.

**Methods:**
- `SetValue(int value)`: Sets the value of the Cube.
- `AddScore(int amount)`: Adds to the Cube's score.
- `TakeDamage(int amount)`: Reduces the Cube's health by the specified amount.

### CubePresenter

The `CubePresenter` class acts as the presenter in the MVP pattern. It interacts with both the model (`CubeModel`) and the view (`ICubeView`), updating the view when the model changes and handling user input from the view.

**Methods:**
- `OnUpdateValueButtonClick(int value)`: Updates the Cube's value and refreshes the view.
- `OnAddScoreButtonClick(int score)`: Adds to the Cube's score and refreshes the view.
- `OnTakeDamageButtonClick(int damage)`: Applies damage to the Cube and refreshes the view.

### CubeView

The `CubeView` class represents the view in the MVP pattern. It handles the user interface and user interactions, such as button clicks and input fields.

**Properties:**
- `Value`: Gets or sets the Cube's value in the UI.
- `Score`: Gets or sets the Cube's score in the UI.
- `Health`: Gets or sets the Cube's health in the UI.

**Methods:**
- `RegisterUpdateValueButtonClickListener(Action<int> onClick)`: Registers a listener for the update value button.
- `RegisterAddScoreButtonClickListener(Action<int> onClick)`: Registers a listener for the add score button.
- `RegisterTakeDamageButtonClickListener(Action<int> onClick)`: Registers a listener for the take damage button.

### GameManager

The `GameManager` class is responsible for initializing the Cube model and presenter at the start of the game.


