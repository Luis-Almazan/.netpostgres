# .netpostgres
Conexion a Postgressql


para instalar un proyecto para la conexion a postgres se tiene que instalar la siguiente libreria 

dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.0


dotnet tool install --global dotnet-ef

dotnet ef dbcontext scaffold "Host=10.1.6.172;Database=admin;Username=postgres;Password=Manager1" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
