SELECT
    e.LastName + e.FirstName as Nome,
    e.Address,
    e.City,
    e.Region
FROM Employees e
WHERE e.EmployeeID IN (
    SELECT o.EmployeeID
FROM Orders o
WHERE o.ShipCountry = 'Belgium'
);



SELECT
    DISTINCT e.LastName + e.FirstName as Nome,
    e.Address,
    e.City,
    e.Region
FROM Employees e, Orders o
WHERE   e.EmployeeID = o.EmployeeID AND
    o.ShipCountry = 'Belgium';