-- a table valued function: the UDF accepts zero or more parameters and returns a table variable
-- a. inline table-valued UDF
-- b. mutli-statement table-valued UDF

-- inline table-valued UDF: contain single statement and that single statement should be a select statement. the result of the query (a result set) becomes the return value of the function (the result set is stored in a temporary table). there is no need of BEGIN...END statement in inline function
-- create function GetAllProducts(@price money)
-- returns TABLE
-- as
--  return (select * from products where UnitPrice>@price)

-- the GetAllProducts is known as "inline" table valued, since the function must be called as prt of the query. the function is called within the query directly without "dbo"
-- when th function is called, it returns a table with results
-- you need to use that table in a query

-- select * from GetAllProducts(100)

-- mutli-statement table-valued UDF: contains multiple SQL statements, enclosed in BEGIN...END blocks.

--select * from products

alter function GetProductUnitPriceStatistics(@unitsinstock smallint)
returns @Statistics TABLE
(
  max_price money,
  min_price money,
  avg_price money
)
as
begin

declare @maxprice money
declare @minprice money
declare @avgprice money

select @maxprice= max(UnitPrice) from products where UnitsInStock>@unitsinstock
select @minprice = min(UnitPrice) from Products where UnitsInStock>@unitsinstock
select @avgprice= avg(UnitPrice) from Products where UnitsInStock>@unitsinstock

insert into @Statistics (max_price, min_price, avg_price)  values(@maxprice, @minprice, @avgprice)

return
end

--select * from GetProductUnitPriceStatistics(50)









--select * from products