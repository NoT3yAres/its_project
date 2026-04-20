SELECT c.ContactName
FROM Customers c
WHERE c.CustomerID  NOT IN (
    SELECT o.CustomerID
FROM Orders o
);

SELECT c.ContactName
FROM Customers c
    LEFT JOIN
    Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL;