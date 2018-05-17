

go 

create table Employee(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(50),
	Age int,
	Address nvarchar(50),
	PhoneNumber nvarchar(20)
)
CREATE TABLE Account(
	UserName varchar(50) PRIMARY KEY,
	PassWords varchar(50) ,
	Type int ,  --1:admin, 0: staff 
	IdEmployee int references Employee(Id)
)
go

create table MenuCategory(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(50)
)
go

create table Menu(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(50),
	Price int,
	Status nvarchar(5), --1: còn, 0: hết
	IdCategory int references MenuCategory(Id)
)
go

create table TableMenu(
	Id int IDENTITY(1,1) PRIMARY KEY,
	TableName nvarchar(100),
	Status int ,-- 1: có ng; 0: trống
	Area nvarchar(50) 
)
go

create table Bill(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdTable int references TableMenu(Id),
	DateCheckIn date default getdate(),
	Status int ,--1: đã thanh toán, 0: chưa thanh toán
	Total int 
)
go

create table BillInfo(
	IdBill int references Bill(Id),
	IdMenu int references Menu(Id),
	Count int,
	primary key (IdBill,IdMenu)
)
go

go

declare  @i int =1
while @i<=20
begin
	insert TableMenu (TableName, Status,Area) values (N'Bàn '+cast(@i as nvarchar(20)), 0, N'Tầng 1') 
	set @i = @i+1
end
 go


select * from TableMenu

insert MenuCategory 
values (N'Món Khai Vị'),(N'Món Chính'),(N'Món tráng miệng'),(N'Đồ Uống') 
go
insert Menu (Name,Price,Status,IdCategory) 
values(N'Súp gà','50000',N'Còn',1),
(N'Súp bò','50000',N'Còn',1)

insert Menu (Name,Price,Status,IdCategory) 
values(N'Mon 1','50000',N'Còn',2),
(N'Mon 2','50000',N'Còn',2)

insert Menu (Name,Price,Status,IdCategory) 
values(N'Thạch','10000',N'Còn',3),
(N'Mon 2','50000',N'Còn',3),
(N'Mon 3','50000',N'Còn',3),
(N'Mon 4','50000',N'Còn',3),
(N'Mon 5','50000',N'Còn',3)

insert Menu (Name,Price,Status,IdCategory) 
values(N'Coca','10000',N'Còn',4),
(N'Pepsi','10000',N'Còn',4),
(N'Mước cam','10000',N'Còn',4),
(N'Bò húc','10000',N'Còn',4)


go 




-- trigger bill
create trigger trg_insertBill on Bill for insert
as
begin
	declare @idTable int, @idBill int 
	select @idTable=inserted.IdTable, @idBill=inserted.Id  from inserted
	update TableMenu set Status=@idBill where Id=@idTable
end

go
-- trigger xóa nhan vien
create trigger trg_deleteEmployee on Employee instead of delete 
as begin
	declare @idEmp int 
	select @idEmp=Id from deleted
	delete Account where IdEmployee=@idEmp
	delete Employee where Id=@idEmp

end

go
--  lay thong tin hoa don voi id cho truoc

select m.Id , m.Name , b.Count , m.Price, (m.Price *b.Count ) as N'Thanh Tien'   from BillInfo b,Menu m where IdMenu = m.Id   and IdBill=1



-- proc  chuyen ban
go 
create Proc ChuyenBan(@idOldTable int , @idNewTable int )
as 
begin
	declare @idBill int 
	select @idBill=Status from TableMenu where Id=@idOldTable
	update TableMenu set Status=0 where Id=@idOldTable
	
	update TableMenu set Status=@idBill where Id=@idNewTable
	
	update Bill set IdTable=@idNewTable where Id=@idBill 
end
go
 


 go
 -- proc them mon

 create proc themMon(@idBill int ,@idMenu int, @SoLuong int)
 as begin
	if @idMenu in ( select IdMenu from BillInfo where IdBill=@idBill)
	begin
		update BillInfo set Count= Count + @SoLuong where IdBill= @idBill and IdMenu=@idMenu
	end 
	else
	begin
		insert BillInfo (IdBill, IdMenu, Count) values (@idBill, @idMenu, @SoLuong)
	 
	end
 end

 go


 -- proc thanh toan

 create proc thanhToan(@idTable int, @idBill int)
 as begin
	update TableMenu set Status=0 where id= @idTable
	update Bill set Status = 1 where id=@idBill
 end
 
 go
  insert Account (UserName,PassWords, Type) values('admin','5F4DCC3B5AA765D61D8327DEB882CF99',1 ) -- password



 --------------------------------------------------------------------------------------------------------


 SELECT * FROM dbo.Bill WHERE DateCheckIn>='1/5/2018' AND DateCheckIn<='3/5/2018'


 insert Account (UserName,PassWords,Type,IdEmployee) values ('admin','admin',1)

 SELECT* FROM dbo.Account
 delete Account

 update BillInfo set Count= where IdBill= and IdMenu



 delete BillInfo
 delete Bill

 update TableMenu set Status=0 
 go

 alter table account drop column DisplayName
 select * from Account
 select e.Id, e.Name, e.Address, e.Age, e.PhoneNumber from Employee  e 

 insert Employee( Name,Address,Age,PhoneNumber) values( )
 go
 update Employee set Name=, Address=, Age=, PhoneNumber= where Id=

 go
