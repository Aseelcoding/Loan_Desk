# LoanDesk

LoanDesk is a Windows Forms desktop application for managing campus equipment loans. It helps staff track borrowers, equipment inventory, loan due dates, returns, lost items, and unpaid fees.

> **Project status:** Under development. Core account, record-management, loan, return, lost-equipment, and fee workflows are being developed and refined. Automated tests and a complete end-to-end verification pass are still needed.

This is a learning project focused on separating the user interface, business rules, and database access while applying practical validation, authentication, and data-integrity practices.

## Features

- **Accounts:** first-run Admin setup, login/logout, password changes, and user sessions.
- **User management:** add, update, activate, and deactivate accounts with Admin restrictions for protected operations.
- **Borrower management:** maintain borrower records and view loan/fine-related information.
- **Equipment inventory:** manage equipment, total quantity, availability, daily late fees, and replacement costs.
- **Loans:** create and search/filter loans by relevant fields, dates, and status.
- **Returns and lost equipment:** record returns, calculate late fees, and mark active loans as lost with a replacement fee.
- **Fee tracking:** record whether a loan's fee has been paid; borrowers with unpaid fees cannot create new loans.
- **Dashboard:** active-user count and daily-loan statistics.
- **Audit log:** record selected user and loan actions for traceability.

## Current implementation

The project is still being refined. The following describes the intended/current scope, not a claim that every workflow has passed end-to-end testing.

### Implemented areas

- First-run setup for the initial Admin account and login/session handling.
- Password hashing with a per-user random salt.
- Business-layer validation for important user and loan rules.
- Parameterized SQL commands through ADO.NET.
- Separate UI, business logic, and data-access layers.
- User, borrower, and equipment management screens.
- Loan creation with a database transaction that also updates available inventory.
- Loan search/filtering, including dates and loan status.
- Return and lost-loan operations in the business layer, with database transactions for related record updates.
- Late-fee and replacement-fee calculations.
- Audit entries for selected account and loan actions.

### Known limitations and next steps

- Run and document end-to-end tests for creating loans, returning items, marking items lost, paying fees, and borrowing again.
- Verify that all loan state changes and inventory updates remain correct under repeated actions and concurrent use.
- Review role checks consistently across all business operations.
- Expand audit coverage and verify what happens if an audit entry cannot be saved after a business operation succeeds.
- Add automated tests for business rules and edge cases.
- Review password-hashing strength before using the application beyond a learning environment.
- Improve setup documentation and continue polishing the UI.

## Screenshots

### Initial Administrator Setup

![Setup form](UI_Screenshots/SetupForm.png)

Shown when the database does not yet contain an Admin account. The setup screen validates the initial account details and password requirements.

### Login

![Login form](UI_Screenshots/LoginForm.png)

Users sign in with their username and password. Successful authentication creates a user session.

### Dashboard

![Dashboard](UI_Screenshots/DashboardForm.png)

The main window provides navigation to the application sections. The dashboard displays active-user count and daily-loan statistics.

### Users

![Users form](UI_Screenshots/UsersForm.png)

Manage user accounts, roles, and active status, with search and filtering.

### Borrowers

![Borrowers form](UI_Screenshots/BorrowersForm.png)

Manage borrower details and review borrower-related loan and unpaid-fee information.

### Equipment

![Equipment form](UI_Screenshots/EquipmentsForm.png)

Manage equipment records, total quantity, available quantity, daily late fees, and replacement costs.

### Loans

![Loans form](UI_Screenshots/LoansForm.png)

Review loan records, including borrower, equipment, quantity, dates, status, late fee, and payment status.

### My Account

![Account view](UI_Screenshots/AccountView.png)

View the signed-in account details and log out.

## Architecture

The application separates presentation, business logic, and database access:

```
Windows Forms UI
       ↓
Business Logic Layer (BLL)
       ↓
Data Access Layer (DAL)
       ↓
SQL Server
```

| Component | Responsibility |
|---|---|
| **UI** | Displays screens, collects input, and presents results. |
| **BLL** | Applies validation, authentication/session rules, and business logic. |
| **DAL** | Executes database operations against SQL Server. |
| **Models** | Represents entities such as `User`, `Borrower`, `Equipment`, `Loan`, and `AuditLog`. |

The intended dependency flow is UI → BLL → DAL. Business rules should be enforced in the BLL rather than relying only on UI controls.

## Technology stack

- C#
- .NET Framework 4.8
- Windows Forms
- SQL Server
- ADO.NET (`System.Data.SqlClient`)
- ReaLTaiizor UI components
- Visual Studio

## Getting started

### Requirements

- Windows
- Visual Studio with the **.NET desktop development** workload
- SQL Server (SQL Server Express is suitable for local development)
- SQL Server Management Studio or another tool for running the database script

### Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/Aseelcoding/Loan_Desk.git
   ```

2. Open `Loan_Desk.slnx` in Visual Studio.
3. Restore the NuGet packages.
4. Run `Database/schema.sql` in SQL Server to create the `LoanDeskDB` database and its schema.
5. Copy `App.config.example` to `App.config` and replace `YOUR_SERVER_NAME` with the name of your SQL Server instance.
6. Build and run the application. If no Admin account exists, the first-run setup screen should appear.

The local `App.config` is excluded from source control so that machine-specific connection settings are not committed.

## Security and data integrity

- Passwords are not stored as plain text; the current implementation uses SHA-256 with a random per-user salt.
- SQL commands use parameters rather than concatenating user input into query strings.
- Session changes are restricted to the business layer through access modifiers.
- Validation and important business rules are handled in the BLL.
- Loan creation, return, and lost-equipment workflows use database transactions for related database updates.

**Password-hashing limitation:** salted SHA-256 is fast and is not recommended for production password storage. A production application should use a password-hashing algorithm designed to resist guessing attacks, such as PBKDF2, bcrypt, or Argon2, with appropriate parameters.

This project is a learning application and has not been presented as production-ready. Authorization coverage, audit-log reliability, concurrency behavior, and automated test coverage still need further verification.

## Project structure

```
Loan_Desk/
├── Login/             Login screen
├── Setup/             First-run Admin setup
├── Main Screen/       Main window and navigation
├── Users/             User management view
├── Borrowers/         Borrower management view
├── Equipment/         Equipment inventory view
├── Loans/             Loan management view
├── Returns/           Return workflow view
├── Fines/             Fee workflow view
├── AuditLog/          Audit log view
├── Account/           Current account and logout
├── Dashboard/         Dashboard and statistics
├── Controls/          Shared UI controls
├── BLL/               Business logic and validation
├── DAL/               SQL Server data access
├── LoanDesk.Models/   Application entities and exceptions
├── utilities/         Shared helpers
├── Database/          Database schema script
├── UI_Screenshots/    README screenshots
├── App.config.example Example database configuration
├── ErrorHandler.cs
└── Program.cs
```

## What this project demonstrates

- Layered application design.
- Windows Forms UI composition with reusable controls.
- Input validation and business-rule enforcement.
- Parameterized database access and transaction usage.
- Authentication, sessions, and role-based restrictions.
- Inventory and loan lifecycle management.

## Author

**Aseel** — [@Aseelcoding](https://github.com/Aseelcoding)
