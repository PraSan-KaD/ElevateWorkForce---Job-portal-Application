# Elevate Workforce Solutions – Job Portal Web Application

This is a Job Portal web application developed as part of an academic project for **Elevate Workforce Solutions**. The system helps connect **job seekers** with **companies** looking to hire. It supports secure login, job listing management, and job application tracking — designed using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQL Server**.

---

## 🔧 Technologies Used

### ✅ Development Tools
- **Visual Studio 2022** – IDE for .NET development  
- **ASP.NET Core MVC** – Framework for backend and front-end logic  
- **Entity Framework Core** – ORM used for database operations  
- **SQL Server LocalDB** – Local relational database  
- **GitHub** – For version control  
- **Trello** – Task and sprint management  
- **Postman** – For testing APIs and HTTP endpoints  

---

## 🖼️ Wireframes

Wireframes were created to outline the layout and structure of the application before development.

![Wireframe 1](https://github.com/user-attachments/assets/6fbb9f92-4f23-476e-b4d2-bb196356443f)  
![Wireframe 2](https://github.com/user-attachments/assets/da75789f-3cb5-42b4-a15f-05fe4d8c33a5)  
![Wireframe 3](https://github.com/user-attachments/assets/91c8627d-e09c-47d9-ad5e-b694b3f603b6)  
![Wireframe 4](https://github.com/user-attachments/assets/2a1dc458-ad11-40c4-8f8f-1eac5fe5efc8)  
![Wireframe 5](https://github.com/user-attachments/assets/eefcfd84-fb88-4c43-8ee5-dd48b7037213)  
![Wireframe 6](https://github.com/user-attachments/assets/4d79110b-e0a5-4e80-9d7a-00443d36aee7)  
![Wireframe 7](https://github.com/user-attachments/assets/be5e6a48-bb03-4b44-856a-b6d2c7ba3a5e)

---

## 🧠 ER Diagram

This diagram shows the relationship between entities like JobSeeker, Company, Job, and Application.

![ER Diagram](https://github.com/user-attachments/assets/4b0fe723-905a-4bb1-85e7-f17732225d1b)

---

## 🔄 Data Flow Diagrams

### Level 0 DFD
Provides a high-level overview of system interaction.

![Level 0 DFD](https://github.com/user-attachments/assets/acd18373-0686-4903-b6bc-be1f93c98298)

### Level 1 DFD
Details user registration, job listing, and application data flows.

![Level 1 DFD]![image](https://github.com/user-attachments/assets/731c0aa9-0872-435a-91a6-7c1893fde209)


---

## 🧩 Class Diagram

Shows how classes are structured and related in the system.

![Class Diagram](https://github.com/user-attachments/assets/652ad1ed-b145-4d5c-85ea-5097186a636e)

---

## ⏱️ Sequence Diagram

Demonstrates the step-by-step flow for specific processes like job application or posting.

![Sequence Diagram](https://github.com/user-attachments/assets/51083ca8-1d78-4d3a-b7d3-025364a1dfd4)

---

## 🎭 Use Case Diagram

Illustrates the functionality available to each type of user.

![Use Case Diagram](https://github.com/user-attachments/assets/93288433-2403-481a-8fed-bf985ecc56f7)

---

## 🧱 Architecture

The application is developed using **MVC (Model-View-Controller)** architecture:

- **Model**: Represents the business logic and database structure.
- **View**: Razor view files render UI dynamically.
- **Controller**: Handles user input, fetches data, and returns views.

---

## 🔑 Key Features

- Role-based Authentication: Admin, Company, and Job Seeker
- Company Dashboard: Post, update, delete, and view job applications
- Job Seeker Dashboard: Browse and apply to job listings
- Admin Dashboard: Track statistics like total companies, job seekers, and jobs
- Pagination for job listing views
- Form validation and security checks



