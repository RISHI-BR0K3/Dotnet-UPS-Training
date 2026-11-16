use KareDB;

UPDATE Student
SET Fees = 15000
WHERE DepartmentID = 2;

UPDATE Student
SET Status = 'Inactive'
WHERE StudentID = 105;

UPDATE Student
SET Email = 'newemail@gmail.com'
WHERE StudentID = 104;

UPDATE Student
SET Fees = Fees + 2000
WHERE DepartmentID = 1;