Create Database QuanLyThuVien
Go

Use QuanLyThuVien
Go



/*=========== Tạo bảng ===========*/

Create Table ThuThu
(
	MaThuThu char(5) Primary key,
	HoTen nvarchar(100),
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
	HoTen nvarchar(100),
	DiaChi nvarchar(50),
	SDT varchar(15),
	CMND varchar(15),
	NgaySinh smalldatetime,
	NgayDK smalldatetime
)

Create Table Sach
(
	MaSach char(5) Primary key,
	TenSach nvarchar(100),
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
	TenTacGia nvarchar(100)
)

Create Table NXB
(
	MaNXB char(5) Primary key,
	TenNXB nvarchar(100),
)

Create Table NhaPhatHanh
(
	MaNhaPhatHanh char(5) Primary key,
	TenNhaPhatHanh nvarchar(100),
)

Create Table ChuDe
(
	MaChuDe char(5) Primary key,
	TenChuDe nvarchar(100)
)

Create Table TheLoai
(
	MaTheLoai char(5) Primary key,
	TenTheLoai nvarchar(100)
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
('CD000', N'Tình yêu'),
('CD001', N'Cuộc sống'),
('CD002', N'Công nghệ'),
('CD003', N'Giả tưởng'),
('CD004', N'Phiêu lưu'),
('CD005', N'Khoa học'),
('CD006', N'Văn học')

Insert into DocGia Values
('DG000', N'Bùi Trung Tín', N'Khu A',	'01285858585', '221425265',	1998-02-08, 2017-08-08),
('DG001', N'Thái Phương Lan', N'Quận 9', '01653434466', '221423568', 1998-03-29, 2017-09-12),
('DG002', N'Lê Đức Anh', N'Linh Đông', '01254477588',	'221455588', 1998-06-04, 2018-05-13), 
('DG003', N'Nguyễn Thị Lan Phương', N'Khu A',	'01684747123', '221433556', 1998-04-20, 2018-05-14), 
('DG004', N'Nguyễn Kỷ Nguyên', N'Khu A', '01243334564', '221533447', 1999-07-20, 2018-05-16) 

Insert into NhaPhatHanh Values
('NPH00',	N'Trường Đại Học Công Nghệ Thông Tin'),
('NPH01',	N'First News - Trí Việt'),
('NPH02',	N'Phương Thu'),
('NPH03',	N'Nhà Xuất Bản Trẻ'),
('NPH04',	N'Nhà Xuất Bản Thanh Niên'),
('NPH05',	N'Nhà Xuất Bản Kim Đồng'),
('NPH06',	N'Alphabooks'),
('NPH07',	N'Phương Nam')

Insert into NXB Values
('NXB00',	N'NXB ĐHQG-HCM'),
('NXB01',	N'NXB Tổng hợp Tp. Hồ Chí Minh'),
('NXB02',	N'NXB Dân Trí'),
('NXB03',	N'NXB Trẻ'),
('NXB04',	N'NXB Thanh Niên'),
('NXB05',	N'NXB Kim Đồng'),
('NXB06',	N'NXB Thế Giới')

Insert into Sach Values
('MS000',	N'Xử Lý Ngôn Ngữ Tự Nhiên',	'TG000',	'2006',	'NXB00',	'NPH00',	'20/3/2017',	'CD002',	'TL003',	16000.00,	30),
('MS001',	N'Đắc Nhân Tâm',	'TG003',	'2016',	'NXB01',	'NPH01',	'23/3/2017',	'CD001',	'TL002',	45600.00,	40),
('MS002',	N'Code Dạo Kí Sự',	'TG004',	'2017',	'NXB02',	'NPH02',	'15/1/2017',	'CD002',	'TL003',	159000.00,	20),
('MS003',	N'Cà Phê Cùng Tony',	'TG005',	'2017',	'NXB03',	'NPH03',	'25/1/2017',	'CD001',	'TL002',	90000.00,	20),
('MS004',	N'Ngày xưa có một chuyện tình',	'TG002',	'2017',	'NXB03',	'NPH03',	'25/10/2018',	'CD006',	'TL004',	86000.00,	30)

Insert into TacGia Values
('TG000',	N'Nguyễn Tuấn Đăng'),
('TG001',	N'Nguyễn Ngọc Tư'),
('TG002',	N'Nguyễn Nhật Ánh'),
('TG003',	N'Dale Carnegie'),
('TG004',	N'Phạm Huy Hoàng'),
('TG005',	N'Tony Buổi Sáng'),
('TG006',	N'Nhiều tác giả'),
('TG007',	N'Tô Hoài'),
('TG008',	N'Uyên Uyên'),
('TG009',	N'Liêu Hà Trinh')

Insert into TheLoai Values
('TL000',	N'Tiểu thuyết'),
('TL001',	N'Kinh tế'),
('TL002',	N'Kỹ năng'),
('TL003',	N'Giáo trình'),
('TL004',	N'Truyện ngắn'),
('TL005',	N'Tản văn'),
('TL006',	N'Truyện tranh'),
('TL007',	N'Thơ ca')

Insert into TinhTrang Values
('TT000', N'Tốt'),
('TT001', N'Hỏng nhẹ'),
('TT002', N'Hỏng nặng'),
('TT003', N'Mất')

Insert into ThuThu Values
('TT000',	N'Lầu Phi Tường',	N'Nhật Bản',	'01679681581',	'365235117'	, 'tuonglp@gmail.com',	'2017-05-09 00:00:00',	'1234'),
('TT001',	N'Nguyễn Vĩnh Kha',	N'Việt Nam',	'01696761984',	'123412312'	, 'khanv@gmail.com',	'2017-05-09 00:00:00',	'1234')


/*========== Tạo Procedure ===========*/
/*== Procedure Độc giả == */

Create Procedure SuaDocGia
	@MaDocGia char(5),
	@TenDocGia nvarchar(20),
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

---

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
	Select MaSach, TenSach, TenTacGia, NamXB , TenNXB, TenNhaPhatHanh, NgayNhap, TenChuDe, TenTheLoai, GiaTri, SoLuong 
	From Sach, TacGia, NXB, NhaPhatHanh, ChuDe, TheLoai
	Where (Sach.MaTacGia = TacGia.MaTacGia) and (Sach.MaNXB = NXB.MaNXB) and (Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh)
		  and (Sach.MaChuDe = ChuDe.MaChuDe) and (Sach.MaTheLoai = TheLoai.MaTheLoai)
End
Go

---

Create Procedure GetSach_DieuKien
	@DieuKien nvarchar(100)
As
Begin
	declare @Sql nvarchar(1000)
	
	Set @Sql = 'Select * From
	(Select MaSach, TenSach, TenTacGia, NamXB , TenNXB, TenNhaPhatHanh, NgayNhap, TenChuDe, TenTheLoai, GiaTri, SoLuong 
	From Sach, TacGia, NXB, NhaPhatHanh, ChuDe, TheLoai
	Where (Sach.MaTacGia = TacGia.MaTacGia) and (Sach.MaNXB = NXB.MaNXB) and (Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh)
		  and (Sach.MaChuDe = ChuDe.MaChuDe) and (Sach.MaTheLoai = TheLoai.MaTheLoai)) as A
	Where ' + @DieuKien
	
	Exec(@Sql)
End
Go

---

Create Procedure LocSach
	@DieuKienLoc varchar(200)
As
Begin
	Declare @Sql varchar(1000)	
	Set @Sql =  'Select ' + @DieuKienLoc + ' From
				(Select MaSach, TenSach, TenTacGia, TenNXB, TenNhaPhatHanh, TenChuDe, TenTheLoai From Sach, TacGia, NXB, NhaPhatHanh, ChuDe, TheLoai
				Where (Sach.MaTacGia = TacGia.MaTacGia) and (Sach.MaNXB = NXB.MaNXB) and (Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh)
				and (Sach.MaChuDe = ChuDe.MaChuDe) and (Sach.MaTheLoai = TheLoai.MaTheLoai)) as A'
	Exec(@Sql)
End
Go

---

Create Function AutoID_Sach()
	Returns varchar(5)
As
Begin	
	Declare @ID varchar(5)
	If (Select Count(MaTacGia) From TacGia) = 0
		Set @ID = 'MS000' 		
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaSach, 3)) From Sach
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'MS00' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'MS0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 999 Then 'MS' + Convert(char, Convert(int, @tempID)+1)			
		End
	Return @ID
End

---

Create Procedure ThemSach
	@TenSach nvarchar(100),
	@TenTacGia nvarchar(100),
	@NamXB int,
	@TenNXB nvarchar(100),
	@TenNhaPhatHanh nvarchar(100),
	@NgayNhap smalldatetime,
	@TenChuDe nvarchar(100),
	@TenTheLoai nvarchar(100),
	@GiaTri money,
	@SoLuong int
As 
Begin 

	If Not exists (Select Sach.TenSach, TacGia.TenTacGia, NXB.TenNXB, NhaPhatHanh.TenNhaPhatHanh, Sach.NamXB
				   From Sach Inner Join TacGia On Sach.MaTacGia = TacGia.MaTacGia
						Inner Join NXB On Sach.MaNXB = NXB.MaNXB
						Inner Join NhaPhatHanh On Sach.MaNhaPhatHanh = NhaPhatHanh.MaNhaPhatHanh
				   Where Sach.TenSach = @TenSach and TacGia.TenTacGia = @TenTacGia and NXB.TenNXB = @TenNXB
						 and NhaPhatHanh.TenNhaPhatHanh = @TenNhaPhatHanh and Sach.NamXB = @NamXB)
	Begin
		Declare @MaSach varchar(5)
		Select @MaSach = dbo.AutoID_Sach()				
			
		Declare @MaTacGia varchar(5)
		Select @MaTacGia = (Select MaTacGia From TacGia Where TenTacGia = @TenTacGia)
		
		Declare @MaNXB varchar(5)
		Select @MaNXB = (Select MaNXB From NXB Where TenNXB = @TenNXB)
		
		Declare @MaNhaPhatHanh varchar(5)
		Select @MaNhaPhatHanh = (Select MaNhaPhatHanh From NhaPhatHanh Where TenNhaPhatHanh = @TenNhaPhatHanh)
		
		Declare @MaChuDe varchar(5)
		Select @MaChuDe = (Select MaChuDe From ChuDe Where TenChuDe = @TenChuDe)
		
		Declare @MaTheLoai varchar(5)
		Select @MaTheLoai = (Select MaTheLoai From TheLoai Where TenTheLoai = @TenTheLoai)
		
		Insert Into Sach
		Values (@MaSach, @TenSach, @MaTacGia, @NamXB, @MaNXB, @MaNhaPhatHanh, @NgayNhap, @MaChuDe, @MaTheLoai, @GiaTri, @SoLuong)
	End
End
Go

---

Create Procedure CapNhatSach
	@MaSach varchar(5),
	@TenSach nvarchar(50),
	@TenTacGia nvarchar(100),
	@NamXB int = 2018,
	@TenNXB nvarchar(100),
	@TenNhaPhatHanh nvarchar(100),
	@NgayNhap smalldatetime,
	@TenChuDe nvarchar(100),
	@TenTheLoai nvarchar(100),
	@GiaTri money,
	@SoLuong int
As
Begin
	Declare @MaTacGia varchar(5)
	Select @MaTacGia = (Select MaTacGia From TacGia Where TenTacGia = @TenTacGia)

	Declare @MaNXB varchar(5)
	Select @MaNXB = (Select MaNXB From NXB Where TenNXB = @TenNXB)

	Declare @MaNhaPhatHanh varchar(5)
	Select @MaNhaPhatHanh = (Select MaNhaPhatHanh From NhaPhatHanh Where TenNhaPhatHanh = @TenNhaPhatHanh)

	Declare @MaChuDe varchar(5)
	Select @MaChuDe = (Select MaChuDe From ChuDe Where TenChuDe = @TenChuDe)

	Declare @MaTheLoai varchar(5)
	Select @MaTheLoai = (Select MaTheLoai From TheLoai Where TenTheLoai = @TenTheLoai)

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

---

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

---

Create Procedure XoaSach
	@MaSach char(5)
As
Begin
	Delete Sach
	Where MaSach = @MaSach
End
Go

/*=== Procedure Tác giả ===*/
Create Function AutoID_TG()
	Returns varchar(5)
As
Begin
	Declare @ID varchar(5)
	If (Select Count(MaTacGia) From TacGia) = 0
		Set @ID = 'TG000' 		
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaTacGia, 3)) From TacGia
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'TG00' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'TG0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 999 Then 'TG' + Convert(char, Convert(int, @tempID)+1)			
		End
	Return @ID
End 

----

Create Procedure ThemTacGia
	@TenTacGia nvarchar(100)
As
Begin
	If @TenTacGia Not in (Select TenTacGia From TacGia)
	Begin
		Declare @MaTacGia varchar(5)
		Select @MaTacGia = dbo.AutoID_TG()
		Insert into TacGia Values (@MaTacGia, @TenTacGia)
	End
End

/*=== Procedure Nhà xuất bản ===*/
Create Function AutoID_NXB()
	Returns varchar(5)
As
Begin
	Declare @ID varchar(5)
	If (Select Count(MaNXB) From NXB) = 0
		Set @ID = 'NXB00' 		
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaNXB, 2)) From NXB
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'NXB0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'NXB' + Convert(char, Convert(int, @tempID)+1)					
		End
	Return @ID
End 

---

Create Procedure ThemNXB
	@TenNXB nvarchar(100)
As
Begin
	If @TenNXB Not in (Select TenNXB From NXB)
	Begin
		Declare @MaNXB varchar(5)
		Select @MaNXB = dbo.AutoID_NXB()
		Insert into NXB Values (@MaNXB, @TenNXB)
	End
End

/*=== Procedure Nhà phát hành ===*/
Create Function AutoID_NPH()
	Returns varchar(5)
As
Begin
	Declare @ID varchar(5)
	If (Select Count(MaNhaPhatHanh) From NhaPhatHanh) = 0
		Set @ID = 'NPH00' 		
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaNhaPhatHanh, 3)) From NhaPhatHanh
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'NPH0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'NPH' + Convert(char, Convert(int, @tempID)+1)		
		End
	Return @ID
End 

---

Create Procedure ThemNhaPhatHanh
	@TenNPH nvarchar(100)
As
Begin
	If @TenNPH Not in (Select TenNhaPhatHanh From NhaPhatHanh)
	Begin
		Declare @MaNPH varchar(5)
		Select @MaNPH = dbo.AutoID_NPH()
		Insert into NhaPhatHanh Values (@MaNPH, @TenNPH)
	End
End


/*=== Procedure Chủ đề ===*/
Create Function AutoID_CD()
	Returns varchar(5)
As
Begin
	Declare @ID varchar(5)
	If (Select Count(MaChuDe) From ChuDe) = 0
		Set @ID = 'CD000' 		
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaChuDe, 3)) From ChuDe
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'CD00' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'CD0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 999 Then 'CD' + Convert(char, Convert(int, @tempID)+1)			
		End
	Return @ID
End 

---

Create Procedure ThemChuDe
	@TenCD nvarchar(100)
As
Begin
	If @TenCD Not in (Select TenChuDe From ChuDe)
	Begin
		Declare @MaCD varchar(5)
		Select @MaCD = dbo.AutoID_CD()
		Insert into ChuDe Values (@MaCD, @TenCD)
	End
End


/*=== Procedure Thể loại ===*/


Create Function AutoID_TL()
	Returns varchar(5)
As
Begin
	Declare @ID varchar(5)
	If (Select Count(MaTheLoai) From TheLoai) = 0
		Set @ID = 'TL000' 		
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaTheLoai, 3)) From TheLoai
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'TL00' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'TL0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 999 Then 'TL' + Convert(char, Convert(int, @tempID)+1)			
		End
	Return @ID
End 

---

Create Procedure ThemTheLoai
	@TenTL nvarchar(100)
As
Begin
	If @TenTL Not in (Select TenTheLoai From TheLoai)
	Begin
		Declare @MaTL varchar(5)
		Select @MaTL = dbo.AutoID_TL()
		Insert into TheLoai Values (@MaTL, @TenTL)
	End
End

/*=== Procedure Chức năng ngoài ===*/

Create Procedure AutoCompleteText
	@TenCot varchar(15),
	@TenBang varchar(15)	
As
Begin
	Declare @Sql nvarchar(1000)
	Set @Sql = 'Select ' + @TenCot + ' From ' + @TenBang				
	Exec(@Sql)
End
Go

---

Create Procedure LayDuLieuComboBox
	@TenCot varchar(15),
	@TenBang varchar(15)	
As
Begin
	Declare @Sql nvarchar(1000)
	Set @Sql = 'Select ' + @TenCot + ' From ' + @TenBang				
	Exec(@Sql)
End
Go

--- Procedure cho tab Cho muon sach

---------------------------------
--Lay Phieu muon:
---------------------------------
Create Procedure GetFullPhieuMuon	
As
Begin
	Select pm.MaPhieuMuon, dg.MaDocGia, dg.HoTen as [TenDocGia], tt.MaThuThu, tt.HoTen as [TenThuThu], pm.NgayMuon, pm.SoLuong from
	     ((PhieuMuon pm Inner Join DocGia dg ON pm.MaDocGia = dg.MaDocGia)
						Inner Join ThuThu tt ON pm.MaThuThu = tt.MaThuThu)	
End 
Go

---------------------------------
--Them phieu muon:
---------------------------------
Create Function AutoID_PM()
	Returns varchar(5)
As
Begin
	Declare @ID varchar(5)
	If (Select Count(MaPhieuMuon) From PhieuMuon) = 0
		Set @ID = 'PM000'
	Else
		Declare @tempID varchar(5)
		Select @tempID = Max(Right(MaPhieuMuon, 3)) From PhieuMuon
		Select @ID = Case
			When @tempID + 1 <= 9 Then 'PM00' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 99 Then 'PM0' + Convert(char, Convert(int, @tempID)+1)
			When @tempID + 1 <= 999 Then 'PM' + Convert(char, Convert(int, @tempID)+1)			
		End
	Return @ID
End 

---

Create Procedure ThemPhieuMuon	
	@MaDocGia char(5),
	@MaThuThu char(5),
	@NgayMuon smalldatetime,
	@SoLuong int
	
As
Begin
	Declare @MaPhieuMuon char(5)
	Select @MaPhieuMuon = dbo.AutoID_PM()

	Insert Into PhieuMuon
	Values (@MaPhieuMuon, @MaDocGia, @MaThuThu, @NgayMuon, @SoLuong)
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


						
--procedure cho tab Nhan tra sach

---------------------------------
--lay full phieu tra:
---------------------------------


Create Procedure GetFullPhieuTra
As
Begin
	Select pt.MaPhieuTra, dg.HoTen as 'TenDocGia', th.HoTen as 'TenThuThu', pt.NgayTra, pt.SoLuong
	From (PhieuTra pt Inner Join DocGia dg ON pt.MaDocGia = dg.MaDocGia)
					  Inner Join ThuThu th ON pt.MaThuThu = th.MaThuThu
End



---------------------------------
--Them phieu tra:
---------------------------------
Create Procedure ThemPhieuTra
	@MaPhieuTra char(5),
	@MaDocGia char(50),
	@MaThuThu char(5),
	@NgayTra smalldatetime,
	@SoLuong int
	
As
Begin
	Insert Into PhieuTra
	Values (@MaPhieuTra, @MaDocGia, @MaThuThu,@NgayTra, @SoLuong)
End
Go
---------------------------------
--Them CTPT:
---------------------------------
Create Procedure ThemCTPT
	@MaPhieuTra char(5),
	@MaSach char(5),
	@MaTinhTrang char(5)
	
As
Begin
	Insert Into CTPT
	Values (@MaPhieuTra, @MaSach, @MaTinhTrang)
End
Go



select s.MaSach, s.TenSach
	from Sach s
	where s.MaSach in 
	(
		select ctpm.MaSach
		from CTPM ctpm inner join PhieuMuon pm on ctpm.MaPhieuMuon = pm.MaPhieuMuon
		where pm.MaDocGia = 'DG000' and MaSach not in 
		(
			select ctpt.MaSach 
			from CTPT ctpt inner join PhieuTra pt on ctpt.MaPhieuTra = pt.MaPhieuTra
			where pt.MaDocGia = 'DG000'
		)
	)


select * 
from PhieuMuon

select * 
from CTPM