CREATE DATABASE QuanlySV
USE QuanlySV
set dateformat dmy 
drop table SinhVien
create table Lop(
	MaLop char(3) primary key not null,
	TenLop nvarchar(30)
);
create table SinhVien(
	MaSV char(6) primary key not null,
	HotenSV nvarchar(40),
	Ngaysinh datetime,
	MaLop char(3) not null
);
alter table SinhVien
	add constraint fk_MaLop foreign key (MaLop)
		references Lop (MaLop);
select * from SinhVien