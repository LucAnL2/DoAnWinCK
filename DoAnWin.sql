USE [master]
GO
/****** Object:  Database [DoAnWin]    Script Date: 5/12/2024 2:15:23 AM ******/
CREATE DATABASE [DoAnWin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAnWin', FILENAME = N'C:\Users\Admin\DoAnWin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DoAnWin_log', FILENAME = N'C:\Users\Admin\DoAnWin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DoAnWin] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAnWin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAnWin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAnWin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAnWin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAnWin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAnWin] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAnWin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DoAnWin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAnWin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAnWin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAnWin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAnWin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAnWin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAnWin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAnWin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAnWin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DoAnWin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAnWin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAnWin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAnWin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAnWin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAnWin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAnWin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAnWin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoAnWin] SET  MULTI_USER 
GO
ALTER DATABASE [DoAnWin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAnWin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAnWin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAnWin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DoAnWin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DoAnWin] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DoAnWin] SET QUERY_STORE = OFF
GO
USE [DoAnWin]
GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidate](
	[IDNguoiLam] [nvarchar](50) NULL,
	[TenNguoiLam] [nvarchar](max) NULL,
	[MaCV] [nvarchar](50) NULL,
	[DanhGia] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[IDNguoiThue] [nvarchar](50) NULL,
	[TenNguoiThue] [nvarchar](max) NULL,
	[IDNguoiLam] [nvarchar](50) NULL,
	[TenNguoiLam] [nvarchar](max) NULL,
	[MaCV] [nvarchar](50) NULL,
	[BinhLuan] [nvarchar](max) NULL,
	[DanhGia] [float] NULL,
	[NgayHoanThanh] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[IDNguoiThue] [nvarchar](50) NULL,
	[TenNguoiThue] [nvarchar](max) NULL,
	[IDNguoiLam] [nvarchar](50) NULL,
	[TenNguoiLam] [nvarchar](max) NULL,
	[MaCV] [nvarchar](50) NULL,
	[MoTaCV] [nvarchar](max) NULL,
	[TrangThaiCV] [nvarchar](max) NULL,
	[DanhGia] [nvarchar](50) NULL,
	[BinhLuan] [nvarchar](max) NULL,
	[NgayLam] [nvarchar](50) NULL,
	[Luong] [int] NULL,
	[DaDanhGia] [nvarchar](50) NULL,
	[NgayHoanThanh] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LikeTable]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LikeTable](
	[IDNguoiThich] [nvarchar](50) NOT NULL,
	[TenNguoiThich] [nvarchar](max) NULL,
	[IDTho] [nvarchar](50) NOT NULL,
	[TenTho] [nvarchar](max) NULL,
	[BinhLuan] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ID] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[CCCD] [nvarchar](max) NULL,
	[NgaySinh] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[STK] [nvarchar](max) NULL,
	[SoDU] [nvarchar](max) NULL,
	[ID_nguoi_thue] [nvarchar](max) NULL,
	[TenNguoiThue] [nvarchar](max) NULL,
	[DanhGia] [nvarchar](max) NULL,
	[BinhLuan] [nvarchar](max) NULL,
	[TenTaiKhoan] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](max) NULL,
	[VaiTro] [nvarchar](max) NULL,
	[Avatar] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPostJob]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPostJob](
	[IDNguoiThue] [nvarchar](50) NULL,
	[TenNguoiThue] [nvarchar](max) NULL,
	[MaCV] [nvarchar](50) NULL,
	[YeuCau] [nvarchar](max) NULL,
	[MoTaCV] [nvarchar](max) NULL,
	[TrangThaiCV] [nvarchar](max) NULL,
	[Luong] [int] NULL,
	[CongViec] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[ID] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[CCCD] [nvarchar](max) NULL,
	[NgaySinh] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[STK] [nvarchar](max) NULL,
	[SoDU] [nvarchar](max) NULL,
	[LuotThue] [nvarchar](max) NULL,
	[TenTaiKhoan] [nvarchar](max) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[VaiTro] [nvarchar](max) NOT NULL,
	[DanhGiaTrungBinh] [float] NULL,
	[TrangThai] [nvarchar](max) NULL,
	[DangThongTin] [nvarchar](3) NULL,
	[NamKinhNghiem] [nvarchar](20) NULL,
	[GiaThue] [nvarchar](100) NULL,
	[NgheNghiep] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Avatar] [nvarchar](max) NULL,
	[LuotThich] [int] NULL,
 CONSTRAINT [PK_worker] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkerUploadImage]    Script Date: 5/12/2024 2:15:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkerUploadImage](
	[ID] [nvarchar](50) NULL,
	[Image] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200069', N'test2', N'310067', 0)
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200069', N'test2', N'310010', 0)
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200069', N'test2', N'310049', 0)
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200069', N'test2', N'', 0)
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200041', N'test2', N'', 0)
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200041', N'test2', N'310099', 0)
INSERT [dbo].[Candidate] ([IDNguoiLam], [TenNguoiLam], [MaCV], [DanhGia]) VALUES (N'200041', N'test2', N'310095', 0)
GO
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300064', N'', 3.5, N'30 04 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300061', N'hơi mệt r đó', 4.5, N'30 04 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300093', N'lần này ok hơn lần trước', 1, N'30 04 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'310095', N'tàm tạm', 3.5, N'02 05 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300020', N'người này làm tốt', 4, N'02 05 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200004', N'Trần Thị D', N'300039', N'', 0, N'07 05 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'fdgdf', 4, N'07 05 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300001', N'quá buồn', 3, N'09 05 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300081', N'good Job', 5, N'09 05 2024')
INSERT [dbo].[Comment] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [BinhLuan], [DanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200053', N'test4', N'300028', N'fdgdg', 5, N'09 05 2024')
GO
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300064', N'', N'Hoàn thành', N'0', NULL, N'22/5/2024', 348585, N'1', N'30 04 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300007', N'', N'Đang làm', N'0', NULL, N'8/5/2024', 64858593, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300061', N'về làm cho anh đi em', N'Hoàn thành', N'0', NULL, N'11/6/2024', 304955, N'1', N'30 04 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300093', N'hahhhhaahfh', N'Hoàn thành', N'0', NULL, N'9/5/2024', 304955, N'1', N'30 04 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300069', N'', N'Chờ xác nhận', N'0', NULL, N'9/5/2024', 304955, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300089', N'về làm cho anh đi em', N'Đang làm', N'0', NULL, N'24/5/2024', 304955, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'300089', N'về làm cho anh đi em', N'Đang làm', N'0', NULL, N'16/5/2024', 304955, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200069', N'test2', N'310067', N'việc nhẹ lương cao', N'Chờ xác nhận', N'0', NULL, N'15/5/2024', 2840342, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'310095', N'tôi cần một người đi chợ hộ tôi', N'Hoàn thành', N'0', NULL, N'19/5/2024', 700, N'1', N'02 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300001', N'sfbdsjdj', N'Hoàn thành', N'0', NULL, N'10/5/2024', 123000, N'1', N'09 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300020', N'fdfgfdfd', N'Hoàn thành', N'0', NULL, N'5/6/2024', 123000, N'1', N'02 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200001', N'Nguyễn Văn A', N'300046', N'về làm cho anh đi mà em', N'Chờ xác nhận', N'0', NULL, N'14 5 2024', 60000, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200004', N'Trần Thị D', N'300039', N'lần này chắc chắn sẽ được', N'Hoàn thành', N'0', NULL, N'15/5/2024', 50000, N'1', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200004', N'Trần Thị D', N'300039', N'lần này chắc chắn sẽ được', N'Chờ xác nhận', N'0', NULL, N'13/5/2024', 50000, N'1', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200004', N'Trần Thị D', N'300039', N'lần này chắc chắn sẽ được', N'Chờ xác nhận', N'0', NULL, N'21/5/2024', 50000, N'1', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'6/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'7/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'8/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'9/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'11/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'12/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'13/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'14/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'15/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'16/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'17/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'18/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'19/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'20/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'21/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'22/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'23/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'24/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'25/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'26/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'27/5/2024', 234554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'28/5/2024', 424554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'29/5/2024', 394554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'30/5/2024', 364554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'31/5/2024', 374554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'1/6/2024', 424554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'2/6/2024', 384554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'3/6/2024', 414554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'4/6/2024', 394554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'5/6/2024', 454554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'6/6/2024', 434554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'7/6/2024', 354554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'8/6/2024', 334554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'9/6/2024', 394554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'10/6/2024', 434554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'11/6/2024', 404554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'12/6/2024', 374554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'13/6/2024', 384554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'14/6/2024', 394554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'15/6/2024', 424554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'16/6/2024', 434554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'17/6/2024', 354554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'18/6/2024', 394554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'19/6/2024', 374554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'20/6/2024', 334554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'21/6/2024', 434554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'22/6/2024', 444554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'23/6/2024', 374554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'24/6/2024', 324554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'25/6/2024', 294554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'26/6/2024', 374554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'27/6/2024', 354554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'28/6/2024', 364554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'29/6/2024', 384554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300193', N'lần này thuê nhiều', N'Hoàn thành', N'0', NULL, N'30/6/2024', 274554, N'1', N'05 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300081', N'lần1', N'Hoàn thành', N'0', NULL, N'11/5/2024', 234554, N'1', N'09 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300081', N'lần1', N'Hoàn thành', N'0', NULL, N'12/5/2024', 234554, N'1', N'09 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300052', N'lần2', N'Chờ xác nhận', N'0', NULL, N'11/5/2024', 234554, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200057', N'test3', N'300009', N'thể hiện kinh nghiệm tôi xem phát bạn ơi', N'Hoàn thành', N'0', NULL, N'24/5/2024', 346586, N'0', N'08 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200053', N'test4', N'300028', N'oklallala', N'Hoàn thành', N'0', NULL, N'14/5/2024', 45453, N'1', N'09 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300164', N'Tôi cần trợ lý', N'Hoàn thành', N'0', NULL, N'14/5/2024', 234554, N'0', N'12 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300164', N'Tôi cần trợ lý', N'Hoàn thành', N'0', NULL, N'21/5/2024', 234554, N'0', N'12 05 2024')
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300056', N'Tôi cần tuyển thợ', N'Chờ xác nhận', N'0', NULL, N'20/5/2024', 234554, N'0', NULL)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong], [DaDanhGia], [NgayHoanThanh]) VALUES (N'100012', N'test1', N'200041', N'test2', N'300096', N'Công ty tôi cần anh', N'Chờ xác nhận', N'0', NULL, N'27/5/2024', 234554, N'0', NULL)
GO
INSERT [dbo].[LikeTable] ([IDNguoiThich], [TenNguoiThich], [IDTho], [TenTho], [BinhLuan]) VALUES (N'100012', NULL, N'200006', NULL, N'ok la')
INSERT [dbo].[LikeTable] ([IDNguoiThich], [TenNguoiThich], [IDTho], [TenTho], [BinhLuan]) VALUES (N'100012', NULL, N'200004', NULL, N'haha')
INSERT [dbo].[LikeTable] ([IDNguoiThich], [TenNguoiThich], [IDTho], [TenTho], [BinhLuan]) VALUES (N'100012', NULL, N'200006', NULL, N'ronando')
INSERT [dbo].[LikeTable] ([IDNguoiThich], [TenNguoiThich], [IDTho], [TenTho], [BinhLuan]) VALUES (N'100012', NULL, N'200004', NULL, N'ok lallalalla')
INSERT [dbo].[LikeTable] ([IDNguoiThich], [TenNguoiThich], [IDTho], [TenTho], [BinhLuan]) VALUES (N'100012', NULL, N'200004', NULL, N'skjhjfds')
GO
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'1', N'Nguyễn Văn A', N'Nam', N'0123456789', N'Hà Nội', N'123456789', N'1990-01-01', N'nguyenvana@example.com', N'1234567890', N'5000000', N'1', N'Trần Thị X', N'5 sao', N'Rất tốt', N'Adsad', N'@123', N'Người Dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'100012', N'test1', NULL, N'0123456789', NULL, NULL, NULL, N'test1@gmail.com', NULL, N'10011013079425', NULL, NULL, NULL, NULL, N'test1', N'12345', N'Người dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'2', N'Nguyễn Thị B', N'Nữ', N'0987654321', N'Hồ Chí Minh', N'987654321', N'1995-05-05', N'nguyenthib@example.com', N'0987654321', N'3000000', N'2', N'Lê Văn Y', N'4 sao', N'Đạt yêu cầu', N'Bddsad', N'@123', N'Người Dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'3', N'Phạm Văn C', N'Nam', N'0123456789', N'Hải Phòng', N'123456789', N'1985-03-15', N'phamvanc@example.com', N'1234567890', N'4000000', N'3', N'Trần Thị Z', N'3 sao', N'Cần cải thiện', N'Cdsad', N'@123', N'Người Dùng', NULL)
GO
INSERT [dbo].[UserPostJob] ([IDNguoiThue], [TenNguoiThue], [MaCV], [YeuCau], [MoTaCV], [TrangThaiCV], [Luong], [CongViec]) VALUES (N'100012', N'test1', N'310069', N'5 năm kinh nghiệm', N'tôi cần một người sơn nhà', N'Chờ xác nhận', 5445, N'Thợ sơn')
INSERT [dbo].[UserPostJob] ([IDNguoiThue], [TenNguoiThue], [MaCV], [YeuCau], [MoTaCV], [TrangThaiCV], [Luong], [CongViec]) VALUES (N'100012', N'test1', N'310099', N'5 năm kinh nghiệm', N'tôi cần một người giúp tôi lau nhà', N'Chờ xác nhận', 427387, N'Thợ máy')
GO
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200001', N'Nguyễn Văn A', N'Nam', N'0123456789', N'Hà Nội', N'123456789', N'1990-01-01', N'nguyenvana@example.com', N'1234567890', N'5000000', N'2', N'A', N'@123', N'Thợ', 5, N'Hoạt động', N'1', N'7', N'60000', N'Thợ sơn', N'Rất ok', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200002', N'Nguyễn Thị B', N'Nữ', N'0987654321', N'Hồ Chí Minh', N'987654321', N'1995-05-05', N'nguyenthib@example.com', N'0987654321', N'3000000', N'3', N'B', N'@123', N'Thợ', 4, N'Hoạt động', N'1', N'3', N'70000', N'Thợ rửa xe', N'Kinh nghiệm đầy mình', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200003', N'Phạm Văn C', N'Nam', N'0123456789', N'Hải Phòng', N'123456789', N'1985-03-15', N'phamvanc@example.com', N'1234567890', N'4000000', N'4', N'C', N'@123', N'Thợ', 4.5, N'Hoạt động', N'1', N'4', N'65000', N'Thợ điêu khắc', N'Không một điểm yếu', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200004', N'Trần Thị D', N'Nữ', N'0123456789', N'Đà Nẵng', N'123456789', N'1993-10-20', N'trand@example.com', N'1234567890', N'6000000', N'5', N'D', N'@123', N'Thợ', 4, N'Hoạt động', N'1', N'1', N'50000', N'Thợ máy', N'Hả', NULL, 1)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200005', N'Lê Văn E', N'Nam', N'0123456789', N'Cần Thơ', N'123456789', N'1991-08-18', N'levane@example.com', N'1234567890', N'4500000', N'3', N'E', N'@123', N'Thợ', 3.5, N'Hoạt động', N'1', N'2', N'80000', N'Thợ điện', N'OMG', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200006', N'Nguyễn Thị F', N'Nữ', N'0987654321', N'Hải Dương', N'987654321', N'1994-09-25', N'nguyenthif@example.com', N'0987654321', N'3500000', N'3', N'F', N'@123', N'Thợ', 4.2, N'Hoạt động', N'1', N'6', N'90000', N'Thợ máy', N'Có nhiều năm trong nghề', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200007', N'Trần Văn G', N'Nam', N'0123456789', N'Vũng Tàu', N'123456789', N'1992-06-30', N'tranvg@example.com', N'1234567890', N'5500000', N'4', N'G', N'@123', N'Thợ', 4.6, N'Hoạt động', N'1', N'5', N'56000', N'Thợ khác', N'Có nhi?u kinh nghi?m', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200008', N'Hoàng Thị H', N'Nữ', N'0123456789', N'Quảng Ninh', N'123456789', N'1988-12-10', N'hoangthih@example.com', N'1234567890', N'4500000', N'5', N'H', N'@123', N'Thợ', 3.8, N'Hoạt động', N'1', N'1', N'610000', N'Thợ khác', N'', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200009', N'Lê Văn I', N'Nam', N'0123456789', N'Bình Dương', N'123456789', N'1996-03-20', N'levani@example.com', N'1234567890', N'4800000', N'3', N'I', N'@123', N'Thợ', 4.1, N'Hoạt động', N'1', N'3', N'75000', N'Kĩ sư', N'', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200010', N'Phạm Thị K', N'Nữ', N'0123456789', N'Long An', N'123456789', N'1997-07-15', N'phamthik@example.com', N'1234567890', N'3200000', N'4', N'K', N'@123', N'Thợ', 3.9, N'Tạm nghỉ', N'1', N'2', N'57000', N'Thợ xây', N'', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200011', N'Hoa M', N'Nu', N'0123456789', N'Vũng Tàu', N'123456789', N'1992-06-30', N'hoam@example.com', N'1234567890', N'5500000', N'4', N'G', N'@123', N'Thợ', 3, N'Hoạt động', N'1', N'5', N'59000', N'Thợ khác', N'Có nhi?u kinh nghi?m', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200012', N'Lục N', N'Nam', N'0123456789', N'Tây Nguyên', N'123456789', N'1997-06-30', N'lucn@example.com', N'1234567890', N'5500000', N'4', N'G', N'@123', N'Thợ', 4.6, N'Hoạt động', N'1', N'5', N'90000', N'Thợ khác', N'Có nhi?u kinh nghi?m', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200041', N'test2', N'Bí mật', N'04384833', N'Hà Nội', N'8478547857', N'4/3/2024 1:48:58 PM', N'test2@gmail.com', NULL, NULL, NULL, N'test2', N'12345', N'Thợ', 3.6, N'Hoạt động', N'1', N'', N'200000', N'Thợ sơn', N'Chuyên sơn nhà', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200053', N'test4', N'Bí mật', N'8599856', N'Hà Nội', N'4438384', N'4/3/2024 1:48:58 PM', N'test4@gmail.com', NULL, NULL, NULL, N'test4', N'12345', N'Thợ', 5, N'Hoạt động', N'1', N'', N'45453', N'Thợ rửa xe', N'gdhghkdfg', NULL, 0)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar], [LuotThich]) VALUES (N'200057', N'test3', N'Bí mật', N'3479273', N'Hà Nội', N'435454354', N'4/3/2024 1:48:58 PM', N'test3@gmail.com', NULL, NULL, NULL, N'test3', N'12345', N'Thợ', 0, N'Hoạt động', N'1', N'', N'346586', N'Thợ điêu khắc', N'tôi có nhiều năm kinh nghiệm trong nghề', NULL, 0)
GO
ALTER TABLE [dbo].[Job] ADD  DEFAULT ('0') FOR [DanhGia]
GO
ALTER TABLE [dbo].[Job] ADD  DEFAULT ('0') FOR [DaDanhGia]
GO
ALTER TABLE [dbo].[Worker] ADD  DEFAULT ((0)) FOR [DanhGiaTrungBinh]
GO
ALTER TABLE [dbo].[Worker] ADD  DEFAULT ((0)) FOR [LuotThich]
GO
USE [master]
GO
ALTER DATABASE [DoAnWin] SET  READ_WRITE 
GO
