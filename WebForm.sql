use clinicalmanagementsystem


CREATE PROCEDURE SP_Pull_Data
AS
BEGIN
	SELECT * FROM tbl_doctor
END
GO


EXEC SP_Pull_Data


create table tbl_doctor
(
d_id int primary key identity,
d_name nvarchar(50) not null,
d_contact nvarchar(50) not null unique,
d_email nvarchar(50) unique,
d_dateofbirth date
)



create proc sp_insert_doctor
(
@d_name nvarchar(50) ,

@d_contact nvarchar(50) ,

@d_email nvarchar(50) ,

@d_dateofbirth date

)

AS

BEGIN

INSERT INTO tbl_doctor VALUES(

@d_name ,

@d_contact ,

@d_email ,

@d_dateofbirth



)

END



USE clinicalmanagementsystem;


select * from tbl_doctor