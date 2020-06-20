create database BTL_QuanLyBanHang
go

use BTL_QuanLyBanHang
go

create table NhanVien(
	maNV nchar(20) primary key not null,
	tenNV nvarchar(30),
	chucVu nvarchar(20),
	luongCoBan float,
	phuCap float
)

create table TaiKhoan(
	maNV nchar(20) not null primary key,
	username nchar(20) not null,
	pass nchar(30) not null,
	quyenTruyCap nvarchar(15) not null,
	constraint FK_tk foreign key (maNV) references NhanVien(maNV)
)
drop table quanLyKhachHang

create table SanPham(
	maSP nchar(20) primary key not null,
	tenSP nvarchar(40),
	donGia float,
	soLuong int
)

create table HoaDon(
	maHD nchar(15) primary key not null,
	maNV nchar(20) constraint FK_maNV1 foreign key (maNV) references NhanVien(maNV),
	maKH nchar(15),
	tenKH nvarchar(50),
	ngayLap date,
	diaChi nvarchar(30)
)

create table ChiTietHoaDon(
	maHD nchar(15),
	maSP nchar(20) constraint FK_maSP foreign key (maSP) references SanPham(maSP),
	soLuongBan int
)
drop table ChiTietHoaDon
create table KhachHang(
	maKH nchar(15) not null primary key,
	tenKH nvarchar(30),
	diaChi nvarchar(30),
	soDT int,
	loaiKH nvarchar(30)
)

create table ThongKe(
	ngayLap date,
	tongDoanhThu float
)
select * from ChiTietHoaDon

Select * from TaiKhoan where username=N'+' and pass = N'"+tk.Pass+ "' and quyenTruyCap=N'" + tk.QuyenTruyCap + "'"