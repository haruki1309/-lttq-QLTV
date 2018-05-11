Create Database QuanLyThuVien
Go

Use QuanLyThuVien
Go



/*=========== Tạo bảng ===========*/

Create Table ThuThu
(
	MaThuThu char(5) Primary key,
	HoTen nvarchar(20),
	DiaChi nvarchar(50),
	SDT varchar(15),
	CMND varchar(15),
	Email varchar(50),
	NgayVL smalldatetime,
	Pass varchar(50)
)

Create Table DocGia
(
	MaDocGia char(5) Primary key,
	HoTen nvarchar(20),
	DiaChi nvarchar(50),
	SDT varchar(15),
	CMND varchar(15),
	NgaySinh smalldatetime,
	NgayDK smalldatetime
)

Create Table Sach
(
	MaSach char(5) Primary key,
	TenSach nvarchar(50),
	MaTacGia char(5),
	NamXB int,
	MaNXB char(5),
	MaNhaPhatHanh char(5),
	NgayNhap smalldatetime,
	MaChuDe char(5),
	MaTheLoai char(5),
	GiaTri money,
	SoLuong int
)

Create Table TacGia
(
	MaTacGia char(5) Primary key,
	HoTen nvarchar(20),	
	NamSinh int,
	NamMat int
)

Create Table CTTG
(
	MaTacGia char(5),
	ButDanh nvarchar(20),
	NamSuDung int

	Primary Key (MaTacGia, ButDanh)
)

Create Table NXB
(
	MaNXB char(5) Primary key,
	TenNXB nvarchar(20),
	DiaChi nvarchar(50),
	SDT varchar(15),
	Email varchar(50)
)

Create Table NhaPhatHanh
(
	MaNhaPhatHanh char(5) Primary key,
	TenNhaPhatHanh nvarchar(50),
	SDT varchar(15),
	DiaChi nvarchar(50)
)

Create Table ChuDe
(
	MaChuDe char(5) Primary key,
	TenChuDe nvarchar(20)
)

Create Table TheLoai
(
	MaTheLoai char(5) Primary key,
	TenTheLoai nvarchar(20)
)

Create Table PhieuMuon
(
	MaPhieuMuon char(5) Primary key,
	MaDocGia char(5),
	MaThuThu char(5),
	NgayMuon smalldatetime,
	SoLuong int
)

Create Table CTPM
(
	MaPhieuMuon char(5),
	MaSach char(5)

	Primary key (MaPhieuMuon, MaSach)
)

Create Table PhieuTra
(
	MaPhieuTra char(5) Primary key,
	MaDocGia char(5),
	MaThuThu char(5),
	NgayTra smalldatetime,
	SoLuong int
)

Create Table CTPT
(
	MaPhieuTra char(5),
	MaSach char(5),
	MaTinhTrang char(5)

	Primary key (MaPhieuTra, MaSach)
)

Create Table TinhTrang
(
	MaTinhTrang char(5) Primary key,
	TenTinhTrang nvarchar(10)
)


/*====================*/
set dateformat dmy



/*========== Tạo Procedure ===========*/

Create Procedure SuaDocGia
	@MaDocGia char(5),
	@HoTen nvarchar(20),
	@DiaChi nvarchar(50),
	@SDT varchar(15),
	@CMND varchar(15),
	@NgaySinh smalldatetime	
As
Begin
	Update DocGia Set
		HoTen = @HoTen,
		DiaChi = @DiaChi,
		SDT = @SDT,
		CMND = @CMND,
		NgaySinh = @NgaySinh
	Where MaDocGia = @MaDocGia
End
Go


Create Procedure XoaDocGia
	@MaDocGia char(5)
As
Begin
	Delete DocGia
	Where MaDocGia = @MaDocGia
End
Go

select * from DocGia