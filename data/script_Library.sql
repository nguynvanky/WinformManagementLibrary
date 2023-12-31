DROP DATABASE IF EXISTS QuanLyThuVien;
GO
CREATE database QuanLyThuVien
go
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[ChiTietThueSach]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThueSach](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaThueSach] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[NgayThue] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[DaTra] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
	[NguoiChoThue] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoSach]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoSach](
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiThue]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiThue](
	[MaNguoiThue] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiThue] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SoDienThoai] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguoiThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](500) NOT NULL,
	[MaTacGia] [int] NOT NULL,
	[MaTheLoai] [int] NOT NULL,
	[TenNXB] [nvarchar](500) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[LinkHinh] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [int] IDENTITY(1,1) NOT NULL,
	[TenTacGia] [nvarchar](100) NOT NULL,
	[NamSinh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[_USER] [varchar](100) NOT NULL,
	[_PASSWORD] [varchar](100) NOT NULL,
	[FullName] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[_USER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThueSach]    Script Date: 03/01/02023 3:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThueSach](
	[MaThueSach] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoiThue] [int] NOT NULL,
	[SoSachDaMuon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThueSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (1, 3)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (2, 3)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (3, 3)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (4, 5)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (5, 6)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (6, 0)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (7, 3)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (8, 5)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (9, 6)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (10, 7)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (11, 1)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (12, 2)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (13, 10)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (14, 23)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (15, 13)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (16, 54)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (17, 65)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (18, 3)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (19, 23)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (24, 0)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (25, 2)
INSERT [dbo].[KhoSach] ([MaSach], [SoLuong]) VALUES (26, 8)
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (1, N'Thao túng tâm lý', 6, 1, N'Nhà báo trẻ', 1999, N'Thaotungtamly.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (2, N'Đắc nhân tâm', 7, 1, N'Simon and schuster', 1976, N'Dacnhantam.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (3, N'Cuốn theo chiều gió bay', 6, 2, N'Macmillan', 1994, N'Cuontheochieugio.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (4, N'nhà giả kim', 10, 3, N'Editora Rocco Ltda', 1964, N'nhagiakim.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (5, N'Bố già', 11, 4, N'G.P Putnams Sons', 1983, N'Bogia.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (6, N'Ông già và biển cả', 12, 5, N'Charles Scribners Sons', 2000, N'Onggiavabienca.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (7, N'Hoàng tử bé', 6, 6, N'Antoine De Saint - Exupéry', 2001, N'Hoangtube.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (8, N'Chiến tranh và hoà bình', 6, 7, N'Russki Vestnik', 1999, N'Chientranhvahoabinh.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (9, N'Không gia đình', 10, 2, N'Nhà xuất bản văn học', 1988, N'Khonggiadinh.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (10, N'cuộc đời của Pi', 11, 5, N'Knopf Canada', 1975, N'cuocdoicuaPi.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (11, N'Bá tước Monte Cristo', 12, 4, N'Alexandre Dumas', 1982, N'BatuocMonteCristo.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (12, N'Cách nghĩ để thành công', 6, 7, N'The Ralston Society', 1998, N'Cachnghidethanhcong.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (13, N'7 Thói quen của người thành đạt', 7, 6, N'Free Press', 2002, N'7Thoiquencuanguoithanhdat.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (14, N'Cuộc sống không giới hạn', 8, 3, N'Nick Vujicic', 2006, N'Cuocsongkhonggioihan.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (15, N'Hành trình về Phương Đông', 8, 4, N'Baird T Spalding', 1892, N'HanhtrinhvePhuongDong.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (16, N'Người giàu có nhất thành Babylon', 10, 5, N'Penguin Books', 1993, N'NguoigiauconhatthanhBabylon.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (17, N'Quăng gánh lo đi mà vui sống', 11, 6, N'Simon and schuster', 1991, N'Quangganhlodimavuisong.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (18, N'Hạt giống tâm hồn', 12, 7, N'Jack Canfield', 1992, N'Hatgiongtamhon.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (19, N'Tốc độ của niềm tin', 6, 2, N'Stephen R Covey', 1989, N'Tocdocuaniemtin.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (24, N'Sang chấn tâm lý', 16, 6, N'Việt Nam', 2012, N'359cbfb80b5fa50d2fa8028db79b22b8.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (25, N'Đọc vị bất kỳ ai', 8, 4, N'Việt Nam', 2000, N'images.jpg')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [TenNXB], [NamXuatBan], [LinkHinh]) VALUES (26, N'Tôi tự học', 10, 1, N'Việt Nam', 2000, N'h_nh_3.jpg')
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (6, N'Shannon Thomas EdiTion', 1982)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (7, N'Dale Carnegie
', 1888)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (8, N'Margaret Mitchell
', 1900)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (10, N'Mario Puzo
', 1972)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (11, N'Ernest Hemingway
', 1899)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (12, N'Lev Nikolayevich Tolstoy
', 1828)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (16, N'Lê Phan Như Quỳnh', 1990)
SET IDENTITY_INSERT [dbo].[TacGia] OFF
GO
INSERT [dbo].[TaiKhoan] ([_USER], [_PASSWORD], [FullName]) VALUES (N'admin', N'admin', N'admin')
INSERT [dbo].[TaiKhoan] ([_USER], [_PASSWORD], [FullName]) VALUES (N'nhattruong', N'nhattruong', N'Đỗ Nhật Trường')
INSERT [dbo].[TaiKhoan] ([_USER], [_PASSWORD], [FullName]) VALUES (N'vanky', N'0403', N'Nguyễn Văn Kỳ')
GO
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Văn hóa xã hội - Lịch sử
')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Truyện Tranh ảnh')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'Tiểu thuyết
')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (4, N'Chính trị gia')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (5, N'Khoa học công nghệ
')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (6, N'Tâm lý học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (7, N'Tôn giáo
')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
GO
ALTER TABLE [dbo].[KhoSach] ADD  DEFAULT ((1)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[ChiTietThueSach]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietThueSach]  WITH CHECK ADD FOREIGN KEY([MaThueSach])
REFERENCES [dbo].[ThueSach] ([MaThueSach])
GO
ALTER TABLE [dbo].[KhoSach]  WITH CHECK ADD  CONSTRAINT [FK_KhoSach_ToSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[KhoSach] CHECK CONSTRAINT [FK_KhoSach_ToSach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[ThueSach]  WITH CHECK ADD FOREIGN KEY([MaNguoiThue])
REFERENCES [dbo].[NguoiThue] ([MaNguoiThue])
GO
