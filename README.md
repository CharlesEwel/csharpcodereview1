# Contact Book

#### A contact book made for the first code review for the C# class at Epicodus

#### Made by Charles Ewel

## Description

This webapp allows users to post contacts to a list, then view them all.

## Instructions

* Clone the repository
* In the console, run ">dnu restore" to set up dependencies
* In the console, run ">dnx kestrel" to set up your local server
* Navigate to localhost:5004 in your web browser

## Specs

The program should handle: | Example Input | Example Output
----- | ----- | -----
Add A Contact | First Name: Goober Last Name: Newton | Appends Newton, Goober to a list of contact
Contact Details Page |User clicks Goober, Newton on contactlist | Taken to localhost:5004/contacts/goobernewton, which displays details about the goober newton contact


## Technologies Used

* C#
* ASP.NET Nancy View Engine
* ASP.NET Razor View Engine

## Known Bugs

None

### License

Licensed under the MIT License.
