# LoanDesk

LoanDesk is a campus equipment loan management system designed to manage the lending and returning of equipment such as laptops, projectors, cameras, and other campus resources.

The project is being developed as a practical C# Windows Forms application with a focus on layered architecture, database management, authentication, authorization, maintainable code, and learning software engineering concepts through implementation.

> **Status:** Under Development
> **Current Focus:** Completing the Users module and preparing the core Borrowers and Equipment modules

---

## Overview

LoanDesk is designed to manage:

- Users
- Borrowers
- Equipment
- Loans
- Returns
- Fines
- Audit Logs

The main goal is not only to build a working application, but also to apply software engineering concepts learned from previous projects and improve the architecture and code quality step by step.

---

## Current State

### Completed / Working

- Initial Admin account setup
- User authentication and login
- Password hashing with salt
- User validation in the Business Logic Layer
- Shared user session management
- Restricted session modification using `internal`
- Parameterized SQL queries
- SQL exception mapping
- Improved exception handling across the application
- Global unhandled exception handling
- Basic logging infrastructure
- Layered UI / BLL / DAL / Models structure
- Main application shell and navigation
- Reusable `UserControl` based views
- Account view
- Users add, update, password update, deactivate, and activate operations
- Soft delete using `IsActive`
- User activation
- Active-user count on the dashboard
- Admin authorization for protected user operations
- Admin authorization for protected navigation

### In Progress

- Users module final cleanup and edge cases
- Borrowers management
- Equipment management
- Loans management
- Returns
- Fines
- Dashboard statistics
- Audit logging
- Complete role-based authorization
- Business rules and validation
- Database transactions

### Planned

- Automated unit and integration testing
- Password security hardening
- Improved configuration management
- More complete audit logging
- Reports
- Additional edge-case handling
- Final UI/UX cleanup

---

## Architecture

LoanDesk follows a layered architecture:

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

Responsible for displaying the interface, receiving user input, navigation, and presenting results.

**BLL**

Responsible for validation, authentication, authorization, business rules, password handling, and session management.

**DAL**

Responsible for communication with SQL Server and database operations.

**Models**

Contains the main application entities such as users, borrowers, equipment, loans, and audit logs.

---

## Technologies

- C#
- .NET Framework 4.8
- Windows Forms
- SQL Server
- ADO.NET
- ReaLTaiizor
- Visual Studio
- Git & GitHub

---

## Security

Security is being considered as part of the application architecture.

Current implementations include:

- Password hashing
- Random salt generation
- Parameterized SQL queries
- Active/inactive user control
- Shared user sessions
- Admin checks in the Business Logic Layer
- Separation between UI and business logic

The current password implementation uses SHA-256 with a random salt as a learning implementation. A slow password-specific hashing algorithm is planned for a later security hardening stage.

---

## Problems Encountered and Solutions

LoanDesk is also a learning project. Several design problems were encountered during development, and solving them has helped improve my understanding of application architecture.

### 1. Creating a Form for Every Section

Creating a separate Form for every application section would make navigation harder to manage and could lead to unnecessary duplication.

Instead, LoanDesk uses reusable `UserControl` views inside the main screen:

```text
UsersView
BorrowersView
EquipmentView
LoansView
ReturnsView
FinesView
AuditLogView
```

This keeps the main window responsible for navigation while each view is responsible for its own section.

### 2. Protecting the User Session from the UI

The UI should be able to read the current session but should not directly control its state.

The session uses restricted setters and an internal session creation method so that session changes are controlled from the Business Logic Layer.

```text
UI
 ↓
Business Logic Layer
 ↓
Session Management
```

### 3. Keeping Validation Outside the UI

User validation is performed in the Business Logic Layer before data reaches the Data Access Layer.

This keeps important business rules out of individual Forms and reduces duplicated validation logic.

### 4. Handling Active and Inactive Users

Users are not physically deleted. Instead, the application uses the `IsActive` field to deactivate accounts.

Admins can activate inactive users again, while the login process prevents inactive accounts from signing in.

### 5. Handling the Current Admin Account

Changing the role of the currently logged-in Admin can affect the current application session. LoanDesk therefore treats this as a special case and can restart the application when the current user's role changes.

The database is updated before the application decides whether the current session needs to be recreated or the application restarted.

### 6. Reusable Top Information Panel

A reusable custom panel is used for the top information area of the main screen. Its title changes according to the currently selected view, while the logged-in user's role is displayed separately.

The custom panel also provides access to the Account view.

---

## Error Handling

Error handling has been improved during development and is now separated according to the layer and type of failure.

The application currently uses custom exceptions such as `ValidationException` and `BusinessRuleException` for expected application and business-rule failures.

Database errors are handled in the Data Access Layer, where SQL exceptions can be mapped to application-specific exceptions.

The application also contains global exception handling for unexpected unhandled errors.

Logging is used to record important technical errors while the UI presents appropriate messages to the user.

The error-handling implementation is still being refined as the remaining modules are developed.

---

## Development Roadmap

The project is being developed in stages rather than trying to complete every module at once.

### Phase 1 — Foundation

- [x] Project structure
- [x] Layered architecture
- [x] Database connection
- [x] Models
- [x] Error handling
- [x] Logging infrastructure

### Phase 2 — Authentication and Sessions

- [x] Initial Admin setup
- [x] Login
- [x] Password hashing and salt
- [x] User session
- [x] Session access restrictions
- [x] Basic authorization checks

### Phase 3 — Users

- [x] Add user
- [x] Update user
- [x] Update password
- [x] Soft delete
- [x] Activate user
- [x] Active-user count
- [ ] Finish filtering behavior
- [ ] Finish edge cases and consistency checks
- [ ] Final authorization checks

### Phase 4 — Core Data

- [ ] Borrowers
- [ ] Equipment

### Phase 5 — Loan Workflow

- [ ] Loans
- [ ] Returns
- [ ] Fines
- [ ] Complete loan business rules
- [ ] Database transactions

### Phase 6 — Administration

- [ ] Complete role-based access control
- [ ] Audit Log
- [ ] Dashboard statistics
- [ ] Reports

### Phase 7 — Quality

- [ ] Unit tests
- [ ] Database/integration tests
- [ ] Exception and edge-case review
- [ ] Configuration cleanup
- [ ] Password security hardening
- [ ] Final UI/UX cleanup

---

## Project Structure

```text
LoanDesk
│
├── UI
│   ├── Login
│   ├── Setup
│   ├── Main Screen
│   ├── Account
│   ├── Users
│   ├── Borrowers
│   ├── Equipment
│   ├── Loans
│   ├── Returns
│   ├── Fines
│   └── AuditLog
│
├── BLL
│   ├── UserBLL
│   ├── PasswordHasher
│   └── Sessions
│
├── DAL
│   ├── UserDAL
│   └── SqlErrorMapper
│
├── LoanDesk.Models
│   ├── User
│   ├── Borrower
│   ├── Equipment
│   ├── Loan
│   └── AuditLog
│
└── Utilities
```

---

## Current Learning Focus

The current development focus is not only completing features, but understanding the programming concepts behind them.

The main concepts currently being practiced include:

**Exception handling**

Understanding how exceptions move between DAL, BLL, and UI and deciding which layer should handle each type of error.

**State consistency**

Understanding the difference between database state and application session state, especially when updating the currently logged-in user.

**Validation and business rules**

Separating input validation from rules that belong to the application domain.

**Authorization**

Protecting sensitive operations in the Business Logic Layer instead of relying only on hidden UI controls.

**Resource management**

Improving database connection, command, and reader disposal using appropriate .NET resource-management patterns.

**Database integrity**

Using primary keys, unique constraints, foreign keys, and other database rules together with BLL validation.

---

## Development Philosophy

LoanDesk is being developed as a learning project.

The focus is not simply on making the application work, but on understanding why architectural and programming decisions are made.

Bugs and design problems discovered during development are treated as part of the learning process. The goal is to improve both the application and my understanding of software engineering practices.

The development process follows a simple cycle:

```text
Understand the concept
        ↓
Understand the flow
        ↓
Predict the correct behavior
        ↓
Implement
        ↓
Test
        ↓
Review
```

---

## Author

**Aseel**

GitHub: [Aseelcoding](https://github.com/Aseelcoding)

---

**LoanDesk is currently under development.**
