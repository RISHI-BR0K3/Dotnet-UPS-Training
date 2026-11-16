USE StockManagementDB;
GO

SELECT * FROM Products
WHERE Price > 3000;
GO

SELECT * FROM Products
WHERE Stock <= 15;
GO

SELECT * FROM Products
WHERE Category != 'Stationery';
GO

SELECT * FROM Products
WHERE Category IN ('Electronics', 'Stationery');
GO

SELECT * FROM Products
WHERE Category NOT IN ('Electronics', 'Stationery');
GO

SELECT TOP 5 * FROM Products
ORDER BY ProductID;
GO

SELECT * FROM Products
WHERE ExpiryDate IS NULL;
GO

SELECT * FROM Products
WHERE ExpiryDate IS NOT NULL;
GO

SELECT * FROM Products
WHERE Price BETWEEN 500 AND 8000;
GO

SELECT * FROM Products
WHERE Price NOT BETWEEN 500 AND 8000;
GO

SELECT * FROM Products
WHERE ProductName LIKE 'C%';
GO