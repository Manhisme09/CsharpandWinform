use master 
go

create database TestEntity
go

use TestEntity
go

create table Lop
(
	malop nchar(10) primary key,
	tenlop nvarchar(20)
)
go

create table SinhVien
(
	masv nchar(10) primary key,
	tensv nchar(20),
	malop nchar(10),
	constraint FK_sv_lop foreign key (malop)
		references Lop(malop)
)
go

insert into Lop values('L01',N'Lớp 1')
insert into Lop values('L02',N'Lớp 2')
insert into Lop values('L03',N'Lớp 3')
insert into Lop values('L04',N'Lớp 4')

insert into SinhVien values('SV01',N'Mạnh','L01')
insert into SinhVien values('SV02',N'nam','L01')
insert into SinhVien values('SV03',N'Ngu','L01')
insert into SinhVien values('SV04',N'NAm','L01')

insert into SinhVien values('SV05',N'Mạnh','L02')
insert into SinhVien values('SV06',N'Pháo','L02')
insert into SinhVien values('SV07',N'Mạnh1','L02')
insert into SinhVien values('SV08',N'Cà','L02')

insert into SinhVien values('SV09',N'Hải','L03')
insert into SinhVien values('SV10',N'Mạnh','L03')
insert into SinhVien values('SV11',N'Áo','L03')
insert into SinhVien values('SV12',N'Mạnh4','L03')

insert into SinhVien values('SV13',N'Nam','L04')
insert into SinhVien values('SV14',N'Mạnh','L04')
insert into SinhVien values('SV15',N'Tuân','L04')
insert into SinhVien values('SV16',N'Bỉ','L04')

select * from Lop
select * from SinhVien