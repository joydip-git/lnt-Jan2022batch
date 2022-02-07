-- use lntdb
insert into DEPARTMENTS(department_id, department_name) values(3,'OTHERS')

select * from DEPARTMENTS
select * from EMPLOYEES

-- inner join
--select d.department_name, e.employee_name
--from DEPARTMENTS d 
--inner join EMPLOYEES e 
--on d.department_id = e.dept_id
--order by d.department_name

-- left outer join
--select d.department_name, e.employee_name
--from DEPARTMENTS d 
--left outer join EMPLOYEES e 
--on d.department_id = e.dept_id
--order by d.department_name

-- ISNULL function
select d.department_name, ISNULL( e.employee_name,'NA')
from DEPARTMENTS d 
left outer join EMPLOYEES e 
on d.department_id = e.dept_id
order by d.department_name

-- left outer join with group by
select d.department_name as DEPT_NAME, count(e.employee_name) as EMP_COUNT
from DEPARTMENTS d 
left outer join EMPLOYEES e 
on d.department_id = e.dept_id
group by d.department_name
order by d.department_name

--right outer join
select  e.employee_name, d.department_name
from DEPARTMENTS d 
right outer join EMPLOYEES e 
on d.department_id = e.dept_id
order by d.department_name

-- full outer join
select  e.employee_name, d.department_name
from EMPLOYEES e
full outer join DEPARTMENTS d
on d.department_id = e.dept_id
order by d.department_name


