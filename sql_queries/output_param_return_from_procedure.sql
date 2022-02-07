alter procedure GetMaximumProductPrice
@name nvarchar(40) output
as

declare @maxprice money
set @maxprice= (select MAX(UnitPrice) from Products)
print @maxprice
--declare @name nvarchar(40)
set @name=(select ProductName from Products where UnitPrice=@maxprice)
--return @name
--select ProductName from Products where UnitPrice=@maxprice
return @maxprice
go

declare @res nvarchar(40)
declare @p int
exec @p= GetMaximumProductPrice @res output
print @res
print @p