--use northwinddb
select * from categories
select * from products

--inner join
select  c.CategoryName, p.ProductName
from Categories c 
join Products p 
on c.CategoryID=p.CategoryID
order by c.CategoryName

--outer (left, right, full)

