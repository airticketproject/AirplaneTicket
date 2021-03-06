CREATE DATABASE QLBVMB
GO
USE [QLBVMB]
GO
/****** Object:  Table [dbo].[ChiTietSanBayTrungGian]    Script Date: 25/06/2019 14:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanBayTrungGian](
	[MaChuyenBay] [nvarchar](5) NOT NULL,
	[MaSanBay] [nvarchar](5) NOT NULL,
	[ThoiGianDung] [int] NULL,
	[GhiChu] [nvarchar](30) NULL,
 CONSTRAINT [FK_ChiTietSanBayTrungGian] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC,
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachChuyenBay]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachChuyenBay](
	[MaChuyenBay] [nvarchar](5) NOT NULL,
	[SoGheTrong] [int] NULL,
	[SoGheDaDat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThuTheoNam]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThuTheoNam](
	[Nam] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[SoChuyenBay] [int] NULL,
	[DoanhThu] [int] NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_DoanhThuTheoNam] PRIMARY KEY CLUSTERED 
(
	[Nam] ASC,
	[Thang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThuTheoThang]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThuTheoThang](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[MaChuyenBay] [nvarchar](5) NOT NULL,
	[SoLuongVe] [int] NULL,
	[DoanhThu] [int] NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_DoanhThuTheoThang] PRIMARY KEY CLUSTERED 
(
	[Thang] ASC,
	[Nam] ASC,
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangVe]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangVe](
	[MaHangVe] [nvarchar](5) NOT NULL,
	[TenHangVe] [nvarchar](20) NULL,
	[TiLeDonGia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HanhKhach]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HanhKhach](
	[MaHanhKhach] [nvarchar](10) NOT NULL,
	[TenHanhKhach] [nvarchar](40) NULL,
	[CMND] [nvarchar](9) NULL,
	[DienThoai] [nvarchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHanhKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichChuyenBay]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChuyenBay](
	[MaChuyenBay] [nvarchar](5) NOT NULL,
	[SanBayDi] [nvarchar](5) NOT NULL,
	[SanBayDen] [nvarchar](5) NOT NULL,
	[NgayGio] [datetime2](7) NULL,
	[ThoiGianBay] [int] NOT NULL,
	[SoLuongGheHang1] [int] NULL,
	[SoLuongGheHang2] [int] NULL,
	[GiaVe] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatVe]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatVe](
	[MaPhieuDat] [nvarchar](5) NOT NULL,
	[MaHanhKhach] [nvarchar](10) NOT NULL,
	[MaChuyenBay] [nvarchar](5) NOT NULL,
	[MaHangVe] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_PhieuDatVe] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC,
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanBay]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanBay](
	[MaSanBay] [nvarchar](5) NOT NULL,
	[TenSanBay] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[ThoiGianBayToiThieu] [int] NULL,
	[SoLuongSanBayTrungGianToiDa] [int] NULL,
	[ThoiGianDungToiDa] [int] NULL,
	[ThoiGianDungToiThieu] [int] NULL,
	[ThoiGianChamNhatKhiDatVe] [int] NULL,
	[ThoiGianHuyVe] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [nvarchar](5) NOT NULL,
	[MaHanhKhach] [nvarchar](10) NOT NULL,
	[MaChuyenBay] [nvarchar](5) NOT NULL,
	[MaHangVe] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC,
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietSanBayTrungGian] ([MaChuyenBay], [MaSanBay], [ThoiGianDung], [GhiChu]) VALUES (N'1', N'5', 30, N'a')
INSERT [dbo].[ChiTietSanBayTrungGian] ([MaChuyenBay], [MaSanBay], [ThoiGianDung], [GhiChu]) VALUES (N'1', N'6', 30, N'a')
INSERT [dbo].[DanhSachChuyenBay] ([MaChuyenBay], [SoGheTrong], [SoGheDaDat]) VALUES (N'1', 0, 2)
INSERT [dbo].[DanhSachChuyenBay] ([MaChuyenBay], [SoGheTrong], [SoGheDaDat]) VALUES (N'2', 1, 1)
INSERT [dbo].[DanhSachChuyenBay] ([MaChuyenBay], [SoGheTrong], [SoGheDaDat]) VALUES (N'3', 2, 0)
INSERT [dbo].[DoanhThuTheoThang] ([Thang], [Nam], [MaChuyenBay], [SoLuongVe], [DoanhThu], [TiLe]) VALUES (6, 2019, N'2', 1, 525000, 1)
INSERT [dbo].[HangVe] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'1', N'Thuong', 1)
INSERT [dbo].[HangVe] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'2', N'VIP', 1.05)
INSERT [dbo].[HanhKhach] ([MaHanhKhach], [TenHanhKhach], [CMND], [DienThoai]) VALUES (N'1', N'Duy', N'251139329', N'123456789')
INSERT [dbo].[LichChuyenBay] ([MaChuyenBay], [SanBayDi], [SanBayDen], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [SoLuongGheHang2], [GiaVe]) VALUES (N'1', N'1', N'2', CAST(N'2018-06-29T00:00:00.0000000' AS DateTime2), 20, 1, 1, 100000)
INSERT [dbo].[LichChuyenBay] ([MaChuyenBay], [SanBayDi], [SanBayDen], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [SoLuongGheHang2], [GiaVe]) VALUES (N'2', N'2', N'1', CAST(N'2019-06-29T00:00:00.0000000' AS DateTime2), 40, 1, 1, 500000)
INSERT [dbo].[LichChuyenBay] ([MaChuyenBay], [SanBayDi], [SanBayDen], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [SoLuongGheHang2], [GiaVe]) VALUES (N'3', N'1', N'2', CAST(N'2019-10-29T00:00:00.0000000' AS DateTime2), 20, 1, 1, 200000)
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'1', N'Nội Bài')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'2', N'Tân Sân Nhất')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'5', N'a')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'6', N'b')
INSERT [dbo].[ThamSo] ([ThoiGianBayToiThieu], [SoLuongSanBayTrungGianToiDa], [ThoiGianDungToiDa], [ThoiGianDungToiThieu], [ThoiGianChamNhatKhiDatVe], [ThoiGianHuyVe]) VALUES (10, 2, 100, 10, 24, 24)
INSERT [dbo].[Ve] ([MaVe], [MaHanhKhach], [MaChuyenBay], [MaHangVe]) VALUES (N'hprwo', N'1', N'1', N'1')
INSERT [dbo].[Ve] ([MaVe], [MaHanhKhach], [MaChuyenBay], [MaHangVe]) VALUES (N'lenbm', N'1', N'1', N'1')
INSERT [dbo].[Ve] ([MaVe], [MaHanhKhach], [MaChuyenBay], [MaHangVe]) VALUES (N'vwnyu', N'1', N'2', N'2')
ALTER TABLE [dbo].[ChiTietSanBayTrungGian]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSanBayTrungGian_MaChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LichChuyenBay] ([MaChuyenBay])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietSanBayTrungGian] CHECK CONSTRAINT [FK_ChiTietSanBayTrungGian_MaChuyenBay]
GO
ALTER TABLE [dbo].[ChiTietSanBayTrungGian]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSanBayTrungGian_MaSanBay] FOREIGN KEY([MaSanBay])
REFERENCES [dbo].[SanBay] ([MaSanBay])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietSanBayTrungGian] CHECK CONSTRAINT [FK_ChiTietSanBayTrungGian_MaSanBay]
GO
ALTER TABLE [dbo].[DanhSachChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachChuyenBay_MaChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LichChuyenBay] ([MaChuyenBay])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanhSachChuyenBay] CHECK CONSTRAINT [FK_DanhSachChuyenBay_MaChuyenBay]
GO
ALTER TABLE [dbo].[DoanhThuTheoThang]  WITH CHECK ADD  CONSTRAINT [FK_DoanhThuTheoThang_MaChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LichChuyenBay] ([MaChuyenBay])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoanhThuTheoThang] CHECK CONSTRAINT [FK_DoanhThuTheoThang_MaChuyenBay]
GO
ALTER TABLE [dbo].[LichChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_LichChuyenBay_SanBayDen] FOREIGN KEY([SanBayDen])
REFERENCES [dbo].[SanBay] ([MaSanBay])
GO
ALTER TABLE [dbo].[LichChuyenBay] CHECK CONSTRAINT [FK_LichChuyenBay_SanBayDen]
GO
ALTER TABLE [dbo].[LichChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_LichChuyenBay_SanBayDi] FOREIGN KEY([SanBayDi])
REFERENCES [dbo].[SanBay] ([MaSanBay])
GO
ALTER TABLE [dbo].[LichChuyenBay] CHECK CONSTRAINT [FK_LichChuyenBay_SanBayDi]
GO
ALTER TABLE [dbo].[PhieuDatVe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatVe_MaChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LichChuyenBay] ([MaChuyenBay])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDatVe] CHECK CONSTRAINT [FK_PhieuDatVe_MaChuyenBay]
GO
ALTER TABLE [dbo].[PhieuDatVe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatVe_MaHangVe] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HangVe] ([MaHangVe])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDatVe] CHECK CONSTRAINT [FK_PhieuDatVe_MaHangVe]
GO
ALTER TABLE [dbo].[PhieuDatVe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatVe_MaHanhKhach] FOREIGN KEY([MaHanhKhach])
REFERENCES [dbo].[HanhKhach] ([MaHanhKhach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDatVe] CHECK CONSTRAINT [FK_PhieuDatVe_MaHanhKhach]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_MaChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LichChuyenBay] ([MaChuyenBay])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_MaChuyenBay]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_MaHangVe] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HangVe] ([MaHangVe])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_MaHangVe]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_MaHanhKhach] FOREIGN KEY([MaHanhKhach])
REFERENCES [dbo].[HanhKhach] ([MaHanhKhach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_MaHanhKhach]
GO
ALTER TABLE [dbo].[DanhSachChuyenBay]  WITH CHECK ADD CHECK  (([SoGheTrong]>=(0)))
GO
ALTER TABLE [dbo].[DanhSachChuyenBay]  WITH CHECK ADD CHECK  (([SoGheDaDat]>=(0)))
GO
ALTER TABLE [dbo].[DoanhThuTheoThang]  WITH CHECK ADD CHECK  (([Thang]>=(0) AND [Thang]<=(12)))
GO
ALTER TABLE [dbo].[DoanhThuTheoThang]  WITH CHECK ADD CHECK  (([Nam]>=(2018)))
GO
ALTER TABLE [dbo].[HangVe]  WITH CHECK ADD CHECK  (([TiLeDonGia]>=(0)))
GO
ALTER TABLE [dbo].[LichChuyenBay]  WITH CHECK ADD CHECK  (([SoLuongGheHang1]>=(0)))
GO
ALTER TABLE [dbo].[LichChuyenBay]  WITH CHECK ADD CHECK  (([SoLuongGheHang2]>=(0)))
GO
ALTER TABLE [dbo].[LichChuyenBay]  WITH CHECK ADD CHECK  (([ThoiGianBay]>(0)))
GO
ALTER TABLE [dbo].[ThamSo]  WITH CHECK ADD CHECK  (([ThoiGianDungToiDa]>[ThoiGianDungToiThieu] AND [ThoiGianDungToiThieu]>(0)))
GO
ALTER TABLE [dbo].[ThamSo]  WITH CHECK ADD CHECK  (([SoLuongSanBayTrungGianToiDa]>(0)))
GO
ALTER TABLE [dbo].[ThamSo]  WITH CHECK ADD CHECK  (([ThoiGianBayToiThieu]>(0)))
GO
ALTER TABLE [dbo].[ThamSo]  WITH CHECK ADD CHECK  (([ThoiGianChamNhatKhiDatVe]>(0)))
GO
ALTER TABLE [dbo].[ThamSo]  WITH CHECK ADD CHECK  (([ThoiGianHuyVe]>(0)))
GO
/****** Object:  StoredProcedure [dbo].[proc_BaoCaoDoanhThuNam]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_BaoCaoDoanhThuNam]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_BaoCaoDoanhThuThang]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_BaoCaoDoanhThuThang]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_ClearThang]    Script Date: 25/06/2019 14:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ClearThang]
as
begin
	delete from DoanhThuTheoThang
end
GO
