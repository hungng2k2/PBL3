USE [QLTAN]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[InsertKhachHang]
 @TenKH nvarchar(MAX),
 @NgaySinh date,
 @GioiTinh bit,
 @SDT nchar(10),
 @DiaChi nvarchar(MAX)
AS
BEGIN
	declare @id_next varchar (10)
	declare @max int

	select @max=COUNT (MAKH) + 1 from Khachhang where MAKH like 'KH'
	set @id_next='KH'+ RIGHT('000'+ CAST (@max as varchar (8)), 3)

	while (exists (select MaKH from Khachhang where MAKH=@id_next))
	begin
		set @max=@max+1
		set @id_next='KH' +RIGHT('000'+ CAST (@max as varchar (8)), 3)
	end
INSERT INTO Khachhang VALUES (@id_next,@TenKH,@NgaySinh,@GioiTinh,@SDT,@DiaChi)
END
GO