**Project Overview**
This is an ASP.NET Core MVC application that connects to a SQL Server database. The application provides user registration, login, and basic CRUD (Create, Read, Update, Delete) functionality. It is built using the Model-View-Controller (MVC) architecture and leverages Entity Framework Core for database operations.

**Features**
User can create new product in to the application. CRUD Operations: Perform Create, Read, Update, and Delete operations on data. Validation: Client-side and server-side validation for forms. Responsive Design: Built with Bootstrap for a mobile-friendly interface. SQL Server Integration: Uses Entity Framework Core to interact with a SQL Server database.

****Prerequisites Before running the application, ensure you have the following installed.**
.NET SDK (version 8.0 or later) Visual Studio 2022 (or later) or Visual Studio Code SQL Server (LocalDB or full SQL Server) SQL Server Management Studio (SSMS) (Optional, for database management).

****Setup Instructions** 
Clone the repository to your local machine.

**Configure the Database** 
Open the appsettings.json file and update the connection string to point to your SQL Server instance.

"ConnectionStrings": { "DefaultConnection": "Server=your-server-name;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True;" }

Replace your-server-name with your SQL Server instance name (e.g., (localdb)\MSSQLLocalDB for LocalDB). Replace YourDatabaseName with the desired database name.

**Run the following commands to create and apply migrations:-** 
dotnet ef migrations add InitialCreate 
dotnet ef database update This will create the database and apply the necessary schema.

**Run the Application**
Open the project in Visual Studio or Visual Studio Code.

**Build the project:** 
dotnet build

**Run the application:** 
dotnet run

Open your browser and navigate to: https://localhost:5001
