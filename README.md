<!-- Vendor and Order Tracker

Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

Use Razor to display information on each page.

    Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
    Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
    The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
    The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
    Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
    Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".
    
     -->
# _Vendor Tracker_

#### _7/24/2020_

#### By _**Hannah Beinstein**_

## Description

_This is a program to track vendors and their weekly orders from a bakery. The program will hold a list of vendors, as well as a list of each vendor's order. The program will allow the user to select a vendor, and when prompted, will display all the bakery items that that specific vendor has ordered for the week._

## Specs

| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| ** 1. Program will take in inputted word | "apple" | -- |
| ** 2. Program will return true if word is a palindrome| "hannah" | true |
| ** 3. Program will return false if word is not a palindrome | "word" | false |

## Setup/Installation Requirements

* _Clone or download this repository located at https://github.com/HBeinstein/VendorTracker.Solution.
* _Open in your code editor of choice._
* _Run $ dotnet restore in terminal from main project directory to download all dev dependencies associated with project._
* _Run $ dotnet build in terminal from VendorTracker folder (VendorTracker.Solution/VendorTracker) to build project._
* _Run $ dotnet run in terminal from VendorTracker folder (VendorTracker.Solution/VendorTracker) to run project and view via live server._

## Known Bugs

_No known bugs_

## Support and contact details

_{Please contact me at with any known bugs or support issues.}_

## Technologies Used

* _GitHub_
* _C#_
* _ASP.NET_

### License

*Copyright (c) 2020 **_Hannah Beinstein MIT License_**