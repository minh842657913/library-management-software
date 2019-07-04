use master
go

WHILE EXISTS(select NULL from sys.databases where name='QuanLiThuVien')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QuanLiThuVien') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QuanLiThuVien]
END
go

create database [QuanLiThuVien]
go
use [QuanLiThuVien]
go

create table DOCGIA
(
	maDocGia	char(8) primary key,
	hoTen		nvarchar(45),
	diaChi		nvarchar(45),
	email		nvarchar(20),
	ngaySinh	smalldatetime
)

-------------------------------- tham chieu
create table LOAIDOCGIA
(
	maLoaiDG	char(5) primary key,
	loaiDG		nvarchar(10)
)

create table NHAXUATBAN
(
	maNXB		char(5) primary key,
	tenNXB		nvarchar(45)
)

create table TACGIA
(
	maTacGia	char(5) primary key,
	tenTacGia	nvarchar(35)
)

create table LOAISACH
(
	maLoaiSach	char(5) primary key,
	theLoai		nvarchar(35)
)

------------------------------- duoc tham chieu
create table THEDOCGIA
(
	maThe		char(10) primary key,
	maDocGia	char(8)	foreign key (maDocGia)
						references DOCGIA (maDocGia),
	maLoaiDG	char(5)	foreign key	(maLoaiDG)
						references LOAIDOCGIA (maLoaiDG),
	ngayLapThe	smalldatetime,
	hanThe		smalldatetime
)

create table SACH
(
	maSach		char(8) primary key,
	tenSach		nvarchar(35),
	maLoaiSach	char(5)	foreign key	(maLoaiSach)
						references LOAISACH (maLoaiSach),
	maTacGia	char(5)	foreign key	(maTacGia)
						references TACGIA (maTacGia),
	namXuatBan	int,
	maNXB		char(5)	foreign key	(maNXB)
						references NHAXUATBAN (maNXB),
	ngayNhap	smalldatetime,
	soLuongTon	int,
	triGia		money
)

create table PHIEUMUON
(
	maPhieuMuon	char(8) primary key,
	maDocGia	char(8)	foreign key (maDocGia)
						references DOCGIA (maDocGia),
	maSach		char(8)	foreign key	(maSach)
						references SACH (maSach),
	maTacGia	char(5)	foreign key	(maTacGia)
						references TACGIA (maTacGia),
	ngayMuon			smalldatetime
)
---------------------------------------
create table PHIEUTRA
(
	maPhieuTra	char(8) primary key,
	maDocGia	char(8)	foreign key (maDocGia)
						references DOCGIA (maDocGia),
	maSach		char(8)	foreign key	(maSach)
						references SACH (maSach),
	maPhieuMuon	char(8)	foreign key	(maPhieuMuon)
						references PHIEUMUON (maPhieuMuon),
	ngayTra				smalldatetime,
	soNgayMuon	int,
	tienPhat	money
)

create table THONGTINNO	/*Chua them du lieu vao bang*/
(
	maTTN		char(5) primary key,
	maDocGia	char(8)	foreign key (maDocGia)
						references DOCGIA (maDocGia),
	tongNo		money
)

create table THONGTINPHAT	/*Chua them du lieu vao bang*/
(
	maPhat		char(5) primary key,
	maPhieuTra	char(8)	foreign key (maPhieuTra)
						references PHIEUTRA (maPhieuTra),
	tienPhatKyNay		money,
	tienNoKyNay			money
)

create table PHIEUTHUTIENPHAT /*Chua them du lieu vao bang*/
(
	maPTTP		char(8) primary key,
	maDocGia	char(8)	foreign key (maDocGia)
						references DOCGIA (maDocGia),
	maTTN		char(5)	foreign key	(maTTN)
						references THONGTINNO (maTTN),
	soTienThu			money,
	soTienConLai		money
)

/*Bao cao muon theo the loai*/
create table BAOCAOMUONSACH		/*Chua them du lieu vao bang*/
(
	maBCMuon	char(8) primary key,
	maLoaiSach	char(5)	foreign key (maLoaiSach)
						references LOAISACH (maLoaiSach),
	thang		int,
	soLuotMuon	int,
	tiLe		real
)

create table TONGLUOTMUON		/*Chua them du lieu vao bang*/
(
	maTLM		char(5) primary key,
	maBCMuon	char(8)	foreign key (maBCMuon)
						references BAOCAOMUONSACH (maBCMuon),
	tongLuotMuon		int
)

create table BAOCAOTRATRE		/*Chua them du lieu vao bang*/
(
	maBCTra		char(8) primary key,
	maSach		char(8)	foreign key (maSach)
						references SACH (maSach),
	maPhieuMuon	char(8)	foreign key (maPhieuMuon)
						references PHIEUMUON (maPhieuMuon),
	soNgayTraTre		int,
	ngay		smalldatetime
)

---------------------------- Dieu kien cac rang buoc cua cac bang
create table QUYDINHTUOI	/*Chua them du lieu vao bang*/
(
	maQDT		char(5) primary key,
	tuoiToiThieu		int,
	tuoiToiDa			int
)

create table TIENPHAT		/*Chua them du lieu vao bang*/
(
	maTienPhat		char(5) primary key,
	tienPhatMotNgay	money
)
create table TAIKHOAN
(
	maTaiKhoan		varchar(5) primary key,
	tenTaiKhoan		varchar(12),
	matKhau			varchar(12)
)
----------------------------

insert into LOAIDOCGIA(maLoaiDG, loaiDG) values ('LDG01', N'Thường')
insert into LOAIDOCGIA(maLoaiDG, loaiDG) values ('LDG02', 'VIP')
---
insert into NHAXUATBAN(maNXB, tenNXB) values ('NXB01', N'Nhà xuất bản Kim Đồng')
insert into NHAXUATBAN(maNXB, tenNXB) values ('NXB02', N'Nhà xuất bản Giáo Dục')
insert into NHAXUATBAN(maNXB, tenNXB) values ('NXB03', N'Nhà xuất bản Tự Do')
insert into NHAXUATBAN(maNXB, tenNXB) values ('NXB04', N'Nhà xuất bản Tại Gia')

insert into TACGIA(maTacGia, tenTacGia) values ('TG001', N'Nguyễn Văn Tác Giả')
insert into TACGIA(maTacGia, tenTacGia) values ('TG002', N'Lê Thị Giả Tác')
insert into TACGIA(maTacGia, tenTacGia) values ('TG003', N'Nguyễn Thành Luân')

insert into LOAISACH(maLoaiSach, theLoai) values ('TLS01', N'Sách thiếu nhi')
insert into LOAISACH(maLoaiSach, theLoai) values ('TLS02', N'Sách trinh thám')
insert into LOAISACH(maLoaiSach, theLoai) values ('TLS03', N'Sách giáo khoa')

set dateformat dmy

insert into DOCGIA(maDocGia, hoTen, diaChi, email, ngaySinh) values ('DG001', N'Nguyễn Văn A', 'TPHCM', 'email@email', '13/06/2001')
insert into DOCGIA(maDocGia, hoTen, diaChi, email, ngaySinh) values ('DG002', N'Nguyễn Thị B', N'Bình Dương', 'hotmail@email', '14/02/2001')
insert into DOCGIA(maDocGia, hoTen, diaChi, email, ngaySinh) values ('DG003', N'Trần Thanh C', N'Hà Nội', 'yahoo@email', '14/07/2000')

insert into THEDOCGIA(maThe, maDocGia, maLoaiDG, ngayLapThe, hanThe) values ('THE001', 'DG001', 'LDG01', '12/12/2016', null)
insert into THEDOCGIA(maThe, maDocGia, maLoaiDG, ngayLapThe, hanThe) values ('THE002', 'DG002', 'LDG01', '12/12/2016', null)
insert into THEDOCGIA(maThe, maDocGia, maLoaiDG, ngayLapThe, hanThe) values ('THE003', 'DG003', 'LDG02', '25/06/2015', null)

insert into SACH(maSach, tenSach, maLoaiSach, maTacGia, namXuatBan, maNXB, ngayNhap, soLuongTon, triGia) values ('SA001', N'Tên sách 01', 'TLS02', 'TG003', '2008', 'NXB04', '12/01/2009', 10, 29000)
insert into SACH(maSach, tenSach, maLoaiSach, maTacGia, namXuatBan, maNXB, ngayNhap, soLuongTon, triGia) values ('SA002', N'Tên sách 02', 'TLS03', 'TG003', '2010', 'NXB04', '21/12/2010', 10, 36000)

insert into PHIEUMUON(maPhieuMuon, maDocGia, maSach, maTacGia, ngayMuon) values ('PM001', 'DG002', 'SA001', 'TG003', '01/01/2017')
insert into PHIEUMUON(maPhieuMuon, maDocGia, maSach, maTacGia, ngayMuon) values ('PM002', 'DG002', 'SA002', 'TG003', '01/01/2017')
insert into PHIEUMUON(maPhieuMuon, maDocGia, maSach, maTacGia, ngayMuon) values ('PM003', 'DG001', 'SA002', 'TG003', '02/04/2017')

insert into PHIEUTRA(maPhieuTra, maDocGia, maSach, maPhieuMuon, ngayTra, soNgayMuon, tienPhat) values ('PTR001', 'DG001', 'SA002', 'PM003', null, null, 0)
insert into PHIEUTRA(maPhieuTra, maDocGia, maSach, maPhieuMuon, ngayTra, soNgayMuon, tienPhat) values ('PTR002', 'DG002', 'SA002', 'PM002', null, null, 0)

insert into TAIKHOAN(maTaiKhoan,tenTaiKhoan,matKhau) values ('TK001','admin','admin')
----


/*
SELECT [maSach], [tenSach], [LOAISACH].[theLoai], [TACGIA].[tentacGia], [namXuatBan], [NHAXUATBAN].[tenNXB], [ngayNhap], [soLuongTon], [triGia]
FROM [QuanLiThuVien].[dbo].[SACH], [QuanLiThuVien].[dbo].[LOAISACH], [QuanLiThuVien].[dbo].[TACGIA], [QuanLiThuVien].[dbo].[NHAXUATBAN]
WHERE ([LOAISACH].[maLoaiSach] = [SACH].[maLoaiSach] AND [TACGIA].[maTacGia] = [SACH].[maTacGia] AND [NHAXUATBAN].[maNXB] = [SACH].[maNXB])
*/


/*
SELECT [LOAISACH].[theLoai], COUNT([theLoai]) AS soLuotMuon
FROM [QuanLiThuVien].[dbo].[LOAISACH], [QuanLiThuVien].[dbo].[PHIEUMUON], [QuanLiThuVien].[dbo].[SACH]
WHERE ([PHIEUMUON].[maSach] = [SACH].[maSach] AND [SACH].[maLoaiSach] = [LOAISACH].[maLoaiSach] and MONTH([ngayMuon]) = '01')
GROUP BY [theLoai]

SELECT COUNT(*) AS tongLuotMuon
FROM [QuanLiThuVien].[dbo].[LOAISACH], [QuanLiThuVien].[dbo].[PHIEUMUON], [QuanLiThuVien].[dbo].[SACH]
WHERE ([PHIEUMUON].[maSach] = [SACH].[maSach] AND [SACH].[maLoaiSach] = [LOAISACH].[maLoaiSach])
*/