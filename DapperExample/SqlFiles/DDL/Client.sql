IF EXISTS (SELECT 1 FROM SYSOBJECTS WHERE Name = 'Client' AND Type = 'U')
	DROP TABLE Client
GO

CREATE TABLE Client
(
	Identification	VARCHAR(30),
	ShortName		VARCHAR(30),
	Name			VARCHAR(120)
)
GO