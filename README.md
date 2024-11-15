# Library Management System

## Project Summary
This project is a library management system that allows users to enter books, add authors, and perform login and signup functions. Users can add, update, and view new books and authors by entering their details. The project features a user-friendly interface for managing essential book details (title, author, genre, publication date, summary, ISBN, copy count, and image) and author details (first name, last name, date of birth, and books).

## Technologies Used
- **ASP.NET Core**: Used for developing the web application.
- **HTML/CSS**: Used for designing the user interface.
- **JavaScript**: Used for form interactions and dynamic content.
- **Bootstrap**: Used for responsive design.

## Requirements to Run the Project
1. **Prerequisites**:
   - .NET Core SDK (minimum version 3.1 or higher)
   - Static list is used instead of a database
   - A database management system (SQL Server, SQLite, etc., if preferred)

2. **Project Setup**:
   - Clone the project or download it as a ZIP file.
   - Navigate to the project directory in your terminal or command prompt.
   - Run the following command to install the necessary packages:
     ```bash
     dotnet restore
     ```

3. **Database Update**:
   - Run the following command to update the database (if using a database):
     ```bash
     dotnet ef database update
     ```

4. **Start the Application**:
   - Run the following command to start the application:
     ```bash
     dotnet run
     ```
   - Open your browser and go to `http://localhost:5000` to view the application.

## Usage
**Before Login**:

Before logging in, users can only perform limited actions such as viewing the lists and details of books and authors.

![Home Page](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/beforesignup1.png)
![Book List](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/beforesignup2.png)
![Author List](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/beforesignup3.png)

**After Login**:
Home Page:
![Home Page](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/login1.png)

Book List:
![Book List](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/login2.png)

Add Book:
![Add Book](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/kitapgirisi.png)

Update Book:
![Update Book](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/editbook.png)

View Book Details:
![Book Details](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/detaylar.png)

Add Author:
![Add Author](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/yazargirisi.png)

Update Author:
![Update Author](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/yazargüncelleme.png)

View Author Details:
![Author Details](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/yazardetay.png)

About Page:
![About](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/about.png)

## Contributors
- Melike
