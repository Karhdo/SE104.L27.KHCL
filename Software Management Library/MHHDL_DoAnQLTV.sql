use master
go
create database MHHDL_DoAnQLTV
go

use MHHDL_DoAnQLTV
go

set dateformat dmy;
go



-- Tạo bảng Sách
create table tblSach
(
	MaSach varchar(10) constraint pk_tblSach primary key,
	NgNhapSach date,
	TenSach nvarchar(50),
	TheLoai nvarchar(50),
	TacGia nvarchar(50),
	NXB nvarchar(50),
	NamXB int,
	SLNhap int,
	TriGia int,
	TinhTrang nvarchar(50),
	Ghichu nvarchar(50),
)
go


-- Tạo bảng Độc Giả
create table tblDocGia
(
	MaDG varchar(10) constraint pk_tblDocGia primary key,
	TenDG nvarchar(50),
	GioiTinhDG nvarchar(50),
	NgaySinhDG date,
	EmailDG nvarchar(50),
	DiaChiDG nvarchar(50),
	LoaiDG nvarchar(50),
	GhiChu nvarchar(50),
	TenTaiKhoanDG varchar(50),
	MatKhauDG varchar(50),
	NgLapThe date,
)
go


-- Tạo bảng Tài khoản thủ thư
create table tblThuThu
(
	MaTT varchar(10) constraint pk_tblThuThu primary key,
	TenTT nvarchar(50),
	GioiTinhTT nvarchar(50),
	NgaySinhTT date,
	EmailTT nvarchar(50),
	DiaChiTT nvarchar(50),
	GhiChu nvarchar(50),
	TaiKhoanTT varchar(50),
	MatKhauTT varchar(50),
)
go

-- Tạo bảng Mượn Trả
create table tblHSPhieuMuon
(
	MaPhieu varchar(10) primary key,
	MaDG varchar(10) foreign key references tblDocgia(MaDG),
	MaSach varchar(10) foreign key references tblSach(MaSach),
	NgayMuon date,
	NgayTra date,
	SLMuon int,
	TinhTrang nvarchar(50),
	GhiChu nvarchar(50)
)
go


-- Tạo bảng Phiếu mượn
create table ChiTietPM
(
	MaCTPT VARCHAR(10) PRIMARY KEY,
	MaSach VARCHAR(10) FOREIGN KEY REFERENCES tblSach(MaSach),
	NgayThang DATE,
	SoLanMuon INT
)
go


-- Tạo bảng Tham số
Create table ThamSo
(
	TenTS varchar(50),
	GiaTri int
)
go



-- Insert dữ liệu vào các bảng

-- Chèn dữ liệu bảng tblSach
insert into tblSach values ('MS001','20/06/2005',N'Lập trình Windown',N'Lập trình',N'Nguyễn Xuân Nam',N'NXB Hồng Bàng','2000','100','50000',N'Mới','...')
insert into tblSach values ('MS002','25/05/2004',N'Lập trình Web',N'Lập trình',N'Lê Hồng Nhân',N'NXB Giáo Dục','2001','100','50000',N'Mới','...')
insert into tblSach values ('MS003','20/06/2005',N'Lập trình HDT',N'Lập trình',N'Nguyễn Đức Phương',N'NXB Hồng Bàng','2002','100','30000',N'Mới','...')
insert into tblSach values ('MS004','25/05/2004',N'Lập trình SQL',N'Lập trình',N'Nguyễn Xuân Nam',N'NXB Hồng Bàng','2004','100','40000',N'Mới','...')
insert into tblSach values ('MS005','20/06/2005',N'Thiết bị công nghệ hiện đại',N'Công nghệ',N'Trần Xuân Bách',N'NXB Thanh Niên','2004','100','60000',N'Mới','...')
insert into tblSach values ('MS006','25/05/2004',N'Khoa học quanh ta',N'Công nghệ',N'Trần Văn Chung',N'NXB Giáo Dục','2002','100','40000',N'Mới','...')
insert into tblSach values ('MS007','20/06/2005',N'Úng dụng công nghệ',N'Công nghệ',N'Nguyễn Hoài Nhâm',N'NXB Hồng Bàng','2009','100','50000',N'Mới','...')
insert into tblSach values ('MS008','25/05/2004',N'Bạn và Tôi',N'Tiểu thuyết',N'Lệ Thu',N'NXB Trẻ','2007','100','50000',N'Mới','...')
insert into tblSach values ('MS009','20/06/2005',N'Ngày Ấy',N'Tiểu thuyết',N'Nguyễn Hoài Nhớ',N'NXB Thanh Niên','2010','100','40000',N'Mới','...')
insert into tblSach values ('MS010','25/05/2004',N'Tôi đi tìm tôi',N'Tiểu thuyết',N'Phạm Đức',N'NXB Thanh Niên','2004','100','20000',N'Mới','...')
go

-- Chèn dữ liệu bảng tblDocGia
insert into tblDocGia values ('DG001',N'Vũ Đình Cần',N'Nam','15/06/1995',N'vudinhcan@gmail.com',N'115 Lê Đức Thọ, Gò Vấp',N'X','...','DG001','123','02/04/2021')
insert into tblDocGia values ('DG002',N'Huỳnh Thanh Hải',N'Nam','14/04/1996',N'huynhthanhhai@gmail.com',N'115 Nguyễn Oanh, Gò Vấp',N'X','...','DG002','123','04/07/2019')
insert into tblDocGia values ('DG003',N'Trần Vĩ Hào',N'Nam','15/01/1995',N'tranvihao@gmail.com',N'115 Lê Văn Thọ, Gò Vấp',N'X','...','DG003','123','02/04/2021')
insert into tblDocGia values ('DG004',N'Trần Nam',N'Nam','11/03/1994',N'trannam@gmail.com',N'115 Hồ Thị Hương, Tân Bình',N'X','...','DG004','123','04/07/2019')
insert into tblDocGia values ('DG005',N'Nguyễn Trãi',N'Nam','23/10/1995',N'nguyentrai@gmail.com',N'119 Lê Đức Thọ, Gò Vấp',N'X','...','DG005','123','02/04/2021')
insert into tblDocGia values ('DG006',N'Nguyễn Xuân Phúc',N'Nam','15/10/1995',N'nguyenxuanphuc@gmail.com',N'113 Lê Duẩn, Q1',N'Y','...','DG006','123','02/04/2021')
insert into tblDocGia values ('DG007',N'Phạm Nguyễn Gia Hân',N'Nữ','20/11/1993',N'pngiahan@gmail.com',N'784 Nguyễn Kiệm, Gò Vấp',N'Y','...','DG007','123','04/07/2019')
insert into tblDocGia values ('DG008',N'Lê Chí Trung',N'Nam','08/03/1995',N'lechitrung@gmail.com',N'988 Quang Trung, Gò Vấp',N'Y','...','DG008','123','02/04/2021')
insert into tblDocGia values ('DG009',N'Lê Nguyễn Hồng Ngọc',N'Nữ','20/11/1995',N'lenguyenhongngoc@gmail.com',N'115 QL1, Q12',N'Y','...','DG009','123','04/07/2019')
insert into tblDocGia values ('DG010',N'Nguyễn Vũ Hoàng',N'Nam','15/01/1990',N'nguyenvuhoang@gmail.com',N'111 Hà Huy Giáp, Q12',N'Y','...','DG010','123','02/04/2021')
go


-- Chèn dữ liệu vào bảng Thamso
insert into ThamSo values ('SoTuoiDGMin', 18)
insert into ThamSo values ('SoTuoiDGMax', 55)
insert into ThamSo values ('GiaTriThe', 6)
insert into ThamSo values ('ThoiGianXB', 8)
insert into ThamSo values ('TienPhat', 1000)
go


-- Chèn dữ liệu bảng tblHSPhieuMuon
insert into tblHSPhieuMuon values ('MP001','DG001','MS001','01/01/2017','21/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP002','DG001','MS002','01/01/2017','21/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','01/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','01/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','02/12/2016','22/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP008','DG007','MS009','01/12/2017','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP009','DG008','MS010','04/12/2017','24/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP010','DG006','MS006','04/12/2017','12/01/2017','1',N'Mới','...')
go

-- Chèn dữ liệu bảng tblDangNhap
insert into tblThuThu values ('TT001',N'Vũ Đình Cần',N'Nam','15/06/1995','vudinhcan@gmail.com',N'115 Lê Đức Thọ, Gò Vấp','...','TT001','123')
insert into tblThuThu values ('TT002',N'Nguyễn Như Trãi',N'Nam','15/06/1995','nguyennhutrai@gmail.com',N'115 Lê Đức Thọ, Gò Vấp','...','TT002','123')
insert into tblThuThu values ('TT003',N'Đỗ Trọng Khánh',N'Nam','15/06/1995','dotrongkhanh@gmail.com',N'115 Lê Đức Thọ, Gò Vấp','...','TT003','123')






-- có ngày hẹn trả
-- Chèn dữ liệu bảng tblHSPhieuMuon
/*
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/01/2017','22/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/01/2017','22/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','01/12/2016','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','01/12/2016','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','02/12/2016','22/12/2016','22/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP008','DG007','MS009','01/12/2017','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP009','DG008','MS010','04/12/2017','24/12/2016','24/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP010','DG006','MS006','04/12/2017','12/01/2017','12/01/2017','1',N'Mới','...')
--delete from tblMuonTra
*/


--delete from tblDangNhap


/*
-- QL Sách

-- Load Sách
select MaSach, TenSach, TenTG, TenCD, TenNXB, SLNhap, SLCon, DonGia, TinhTrang from tblSach, tblTacGia, tblNhaXuatBan, tblChuDeSach where tblSach.MaTG=tblTacGia.MaTG and tblSach.MaCD=tblChuDeSach.MaCD and tblSach.MaNXB=tblNhaXuatBan.MaNXB
-- Tìm kiếm 
select MaSach, TenSach, TenTG, TenCD, TenNXB, SLNhap, SLCon, DonGia, TinhTrang from tblSach, tblTacGia, tblNhaXuatBan, tblChuDeSach where tblSach.MaTG=tblTacGia.MaTG and tblSach.MaCD=tblChuDeSach.MaCD and tblSach.MaNXB=tblNhaXuatBan.MaNXB and TenCD like N'%Lập%'

delete from tblSach where MaSach='MS0012'

select count(MaSach) as TongSLDauSach, sum(SLNhap) as TongSLSach, sum(SLCon) as TongSLCon, sum(DonGia) as TongGiaTriSach from tblSach



update tblSach set SLCon='75' where MaSach='MS011'

-- QL Độc Giả
select * from tblDocGia

delete from tblDocGia where MaDG='DG010'

select count(MaDG) as TongSLDG from tblDocGia


-- QL Mượn Trả

select * from tblMuonTra

select sum(SLMuon) as Tong from tblMuonTra where MaDG='DG001' group by MaDG

update tblMuonTra set NgayMuon='11/01/2017', NgayTra='31/01/2017' where MaPhieu='MP014'

select sum(SLMuon) as Tong from tblMuonTra

select (count(distinct(MaDG))) as TongSLDGMuon from tblMuonTra


--
select *
from tblMuonTra 

where substring(NgayTra,7,4) <  SUBSTRING(cast(GETDATE() as varchar),8,5)

and substring(NgayTra,4,2) < 13
and substring(NgayTra,1,2) < 22


-- tốt
-- SL DG quá Hạn
SELECT count(distinct(MaDG)) as TongSLQuaHan from tblMuonTra where CONVERT (datetime, NgayTra, 103) < getdate()

-- DS DG Quá Hạn
SELECT MaDG, count(SLMuon) as 'SL Sách Mượn' from tblMuonTra where CONVERT (datetime, NgayTra, 103) <= getdate() group by MaDG

-- SL SÁch quá hạn
SELECT count(SLMuon) as TongSLQuaHan 
from tblMuonTra 
where CONVERT (datetime, NgayTra, 103) <= getdate()

-- DS SÁch quá hạn
SELECT MaSach, count(SLMuon)
from tblMuonTra 
where CONVERT (datetime, NgayTra, 103) <= getdate()
group by MaSach








select *
from tblMuonTra 

where substring(NgayTra,1,2) <= 22

and substring(NgayTra,4,2) <= 01
and substring(NgayTra,7,4) <=  SUBSTRING(cast(GETDATE() as varchar),8,5)

and DateTime(substring(NgayTra,7,4),substring(NgayTra,4,2),substring(NgayTra,1,2))







select SUBSTRING(cast(GETDATE() as varchar),9,5) as nam


select substring(NgayTra,7,4) as Nam 
from tblMuonTra 

where substring(NgayTra,1,2) < 11





--group by MaPhieu 

-- SL chủ đề

select count(MaCD) as TongSLCD from tblChuDeSach

-- SL NXB 
select count(MaNXB) as TongSLNXB from tblNhaXuatBan

-- SL tác giả

select count(MaTG) as TongSLTG from tblTacGia

*/

go


-- Drop all table

--DROP TABLE tblDocGia
--drop table tblHSPhieuMuon
--drop table tblSach
--drop table tblThuThu
--drop table ThamSo
--drop table ChiTietPM