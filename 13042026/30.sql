SELECT p.ProductName
FROM Products p
    INNER JOIN
    Categories c ON c.CategoryID = p.CategoryID
WHERE c.CategoryName LIKE 'Condiments';


SELECT p.ProductName
FROM Products p
WHERE p.CategoryID IN 
    (
        SELECT c.CategoryID
FROM Categories c
WHERE c.CategoryName LIKE 'Condiments'
    ) 
