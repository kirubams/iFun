SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetMonthlyExpenseTransaction_SP
	@ReportDate Datetime 
AS
BEGIN

	SET NOCOUNT ON;
	
	Select et.ExpenseTransactionID,
			et.ExpenseID,
			e.Description,
			et.Comments,
			et.Amount,
			et.CreatedDate,
			et.Createdby
		 from ExpenseTransaction et (nolock)
			inner join Expenses e (nolock) on et.ExpenseID = e.ExpenseID
			Where Month(et.CreatedDate) = Month(@ReportDate)
	
	  

END
GO
