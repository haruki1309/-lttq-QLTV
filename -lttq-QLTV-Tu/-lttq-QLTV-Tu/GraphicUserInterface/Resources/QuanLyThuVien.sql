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
	HoTen nvarchar(20)
)

Create Table NXB
(
	MaNXB char(5) Primary key,
	TenNXB nvarchar(50),
)

Create Table NhaPhatHanh
(
	MaNhaPhatHanh char(5) Primary key,
	TenNhaPhatHanh nvarchar(50),
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


/*=================== Insert Dữ liệu =================*/
Insert into ChuDe Values
('CD000', 'Tình yêu'),
('CD001', 'Cuộc sống'),
('CD002', 'Công nghệ'),
('CD003', 'Giả tưởng'),
('CD004', 'Phiêu lưu'),
('CD005', 'Khoa học'),
('CD006', 'Văn học')

Insert into DocGia Values
('DG000', 'Bùi Trung Tín', 'Khu A',	'01285858585', '221425265',	1998-02-08, 2017-08-08),
('DG001', 'Thái Phương Lan', 'Quận 9', '01653434466', '221423568', 1998-03-29, 2017-09-12),
('DG002', 'Lê Đức Anh', 'Linh Đông', '01254477588',	'221455588', 1998-06-04, 2018-05-13), 
('DG003', 'Nguyễn Thị Lan Phương', 'Khu A',	'01684747123', '221433556', 1998-04-20, 2018-05-14), 
('DG004', 'Nguyễn Kỷ Nguyên', 'Khu A', '01243334564', '221533447', 1999-07-20, 2018-05-16) 

Insert into NhaPhatHanh Values
('NPH00',	'Trường Đại Học Công Nghệ Thông Tin'),
('NPH01',	'First News - Trí Việt'),
('NPH02',	'Phương Thu'),
('NPH03',	'Nhà Xuất Bản Trẻ'),
('NPH04',	'Nhà Xuất Bản Thanh Niên'),
('NPH05',	'Nhà Xuất Bản Kim Đồng'),
('NPH06',	'Alphabooks'),
('NPH07',	'Phương Nam')

Insert into NXB Values
('NXB00',	'NXB ĐHQG-HCM'),
('NXB01',	'NXB Tổng hợp Tp. Hồ Chí Minh'),
('NXB02',	'NXB Dân Trí'),
('NXB03',	'NXB Trẻ'),
('NXB04',	'NXB Thanh Niên'),
('NXB05',	'NXB Kim Đồng'),
('NXB06',	'NXB Thế Giới')

Insert into Sach Values
('MS000',	'Xử Lý Ngôn Ngữ Tự Nhiên',	'TG000',	'2006',	'NXB00',	'NPH00',	2017-03-20,	'CD002',	'TL003',	16000.00,	30),
('MS001',	'Đắc Nhân Tâm',	'TG003',	'2016',	'NXB01',	'NPH01',	2017-03-02,	'CD001',	'TL002',	45600.00,	40),
('MS002',	'Code Dạo Kí Sự',	'TG004',	'2017',	'NXB02',	'NPH02',	2017-05-01,	'CD002',	'TL003',	159000.00,	20),
('MS003',	'Cà Phê Cùng Tony',	'TG005',	'2017',	'NXB03',	'NPH03',	2017-05-01,	'CD001',	'TL002',	90000.00,	20),
('MS004',	'Ngày xưa có một chuyện tình',	'TG002',	'2017',	'NXB03',	'NPH03',	2018-05-10,	'CD006',	'TL004',	86000.00,	30)

Insert into TacGia Values
('TG000',	'Nguyễn Tuấn Đăng'),
('TG001',	'Nguyễn Ngọc Tư'),
('TG002',	'Nguyễn Nhật Ánh'),
('TG003',	'Dale Carnegie'),
('TG004',	'Phạm Huy Hoàng'),
('TG005',	'Tony Buổi Sáng'),
('TG006',	'Nhiều tác giả'),
('TG007',	'Tô Hoài'),
('TG008',	'Uyên Uyên'),
('TG009',	'Liêu Hà Trinh')

Insert into TheLoai Values
('TL000',	'Tiểu thuyết'),
('TL001',	'Kinh tế'),
('TL002',	'Kỹ năng'),
('TL003',	'Giáo trình'),
('TL004',	'Truyện ngắn'),
('TL005',	'Tản văn'),
('TL006',	'Truyện tranh'),
('TL007',	'Thơ ca')

Insert into TinhTrang Values
('TT000', 'Tốt'),
('TT001', 'Hỏng nhẹ'),
('TT002', 'Hỏng nặng'),
('TT003', 'Mất')



/*========== Tạo Procedure ===========*/
/*== Procedure Độc giả == */

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


/*== Procedure Sách ==*/
Create Procedure GetFullSach
As
Begin
	Select MaSach, TenSach, HoTen, NamXB , TenNXB, TenNhaPhatHanh, NgayNhap, TenChuDe, TenTheLoai, GiaTri, SoLuong 
	From Sach, TacGia, NXB, NhaPhatHanh, ChuDe, TheLoai
	Where (Sach.MaTacGia = TacGia.MaTacGia) and (Sach.MaNXB = NXB.MaNXB) and (Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh)
		  and (Sach.MaChuDe = ChuDe.MaChuDe) and (Sach.MaTheLoai = TheLoai.MaTheLoai)
End
Go


Create Procedure GetSach_DieuKien
	@DieuKien nvarchar(50)
As
Begin
	declare @Sql nvarchar(1000)
	
	Set @Sql = 'Select * From
	(Select MaSach, TenSach, HoTen, NamXB , TenNXB, TenNhaPhatHanh, NgayNhap, TenChuDe, TenTheLoai, GiaTri, SoLuong 
	From Sach, TacGia, NXB, NhaPhatHanh, ChuDe, TheLoai
	Where (Sach.MaTacGia = TacGia.MaTacGia) and (Sach.MaNXB = NXB.MaNXB) and (Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh)
		  and (Sach.MaChuDe = ChuDe.MaChuDe) and (Sach.MaTheLoai = TheLoai.MaTheLoai)) as A
	Where ' + @DieuKien
	
	Exec(@Sql)
End
Go


Create Procedure LocSach
	--@DieuKienLoc varchar(200)
As
Begin
	Declare @Sql varchar(1000)	
	Set @Sql =  'select MaSach' + @DieuKienLoc + ' From
				(Select MaSach, TenSach, HoTen, TenNXB, TenNhaPhatHanh, TenChuDe, TenTheLoai From Sach, TacGia, NXB, NhaPhatHanh, ChuDe, TheLoai
				Where (Sach.MaTacGia = TacGia.MaTacGia) and (Sach.MaNXB = NXB.MaNXB) and (Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh)
				and (Sach.MaChuDe = ChuDe.MaChuDe) and (Sach.MaTheLoai = TheLoai.MaTheLoai)) as A'
	Exec(@Sql)
End
Go

Create Procedure ThemSach
	@MaSach char(5),
	@TenSach nvarchar(50),
	@MaTacGia char(5),
	@NamXB int,
	@MaNXB char(5),
	@MaNhaPhatHanh char(5),
	@NgayNhap smalldatetime,
	@MaChuDe char(5),
	@MaTheLoai char(5),
	@GiaTri money,
	@SoLuong int
As
Begin
	Insert Into Sach
	Values (@MaSach, @TenSach, @MaTacGia, @NamXB, @MaNXB, @MaNhaPhatHanh, @NgayNhap, @MaChuDe, @MaTheLoai, @GiaTri, @SoLuong)
End
Go


Create Procedure CapNhatSach
	@MaSach char(5),
	@TenSach nvarchar(50),
	@MaTacGia char(5),
	@NamXB int,
	@MaNXB char(5),
	@MaNhaPhatHanh char(5),
	@NgayNhap smalldatetime,
	@MaChuDe char(5),
	@MaTheLoai char(5),
	@GiaTri money,
	@SoLuong int
As
Begin
	Update Sach
	Set TenSach = @TenSach,
		MaTacGia = @MaTacGia,
		NamXB = @NamXB,
		MaNXB = @MaNXB,
		MaNhaPhatHanh = @MaNhaPhatHanh,
		NgayNhap = @NgayNhap,
		MaChuDe = @MaChuDe,
		MaTheLoai = @MaTheLoai,
		GiaTri = @GiaTri,
		SoLuong = @SoLuong
	Where  MaSach = @MaSach
End
--cap nhat so luong sach
Go
Create Procedure CapNhatSoLuongSach
	@MaSach char(5),
	@SoLuong int
As
Begin
	Update Sach
	Set SoLuong = @SoLuong
	Where  MaSach = @MaSach
End
Go
Create Procedure XoaSach
	@MaSach char(5)
As
Begin
	Delete Sach
	Where MaSach = @MaSach
End
Go


--procedure cho tab Cho muon sach

---------------------------------
--Them phieu muon:
---------------------------------
Create Procedure ThemPhieuMuon
	@MaPhieuMuon char(5),
	@MaDocGia char(50),
	@MaThuThu char(5),
	@NgayMuon smalldatetime,
	@SoLuong int
	
As
Begin
	Insert Into PhieuMuon
	Values (@MaPhieuMuon, @MaDocGia, @MaThuThu,@NgayMuon, @SoLuong)
End
Go
---------------------------------
--Them CTPM:
---------------------------------
Create Procedure ThemCTPM
	@MaPhieuMuon char(5),
	@MaSach char(5)
	
As
Begin
	Insert Into CTPM
	Values (@MaPhieuMuon, @MaSach)
End
Go



