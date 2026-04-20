SELECT c.ContactName
FROM Customers c
WHERE c.CustomerID NOT IN (
    SELECT o.CustomerID
FROM Orders o
)

--SKIPPATOOOOO
