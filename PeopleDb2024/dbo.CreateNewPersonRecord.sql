CREATE procedure [dbo].[CreateNewPersonRecord]
(
	@Name nvarchar (50),
	@Age int,
	@Address nvarchar (50),
	@Number int
)

as 

begin

	Insert into People values(@Name,@Age)

End