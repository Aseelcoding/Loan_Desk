# LoanDesk

LoanDesk is a Windows Forms desktop application for managing campus equipment lending. It is being developed as a learning project focused on C#, SQL Server, layered architecture, validation, and reliable application behavior.

**Status:** Under development  
**Current development focus:** Finishing the Users module and continuing the Borrowers module.

## Current Features

### Authentication and account management
- First-run setup flow to create the initial Admin account when no active Admin exists.
- Login flow and shared current-user session.
- Logout and application restart flow.
- Password hashing with SHA-256 and a randomly generated salt.
- Username and password validation in the Business Logic Layer.
- User roles currently supported by the code: `Admin` and `Staff`.

### Users
- Add users, update user details, and change passwords.
- Activate and deactivate user accounts using `IsActive` rather than physically deleting them.
- Count active users and active Admin accounts.
- Check Admin permissions in the Business Logic Layer for protected user operations.
- Prevent changing the only active Admin into a Staff account.
- Handle changes to the currently logged-in user's role through an application restart flag.

### Borrowers
- List borrowers with passport number, phone number, active status, active-loan count, and unpaid-fine information.
- Add and update borrower records.
- Look up borrowers by ID or passport number.
- Validate borrower names, passport numbers, and phone numbers in the Business Logic Layer.
- Check passport-number uniqueness.
- Activate and deactivate borrower records.

The Borrowers module is still under development; its implementation and database behavior need further testing and refinement.

### Application infrastructure
- Layered separation between the Windows Forms UI, Business Logic Layer (BLL), Data Access Layer (DAL), and Models project.
- Parameterized SQL commands for database operations.
- SQL exception mapping to application-specific data-access exceptions.
- Centralized UI error handling for validation errors, business-rule errors, data-access errors, and unexpected exceptions.
- Basic logging for technical and unexpected errors.
- Reusable `UserControl` views within the main application window.

## Modules Planned or Still in Progress

The repository contains UI sections for Equipment, Loans, Returns, Fines, Dashboard, and Audit Log. Their presence in the project does not mean the complete workflows are implemented.

Remaining work includes:
- Finish and test Users behavior and filtering.
- Complete and test Borrowers behavior.
- Implement Equipment management.
- Implement the loan and return workflows and related business rules.
- Implement fine handling.
- Complete dashboard statistics and audit logging.
- Review authorization across all modules.
- Add automated tests and improve configuration and password-storage security.

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
SQL Server
```

- **UI:** Displays data, collects input, handles navigation, and presents results and errors.
- **BLL:** Applies validation, authentication, authorization, and business rules.
- **DAL:** Executes database queries and commands.
- **LoanDesk.Models:** Contains application models and custom exceptions.

## Technology Stack

- C#
- .NET Framework 4.8
- Windows Forms
- Microsoft SQL Server
- ADO.NET
- ReaLTaiizor UI controls
- Visual Studio
- Git and GitHub

## Security Notes

The project currently uses parameterized SQL commands, salted SHA-256 password hashes, active/inactive account flags, and Business Logic Layer checks for protected user operations.

**Security limitation:** SHA-256 is a fast general-purpose hash and is not recommended as a standalone password-hashing algorithm for production applications. Replacing it with a password-specific, deliberately slow algorithm is planned. The application is a work in progress and has not been presented as production-ready.

## Error Handling

The application defines custom exceptions for validation, business-rule, and data-access failures. The UI error handler displays expected validation and business-rule messages, logs data-access and unexpected errors, and avoids showing raw unexpected exception messages to users.

The handling and logging behavior will continue to evolve as more modules are implemented.

## Project Structure

The main folders and files currently include:

```text
Loan_Desk
├── Account/
├── AuditLog/
├── Borrowers/
├── BLL/
│   ├── BorrowersBLL.cs
│   ├── PasswordHasher.cs
│   ├── Sessions.cs
│   └── UserBLL.cs
├── DAL/
│   ├── BorrowersDAL.cs
│   ├── SqlErrorMapper.cs
│   └── UserDAL.cs
├── Dashboard/
├── Equipment/
├── Fines/
├── LoanDesk.Models/
├── Loans/
├── Login/
├── Main Screen/
├── Returns/
├── Setup/
├── Users/
├── utilities/
├── ErrorHandler.cs
├── Program.cs
└── Loan_Desk.csproj
```

## Development Roadmap

- [x] Layered project structure
- [x] SQL Server data-access foundation
- [x] Initial Admin setup flow
- [x] Login and shared session
- [x] Basic user creation, updating, activation, and deactivation
- [x] Basic Borrowers operations
- [ ] Finish Users filtering, edge cases, and consistency checks
- [ ] Finish and test Borrowers
- [ ] Implement Equipment management
- [ ] Implement Loans, Returns, and Fines workflows
- [ ] Complete authorization checks across modules
- [ ] Complete Dashboard and Audit Log functionality
- [ ] Add unit and integration tests
- [ ] Improve password-storage security
- [ ] Final configuration and UI cleanup

## Development Approach

This project is built incrementally. Each feature is used to practice the reasoning behind validation, session state, authorization, database integrity, exception handling, and separation of responsibilities between layers.

## Author

**Aseel**  
GitHub: [Aseelcoding](https://github.com/Aseelcoding)

---

**LoanDesk is under active development. Features and implementation details may change.**
