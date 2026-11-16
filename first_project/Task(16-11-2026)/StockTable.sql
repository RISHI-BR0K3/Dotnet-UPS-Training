USE StockManagementDB;
GO
 
CREATE TABLE Products (
    ProductID    INT IDENTITY(1,1) PRIMARY KEY,
    ProductName  VARCHAR(100)   NOT NULL,
    Category     VARCHAR(50)    NOT NULL,
    Price        DECIMAL(10,2)  NOT NULL,
    Stock        INT            NOT NULL,
    ExpiryDate   DATE           NULL
);
GO