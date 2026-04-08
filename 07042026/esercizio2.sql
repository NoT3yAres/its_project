--SELECT p.ProductName, od.Quantity
--FROM Products p
--INNER JOIN [Order Details] od
--ON p.ProductID = od.ProductID;

--SELECT s.SupplierID, ProductName, CompanyName
--FROM Products p
--INNER JOIN Suppliers s
--ON s.SupplierID = p.SupplierID
--WHERE CompanyName IN ('Exotic Liquids', 'Specialty Biscuits, Ltd.', 'Escargots Nouveaux')
--ORDER BY s.SupplierID;

--SELECT s.SupplierID, CompanyName, CategoryName, ProductName, UnitPrice
--FROM Products p
--INNER JOIN Suppliers s
--ON s.SupplierID = p.SupplierID
--INNER JOIN Categories c
--ON c.CategoryID = p.CategoryID


--SELECT *
--FROM [Order Details] od
--INNER JOIN Orders o 
--ON od.OrderID = o.OrderID
--INNER JOIN Customers c
--ON c.CustomerID = o.CustomerID;



--SELECT DISTINCT c.CategoryName, p.ProductName, p.QuantityPerUnit, p.UnitsInStock, p.Discontinued
--FROM Categories c
--WHERE Discontinued = 0
--INNER JOIN Products p
--ON c.CategoryID = p.CategoryID
--ORDER BY c.CategoryName, p.ProductName;
