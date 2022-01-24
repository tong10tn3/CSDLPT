USE [QLVT]
GO

/****** Object:  StoredProcedure [dbo].[SP_DanhSachNhanVien]    Script Date: 1/24/2022 10:11:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DanhSachNhanVien]
	-- Add the parameters for the stored procedure here
	@QuyenTruyCap nvarchar(10),
	@MaCN nvarchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF(@QuyenTruyCap='CONGTY')
	BEGIN
		SELECT MANV, concat(HO, ' ', TEN) AS HoTen, DIACHI, NGAYSINH, MACN 
		FROM LINK2.QLVT.DBO.NhanVien
		WHERE TrangThaiXoa = 0 AND MACN = @MaCN
		ORDER BY TEN, HO ASC
	END
	ELSE
	BEGIN 
		SELECT MANV, concat(HO, ' ', TEN) AS HoTen, DIACHI, NGAYSINH, MACN 
		FROM NhanVien
		WHERE TrangThaiXoa = 0
		ORDER BY TEN, HO ASC
	END
END

GO

