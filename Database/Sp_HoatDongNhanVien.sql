USE [QLVT]
GO

/****** Object:  StoredProcedure [dbo].[SP_HoatDongNhanVien]    Script Date: 1/24/2022 10:12:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SP_HoatDongNhanVien]
@MANV INT,			
@NGAYBD nchar(20),		
@NGAYKT nchar(20),		
@Type NVARCHAR(4)	
AS
IF(@Type = 'N')
	BEGIN
	SELECT
		FORMAT(PN.NGAY,'MMMM yyyy') AS THANGNAM, 
		PN.NGAY,
		CTPN.MAPN AS MAPHIEU,
		N'Không Xác Định' AS HOTENKH,
		TENVT ,
		TENKHO ,
		CTPN.SOLUONG,
		CTPN.DONGIA
		FROM dbo.CTPN AS CTPN, 
		(SELECT VT.TENVT, VT.MAVT FROM dbo.Vattu AS VT) as VT,
		(SELECT PhieuNhap.MAPN,PhieuNhap.MasoDDH,PhieuNhap.NGAY
			 FROM dbo.PhieuNhap
			 WHERE MANV = @MANV 
			 AND (NGAY BETWEEN @NGAYBD AND @NGAYKT)) as PN,
		(select Kho.MaKHO,kho.tenkho from kho ) as KHO,
		(select DatHang.MaSoDDH ,DatHang.maKho from DatHang) as DDH
		
		where DDH.MasoDDH = PN.MasoDDH and VT.MAVT = CTPN.MAVT and DDH.MAKHO=KHO.MAKHO and CTPN.MAPN =PN.MAPN
	END
ELSE IF(@Type = 'X')
	BEGIN
	SELECT
		FORMAT(PX.NGAY,'MMMM yyyy') AS THANGNAM, 
		PX.NGAY,
		CTPX.MAPX AS MAPHIEU, 
		HOTENKH,	
		TENVT ,
		TENKHO ,
		CTPX.SOLUONG,
		CTPX.DONGIA
		FROM dbo.CTPX AS CTPX, 
		(SELECT VT.TENVT, VT.MAVT FROM dbo.Vattu AS VT) as VT,

		(SELECT PhieuXuat.MAPX,phieuXuat.MAKHO,PhieuXuat.NGAY, PhieuXuat.HOTENKH
			 FROM dbo.PhieuXuat
			 WHERE MANV = @MANV
			 AND (NGAY BETWEEN @NGAYBD AND @NGAYKT)) as PX,
		(select Kho.MaKHO,kho.tenkho from kho ) as KHO
		where VT.MAVT = CTPX.MAVT and PX.MAKHO=KHO.MAKHO and CTPX.MAPX =PX.MAPX
	END
GO

