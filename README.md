📌 Overview

A sample banking system built using 3-Tier Architecture with C# Windows Forms. The system provides essential functionalities for managing customers, transfers and transactions, users, currency exchange, and login logs.
---

🧱 System Architecture

Presentation Layer: Windows Forms UI.

Business Logic Layer (BLL): Handles business rules and banking logic.

Data Access Layer (DAL): Manages database operations and CRUD actions.

---
The main screen displays navigation buttons for the five window form, and the visibility of each form is controlled based on the user’s permissions. These permissions are managed using a bitwise AND mechanism, allowing flexible and efficient access control for each user.
___

🚀 Main Screens

1. Customer Management: Add, edit, delete, and search customers.


2. Bank Transfers: Perform transfers and transactions like withdraw and deposit with balance validation and view tables relative to them.


3. User Management: Create,update,delete users, ,modify permission for each users.


4. Currency Exchange: Calculate currency conversions based on exchange rates and update currencies.


5. Login Log: Display and record all login attempts.


🗄️ Database

Main tables include:

Client (ID,First Name,Last Name,Email, phone, Account number,pin code, Account balance)

Users (ID,First Name,Last Name,Email, phone,user name, password, permission)

Transfers (user id,user name, source account number, destination account number, source balance, destination balance,amount , date time)

Currencies (id, country, code,name,rate per dollar)

LoginLogs (login id, user id,user name, password, permission, data time)

transactions ( record id, id, Account number, amount, date time, transaction name)






