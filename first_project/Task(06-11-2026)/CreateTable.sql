USE KareDB

CREATE TABLE Department
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(50) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Student
(
    StudentID int PRIMARY KEY,
    StudentName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Gender VARCHAR(10),
    DOB DATE,
    Fees DECIMAL(10,2),
    DepartmentID INT,
    Status VARCHAR(10) DEFAULT 'Active',
    CreatedAt DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Student_Department
    FOREIGN KEY (DepartmentID)
    REFERENCES Department(DepartmentID)
);