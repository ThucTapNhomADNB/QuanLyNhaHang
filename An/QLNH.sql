
USE QLNHAHANG
go 
CREATE TABLE Account(
	Id int IDENTITY(1,1) PRIMARY KEY,
	UserName varchar(50) ,
	DisplayName varchar(100) ,
	PassWords varchar(50) ,
	Type int  --1:admin, 0: staff 
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
	Status int, --1: còn, 0: hết
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


alter table Bill add 
Total int 

select * from TableMenu

insert MenuCategory 
values (N'Món Khai Vị'),(N'Món Chính'),(N'Món tráng miệng'),(N'Đồ Uống') 
go
insert Menu (Name,Price,Status,IdCategory) 
values(N'Súp gà','50000',1,1),
(N'Súp bò','50000',1,1)

insert Menu (Name,Price,Status,IdCategory) 
values(N'Mon 1','50000',1,2),
(N'Mon 2','50000',1,2)

insert Menu (Name,Price,Status,IdCategory) 
values(N'Thạch','10000',1,3),
(N'Mon 2','50000',1,3),
(N'Mon 3','50000',1,3),
(N'Mon 4','50000',1,3),
(N'Mon 5','50000',1,3)

insert Menu (Name,Price,Status,IdCategory) 
values(N'Coca','10000',1,4),
(N'Pepsi','10000',1,4),
(N'Mước cam','10000',1,4),
(N'Bò húc','10000',1,4)

select * from Menu where IdCategory=1




insert Bill(IdTable,DateCheckIn, Status) values (6,'1/5/2018',0)

insert BillInfo(IdBill, IdMenu, Count) values (1,1,1)

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
 update Bill set Total = where id =
 select * from MenuCategory