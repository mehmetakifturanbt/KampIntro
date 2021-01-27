--Select 
--ANSII standardı
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City ='Berlin'

--case insensitive
sElEcT * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc --ascending (artan sıra) --desc(descending-azalan sıra)

select count(*) Adet from Products where CategoryID=2

select CategoryID,count(*) from Products group by CategoryID

select CategoryID,count(*) from Products group by CategoryID having count(*)<10 

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10 
order by Products.UnitPrice

--DTO Data Transformation Object

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


