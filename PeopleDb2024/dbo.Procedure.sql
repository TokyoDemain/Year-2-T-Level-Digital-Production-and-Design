CREATE procedure [dbo].[CreateNewPersonRecord]
(
	@Name nvarchar (50),

	@Age int
)

as 

begin

	Insert into People values(@Name,@Age)

End