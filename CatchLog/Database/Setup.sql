IF DB_ID(N'CatchLogDB') IS NULL
BEGIN
	CREATE DATABASE CatchLogDB;
END;
GO

USE CatchLogDB;
GO

IF OBJECT_ID(N'dbo.Catches', N'U') IS NULL
BEGIN
	CREATE TABLE dbo.catches
	(
		CatchID INT IDENTITY(1,1) PRIMARY KEY,
		CatchDate DATE NOT NULL,
		Species NVARCHAR(100) NOT NULL,
		Location NVARCHAR(150) NOT NULL,
		Bait NVARCHAR(100) NULL,
		LengthInches DECIMAL(8,2) NOT NULL,
		WeightPounds DECIMAL(8,2) NOT NULL,

		CONSTRAINT CK_Catches_Weight
			CHECK (WeightPounds > 0)
	);
END;
GO

IF OBJECT_ID(N'dbo.CK_Catches_Length', N'C') IS NULL
BEGIN
	ALTER TABLE dbo.catches
	ADD CONSTRAINT CK_Catches_Length
		CHECK (LengthInches > 0);
END;
GO