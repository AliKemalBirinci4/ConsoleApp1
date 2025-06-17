--Select 
--Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers


--Select * from Customers where City = 'London'


--case insensitive
select * from Products where CategoryId =1 or categoryId = 3

select * from Products where CategoryId =1 and UnitPrice > 15

select * from Products where CategoryId=3	order by UnitPrice desc --ascending --descending


select CategoryId,count(*) from products where UnitPrice>20 group by CategoryId having count(*)<10

select products.productId , products.productname , products.Unitprice , categories.CategoryName 
 from products inner join categories on products.CategoryID = categories.CategoryID
 where Products.UnitPrice>10


 --DTO Data Transformation Object

 select * from Product  left join [Order Details] on Product.ProductID = [Order Details].ProductID

 select * from Customers c left join Orders o on c.CustomerId = o.CustomerID
 where o.customerID is null







