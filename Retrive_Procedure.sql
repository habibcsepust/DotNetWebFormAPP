USE [clinicalmanagementsystem]
GO
/****** Object:  StoredProcedure [dbo].[SP_Pull_Data]    Script Date: 7/3/2022 11:08:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_Pull_Data]
AS
BEGIN
	SELECT * FROM tbl_doctor WHERE d_id = 1
END
