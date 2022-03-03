create table categories(
categoryid int not null primary key identity(1,1),
categoryname varchar(50) not null
)

create table products(
productid int not null primary key identity(100,1),
productname varchar(50) not null,
price decimal(18,2) default(0),
description varchar(max),
imagepath varchar(max),
releasedate date not null,
rating decimal(2,1) default(0),
categoryid int foreign key references categories (categoryid)
)