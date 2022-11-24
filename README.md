# Pierre's Bakery

#### A bakery offering bread and pastries, with standard discount offerings.

#### By Greg Ramsower

## Technologies Used

* C#
* Markdown
* MSTest
* .NET

## Description
* This application runs in the console.  Upon startup, the user is greeted with a message welcoming them to Pierre's Bakery and displaying the menu.
* The menu consists of two items: bread and pastry. Depending upon the customer's order size, the customer may recieve a discount on either or both types of item.
* The user is not required to order both types of items, but must enter '0' for any item type they do not want.
* The program will return a confirmation of the number of each item, using correct grammar (i.e., "pastry" when a single pastry is ordered, "pastries" in all other circumstances.)
* The application then returns the subtotal for each type of item, the overall total, and the amount the user saved due to the specials.
* The user is then prompted to enter another order, or quit the application.

## Setup/Installation Requirements

* Open the following link: https://github.com/gramsower/BakeryPierre.
* Fork the repository to your own GitHub. 
* Open up a directory on your computer to hold the application files. 
* Navigate to the directory using your favorite terminal.  Open the files in your preferred text editor.
* Install the dotnet framework entering the command 'dotnet restore' in the terminal while within the application main directory.
* Open the application using the command 'dotnet run'.
* Follow the application prompts.

## Known Bugs, Limitations, and Easter Eggs

* Very limited error checking.
* Specifically, the program will crash and terminate if the user enters any other character than a whole positive integer when asked how many of each item the user would like to order.
* UI is rudimentary.
* If the user only orders a single pastry, the program will display a special message.

## License
[GNU GPL 3.0](https://choosealicense.com/licenses/gpl-3.0/) Copyright (c) 11/14/2022 Greg Ramsower