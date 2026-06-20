# 16_API_MVC_CRUD

## Project Overview

This project demonstrates how to build a complete CRUD (Create, Read, Update, Delete) application using ASP.NET Core MVC and Web API.

The application uses a shared Service Layer that is consumed by both MVC Controllers and API Controllers. This approach reduces code duplication and follows a cleaner architecture compared to placing business logic directly inside controllers.

---

## Features

### MVC Features

* Add Student
* View Student List
* Update Student
* Delete Student
* Bootstrap UI
* Validation Support
* Delete Confirmation Modal

### API Features

* Get All Students
* Add Student
* Update Student
* Delete Student
* Swagger API Testing

---

## Technologies Used

* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Dependency Injection
* Service Layer Pattern
* Bootstrap 5
* Swagger

---

## Project Structure

Controllers

* StudentsController (MVC)
* StudentsApiController (API)

Services

* IStudentService
* StudentService

Data

* ApplicationDbContext

Models

* Student

Database

* SQL Server

---

## Architecture Flow

MVC Controller
↓
Student Service
↓
Entity Framework Core
↓
SQL Server


API Controller
↓
Student Service
↓
Entity Framework Core
↓
SQL Server

Both MVC and API controllers use the same service layer, which keeps business logic centralized and reusable.

---

## CRUD Operations

### Create

Add new student records to the database.

### Read

Display student records in MVC View and API response.

### Update

Modify existing student information.

### Delete

Remove student records with confirmation modal support.

---

## API Endpoints

GET
/api/StudentsApi

POST
/api/StudentsApi

PUT
/api/StudentsApi

DELETE
/api/StudentsApi

---

## Learning Outcomes

* MVC Controller Development
* API Controller Development
* Service Layer Implementation
* Dependency Injection
* Entity Framework Core CRUD
* SQL Server Integration
* Bootstrap UI Design
* Swagger Documentation
* Code Reusability Between MVC and API

---

## Future Improvements

* Repository Pattern
* DTO Implementation
* AutoMapper
* Global Exception Handling
* Logging with ILogger
* Authentication & Authorization
* Clean Architecture
* Unit Testing

## Screenshots
<img width="2560" height="1600" alt="localhost_7241_swagger_index html(Nest Hub Max)" src="https://github.com/user-attachments/assets/e0596feb-3d11-415d-b4b7-555800544feb" /><img width="2560" height="3402" alt="localhost_7241_swagger_index html(Nest Hub Max) (1)" src="https://github.com/user-attachments/assets/ff0c5487-99ce-4d1a-8c23-82cf49905bc5" /><img width="2560" height="3898" alt="localhost_7241_swagger_index html(Nest Hub Max) (2)" src="https://github.com/user-attachments/assets/cee6efca-8039-48d1-9f99-50c347d3657f" /><img width="2560" height="3928" alt="localhost_7241_swagger_index html(Nest Hub Max) (3)" src="https://github.com/user-attachments/assets/38312d08-f273-489e-9223-21af7a337e95" /><img width="2560" height="3928" alt="localhost_7241_swagger_index html(Nest Hub Max) (4)" src="https://github.com/user-attachments/assets/9e08cfc8-2468-44d7-91a4-939d883102c4" /><img width="2560" height="1600" alt="localhost_7241_(Nest Hub Max)" src="https://github.com/user-attachments/assets/5a157251-cb60-4ef4-8249-da27e1da180a" /><img width="2560" height="1600" alt="localhost_7241_Students_ListStudent(Nest Hub Max)" src="https://github.com/user-attachments/assets/f32b2fb4-2efa-4da2-84ba-cb189a0b7aec" /><img width="2560" height="1600" alt="localhost_7241_Students_UpdateStudent_10(Nest Hub Max)" src="https://github.com/user-attachments/assets/0ffba448-108f-41ea-80e6-41add16ad5df" /><img width="2560" height="1600" alt="localhost_7241_Students_DeleteStudent_10(Nest Hub Max)" src="https://github.com/user-attachments/assets/44ebeb5d-caef-44c1-a85f-4c17a3dc01ac" /><img width="2560" height="1600" alt="localhost_7241_Students_DeleteStudent_10(Nest Hub Max) (1)" src="https://github.com/user-attachments/assets/6731d0bd-221d-43b3-b296-85ac4f4126b9" />



## Project Status
✅ Completed.

## Author
Dhiraj Padhiyar

