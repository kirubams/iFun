--Table for different types of systems

Create table Gamesystems
(
	GameSystemID INT PRIMARY KEY IDENTITY,
	Description varchar(255),
	ModelNo varchar(25),
	CreatedDate DateTIME,
	Createdby int,
	ModifiedDate DateTime,
	Modifiedby int
)

--Table for list of expenses

Create table Expenses
(
	ExpenseID INT PRIMARY KEY IDENTITY,
	[Description] nvarchar(max),
	Amount int,
	CreatedDate DateTIME,
	Createdby int,
	ModifiedDate DateTime,
	Modifiedby int
)

-- Table for Storing Price Information

Create table GamePrice
(
	PriceID INT PRIMARY KEY IDENTITY,
	Game_SystemID int,
	Constraint fk_gamesystemid foreign key (Game_SystemID) references Gamesystems (GameSystemID),
	PlayerNo int,
	Price int,
	Minutes int,
	IndividualPrice int,
	CreatedDate DateTIME,
	Createdby int,
	ModifiedDate DateTime,
	Modifiedby int
)

-- Table for Number of Game Systems 

Create table NumberOfSystems
(
	ID INT PRIMARY KEY IDENTITY,
	SystemOrderId int,
	Game_SystemID int,
	Constraint fk_game_systemid foreign key (Game_SystemID) references Gamesystems (GameSystemID),
	CreatedDate DateTIME,
	Createdby int,
	ModifiedDate DateTime,
	Modifiedby int
)

-- Table for DailyIncomeTransaction

Create table IncomeTransaction
(
	IncomeTransactionID INT PRIMARY KEY IDENTITY,
	Game_SystemID int,
	Constraint fk_game_Incomesystemid foreign key (Game_SystemID) references Gamesystems (GameSystemID),
	NoofPlayers int,
	isIndividual bit,
	isManual bit,
	ManualPrice int,
	ReasonForManualPrice nvarchar(max),
	CreatedDate DateTIME,
	Createdby int,
	ModifiedDate DateTime,
	Modifiedby int
)

-- Table for Expense Transaction

Create table ExpenseTransaction
(
	ExpenseTransactionID INT PRIMARY KEY IDENTITY,
	ExpenseID int,
	Constraint fk_expenseID foreign key (ExpenseID) references Expenses (ExpenseID),
	Comments nvarchar(max),
	Amount int,
	CreatedDate DateTIME,
	Createdby int,
	ModifiedDate DateTime,
	Modifiedby int
)
