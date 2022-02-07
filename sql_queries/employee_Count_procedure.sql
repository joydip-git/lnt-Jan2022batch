--alter procedure GetEmployeeCount
--@salary decimal(10,2) /*input parameter*/
--as
--begin
--declare @result int
--select @result= COUNT(employee_name) from EMPLOYEES where employee_salary>@salary
--return @result
--end

alter procedure GetEmployeeCount
@salary decimal(10,2) /*input parameter*/,
@empcount int output
as
begin

--declare @result int
--select @result= COUNT(employee_name) from EMPLOYEES where employee_salary>@salary
--set @empcount=@result

select @empcount = count(employee_name) from EMPLOYEES where employee_salary>@salary
end