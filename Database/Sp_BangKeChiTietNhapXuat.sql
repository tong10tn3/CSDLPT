USE [QLVT]
GO

/****** Object:  StoredProcedure [dbo].[SP_BangKeChiTietNhapXuat]    Script Date: 1/24/2022 10:08:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_BangKeChiTietNhapXuat] 
	-- Add the parameters for the stored procedure here
	@QuyenTruyCap nvarchar(9),
	@LoaiNhapXuat nvarchar(5),
	@ThoiGianBD date,
	@ThoiGianKT date
AS
BEGIN
	if(@QuyenTruyCap='CONGTY')  -- trường hợp quyền CONGTY truy cập
	begin
		if(@LoaiNhapXuat ='Nhap')
		begin
			SELECT FORMAT(NGAY, 'MM/yyyy') as THANGNAM, TENVT, SUM(SOLUONG) as TONGSOLUONG, SUM(SOLUONG*DONGIA) as TONGGIATRI
			FROM (SELECT PNHT.MAPN, PNHT.NGAY FROM PhieuNhap as PNHT
					UNION SELECT PNK.MAPN, PNK.NGAY FROM LINK1.QLVT.DBO.PhieuNhap as PNK) as PhieuNhap, 
					(SELECT * FROM CTPN
					UNION SELECT * FROM LINK1.QLVT.DBO.CTPN) as CTPN, Vattu
			WHERE NGAY BETWEEN @ThoiGianBD AND @ThoiGianKT AND PHIEUNHAP.MAPN = CTPN.MAPN AND CTPN.MAVT = Vattu.MAVT
			GROUP BY NGAY, TENVT
			ORDER BY NGAY
		end
		else if(@LoaiNhapXuat = 'Xuat')
		begin
			SELECT FORMAT(NGAY, 'MM/yyyy') as THANGNAM, TENVT, SUM(SOLUONG) as TONGSOLUONG, SUM(SOLUONG*DONGIA) as TONGGIATRI
			FROM (SELECT PXHT.MAPX, PXHT.NGAY FROM PhieuXuat as PXHT
					UNION SELECT PXK.MAPX, PXK.NGAY FROM LINK1.QLVT.DBO.PhieuXuat as PXK) as PhieuXuat, 
					(SELECT * FROM CTPX
					UNION SELECT * FROM LINK1.QLVT.DBO.CTPX) as CTPX, Vattu
			WHERE NGAY BETWEEN @ThoiGianBD AND @ThoiGianKT AND PhieuXuat.MAPX = CTPX.MAPX AND CTPX.MAVT = Vattu.MAVT
			GROUP BY NGAY, TENVT
			ORDER BY NGAY
		end
	end
	else	-- trường hợp quyền CHINHANH hoặc USER truy cập
	begin
		if(@LoaiNhapXuat ='Nhap')
		begin
			SELECT FORMAT(NGAY, 'MM/yyyy') as THANGNAM, TENVT, SUM(SOLUONG) as TONGSOLUONG, SUM(SOLUONG*DONGIA) as TONGGIATRI
			FROM PhieuNhap, CTPN, Vattu
			WHERE NGAY BETWEEN @ThoiGianBD AND @ThoiGianKT AND PHIEUNHAP.MAPN = CTPN.MAPN AND CTPN.MAVT = Vattu.MAVT
			GROUP BY NGAY, TENVT
			ORDER BY NGAY
		end
		else if(@LoaiNhapXuat = 'Xuat')
		begin
			SELECT FORMAT(NGAY, 'MM/yyyy') as THANGNAM, TENVT, SUM(SOLUONG) as TONGSOLUONG, SUM(SOLUONG*DONGIA) as TONGGIATRI
			FROM PhieuXuat, CTPX, Vattu
			WHERE NGAY BETWEEN @ThoiGianBD AND @ThoiGianKT AND PhieuXuat.MAPX = CTPX.MAPX AND CTPX.MAVT = Vattu.MAVT
			GROUP BY NGAY, TENVT
			ORDER BY NGAY
		end
	end
END

GO

