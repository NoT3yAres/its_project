SELECT c.ContactName
FROM Customers c
WHERE c.CustomerID IN (
    SELECT o.CustomerID
FROM Orders o
WHERE o.OrderID IN (
        SELECT od.OrderID
FROM [Order Details] od
WHERE od.ProductID IN (
            SELECT p.ProductID
FROM Products p
WHERE p.UnitPrice < 50
        )
    )
)