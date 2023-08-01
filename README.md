# AuthAPI - Authentication and Authorization Web API

This is a web API built with .NET 6 that provides authentication and authorization functionality using an identity framework with an in-app database. The API allows users to log in and generate JWT tokens for accessing protected resources. The API also implements role-based access control, allowing only users with the "Admin" and "BackOffice" roles to access certain endpoints.

Prerequisites
.NET 6 SDK: Make sure you have .NET 6 SDK installed on your machine.
Getting Started
Clone the repository to your local machine.
Navigate to the AuthApi directory.
Database Setup
Before running the API, ensure you have set up the database:

Open a terminal or command prompt.
Navigate to the AuthApi directory.
Run the following command to create the database and apply migrations:
bash
Copy code
dotnet ef database update --project AuthApi --startup-project AuthApi --msbuildprojectextensionspath .
JWT Token Configuration
To enable JWT token generation and authentication, you need to replace the placeholders with the actual values for JWT token configuration in the Program.cs file:

csharp
Copy code
// Replace the following placeholders with actual values for JWT token configuration
const string issuer = "your-issuer";
const string audience = "your-audience";
const string secretKey = "your-secret-key";
Replace your-issuer, your-audience, and your-secret-key with your desired values.

Build and Run the API
Open a terminal or command prompt.
Navigate to the AuthApi directory.
Run the following command to build the API:
bash
Copy code
dotnet build
Run the following command to start the API:
bash
Copy code
dotnet run --project AuthApi --urls=https://localhost:5001
Testing the API
You can now test the API using a tool like Postman or any other HTTP client:

Use your HTTP client to send a POST request to https://localhost:5001/api/auth/login with the following JSON body:
json
Copy code
{
  "username": "FrontOffice",
  "password": "your-password"
}
Replace your-password with the password for the "FrontOffice" user.

The API will respond with a JWT token. Copy the token.

Use the JWT token to access protected endpoints. Include the token in the Authorization header as a Bearer token for requests to endpoints that require authentication.

Role-Based Access
The API implements role-based access control. Users with the roles "Admin" and "BackOffice" will be able to access certain endpoints, while other users will be denied access.
