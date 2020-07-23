# _Go Fish_

#### _A recreation of the classic childrens game Go Fish using the MVC structure_

#### By _**Ian Scott and Tyson Lackey**_

## Description

_Long description._

### Specifications
| | Spec | Input | Output | isComplete |
| :-------------     | :-------------     | :------------- | :------------- |:------------- |
|1.|The program can instantiate a Game object  |  |  | _True_ |
|2.|The Game object contains a turn count number |Turn Number: |7 |_True_  |
|3.|The game object contains a deck of standard 52 cards |  |  |_True_  |
|4.|The game object contains a dictionary of player objects |  |  |_True_  |

|5.|The game object checks if selected card value exists in opponent's hand  |  |  |_False_  |
|6|If selected card value exists in opponent's hand, remove that card from oppenent hand and add it to player's|||_False_|
|7|If selected card value does not exist in opponent's hand, draw a card from game deck and add to player's hand, player turn ends|||_False_|

|8.|The game object has a index value to know whose turn it is  |  |  |_True_  |
|9.|The program can instantiate a Player object  |  |  |_True_  |
|10.|The player object contains a list of cards in hand  |  |  |_True_  |
|11.|The player object tracks the players score  |  |  |_True_  |

|X.| The player object is dealt a hand of 5 cards upon instantiation | | | _False_|

|12.|The game object is able to cards and add it to a players hand  |  |  |_True_  |
|13.| The player object will continue play if no cards are left in the deck| | | _False|
|14.|The player object can identify matches within it's own hand and remove them |  |  |_False_  |
|15.| The player object, after identifying a match, will increment its score  |  |  |_False_  |
|16.|The player object maintains a list of all matches it found in the game  |  |  |_False_  |
|17.|The player object will add found matches to the match list| | | _False_|


Player:
cards in hand
score
drawCard(int)
removeMatches() - increment score
list of matching cards as a single item string



Game
turn#
cards remaining(the deck)
dictionary of players
Player Turn (1 or 2)
checkformatches(int)


## Setup/Installation Requirements

1. This program utilizes .NET version 3.1, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK   version 2.2 or greater patch version, but do not upgrade to a higher minor version number.
2. Clone this repository onto your computer: https://github.com/...
3. In your preferred terminal window, navigate into PROJECTNAME.SOLUTIONS/PROJECTNAME using cd (i.e. cd desktop/PROJECTNAME.SOLUTIONS/PROJECTNAME) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore
5. To initiate this program, run the command: $ dotnet run
6. To run the test suite included with this project, within the terminal navigate into PROJECTNAME.TESTS and run the following commands:
    * $ dotnet restore
    * $ dotnet test


## Known Bugs

_There are currently no known bugs_

## Support and contact details

_Contact the authors via their respective GitHub profile pages._

## Technologies Used

- C#
- .NET
- MVC

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Ian Scott and Tyson Lackey**.