CREATE DATABASE QLNS
USE QLNS

CREATE TABLE SACH
(
	MaSach		nchar(10)PRIMARY KEY,
	TenSach		nchar(100),
	TheLoai		nchar(50),
	TacGia		nchar(100),
	SoLuongTon	int,
)


CREATE TABLE PHIEUNHAP
(
	MaPhieuNhap	nchar(10)PRIMARY KEY not null,
	NgayNhap datetime,
)

CREATE TABLE CHITIETPHIEUNHAP
(
	MaChiTietPhieuNHap	nchar(10)PRIMARY KEY not null,
	MaPhieuNhap	nchar(10)FOREIGN KEY REFERENCES PHIEUNHAP(MaPhieuNhap),
	MaSach	nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongNhap	int,
)

CREATE TABLE KHACHHANG
(
	MaKhachHang	nchar(10)PRIMARY KEY not null,
	HoTenKhachHang nchar(100),
	DiaChi nchar(100),
	DienThoai nchar(20),
	Email nchar(50),
	SoTienNo float
)

CREATE TABLE HOADON
(
	MaHoaDon	nchar(10)PRIMARY KEY not null,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NgayLapHoaDon datetime,
	TongThanhTien int
)

CREATE TABLE CHITIETHOADON
(
	MaChiTietHoaDon	nchar(10)PRIMARY KEY not null,
	MaHoaDon nchar(10)FOREIGN KEY REFERENCES HOADON(MaHoaDon),
	MaSach nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongBan int,
	DonGiaBan float,
)

CREATE TABLE PHIEUTHUTIEN
(
	MaPhieuThu	nchar(10)PRIMARY KEY not null,
	SoTienThu float,
	NgayThuTien datetime,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
)

CREATE TABLE BAOCAOTON
(
	MaChiTietTon	nchar(10)PRIMARY KEY not null,
	Thang int,
	Nam int,
	MaSach nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	TonDau int,
	TonPhatSinh int,
	TonCuoi int,
)

CREATE TABLE BAOCAOCONGNO
(
	MaChiTietCongNo	nchar(10)PRIMARY KEY not null,
	Thang int,
	Nam int,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NoDau float,
	NoCuoi float,
	NoPhatSinh float,
)

CREATE TABLE THAMSO
(
	MaThamSo	int identity(1,1) PRIMARY KEY not null,
	SoLuongNhapItNhat int,
	SoLuongTonToiDaTruocNhap int,
	SoLuongTonSauToiThieu int,
	SoTienNoToiDa float,
	SuDungQuyDinh4 int,
)

CREATE TABLE NGUOIDUNG
(
	MaNguoiDung	int identity(1,1) PRIMARY KEY,
	NguoiDung nchar(10),
	MatKhau nchar(10),
)

insert into NGUOIDUNG values('Admin',123456)
insert into NGUOIDUNG values(N'Hùng',15520277)
insert into NGUOIDUNG values(N'Hưng',15520285)

insert into THAMSO values(150,300,20,20000,1)
