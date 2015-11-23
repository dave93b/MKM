Create DataBase RiscSystem collate Cyrillic_General_CI_AS
GO

use RiscSystem
GO


Create table MainLevel
(
	[LevelId] int identity(1,1) NOT NULL,
	[LevelName] NVARCHAR (max) NOT NULL
)
GO

ALTER TABLE MainLevel
add constraint 
PK_MAINLEVEL_LevelId PRIMARY KEY(LevelId)
GO


Create table SubLevel
(
	[SubLevelId] int identity(1,1) NOT NULL,
	[LevelId] int NOT NULL,
	[SubLevelName] NVARCHAR (max) NOT NULL
)
GO

ALTER TABLE SubLevel
add constraint 
PK_SUBLEVEL_SubLevelId PRIMARY KEY(SubLevelId)
GO

ALTER TABLE SubLevel
add constraint 
FK_SubLevel_LevelId FOREIGN KEY(LevelId)
REFERENCES MainLevel(LevelId)
GO


Create table Element
(
	[ElementId] int identity(1,1) NOT NULL,
	[LevelId] int NOT NULL,
	[SubLevelId] int NOT NULL,
	[ElementName] NVARCHAR (max) NOT NULL
)
GO

ALTER TABLE Element
add constraint 
PK_Element_ElementId PRIMARY KEY(ElementId)
GO

ALTER TABLE Element
add constraint 
FK_Element_LevelId FOREIGN KEY(LevelId)
REFERENCES MainLevel(LevelId)
GO

ALTER TABLE Element
add constraint 
FK_Element_SubLevelId FOREIGN KEY(SubLevelId)
REFERENCES SubLevel(SubLevelId)
GO