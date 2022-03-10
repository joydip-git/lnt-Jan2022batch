create table products(
productid int primary key not null,
productname varchar(50) not null,
price decimal(18,2) default(0),
description varchar(max)
)

create procedure GetProducts
as
begin
select * from products
end

create procedure GetProductById
@productid int
as
begin
select * from products where productid = @productid
end

create procedure AddProduct
@productid int,
@productname varchar(50),
@price decimal(18,2),
@description varchar(max)
as
begin
insert into products(productid,productname,price,description) values(@productid,@productname,@price,@description)
end