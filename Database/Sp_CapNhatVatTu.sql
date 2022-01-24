USE [QLVT]
GO

/****** Object:  StoredProcedure [dbo].[SP_CapNhatVatTu]    Script Date: 1/24/2022 10:09:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_CapNhatVatTu]
	@MaVT nchar(4),
	@LoaiCapNhat nchar(10),
	@SoLuong int
as
Begin
	begin try
		if(@LoaiCapNhat ='NhapVatTu')
		begin
			Update Vattu set SOLUONGTON =(SOLUONGTON+@SoLuong) where Vattu.MAVT = @MaVT
			return 1 -- thành công nhập
		end
		if(@LoaiCapNhat ='XuatVatTu')
		begin
			update Vattu set SOLUONGTON =(SOLUONGTON+@SoLuong) where Vattu.MAVT = @MaVT
			return 1 -- xuất thành công
		end
	end try
	begin catch
		return 0; -- thất bại cập nhật
	end catch
End

GO

