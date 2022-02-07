-- where, group by, order by, having, select

-- group by

-- the nane of columns that appear in the select clause must appear in the broup by clause
select City, COUNT(ContactName) as Contacts from Customers
group by City
order by City DESC

select ProductName, ProductID, MAX(UnitPrice) AS MAX_UNIT_PRICE from Products
group by ProductName, ProductID
order by ProductName ASC

-- aggregate function
-- MAX, MIN, COUNT, SUM, AVG etc.

select MAX(UnitPrice) as MAX_UNIT_PRICE from Products
select MIN(UnitPrice) as MIN_UNIT_PRICE from Products
select AVG(UnitPrice) as AVG_UNIT_PRICE from Products
select COUNT(ProductName) as NO_Of_PRODUCTS from products

select * from Products
where UnitsInStock>40
order by UnitPrice ASC

-- having: mention conditions for a group or an aggregate. can work ONLY with select statements and generally used with groyp by clause
-- having is used mainly to apply condition on each group created by group by clause, after the group is created
-- where clause is used before group is created, and also result of aggregate function can't be used with where (where is used to validate each and every row/record)
-- where clause can't use aggregate function as part of the condition, whereas having clause can use the aggregate function as pat of the condition

select * from [Order Details]
select * from orders
--select  customerid, orderid, sum(freight) as total from orders
--group by CustomerID, OrderID

select orderid, sum(unitprice) as order_total from [Order Details]
--where sum(unitprice)>50
group by orderid
having sum(UnitPrice)>100

-- 10248:  34.80=58.60
-- 
