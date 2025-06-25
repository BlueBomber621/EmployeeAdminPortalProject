# Employee Admin Portal

A simple ASP.NET Core Web API for managing employees, built with .NET 8 and Entity Framework Core.

## Features

- CRUD operations for employees (Create, Read, Update, Delete)
- RESTful API endpoints
- Swagger UI for API documentation and testing

## Technologies

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core (SQL Server)
- Swagger (Swashbuckle)

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (local or remote, recommend Microsoft SQL Server)

### Setup

1. **Clone the repository:**

git clone <your-repo-url> cd EmployeeAdminPortalProject

2. **Configure the database connection:**
   - Add a `appsettings.json` file in the project root with:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=...;Database=...;Trusted_Connection=True;"
       }
     }
     ```
   - Adjust the connection string as needed for your environment.

3. **Apply database migrations:**

Update migrations with the Package Manager Console

4. **Run the application:**

5. **Access the API:**
   Access via the port shown within the terminal!

## API Endpoints

- `GET /api/employees` - List all employees
- `GET /api/employees/{id}` - Get a single employee by ID
- `POST /api/employees` - Add a new employee
- `PUT /api/employees/{id}` - Update an existing employee
- `DELETE /api/employees/{id}` - Delete an employee

## Notes

- Make sure to add a design-time DbContext factory if you encounter issues running migrations.
- Do not commit sensitive information (like real connection strings) to version control.

## License

This project is licensed under the MIT License.
