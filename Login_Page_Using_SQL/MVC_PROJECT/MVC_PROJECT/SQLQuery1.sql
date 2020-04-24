create proc Sp_Login
@Login_ID int,
@Password Varchar(20),
@Isvalid BIT OUT
As
BEGIN
Set @Isvalid = (Select Count(1) from Login Where LoginID = @Login_ID AND Password = @Password)
END
