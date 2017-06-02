USE [iFun]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 06/01/2017 23:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Amount] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Createdby] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Modifiedby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gamesystems]    Script Date: 06/01/2017 23:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gamesystems](
	[GameSystemID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](255) NULL,
	[ModelNo] [varchar](25) NULL,
	[CreatedDate] [datetime] NULL,
	[Createdby] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Modifiedby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GameSystemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GamePrice]    Script Date: 06/01/2017 23:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GamePrice](
	[PriceID] [int] IDENTITY(1,1) NOT NULL,
	[Game_SystemID] [int] NULL,
	[PlayerNo] [int] NULL,
	[Price] [int] NULL,
	[Minutes] [int] NULL,
	[IndividualPrice] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Createdby] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Modifiedby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PriceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseTransaction]    Script Date: 06/01/2017 23:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseTransaction](
	[ExpenseTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseID] [int] NULL,
	[Comments] [nvarchar](max) NULL,
	[Amount] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Createdby] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Modifiedby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseTransactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberOfSystems]    Script Date: 06/01/2017 23:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberOfSystems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SystemOrderId] [int] NULL,
	[Game_SystemID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Createdby] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Modifiedby] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncomeTransaction]    Script Date: 06/01/2017 23:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncomeTransaction](
	[IncomeTransactionID] [int] IDENTITY(1,1) NOT NULL,
	[Game_SystemID] [int] NULL,
	[NoofPlayers] [int] NULL,
	[isIndividual] [bit] NULL,
	[isManual] [bit] NULL,
	[ManualPrice] [int] NULL,
	[ReasonForManualPrice] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[Createdby] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Modifiedby] [int] NULL,
	[FinalPrice] [int] NULL,
	[SystemOrderId] [int] NULL,
	[Minutes] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncomeTransactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetYearlyExpenseTransaction_SP]    Script Date: 06/01/2017 23:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetYearlyExpenseTransaction_SP]
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
			Where Year(et.CreatedDate) = Year(@ReportDate)
	
	  

END
GO
/****** Object:  StoredProcedure [dbo].[GetMonthlyExpenseTransaction_SP]    Script Date: 06/01/2017 23:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMonthlyExpenseTransaction_SP]
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
/****** Object:  StoredProcedure [dbo].[GetDailyExpenseTransaction_SP]    Script Date: 06/01/2017 23:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDailyExpenseTransaction_SP]
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
			Where Convert(date,et.CreatedDate) = Convert(date,@ReportDate)
	
	  

END
GO
/****** Object:  StoredProcedure [dbo].[GenerateYearlyReport_SP]    Script Date: 06/01/2017 23:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerateYearlyReport_SP]
	@ReportDate Datetime 
AS
BEGIN

	SET NOCOUNT ON;
	
	  Select it.NoofPlayers, it.isManual, it.ManualPrice, it.ReasonForManualPrice, it.CreatedDate, it.FinalPrice, it.Game_SystemID, gs.Description,it.SystemOrderId, it.Minutes  from dbo.IncomeTransaction it
		inner join dbo.Gamesystems gs on it.Game_SystemID = gs.GameSystemID
		  Where Year(it.CreatedDate) = Year(@ReportDate)

END
GO
/****** Object:  StoredProcedure [dbo].[GenerateMonthlyReport_SP]    Script Date: 06/01/2017 23:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerateMonthlyReport_SP]
	@ReportDate Datetime 
AS
BEGIN

	SET NOCOUNT ON;
	
	  Select it.NoofPlayers, it.isManual, it.ManualPrice, it.ReasonForManualPrice, it.CreatedDate, it.FinalPrice, it.Game_SystemID, gs.Description,it.SystemOrderId, it.Minutes  from dbo.IncomeTransaction it
		inner join dbo.Gamesystems gs on it.Game_SystemID = gs.GameSystemID
		  Where Month(it.CreatedDate) = Month(@ReportDate)

END
GO
/****** Object:  StoredProcedure [dbo].[GenerateDailyReport_SP]    Script Date: 06/01/2017 23:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerateDailyReport_SP]
	@ReportDate Datetime 
AS
BEGIN

	SET NOCOUNT ON;
	
	  Select it.NoofPlayers, it.isManual, it.ManualPrice, it.ReasonForManualPrice, it.CreatedDate, it.FinalPrice, it.Game_SystemID, gs.Description,it.SystemOrderId, it.Minutes  from dbo.IncomeTransaction it
		inner join dbo.Gamesystems gs on it.Game_SystemID = gs.GameSystemID
		  Where Convert(date,it.CreatedDate) = Convert(date,@ReportDate)

END
GO
/****** Object:  ForeignKey [fk_expenseID]    Script Date: 06/01/2017 23:34:31 ******/
ALTER TABLE [dbo].[ExpenseTransaction]  WITH CHECK ADD  CONSTRAINT [fk_expenseID] FOREIGN KEY([ExpenseID])
REFERENCES [dbo].[Expenses] ([ExpenseID])
GO
ALTER TABLE [dbo].[ExpenseTransaction] CHECK CONSTRAINT [fk_expenseID]
GO
/****** Object:  ForeignKey [fk_gamesystemid]    Script Date: 06/01/2017 23:34:31 ******/
ALTER TABLE [dbo].[GamePrice]  WITH CHECK ADD  CONSTRAINT [fk_gamesystemid] FOREIGN KEY([Game_SystemID])
REFERENCES [dbo].[Gamesystems] ([GameSystemID])
GO
ALTER TABLE [dbo].[GamePrice] CHECK CONSTRAINT [fk_gamesystemid]
GO
/****** Object:  ForeignKey [fk_game_Incomesystemid]    Script Date: 06/01/2017 23:34:31 ******/
ALTER TABLE [dbo].[IncomeTransaction]  WITH CHECK ADD  CONSTRAINT [fk_game_Incomesystemid] FOREIGN KEY([Game_SystemID])
REFERENCES [dbo].[Gamesystems] ([GameSystemID])
GO
ALTER TABLE [dbo].[IncomeTransaction] CHECK CONSTRAINT [fk_game_Incomesystemid]
GO
/****** Object:  ForeignKey [fk_game_systemid]    Script Date: 06/01/2017 23:34:31 ******/
ALTER TABLE [dbo].[NumberOfSystems]  WITH CHECK ADD  CONSTRAINT [fk_game_systemid] FOREIGN KEY([Game_SystemID])
REFERENCES [dbo].[Gamesystems] ([GameSystemID])
GO
ALTER TABLE [dbo].[NumberOfSystems] CHECK CONSTRAINT [fk_game_systemid]
GO
