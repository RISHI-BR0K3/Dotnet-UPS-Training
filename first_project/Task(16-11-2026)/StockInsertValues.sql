use StockManagementDB;

INSERT INTO Products (ProductName, Category, Price, Stock, ExpiryDate) VALUES
('Laptop',             'Electronics', 55000.00,  10, NULL),
('Smartphone',         'Electronics', 22000.00,  25, NULL),
('Cordless Mouse',     'Electronics',   799.00,  40, NULL),
('Camera',             'Electronics',  9500.00,   8, NULL),
('Notebook',           'Stationery',     60.00, 200, NULL),
('Ball Pen Pack',      'Stationery',    120.00, 150, NULL),
('Chart Paper',        'Stationery',     45.00,  15, NULL),
('Calculator',         'Stationery',    650.00,  30, NULL),
('Chocolate Box',      'Grocery',       450.00,  12, '2027-03-15'),
('Cooking Oil',        'Grocery',       180.00,  60, '2027-01-10'),
('Cereal Pack',        'Grocery',       320.00,   5, '2026-12-30'),
('Office Chair',       'Furniture',    7500.00,  14, NULL),
('Study Table',        'Furniture',    8000.00,   6, NULL),
('Curtains',           'Home Decor',   3500.00,  20, NULL),
('Cough Syrup',        'Medicine',      210.00,  18, '2027-06-01');
GO