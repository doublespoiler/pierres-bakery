# PIERRE'S BAKERY

### By Skylan Lew

### Independent Project 7 for Epicodus

## Technologies Used

- C#
- .NET 5

## Description

This console application presents the user with a storefront application to buy bread.

The user may press escape at the first screen to close the program.

The application displays the prices, and prompts the user to press any key to continue. Then they put how many loaves of bread they want as an integer into the console and press enter. Then they enter how many pastries they want and press enter. If the user does not put a valid answer, the program repeats the prompt.

After the user has chosen their bread and pastries, the program prints a reciept with the subtotals of each category of item, how many were purchased, and the total. The program exits after the user presses a key.

## Setup/Installation Requirements

### Requires

- [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) - <https://dotnet.microsoft.com/en-us/download/dotnet/5.0>

### Tested on

- Windows 11 21H2
- .NET 5.0.412

### Download/Run Instructions (git)

- clone: `$ git clone https://github.com/doublespoiler/pierres-bakery` or Code>Download ZIP
- navigate to project folder: `$ cd pierres-bakery/bakery`
- restore: `$ dotnet restore`
- build: `$ dotnet build`
- run: `$ dotnet run`

### Test Instructions (git)

- clone: `$ git clone https://github.com/doublespoiler/pierres-bakery` or Code>Download ZIP
- navigate to test folder: `$ cd pierres-bakery/bakery.tests`
- test: `$ dotnet test`

## Known Bugs

- When pressing escape to close the application at the start screen, I need to print another line otherwise the rest of the lines don't show.

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2022 Skylan Lew
