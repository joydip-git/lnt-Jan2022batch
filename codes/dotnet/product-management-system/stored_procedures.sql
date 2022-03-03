--create procedure GetAllProducts
--as 
--begin
--select * from products
--end

--create procedure GetProductById
--@pid int
--as
--begin
--select * from products where productid=@pid
--end

--create procedure GetPoductsByName
--@pname varchar(50)
--as
--begin
--select * from products where productname like '@pname%'
--end

--create procedure GetProductsByCategoryId
--@cid int
--as
--begin
--select * from products p where categoryid=@cid
--end

--create procedure InsertProduct
--@pname varchar(50),
--@price decimal(18,2),
--@desc varchar(max),
--@releasedate date,
--@imgpath varchar(max),
--@rating decimal(2,1),
--@cid int
--as
--begin
--insert into products(productname,price,description,releasedate,imagepath,rating,categoryid) values(@pname,@price,@desc,@releasedate,@imgpath,@rating,@cid)
--end

--create procedure UpdateProduct
--@pid int,
--@pname varchar(50),
--@price decimal(18,2),
--@desc varchar(max),
--@releasedate date,
--@imgpath varchar(max),
--@rating decimal(2,1),
--@cid int
--as
--begin
--update products set productname=@pname, price=@price, description=@desc, @releasedate=@releasedate,imagepath=@imgpath,rating=@rating,categoryid=@cid where productid=@pid
--end

--create procedure DeleteProduct
--@pid int
--as
--begin
--delete from products where productid=@pid
--end