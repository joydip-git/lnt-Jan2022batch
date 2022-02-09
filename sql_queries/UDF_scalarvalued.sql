 -- select * from Employees
-- create procedure GetEmployeeById
-- @empid int
-- as
-- begin
-- select FirstName from Employees where EmployeeID=@empid
-- end
-- execute GetEmployeeById 1


-- function must return a value

-- this function is returning a single value: scalar function

-- create function GetEmployeeById(@empid int)
-- returns nvarchar(10)
-- as
-- begin
--	return (select FirstName from Employees where EmployeeID=@empid)
-- end

-- only built-in functions can be called directly
-- UDFs should be called using "dbo" (database object)

--declare @res nvarchar(10)
--set @res = dbo.GetEmployeeById(1)
--print @res

-- UDF name is not case-sensitive
print dbo.getemployeebyid(2)




