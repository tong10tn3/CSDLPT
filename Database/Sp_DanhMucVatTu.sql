USE [QLVT]
GO

/****** Object:  StoredProcedure [dbo].[SP_DanhMucVatTu]    Script Date: 1/24/2022 10:10:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DanhMucVatTu] 
AS
BEGIN
	Select MAVT, TENVT, DVT, SOLUONGTON
	FROM Vattu
	ORDER BY TENVT ASC
END

GO

