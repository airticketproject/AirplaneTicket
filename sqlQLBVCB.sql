create database QLBVMB
use QLBVMB

create table LichChuyenBay
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

create table SanBay
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
MaChuyenBay nvarchar(5) not null primary key,
SoGheTrong int,
SoGheDaDat int
)

create table HangVe
(
MaHangVe nvarchar(5) not null primary key,
TenHangVe nvarchar(20),
TiLeDonGia float  not null
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
MaChuyenBay nvarchar(5) not null,
MaSanBay nvarchar(5) not null,
ThoiGianDung int,
GhiChu nvarchar(30)
constraint FK_ChiTietSanBayTrungGian primary key (MaChuyenBay,MaSanBay)
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
Thang int not null,
Nam int not null,
MaChuyenBay nvarchar(5) not null,
SoLuongVe int,
DoanhThu int,
TiLe float
constraint PK_DoanhThuTheoThang primary key (Thang,Nam,MaChuyenBay)
)

create table DoanhThuTheoNam
(
Nam int not null,
Thang int not null,
SoChuyenBay int,
DoanhThu int,
TiLe float
constraint PK_DoanhThuTheoNam primary key (Nam,Thang)
)

alter table LichChuyenBay
add constraint FK_LichChuyenBay_SanBayDi foreign key (SanBayDi) references SanBay(MaSanBay),
	constraint FK_LichChuyenBay_SanBayDen foreign key (SanBayDen) references SanBay(MaSanBay)

alter table DanhSachChuyenBay
add constraint FK_DanhSachChuyenBay_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay) on delete cascade

alter table PhieuDatVe
add constraint FK_PhieuDatVe_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay) on delete cascade,
	constraint FK_PhieuDatVe_MaHanhKhach foreign key (MaHanhKhach) references HanhKhach(MaHanhKhach) on delete cascade,
	constraint FK_PhieuDatVe_MaHangVe foreign key (MaHangVe) references HangVe(MaHangVe) on delete cascade

alter table Ve
add constraint FK_Ve_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay) on delete cascade,
	constraint FK_Ve_MaHanhKhach foreign key (MaHanhKhach) references HanhKhach(MaHanhKhach) on delete cascade,
	constraint FK_Ve_MaHangVe foreign key (MaHangVe) references HangVe(MaHangVe) on delete cascade

alter table DoanhThuTheoThang
	add constraint FK_DoanhThuTheoThang_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay) on delete cascade

alter table ChiTietSanBayTrungGian
add constraint FK_ChiTietSanBayTrungGian_MaChuyenBay foreign key (MaChuyenBay) references LichChuyenBay(MaChuyenBay) on delete cascade,
	constraint FK_ChiTietSanBayTrungGian_MaSanBay foreign key (MaSanBay) references SanBay(MaSanBay) on delete cascade

alter table LichChuyenBay
add	check (ThoiGianBay>0),
	check (SoLuongGheHang1>=0),
	check (SoLuongGheHang2>=0)

alter table DanhSachChuyenBay
add check (SoGheTrong>=0),
	check (SoGheDaDat>=0)

alter table HangVe
add check (TiLeDonGia>=0)

alter table DoanhThuTheoThang
add check (Thang>=0 and Thang<=12),
	check (Nam>=2018)

create trigger tr_SanBayKhacNhau
on LichChuyenBay
for insert, update
as
	declare @di nvarchar(5)
	declare @den nvarchar(5)
	select @di=SanBayDi, @den=SanBayDen
	from inserted
	if (@di=@den)
	begin
		print 'Sân bay đi và sân bay đến không được trùng nhau'
		rollback tran
	end

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
		print 'Thời gian bay < thời gian bay tối thiểu'
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
		print 'Thời gian bay < thời gian bay tối thiểu'
		rollback tran
	end

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
		print 'Số lượng sân bay trung gian vượt quá số lượng tối đa'
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
		print 'Số lượng sân bay trung gian vượt quá số lượng tối đa'
		rollback tran
	end

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
		print 'Thời gian đặt vé đã hết'
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
		print 'Thời gian đặt vé đã hết'
		rollback tran
	end

alter table ThamSo
add check (ThoiGianDungToiDa>ThoiGianDungToiThieu and ThoiGianDungToiThieu>0)

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
		print 'Thời gian dừng không hợp lệ'
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
		print 'Thời gian dừng không hợp lệ'
		rollback tran
	end

create trigger tr_DanhSachChuyenBay_insert
on LichChuyenBay
for insert
as
begin
	declare @ma nvarchar(5)
	declare @ghe int
	select @ma=MaChuyenBay from inserted
	select @ghe=SoLuongGheHang1+SoLuongGheHang2 from inserted
	insert into DanhSachChuyenBay values (@ma,@ghe,0)
end

create trigger tr_DanhSachChuyenBay_update
on LichChuyenBay
for insert
as
begin
	declare @ma nvarchar(5)
	declare @ghe int
	select @ma=MaChuyenBay from inserted
	select @ghe=SoLuongGheHang1+SoLuongGheHang2 from inserted
	update DanhSachChuyenBay
	set SoGheTrong=@ghe, SoGheDaDat=0
	where MaChuyenBay=@ma
end

<<<<<<< Updated upstream

/*Trigger chi ban ve khi con cho*/
=======
>>>>>>> Stashed changes
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
		print 'Đã hết vé'
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
		print 'Đã hết vé'
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

create trigger tr_CheckTrungSanBayTrungGian
on ChiTietSanBayTrungGian
for insert
as
	declare @i nvarchar(5)
	declare @sanbay nvarchar(5)
	declare @di nvarchar(5)
	declare @den nvarchar(5)
	select @i=MaChuyenBay from inserted
	select @sanbay=MaSanBay from inserted
	select @di=SanBayDi from LichChuyenBay
	where MaChuyenBay=@i
	select @den=SanBayDen from LichChuyenBay
	where MaChuyenBay=@i
	if (@di=@sanbay) or (@den=@sanbay)
	begin
		print 'Sân bay trung gian trùng với sân bay đi hoặc đến'
		rollback tran
	end

create trigger tr_CheckTrungSanBayTrungGian_update
on ChiTietSanBayTrungGian
for update
as
	declare @i nvarchar(5)
	declare @sanbay nvarchar(5)
	declare @di nvarchar(5)
	declare @den nvarchar(5)
	select @i=MaChuyenBay from inserted
	select @sanbay=MaSanBay from inserted
	select @di=SanBayDi from LichChuyenBay
	where MaChuyenBay=@i
	select @den=SanBayDen from LichChuyenBay
	where MaChuyenBay=@i
	if (@di=@sanbay) or (@den=@sanbay)
	begin
		print 'Sân bay trung gian trùng với sân bay đi hoặc đến'
		rollback tran
	end

create proc proc_BaoCaoDoanhThuThang
@thang int,
@nam int
as
begin
	insert into DoanhThuTheoThang (Thang,Nam,MaChuyenBay,SoLuongVe,DoanhThu)
	select @thang, @nam, a.MaChuyenBay, count(b.MaVe), sum(a.GiaVe*c.TiLeDonGia)
	from LichChuyenBay a, Ve b, HangVe c
	where month(a.NgayGio)=@thang and year(a.NgayGio)=@nam and a.MaChuyenBay=b.MaChuyenBay and b.MaHangVe=c.MaHangVe
	group by a.MaChuyenBay
	declare @tong int
	select @tong=sum(DoanhThu)
	from DoanhThuTheoThang
	where Thang=@thang and Nam=@nam
	update DoanhThuTheoThang
	set TiLe=(convert(float,DoanhThu)/convert(float,@tong))
	where Thang=@thang and Nam=@nam
end

create proc proc_ClearThang
as
begin
	delete from DoanhThuTheoThang
end

create proc proc_BaoCaoDoanhThuNam
@nam int
as
begin
	delete from DoanhThuTheoNam
	insert into DoanhThuTheoNam (Thang,Nam,SoChuyenBay,DoanhThu)
	select distinct Thang, @nam, count(MaChuyenBay),sum(DoanhThu)
	from DoanhThuTheoThang
	where Nam=@nam
	group by Thang,Nam
	declare @tong int
	select @tong=sum(DoanhThu)
	from DoanhThuTheoNam
	where Nam=@nam
	update DoanhThuTheoNam
	set TiLe=(convert(float,DoanhThu)/convert(float,@tong))
	where Nam=@nam
end

INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('1',N'Nội Bài')
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('2',N'Tân Sân Nhất')
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('5',N'a')
INSERT INTO SanBay (MaSanBay,TenSanBay) VALUES ('6',N'b')
insert into ThamSo values (10,2,100,10,24,24)
insert into LichChuyenBay values ('1','1','2','2018-06-29',20,1,1,100000)
insert into LichChuyenBay values ('3','1','2','2019-10-29',20,1,1,200000)
insert into LichChuyenBay values ('2','2','1','2019/06/29', 40, 1, 1, 500000)
INSERT INTO HangVe (MaHangVe,TenHangVe,TiLeDonGia) VALUES ('1','Thuong',1)
INSERT INTO HangVe (MaHangVe,TenHangVe,TiLeDonGia) VALUES ('2','VIP',1.05)
insert into PhieuDatVe values ('1','1','2','2')
insert into Ve values ('1','1','3','2')
insert into Ve values ('1','1','1','1')
insert into Ve values ('1','1','2','1')
insert into ChiTietSanBayTrungGian values ('1','5',30,'a')
insert into ChiTietSanBayTrungGian values ('1','6',30,'a')
