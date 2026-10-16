# LoanDesk

LoanDesk is a C# Windows Forms desktop application for managing campus equipment lending. It is being developed as a practical project focused on layered architecture, SQL Server data access, validation, and reliable application behavior.

**Status:** Under active development  
**Platform:** Windows desktop

## Current Progress

- **Authentication:** First-run setup for the initial Admin, login/logout, shared user sessions, and salted SHA-256 password hashing.
- **Users:** Create and update users, change passwords, activate/deactivate accounts, support Admin and Staff roles, and apply Business Logic Layer checks to protected operations.
- **Borrowers:** List, add, update, search by ID or passport through the service layer, validate borrower details, check passport uniqueness, and activate/deactivate records. This module still needs further testing and refinement.
- **Equipment:** Add and update equipment, validate quantities and costs, check duplicate names, retrieve equipment records, and activate/deactivate equipment with a check for outstanding loans.
- **Dashboard:** Main navigation and summary cards are present. A daily-loans chart is being integrated; dashboard statistics and chart behavior are not yet complete.
- **Application infrastructure:** Reusable UserControl views, centralized error handling, technical error logging, and SQL exception mapping.

The interface includes navigation for Dashboard, Users, Borrowers, Equipment, Loans, Returns, Fines, and Audit Log. A visible screen or navigation item does not mean its full workflow is complete.

## Architecture

```text
Windows Forms UI
       |
       v
Business Logic Layer (BLL)
       |
       v
Data Access Layer (DAL)
       |
       v
Microsoft SQL Server
```

- **UI:** Collects user input, displays information, and calls BLL methods.
- **BLL:** Handles validation, business rules, and authorization checks.
- **DAL:** Executes parameterized SQL commands and retrieves data.
- **LoanDesk.Models:** Holds shared models and custom exceptions.

## Technology Stack

- C#
- .NET Framework 4.8
- Windows Forms
- Microsoft SQL Server
- ADO.NET
- ReaLTaiizor UI controls
- `System.Windows.Forms.DataVisualization.Charting` for charts
- Visual Studio and Git/GitHub

## Current Priorities

- Finish and test Users filtering and edge cases.
- Complete and test Borrowers behavior.
- Continue Equipment management and validation.
- Implement and test Loans, Returns, and Fines workflows.
- Complete Dashboard statistics and Audit Log functionality.
- Review authorization across modules.
- Add automated tests and improve password-storage security.
- Finish UI consistency and application configuration.

## Security Note

The application uses parameterized SQL commands and salted SHA-256 password hashes. SHA-256 is a fast general-purpose hash and is not recommended as a standalone password-hashing algorithm for production applications. Password-storage hardening remains planned. LoanDesk is a work in progress and is not presented as production-ready.

## Author

**Aseel** — [GitHub: Aseelcoding](https://github.com/Aseelcoding)

---

Features and implementation details may change while the project is under development.
