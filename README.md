# _Vendor Tracker_

#### _7/24/2020_

#### By _**Hannah Beinstein**_

## Description

_This is a program to track vendors and their weekly orders from a bakery. The program will hold a list of vendors, as well as a list of each vendors' orders for the week. The program will allow the user to select a vendor, and when prompted, will display all the bakery orders that that specific vendor has ordered for the week. The program also allows the user to add new vendors and to see a full list of all vendors who have placed an order._

## Specs

| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| ** 1. Program will instantiate empty Vendor object | "add vendor" | -- |
| ** 2. Program will instantiate empty Order object | "add order" | -- |
| ** 3. Program will instantiate Vendor object with name, description, and place | "add vendor" | "Jeff", "runs coffee shop downtown", "Portland, OR" |
| ** 4. Program will instantiate Order object with title, description, date, price, and comments | "add order" | "Bread order", "bread, pastry", "5/3", "$5", "none" |
| ** 5. Program will return all vendors | -- | "Grocery, Restaurant, Bar" |
| ** 6. Program will specific vendor based on ID | Vendor.2 | "Grocery Store" |
| ** 7. Program will return empty list if no vendors | "Vendors:" | -- |
| ** 8. Program will add Orders to Vendor object | add: "1 bread, 1 pastry" | Grocery: "1 bread, 1 pastry" |
| ** 9. Program will return empty list for specific vendor if no orders | "Grocery Store" | -- |
| ** 10. Program will return all orders for specific vendor | "Grocery Store" | Grocery: "1 bread, 1 pastry" |

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