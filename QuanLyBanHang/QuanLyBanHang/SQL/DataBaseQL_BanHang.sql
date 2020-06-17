USE [QL_BanHang]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[TaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Admin_1] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'123456')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[RankNV] [varchar](10) NOT NULL,
	[TaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [RankNV], [TaiKhoan], [MatKhau]) VALUES (N'nv1', N'Phạm Quang Thiện', 1, N'Tuyên Quang', N'5', N'8000000', N'thien123', N'123456')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [RankNV], [TaiKhoan], [MatKhau]) VALUES (N'nv2', N'Phạm Hồng Quân', 1, N'Hà Nam', N'564', N'5000000', N'quan13', N'213')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [SDT], [RankNV], [TaiKhoan], [MatKhau]) VALUES (N'nv3', N'Vũ Thái Trường', 1, N'Hà Nam', N'5', N'3000000', N'truong1', N'123456')
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SDT] [int] NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Mail], [DiaChi]) VALUES (N'ncc1', N'Samsung', 5, N'sdfsdf', N'Bắc ninh')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Mail], [DiaChi]) VALUES (N'ncc2', N'Apple', 5, N'apple@gmail.com', N'Hà nội')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[SoDiem] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [MaNV], [SoDiem]) VALUES (N'kh1', N'Vũ Thu Hường', N'654', 0, N'Hưng Yên', N'nv1', 5)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [MaNV], [SoDiem]) VALUES (N'kh2', N'Hà Duy Hưng', N'777', 1, N'Hưng Yên', N'nv2', 5)
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[MaNCC] [varchar](10) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[HoaHong] [int] NOT NULL,
 CONSTRAINT [PK_HoaHong] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HangHoa] ([MaHH], [TenHang], [MaNCC], [DonGia], [SoLuong], [HoaHong]) VALUES (N'gg', N'IphoneX', N'ncc2', 25000, 5000, 1250)
INSERT [dbo].[HangHoa] ([MaHH], [TenHang], [MaNCC], [DonGia], [SoLuong], [HoaHong]) VALUES (N'gggg', N'GalaxyS9', N'ncc1', 20000, 96000, 1000)
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'hd1', N'kh1', N'nv1', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'hd2', N'kh2', N'nv3', CAST(0x013F0B00 AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'hd3', N'kh1', N'nv2', CAST(0x013F0B00 AS Date))
/****** Object:  View [dbo].[hangton]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hangton]
as
select HangHoa.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,HangHoa.DonGia,HangHoa.SoLuong
from HangHoa inner join NhaCungCap on HangHoa.MaNCC = NhaCungCap.MaNCC
group by HangHoa.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,HangHoa.DonGia,HangHoa.SoLuong
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'gg', 30000, 2000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'gggg', 35000, 2000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'gg', 32000, 3000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'gggg', 35000, 2000)
/****** Object:  View [dbo].[BangLuong]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BangLuong]
as
select NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)as'Luong cung',Sum(HangHoa.HoaHong*ChiTietHoaDon.SoLuong)as'Hoa hong'
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join NhanVien on HoaDon.MaNV = NhanVien.MaNV
group by NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)
GO
/****** Object:  View [dbo].[InHoaDon]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[InHoaDon]
as
select ChiTietHoaDon.MaHD , ChiTietHoaDon.MaHH , HangHoa.TenHang, NhaCungCap.TenNCC , KhachHang.TenKH , KhachHang.GioiTinh , KhachHang.DiaChi ,KhachHang.SDT ,NhanVien.MaNV,NhanVien.TenNV, ChiTietHoaDon.DonGia , ChiTietHoaDon.SoLuong
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on KhachHang.MaNV = NhanVien.MaNV
group by ChiTietHoaDon.MaHD , ChiTietHoaDon.MaHH , HangHoa.TenHang, NhaCungCap.TenNCC , KhachHang.TenKH , KhachHang.GioiTinh , KhachHang.DiaChi ,KhachHang.SDT , ChiTietHoaDon.DonGia , ChiTietHoaDon.SoLuong,NhanVien.MaNV,NhanVien.TenNV
GO
/****** Object:  View [dbo].[hangban]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hangban]
as
select ChiTietHoaDon.MaHD, ChiTietHoaDon.MaHH , HangHoa.TenHang, KhachHang.TenKH , ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH
group by ChiTietHoaDon.MaHD, ChiTietHoaDon.MaHH , HangHoa.TenHang,KhachHang.TenKH,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong
GO
/****** Object:  View [dbo].[DoanhThu]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DoanhThu]
as
select ChiTietHoaDon.MaHH,TenHang,ChiTietHoaDon.DonGia as'dongiaban',ChiTietHoaDon.SoLuong as'Soluongban',HangHoa.SoLuong as'Soluongnhap',HangHoa.DonGia as'dongianhap',HoaDon.NgayLap
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD
group by ChiTietHoaDon.MaHH,TenHang,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HangHoa.SoLuong,HangHoa.DonGia,HoaDon.NgayLap
GO
/****** Object:  View [dbo].[DanhSachBan]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DanhSachBan]
as	
select ChiTietHoaDon.MaHD,KhachHang.TenKH,ChiTietHoaDon.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HoaDon.MaNV,NhanVien.TenNV,HoaDon.NgayLap
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on KhachHang.MaNV = NhanVien.MaNV
group by ChiTietHoaDon.MaHD,KhachHang.TenKH,ChiTietHoaDon.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HoaDon.MaNV,NhanVien.TenNV,HoaDon.NgayLap
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HangHoa]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HangHoa]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_HangHoa_NhaCungCap]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_HoaDon_KhachHang]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien1]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien1]
GO
/****** Object:  ForeignKey [FK_KhachHang_NhanVien]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NhanVien]
GO
