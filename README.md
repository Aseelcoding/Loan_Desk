# LoanDesk

LoanDesk is a campus equipment loan management system designed to manage the lending and returning of equipment such as laptops, projectors, cameras, and other campus resources.

The project is being developed as a practical C# Windows Forms application with a focus on layered architecture, database management, authentication, and maintainable code.

> **Status:** Under Development
> **Current Progress:** Approximately 40%

---

## Overview

LoanDesk is designed to manage the equipment lending process and organize:

* Users
* Borrowers
* Equipment
* Loans
* Returns
* Fines
* Audit Logs

The main goal of the project is not only to build a working application, but also to apply software engineering concepts learned from previous projects and improve the overall architecture and code quality.

---

## Current Progress

### Implemented

* User authentication
* Initial Admin account setup
* Password hashing and salt generation
* User validation in the Business Logic Layer
* User session management
* Parameterized SQL queries
* Basic 3-layer architecture
* Main application dashboard
* Navigation between application sections
* Core models for users, borrowers, equipment, and loans
* Reusable `UserControl` based views

### In Progress

* Users management
* Borrowers management
* Equipment management
* Loan management
* Returns
* Fines
* Audit logging
* Role-based access control
* Business rules and validation

### Planned

* Database transactions
* Improved exception handling
* Logging
* Automated testing
* Improved password security
* Better configuration management
* Additional validation and edge-case handling
* Reports
* Final UI/UX improvements

---

## Architecture

LoanDesk follows a layered architecture to separate responsibilities between the user interface, business logic, data access, and models.

```text
Windows Forms UI
       ↓
Business Logic Layer (BLL)
       ↓
Data Access Layer (DAL)
       ↓
SQL Server
```

### Layers

**UI**

Responsible for displaying the interface, receiving user input, and presenting results.

**BLL**

Responsible for validation, authentication, business rules, password handling, and session management.

**DAL**

Responsible for communication with SQL Server and database operations.

**Models**

Contains the main entities used by the application.

---

## Technologies

* C#
* .NET Framework 4.8
* Windows Forms
* SQL Server
* ADO.NET
* ReaLTaiizor
* Visual Studio
* Git & GitHub

---

## Security

Security considerations are being introduced as part of the application's architecture.

Current implementations include:

* Password hashing
* Random salt generation
* Parameterized SQL queries
* User session management
* Separation between UI and business logic

Further security improvements are planned as development continues.

---

## Problems Encountered and Solutions

LoanDesk is also a learning project. Several design problems were encountered during development, and solving them helped improve my understanding of application architecture.

### 1. Creating a Form for Every Section

One problem was deciding how to handle the different sections of the application.

Creating a separate Form for every section would make the main application harder to manage and could lead to unnecessary duplication.

Instead, I started using reusable `UserControl`s for the different sections:

```text
UsersView
BorrowersView
EquipmentView
LoansView
ReturnsView
FinesView
AuditLogView
```

The main screen is responsible for navigation, while each `UserControl` is responsible for its own section.

This made the navigation structure much easier to manage and allowed the different sections to be displayed inside the same main window.

---

### 2. Protecting the User Session from the UI

Another problem was controlling who should be able to modify the current user session.

Allowing Forms to directly modify the session would give the UI too much control over application state.

To solve this, the session modification functionality was restricted using the `internal` access modifier.

This allows the Business Logic Layer to manage the session while preventing the UI from directly changing it.

The intended structure is:

```text
UI
 ↓
Business Logic Layer
 ↓
Session Management
```

instead of:

```text
UI
 ↓
Directly modifying Session
```

This helped reinforce the separation of responsibilities between the UI and the Business Logic Layer.

---

### 3. Keeping Validation Outside the UI

Another lesson was that validation should not depend entirely on the Forms.

For example, user validation is handled in the Business Logic Layer before the data is sent to the Data Access Layer.

This helps prevent business rules from being duplicated across different Forms.

---

## Lessons Learned

Through the development of LoanDesk, I have been able to practice several concepts through actual implementation:

* Separating UI, business logic, data access, and models
* Using `UserControl`s for reusable application views
* Understanding when to use Forms versus UserControls
* Using access modifiers such as `internal` to control access to application state
* Keeping business validation inside the Business Logic Layer
* Using parameterized SQL queries
* Understanding password hashing and salts
* Managing user sessions
* Separating application navigation from individual views
* Thinking about maintainability as the application grows

---

## Project Structure

```text
LoanDesk
│
├── UI
│   ├── Login
│   ├── Setup
│   ├── Main Screen
│   ├── Users
│   ├── Borrowers
│   ├── Equipment
│   ├── Loans
│   ├── Returns
│   ├── Fines
│   └── AuditLog
│
├── LoanDesk.BLL
│   ├── UserBLL
│   ├── PasswordHasher
│   └── Sessions
│
├── LoanDesk.DAL
│   └── UserDAL
│
├── LoanDesk.Models
│   ├── User
│   ├── Borrower
│   ├── Equipment
│   └── Loan
│
└── Utilities
```

---

## Development Philosophy

LoanDesk is being developed as a learning project.

The focus is not simply on making the application work, but on understanding the reasons behind architectural and programming decisions.

Problems discovered during development are treated as opportunities to improve the project and apply better solutions in future projects.

---

## Future Improvements

The remaining development will focus on:

* Completing CRUD operations
* Implementing the main loan workflow
* Adding stronger business rules
* Completing role-based access control
* Adding database transactions
* Improving exception handling
* Adding logging
* Adding automated tests
* Improving password security
* Improving configuration management
* Adding reporting
* Handling more edge cases
* Final UI/UX improvements

---

## Author

**Aseel**

GitHub: [Aseelcoding](https://github.com/Aseelcoding)

---

**LoanDesk is currently under development.**
