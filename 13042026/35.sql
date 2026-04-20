SELECT SUM((od.UnitPrice * od.Quantity) * (1 - od.Discount))
FROM [Order Details] od
WHERE od.OrderID IN (
    SELECT o.OrderID
FROM Orders o
WHERE o.OrderDate BETWEEN '1997-01-01' AND '1997-12-31');
