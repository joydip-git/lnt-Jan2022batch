--select * from Products
--select * from  Categories

--create view FILTEREDPRODUCTS
--as
--select p.ProductName, p.UnitPrice, c.CategoryName from Products p
--inner join Categories c on p.CategoryID=c.CategoryID
--where p.UnitsInStock>100

--alter view FILTEREDPRODUCTS
--as
--select p.ProductName as Product, p.UnitPrice as Price, c.CategoryName as Category from Products p
--inner join Categories c on p.CategoryID=c.CategoryID
--where p.UnitsInStock>100

--select * from FILTEREDPRODUCTS

--create function FilterProducts(@units smallint)
--returns TABLE
--as
--return (select p.ProductName as Product, p.UnitPrice as Price, c.CategoryName as Category from Products p inner join Categories c on p.CategoryID=c.CategoryID where p.UnitsInStock>@units)

--select * from FilterProducts(80)

--create procedure FilterandJoinProducts
--@units smallint
--as
--begin
--select p.ProductName as Product, p.UnitPrice as Price, c.CategoryName as Category from Products p inner join Categories c on p.CategoryID=c.CategoryID where p.UnitsInStock>@units
--end

--exec FilterandJoinProducts 100

--select p.ProductName, p.UnitPrice, c.CategoryName from Products p
--inner join Categories c on p.CategoryID=c.CategoryID
--where p.UnitsInStock>100

--customer (customerid, accountid)
--account (accountid)

--create view customerbalance
--as
--begin
--select c.customername, a.accountbalance from customers c join accounts a on c.accountid=a.accountid

--select * from customerbalance
/*
 customername		accountbalance
 ----------------------------------------
 joydip				1000
 vinod				2000
*/


