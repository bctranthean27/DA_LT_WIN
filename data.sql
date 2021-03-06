USE [QL_CH_CAFE]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[Dchi] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[Mail] [varchar](20) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiHoaDon]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiHoaDon](
	[MaLoaiHD] [varchar](10) NOT NULL,
	[TenLoaiHD] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Dchi] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[Mail] [varchar](20) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [varchar](10) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Size]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Size](
	[MaSize] [varchar](10) NOT NULL,
	[TenSize] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaLoai] [varchar](10) NULL,
	[MaNCC] [varchar](10) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoNV] [nvarchar](20) NULL,
	[TenNV] [nvarchar](50) NULL,
	[Dchi] [nvarchar](50) NULL,
	[NgayVaoLam] [date] NULL,
	[MaChucVu] [varchar](10) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NULL,
	[NgayLap] [date] NULL,
	[MaLoaiHD] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[MaCTSP] [varchar](20) NULL,
	[MaSP] [varchar](10) NOT NULL,
	[MaSize] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_CTSP] PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 05/16/2022 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [varchar](30) NULL,
	[MaHD] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[GiaGoc] [int] NULL,
	[KhuyenMai] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__ChiTietSa__Trang__37A5467C]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[ChiTietSanPham] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__HoaDon__TrangTha__2F10007B]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__KhachHang__Trang__164452B1]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__LoaiHoaDo__Trang__117F9D94]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[LoaiHoaDon] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__LoaiSanPh__Trang__398D8EEE]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[LoaiSanPham] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__NhaCungCa__Trang__0CBAE877]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__NhanVien__TrangT__20C1E124]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__SanPham__TrangTh__276EDEB3]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  Default [DF__Size__TrangThai__38996AB5]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[Size] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
/****** Object:  ForeignKey [FK__ChiTietHoa__MaHD__31EC6D26]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
/****** Object:  ForeignKey [FK__ChiTietHoa__MaSP__32E0915F]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
/****** Object:  ForeignKey [FK__ChiTietSa__MaSiz__36B12243]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
/****** Object:  ForeignKey [FK__ChiTietSan__MaSP__35BCFE0A]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
/****** Object:  ForeignKey [FK__HoaDon__MaKH__2C3393D0]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
/****** Object:  ForeignKey [FK__HoaDon__MaLoaiHD__2D27B809]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaLoaiHD])
REFERENCES [dbo].[LoaiHoaDon] ([MaLoaiHD])
GO
/****** Object:  ForeignKey [FK__HoaDon__MaNV__2E1BDC42]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
/****** Object:  ForeignKey [FK__NhanVien__MaChuc__1FCDBCEB]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__SanPham__MaLoai__25869641]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
/****** Object:  ForeignKey [FK__SanPham__MaNCC__267ABA7A]    Script Date: 05/16/2022 06:39:43 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO

/*Add new table */
