# WordCounter (C# Console Application)

#### A console-based application check how many times a word appears in block of text. Hosted on [GitHub](https://github.com/StevenFleming/). _Last Updated 03.03.2020._

#### By _**Steven Fleming**_

## Description

This application utlizes an MVC framework which lets the user Keep track of employess and their respective clients. Employees can be added dynamically, and their clients can be added and displayed under each Employees account. The app uses C#, .Net Core and SQL, Entity Framework, RESTful routing,  Razor View Engine and MVC conventions to acheive this.

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/StevenFleming/) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'HairSalon.Solution'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/StevenFleming/HairSalon.git`
    - The new directory will be created as 'Desktop/HairSalon.Solution'.

    - Build a local Data Base
        - To construct import from this file:
        - Open MySQL Workbench. In the Navigator > Administration window, select Data Import/Restore.
        - From Import Options select Import from Self-Contained File.
        > CREATE Schemea steven_fleming;
        > This program is currently set to look for a database called 'steven_fleming'. If you use a different name, you will need to change the connection string in appsettings.json to reflect this.
        > CREATE TABLE clients (clientid int (11) PRIMARY KEY, NEVERNULL, AUTO INCREMENTING, name VARCHAR(100,clientid int(11), NEVER NULL, DEFALUT 0);
        > Click Apply
        > CREATE TABLE stylists (stylistid int (11) PRIMARY KEY, NEVERNULL, AUTO INCREMENTING,  name VARCHAR(100), clientid int(11), NEVER NULL, DEFALUT 0);
        Click Start Import.
        > Click Apply
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd HairSalon.Solution/HairSalon`
  - `dotnet build`
  - `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- C#
- .NET Core 2.2
- MySQL Server and MySQL Workbench
- Entity Framework
- HTML with Razor


## Specs

- [x] Database table and column names follow both the specific requirements for this project and general .NET naming conventions.
- [x] Instructions for re-creating your database are thorough and clear.
- [x] There is a one-to-many relationship set up correctly in the database.
- [x] CREATE functionality is included for one class and CREATE and VIEW functionality are included for the other class.
- [x] Entity is used for communication with the database
- [x] The project demonstrates understanding of this week's concepts.
- [x] The project is in a polished, portfolio-quality state.
- [x] Project uses two or more controllers.
- [x] GET and POST requests/responses are used successfully.
- [x] MVC routes follow RESTful conventions
- [x] Build files are included in .gitignore file and are not be tracked by Git
- [x] Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README).



</details>
<details>
  <summary>Expand user stories for this project</summary>

| As a _User-Type_, | I want... | so that... |
| As the salon owner | I need to be able to see a list of all stylists | So I can keep track of my employees|
| As the salon owner | I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist| So I can undestand the relationships between stylists and their respective clientele| 
| As the salon owner | I need to add new stylists to our system when they are hired| So I can reflect changes in my business|
| As the salon owner |  I need to be able to add new clients to a specific stylist.| This way I can update the relationships between Stylists and their respective clientele|

</details>

## Known Bugs

- No known bugs

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. I can be contacted at <12flemings@gmail.com>. Feel free to create a pull request for updates - _contributions are encouraged!_

### License

Copyright (c) 2020 **\_Steven_Fleming**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
