select p.Name ProductName, c.Name CategoryName
from Production.Product p 
left outer join Production.ProductCategory c
on p.ProductCategoryID = c.ProductCategoryID