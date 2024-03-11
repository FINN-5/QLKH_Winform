create database QLKH
go
use QLKH
go

create table doituong
(
	iddoituong nvarchar(50) not null primary key,
	ten nvarchar(50),
	dienthoai nvarchar(50),
	diachi nvarchar(100),
	kieu int --0 la ad, 1 la nv
)
go

create table hanghoa
(
	idhang nvarchar(50) not null primary key,
	ten nvarchar(100),
	loaihang nvarchar(100),
	gianhap nvarchar(50) default 0,
	giaxuat nvarchar(50) default 0,
	iddoituong nvarchar(50),
	foreign key (iddoituong) references doituong(iddoituong),
)
go


update hanghoa set idhang=N'2', ten=N'dasua', loaihang=N'Ngol' where idhang=N'1'
go

select idhang as 'Mã hàng hóa', ten as 'Tên hàng hóa', loaihang as 'Phân loại' from hanghoa
go

DROP TABLE dbo.phieuxuat
go

DELETE FROM hanghoa
WHERE iddoituong = N'ad'
go
insert into dbo.doituong values(N'ad',N'admin',N'0999',N'HaNoi',0)
go


insert into dbo.hanghoa(idhang,ten,loaihang,iddoituong) values(N'1',N'2',N'3', N'ad')
go

DELETE FROM hanghoa;

select * from hanghoa;