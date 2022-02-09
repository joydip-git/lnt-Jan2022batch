-- possible to call UDF from procedure
create procedure ShowProducts
@price money
as
begin
select * from GetAllProducts(@price)
end

-- exec ShowProducts 100

-- not possible to call procedure from UDF
--create function ViewProducts(@price money)
--returns TABLE
--as
--return exec ShowProducts @price