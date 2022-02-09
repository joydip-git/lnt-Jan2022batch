--select * from Customers
--create function GetCustomersWithNullRegion()
--returns table
--as
--return (select * from Customers where Region is null)

--select * from Customers where Region is null


-- show the record of a customer with given customer id
-- scalar, inline table valued (single SQL statement), multi-statement table valued
-- create function GetCustomerDetail(@custid nchar(5))
-- returns TABLE
-- as
-- return (select * from Customers where CustomerID=@custid)

--select * from GetCustomerDetail('ANATR')
--select * from GetCustomerDetail('ALFKI')

--select City from Customers where customerid=@custid

-- scalar UDF which is accepting a parameter
--create function GetCustomerCity(@custid nchar(5))
--returns nvarchar(15)
--as 
--begin
--return (select City from Customers where customerid=@custid)
--end

--print dbo.GetCustomerCity('ALFKI')
--select dbo.GetCustomerCity('ANATR') as CITY_NAME

-- calling UDF from another UDF
--create function GetCustomerCities(@custid nchar(5))
--returns table
--as
--return (select * from Customers where City=dbo.GetCustomerCity(@custid))

--select * from GetCustomerCities('ANATR')
