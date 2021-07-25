use master
go

create database QLNV
go
 

use QLNV
go

create table chucvu(
	macv nvarchar(2) not null primary key ,
	tencv nvarchar(30)
)

go

create table nhanvien(
	manv nvarchar(4) not null primary key,
	macv nvarchar(2),
	tennv nvarchar(30),
	luong float,
	tinhtrang nvarchar(10)
	
	constraint FK_nhanvien_chucvu foreign key(macv)
		references chucvu(macv) 	
)
go


insert into chucvu values('BV',N'Bảo Vệ')
insert into chucvu values('GD',N'Giám Đốc')
insert into chucvu values('HC',N'Hành Chính')
insert into chucvu values('KT',N'Kế Toán')
insert into chucvu values('TQ',N'Thủ Quỹ')
insert into chucvu values('VS',N'Vệ Sinh')
go

insert into nhanvien values('NV01','GD',N'Nguyễn Văn An',700000,N'tốt')
insert into nhanvien values('NV02','BV',N'Bùi Văn Tí',400000,N'tốt')
insert into nhanvien values('NV03','KT',N'Trần Thanh Nhật',600000,N'kém')
insert into nhanvien values('NV04','VS',N'Nguyễn Thị Út',300000,N'trung bình')
insert into nhanvien values('NV05','HC',N'Lê Thị Hà',500000,N'tốt')
go

select * from chucvu
select * from nhanvien
