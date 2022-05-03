USE [qlchtan]
GO

/****** Object:  StoredProcedure [dbo].[InsertNhanVien]    Script Date: 01/05/2022 3:17:14 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[InsertNhanVien]
 @TenNV nvarchar(MAX),
 @NgaySinh date,
 @GioiTinh nvarchar(10),
 @SDT nchar(10),
 @DiaChi nvarchar(MAX)
AS
BEGIN
	declare @id_next varchar (10)
	declare @max int

	select @max=COUNT (MANV) + 1 from Nhanvien where MaNV like 'NV'
	set @id_next='NV'+ RIGHT('000'+ CAST (@max as varchar (8)), 3)

	while (exists (select MaNV from Nhanvien where MaNV=@id_next))
	begin
		set @max=@max+1
		set @id_next='NV' +RIGHT('000'+ CAST (@max as varchar (8)), 3)
	end
INSERT INTO Nhanvien VALUES (@id_next,@TenNV,@NgaySinh,@GioiTinh,@SDT,@DiaChi)
END
GO


