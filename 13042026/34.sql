SELECT c.ContactName, c.Address
FROM Customers c
WHERE c.CustomerID IN (
    SELECT o.ShipVia
FROM Orders o
WHERE o.ShipVia IN (
        SELECT *
FROM Shippers s
WHERE s.CompanyName = 'Speedy Express'
    )
)