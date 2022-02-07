select ContactName, CompanyName, City from Customers where City='Berlin' or City='México D.F.' or City='London'

-- use IN operator to avoid multiple OR conditions in SELCT, INSERT, UPDATE or DELETE statements
select ContactName, CompanyName, City from Customers where City IN ('Berlin','México D.F.', 'London')

--NOT is used to negate
select ContactName, CompanyName, City from Customers where City NOT IN ('Berlin','México D.F.', 'London')

--BETWEEN (fetch values within a specified range)
select * from Products where UnitPrice BETWEEN 60 and 200

--IS NULL checking records with NULL value

select * from customers where Fax IS NULL
select * from customers where Region IS NOT NULL

--LIKE (pattern matching)
-- %: match any string of any length
-- -: match single character
-- []: match on any chararacter in the brackets[abc]
-- [^]: match on any character not in the brackets [^abc]

-- name starts with letter A
select * from Customers  where ContactName LIKE 'A%'

-- name ends with letter A
select * from Customers  where ContactName LIKE '%A'

-- name containing letter A
select * from Customers  where ContactName LIKE '%A%'

select * from Customers  where ContactName LIKE 'M[^AC]%'

select * from Customers  where ContactName LIKE 'M[AI]%'

select * from Customers  where ContactName NOT LIKE 'M[AI]%'


