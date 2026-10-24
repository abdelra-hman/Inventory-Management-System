# 📦 Inventory Management System

A desktop-based **Inventory Management System** developed using **C# Windows Forms (.NET 10)** and **Microsoft SQL Server**.

The application is designed to simplify inventory operations by providing an organized interface for managing products, users, and other inventory-related activities.

This project is developed as part of a university coursework assignment, focusing on desktop application development, database integration, and CRUD operations.

## 🚀 Features

### 🔐 Authentication & Authorization
- User Login and Registration
- Role-Based Access Control (RBAC)
- Admin and Employee roles
- Different interfaces based on user permissions

### 📦 Product Management
- Add new products
- View product information
- Update existing products
- Delete products
- Manage product details

### 👥 User Management
- Manage system users
- Assign user roles
- Control access based on permissions

### 🖥️ User Interface
- Windows Forms desktop application
- Admin dashboard
- Navigation between different forms
- User-friendly interface

> **Note:** The project is currently under development. Some features are planned or partially implemented.

---

## 🛠️ Tech Stack

| Technology | Purpose |
|---|---|
| C# | Application Development |
| .NET 10 | Application Framework |
| Windows Forms | Desktop GUI |
| Microsoft SQL Server | Relational Database |
| ADO.NET | Database Connectivity |
| Visual Studio | Development Environment |
| Git & GitHub | Version Control |

---

## 🏗️ System Architecture

The application follows a database-driven desktop architecture.

```text
┌─────────────────────────────┐
│          User               │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│     Windows Forms UI        │
│                             │
│  • Login / Registration     │
│  • Admin Dashboard          │
│  • Products Form            │
│  • User Management          │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│      C# Application         │
│                             │
│  • Business Logic           │
│  • Input Validation         │
│  • CRUD Operations          │
│  • Role-Based Access        │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│         ADO.NET             │
│     Database Connection     │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│     Microsoft SQL Server    │
│                             │
│  • Users                    │
│  • Products                 │
│  • Inventory Data           │
└─────────────────────────────┘
```

---

## 🔑 User Roles

The system is designed to support two primary user roles.

### 👨‍💼 Admin
- Access the admin dashboard
- Manage products
- Manage system users
- Perform administrative operations

### 👨‍💻 Employee
- Access authorized application features
- View and manage inventory based on assigned permissions
- Perform daily inventory operations

---

## ⚙️ Installation & Setup

### Prerequisites

Make sure the following tools are installed:

- Windows 10/11
- Visual Studio 2022 or later with .NET desktop development support
- .NET 10 SDK
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)

### 1. Clone the Repository

```bash
git clone <repository-url>
```

### 2. Open the Project

Open the solution file (`.sln` or `.slnx`) using Visual Studio.

### 3. Configure the Database

1. Create the required database in SQL Server.
2. Create the necessary tables.
3. Configure the SQL Server connection string in the application.
4. Ensure SQL Server is running.

### 4. Run the Application

Build and run the project using Visual Studio.

```text
Build → Build Solution
Debug → Start Debugging
```

---

## 📸 Screenshots

Application screenshots will be added as development progresses.

- Login Form
- Registration Form
- Admin Dashboard
- Products Management Form
- User Management Form

---

## 📋 Development Status

🚧 **Under Development**

| Module | Status |
|---|---|
| Login & Authentication | 🟡 In Progress |
| Registration | 🟡 In Progress |
| Admin Dashboard | 🟡 In Progress |
| Product Management | 🟡 In Progress |
| User Management | 🔴 Planned |
| Database Integration | 🟡 In Progress |
| Testing & Validation | 🔴 Planned |

---

## 🎯 Project Objectives

- Apply Object-Oriented Programming concepts using C#.
- Develop a desktop application using Windows Forms.
- Implement CRUD operations with SQL Server.
- Practice relational database integration.
- Implement role-based access control.
- Improve software development and debugging skills.

---

## 🔮 Future Improvements

- Inventory stock tracking
- Low-stock notifications
- Product search and filtering
- Sales and purchase management
- Inventory reports
- Dashboard statistics
- Improved input validation and error handling

---

## 👨‍💻 Developer

**Abdelrahman Samir**

Software Engineering Student  
Faculty of Computers & Information  
Mansoura University

**GitHub:** [abdelra-hman](https://github.com/abdelra-hman)

---

## 📄 License

This project is developed for educational purposes.