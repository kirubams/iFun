SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GenerateYearlyReport_SP
	@ReportDate Datetime 
AS
BEGIN

	SET NOCOUNT ON;
	
	  Select it.NoofPlayers, it.isManual, it.ManualPrice, it.ReasonForManualPrice, it.CreatedDate, it.FinalPrice, it.Game_SystemID, gs.Description,it.SystemOrderId  from dbo.IncomeTransaction it
		inner join dbo.Gamesystems gs on it.Game_SystemID = gs.GameSystemID
		  Where Year(it.CreatedDate) = Year(@ReportDate)

END
GO
