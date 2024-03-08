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
	iddoituong nvarchar(50) default 0,
	foreign key (iddoituong) references doituong(iddoituong),
)
go

insert into dbo.hanghoa values(N'',N'',N'',N'',N'',N'')
go

select * from doituong
go

DROP TABLE dbo.phieuxuat
go

DELETE FROM doituong
WHERE ten = N'Duc Dep Trai'
go
