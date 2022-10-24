--Select
--ANSII
Select * from Customers
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='London'

--case insensitive
sEleCT * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>10

Select * from Products order by CategoryID,ProductName

select * from Products where CategoryID=1 order by UnitPrice desc    --asc ascending   -desc  descending

select count(*) Adet from Products

select count(*) Adet from Products where CategoryID=2

select CategoryID,count(*) Adet from Products group by CategoryID

select CategoryID,count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

--DTA Data Transformation object
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
