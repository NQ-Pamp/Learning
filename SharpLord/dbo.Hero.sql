CREATE TABLE [dbo].[Hero] (
    [Name]        NVARCHAR (30)   NOT NULL,
    [Lvl]         INT             NOT NULL,
    [Alliance1]    NVARCHAR (30)   NOT NULL,
	[Alliance2] NVARCHAR(30) NULL, 
    [Alliance3] NVARCHAR(30) NULL, 
    [AttackSpeed] DECIMAL (18, 2) NOT NULL,
    [Attackvalue] INT             NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

