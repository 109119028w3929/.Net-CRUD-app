CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;

CREATE TABLE Employees
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Department NVARCHAR(100),
    Salary DECIMAL(10,2)
);