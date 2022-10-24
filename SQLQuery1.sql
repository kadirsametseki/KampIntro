Select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10




select p.ProductName [Ürün Adı], sum(od.UnitPrice*od.Quantity) [Kazanılan Toplam Miktar]
from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
group by p.ProductName


select p.ProductName as [Ürün Adı], sum(od.UnitPrice*od.Quantity) as [Kazanılan Toplam Miktar]
from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
group by p.ProductName




SELECT SUM(products.UnitPrice)
FROM products



select Products.ProductID, Products.ProductName,Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice<10
--group by Products.ProductID, Products.ProductName,Products.UnitPrice, Categories.CategoryName 


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID= od.OrderID


select * from Customers l left join Orders o
on l.CustomerID = o.CustomerID
where o.CustomerID is null




--SELECT COUNT(CustomerID), Country
--FROM Customers
--GROUP BY Country
--HAVING COUNT(CustomerID) > 5
--ORDER BY COUNT(CustomerID) DESC;