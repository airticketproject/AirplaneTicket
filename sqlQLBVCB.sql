create database QLBVMB
use QLBVMB


CREATE TABLE LichChuyenBay
(
MaChuyenBay CHAR(5) NOT NULL PRIMARY KEY,
SanBayDi CHAR(5) not null,
SanBayDen CHAR(5) not null,
NgayGio DATETIME2(7),
ThoiGianBay int,
SoLuongGheHang1 int,
SoLuongGheHang2 int,
)

Create table SanBay
(
MaSanBay char(5) not null primary key,
TenSanBay char(20)
)

create table HanhKhach
(
MaHanhKhach char(10) not null primary key,
TenHanhKhach char(40),
CMND char(9),
DienThoai char(11)
)

create table DanhSachChuyenBay
(
MaDanhSach char(5) not null primary key,
MaChuyenBay char(5) not null,
SoGheTrong int,
SoGheDaDat int
)

create table LoaiVe
(
MaLoaiVe char(5) not null primary key,
TenLoaiVe char(10),
GiaTien money
)

create table PhieuDatVe
(
MaPhieuDat char(5) not null primary key,
MaHanhKhach char(10) not null,
MaChuyenBay char(5) not null,
MaLoaiVe char(5) not null
)

create table Ve
(
MaVe char(10) not null primary key,
MaHanhKhach char(10) not null,
MaChuyenBay char(5) not null,
MaLoaiVe char(5) not null
)

create table ChiTietSanBayTrungGian
(
MaChiTietSanBayTrungGian char(5) not null primary key,
MaChuyenBay char(5) not null,
MaSanBay char(5) not null,
ThoiGianDung int,
GhiChu char(30)
)

create table ThamSo
(
ThoiGianBayToiThieu int,
SoLuongSanBayTrungGianToiDa int,
ThoiGianDungToiDa int,
ThoiGianDungToiThieu int,
DonGiaVeHang1 money,
ThoiGianChamNhatKhiDatVe int,
ThoiGianHuyVe int
)

create table DoanhThuTheoThang
(
MaDoanhThuTheoThang char(5) not null primary key,
MaChuyenBay char(5) not null,
SoLuongVe int,
DoanhThu money,
TiLe float
)

create table DoanhThuTheoNam
(
MaDoanhThuTheoNam char(5) not null primary key,
MaDoanhThuTheoThang char(5) not null,
SoChuyenBay int,
DoanhThu money,
TiLe float
)



alter table LichChuyenBay
add constraint FK_LichChuyenBay_SanBayDi foreign key (SanBayDi) references SanBay(MaSanBay),
	constraint FK_LichChuyenBay_SanBayDen foreign key (SanBayDen) references SanBay(MaSanBay)

alter table DanhSachChuyenBay
add constraint FK_DanhSachChuyenBay_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay)

alter table PhieuDatVe
add constraint FK_PhieuDatVe_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay),
	constraint FK_PhieuDatVe_MaHanhKhach foreign key (MaHanhKhach) references HanhKhach(MaHanhKhach),
	constraint FK_PhieuDatVe_MaLoaiVe foreign key (MaLoaiVe) references LoaiVe(MaLoaiVe)

alter table Ve
add constraint FK_Ve_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay),
	constraint FK_Ve_MaHanhKhach foreign key (MaHanhKhach) references HanhKhach(MaHanhKhach),
	constraint FK_Ve_MaLoaiVe foreign key (MaLoaiVe) references LoaiVe(MaLoaiVe)

alter table DoanhThuTheoThang
add constraint FK_DoanhThuTheoThang_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay)

alter table DoanhThuTheoNam
add constraint FK_DoanhThuTheoNam_MaDoanhThuTheoThang foreign key (MaDoanhThuTheoThang) references DoanhThuTheoThang(MaDoanhThuTheoThang)

alter table ChiTietSanBayTrungGian
add constraint FK_ChiTietSanBayTrungGian_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay),
	constraint FK_ChiTietSanBayTrungGian_MaSanBay foreign key (MaSanBay) references SanBay(MaSanBay)



alter table LichChuyenBay
add check (SanBayDi<>SanBayDen),
	check (ThoiGianBay>0),
	check (SoLuongGheHang1>=0),
	check (SoLuongGheHang2>=0)

alter table DanhSachChuyenBay
add check (SoGheTrong>=0),
	check (SoGheDaDat>=0)

--alter table ChiTietSanBayTrungGian
--add check (10<=ThoiGianDung and ThoiGianDung<=20)

--insert into ThamSo
--	values (30,2,20,1000000,24,24)

Select * from LichChuyenBay
Update LichChuyenBay set SoLuongGheHang1 = 10
Where MaChuyenBay = '2'

/*Trigger Thoi Gian Bay Toi Thieu*/
create trigger tr_ThoiGianBay
on LichChuyenBay
for Insert
as
	declare @t int
	declare @min int
	select @t=ThoiGianBay from inserted
	select @min=ThoiGianBayToiThieu from ThamSo
	if (@t<@min)
	begin
		print 'Thoi gian bay < Thoi gian bay toi thieu'
		rollback tran
	end

create trigger tr_ThoiGianBay_Update
on LichChuyenBay
for update
as
	declare @t int
	declare @min int
	select @t=ThoiGianBay from inserted
	select @min=ThoiGianBayToiThieu from ThamSo
	if (@t<@min)
	begin
		print 'Thoi gian bay < Thoi gian bay toi thieu'
		rollback tran
	end


/*Trigger San Bay Trung Gian Toi Da*/
create trigger tr_SanBayTrungGianToiDa
on ChiTietSanBayTrungGian
for insert
as
	declare @i char(5)
	declare @t int
	declare @max int
	select @i=MaChuyenBay from inserted
	select @t=count(MaSanBay) from ChiTietSanBayTrungGian
	where MaChuyenBay=@i
	select @max=SoLuongSanBayTrungGianToiDa from ThamSo
	if (@t>@max)
	begin
		print 'So luong san bay trung gian vuot qua so luong toi da'
		rollback tran
	end

create trigger tr_SanBayTrungGianToiDa_Update
on ChiTietSanBayTrungGian
for update
as
	declare @i char(5)
	declare @t int
	declare @max int
	select @i=MaChuyenBay from inserted
	select @t=count(MaSanBay) from ChiTietSanBayTrungGian
	where MaChuyenBay=@i
	select @max=SoLuongSanBayTrungGianToiDa from ThamSo
	if (@t>@max)
	begin
		print 'So luong san bay trung gian vuot qua so luong san bay trung gian toi da'
		rollback tran
	end

/*Trigger Chi ban ve khi con cho*/

create trigger tr_BanVe
on Ve
for insert
as
	declare @i char(5)
	declare @controng int
	select @i=MaChuyenBay from inserted
	select @controng=SoGheTrong from DanhSachChuyenBay
	where @i=MaChuyenBay
	if (@controng<=0)
	begin
		print 'Da het ve'
		rollback tran
	end
	else
	begin
		update DanhSachChuyenBay
		set SoGheTrong=SoGheTrong-1
		where MaChuyenBay=@i
		update DanhSachChuyenBay
		set SoGheDaDat=SoGheDaDat+1
		where MaChuyenBay=@i
	end

create trigger tr_BanVe_Update
on Ve
for update
as
	declare @i char(5)
	declare @controng int
	select @i=MaChuyenBay from inserted
	select @controng=SoGheTrong from DanhSachChuyenBay
	where @i=MaChuyenBay
	if (@controng<=0)
	begin
		print 'Da het ve'
		rollback tran
	end
	else
	begin
		update DanhSachChuyenBay
		set SoGheTrong=SoGheTrong-1
		where MaChuyenBay=@i
		update DanhSachChuyenBay
		set SoGheDaDat=SoGheDaDat+1
		where MaChuyenBay=@i
	end


/*Update 11/6*/

/*Trigger thoi gian dat ve cham nhat*/
create trigger tr_ThoiGianDatVeChamNhat
on PhieuDatVe
for insert
as
	declare @i char(5)
	declare @ngaykhoihanh smalldatetime
	declare @ngaydat smalldatetime
	declare @thoigian int
	select @i=MaChuyenBay from inserted
	select @thoigian=ThoiGianChamNhatKhiDatVe from ThamSo
	select @ngaydat=GETDATE()
	select @ngaykhoihanh=NgayGio from LichChuyenBay
	where @i=MaChuyenBay
	if (DATEDIFF(hour,@ngaydat,@ngaykhoihanh)<=@thoigian)
	begin
		print 'Thoi gian dat ve da het'
		rollback tran
	end

create trigger tr_ThoiGianDatVeChamNhat_Update
on PhieuDatVe
for update
as
	declare @i char(5)
	declare @ngaykhoihanh smalldatetime
	declare @ngaydat smalldatetime
	declare @thoigian smalldatetime
	select @i=MaChuyenBay from inserted
	select @thoigian=ThoiGianChamNhatKhiDatVe from ThamSo
	select @ngaydat=GETDATE()
	select @ngaykhoihanh=NgayGio from LichChuyenBay
		where @i=MaChuyenBay
	if (DATEDIFF(hour,@ngaydat,@ngaykhoihanh)<=@thoigian)
	begin
		print 'Thoi gian dat ve da het'
		rollback tran
	end


/*Dữ liệu mẫu*/
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('1',N'Nội Bài')
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('2',N'Tân Sân Nhất')
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('5',N'a')
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('6',N'b')
INSERT INTO LichChuyenBay (MaChuyenBay, SanBayDi, SanBayDen, NgayGio, ThoiGianBay, SoLuongGheHang1, SoLuongGheHang2)
VALUES ('2','2','1','2019/06/21', 40, 1, 1)

SELECT MaChuyenBay, SanBayDi, SanBayDen FROM LichChuyenBay
SELECT * FROM SanBay

SELECT * FROM LoaiVe
INSERT INTO LoaiVe (MaLoaiVe,TenLoaiVe) VALUES ('1','Thuong')
INSERT INTO LoaiVe (MaLoaiVe,TenLoaiVe) VALUES ('2','VIP')
UPDATE LoaiVe set GiaTien = 10000 where MaLoaiVe = '1'

/*drop table ThamSo
drop table ChiTietSanBayTrungGian*/


alter table ThamSo
add check (ThoiGianDungToiDa>ThoiGianDungToiThieu and ThoiGianDungToiThieu>0)


/*Trigger thoi gian dung cua san bay trung gian*/
create trigger tr_ThoiGianDung
on ChiTietSanBayTrungGian
for insert
as
	declare @thoigiandung int
	declare @min int
	declare @max int
	select @thoigiandung=ThoiGianDung from inserted
	select @min=ThoiGianDungToiThieu from ThamSo
	select @max=ThoiGianDungToiDa from ThamSo
	if (@thoigiandung<@min or @thoigiandung>@max)
	begin
		print 'Thoi gian dung khong hop le'
		rollback tran
	end

create trigger tr_ThoiGianDung_Update
on ChiTietSanBayTrungGian
for update
as
	declare @thoigiandung int
	declare @min int
	declare @max int
	select @thoigiandung=ThoiGianDung from inserted
	select @min=ThoiGianDungToiThieu from ThamSo
	select @max=ThoiGianDungToiDa from ThamSo
	if (@thoigiandung<@min or @thoigiandung>@max)
	begin
		print 'Thoi gian dung khong hop le'
		rollback tran
	end
