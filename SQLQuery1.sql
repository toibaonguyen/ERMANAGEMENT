create database Erestaurant
use Erestaurant

create table Foodanddrink
(
IDmonan varchar(10) primary key,
TEN nvarchar(225),
COST money,
anh varchar(max)
)
create table Khachhang
(
IDkhachhang varchar(10) primary key,
TEN nvarchar(225),
Ngaydangky smalldatetime
)
create table bill
(
IDbill varchar(10) primary key,
IDkhachhang varchar(10) FOREIGN KEY REFERENCES Khachhang(IDkhachhang),
ngay smalldatetime 
)
create table staff
(
CMND varchar(10) primary key,
TEN nvarchar(225),
ngaybatdaulam smalldatetime,
ngaysinh smalldatetime,
chucvu nvarchar(20),
anh  varchar(max)
)

create table orders
(
IDmonan varchar(10) FOREIGN KEY REFERENCES Foodanddrink(IDmonan) ,
IDbill varchar(10) FOREIGN KEY REFERENCES bill(IDbill),
soluong int
)


create table accountad
(
username varchar(20),
pass varchar(20)
)

alter table staff add constraint CK_CV check (chucvu='Chief' or chucvu='Waiter')


