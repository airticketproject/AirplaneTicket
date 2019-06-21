create database QLBVMB
--use master
--drop database QLBVMB
use QLBVMB


CREATE TABLE LichChuyenBay
(
MaChuyenBay nvarchar(5) NOT NULL PRIMARY KEY,
SanBayDi nvarchar(5) not null,
SanBayDen nvarchar(5) not null,
NgayGio DATETIME2(7),
ThoiGianBay int not null,
SoLuongGheHang1 int,
SoLuongGheHang2 int,
GiaVe int
)

Create table SanBay
(
MaSanBay nvarchar(5) not null primary key,
TenSanBay nvarchar(20)
)

create table HanhKhach
(
MaHanhKhach nvarchar(10) not null primary key,
TenHanhKhach nvarchar(40),
CMND nvarchar(9),
DienThoai nvarchar(11)
)

create table DanhSachChuyenBay
(
MaDanhSach nvarchar(5) not null primary key,
MaChuyenBay nvarchar(5) not null,
SoGheTrong int,
SoGheDaDat int
)

create table HangVe
(
MaHangVe nvarchar(5) not null primary key,
TenHangVe nvarchar(20),
TiLeDonGia float  not null /*vd: ti le don gia = 0.9 tuong duong voi 90%, ti le don gia = 1.05 tuong duong voi 105%*/
)

create table PhieuDatVe
(
MaPhieuDat nvarchar(5) not null,
MaHanhKhach nvarchar(10) not null,
MaChuyenBay nvarchar(5) not null,
MaHangVe nvarchar(5) not null
constraint PK_PhieuDatVe primary key (MaPhieuDat,MaChuyenBay)
)

create table Ve
(
MaVe nvarchar(5) not null,
MaHanhKhach nvarchar(10) not null,
MaChuyenBay nvarchar(5) not null,
MaHangVe nvarchar(5) not null
constraint PK_Ve primary key (MaVe,MaChuyenBay)
)

create table ChiTietSanBayTrungGian
(
MaChiTietSanBayTrungGian nvarchar(5) not null primary key,
MaChuyenBay nvarchar(5) not null,
MaSanBay nvarchar(5) not null,
ThoiGianDung int,
GhiChu nvarchar(30)
)

create table ThamSo
(
ThoiGianBayToiThieu int,
SoLuongSanBayTrungGianToiDa int,
ThoiGianDungToiDa int,
ThoiGianDungToiThieu int,
ThoiGianChamNhatKhiDatVe int,
ThoiGianHuyVe int
)

create table DoanhThuTheoThang
(
MaDoanhThuTheoThang nvarchar(5) not null primary key,
MaChuyenBay nvarchar(5) not null,
SoLuongVe int,
DoanhThu money,
TiLe float
)

create table DoanhThuTheoNam
(
MaDoanhThuTheoNam nvarchar(5) not null primary key,
MaDoanhThuTheoThang nvarchar(5) not null,
SoChuyenBay int,
DoanhThu int,
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
	constraint FK_PhieuDatVe_MaHangVe foreign key (MaHangVe) references HangVe(MaHangVe)

alter table Ve
add constraint FK_Ve_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay),
	constraint FK_Ve_MaHanhKhach foreign key (MaHanhKhach) references HanhKhach(MaHanhKhach),
	constraint FK_Ve_MaHangVe foreign key (MaHangVe) references HangVe(MaHangVe)

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

alter table HangVe
add check (TiLeDonGia>=0)

--Select * from LichChuyenBay
--Update LichChuyenBay set SoLuongGheHang1 = 10
--Where MaChuyenBay = '2'

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
	declare @i nvarchar(5)
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
	declare @i nvarchar(5)
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
	declare @i nvarchar(5)
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
	declare @i nvarchar(5)
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
	declare @i nvarchar(5)
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
	declare @i nvarchar(5)
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
INSERT INTO LichChuyenBay (MaChuyenBay, SanBayDi, SanBayDen, NgayGio, ThoiGianBay, SoLuongGheHang1, SoLuongGheHang2, GiaVe)
VALUES ('2','2','1','2019/06/21', 40, 1, 1, 100000)

SELECT MaChuyenBay, SanBayDi, SanBayDen FROM LichChuyenBay
SELECT * FROM SanBay

SELECT * FROM HangVe
INSERT INTO HangVe (MaHangVe,TenHangVe,TiLeDonGia) VALUES ('1','Thuong',1) /*hang thuong co gia ve = 1*gia ve*/
INSERT INTO HangVe (MaHangVe,TenHangVe,TiLeDonGia) VALUES ('2','VIP',1.05) /*hang vip co gia ve = 1.05*gia ve*/
/*UPDATE HangVe set GiaTien = 10000 where MaHangVe = '1'*/

/*drop table ThamSo
drop table ChiTietSanBayTrungGian*/


/*Update 18/6*/

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
