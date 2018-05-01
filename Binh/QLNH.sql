


CREATE TABLE Account(
	Ma int IDENTITY(1,1) PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL,
	Gt NVARCHAR(10),
	Diachi NVARCHAR(100) ,
	Username varchar(50),
	Passwords varchar(50),
)

create table MonAn(
	MaMA int IDENTITY(1,1) PRIMARY KEY,
	TenMA nvarchar(50),
	Gia int,
	TinhTrang BIT
)

create table KhachHang(
	MaKH int IDENTITY(1,1) PRIMARY KEY,
	TenKH nvarchar(50),
	SDT varchar(20),
	DiaChi nvarchar(200)
)

create table Ban(
	MaBan int IDENTITY(1,1) PRIMARY KEY,
	TenBan nvarchar(100),
	TrangThai bit,
	KhuVuc nvarchar(50)
)

create table HoaDon(
	MaHD int IDENTITY(1,1) PRIMARY KEY,
	MaKH int references KhachHang(MaKH),
	Ma int references Account(MA),
	MaBan int references Ban(MaBan),
	TongTien int,
	Ngay date
)

create table CT_HoaDon(
	MaHD int references HoaDon(MaHD),
	MaMA int references MonAn(MaMA),
	SoLuong int,
	primary key (MaHD, MaMA)
)


go

/*create trigger TotalHD(@MaHD int)
returns int 
as 
begin
declare @total int;
set @total= SUM(Gia) 
		   from MonAn 
		   where(select MaMA 
				  from CT_HoaDon 
				  where MaHD=@MaHD)

select SUM(Gia) from MonAn */

create trigger TongHD
on HoaDon
for update, insert
as
begin
declare @tong int
select
@tong=SUM(Gia) from MonAn 

BEGIN
 DECLARE @age int
 DECLARE @EmployeeID int
 SELECT
  @age=YEAR(GETDATE())-year(BirthDate),
  @EmployeeID=EmployeeID
 FROM inserted
 IF UPDATE (BirthDate)
 UPDATE Employees
  SET Age = @age
 WHERE EmployeeID=@EmployeeID
END