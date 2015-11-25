Create DataBase RiskSystem collate Cyrillic_General_CI_AS
GO

use RiskSystem
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
FK_Element_SubLevelId FOREIGN KEY(SubLevelId)
REFERENCES SubLevel(SubLevelId)
GO

Create table Damage
(
	[DamageId] int identity(1,1) NOT NULL,
	[DamageName] NVARCHAR (max) NOT NULL
)
GO

ALTER TABLE Damage
add constraint 
PK_DAMAGE_DamageId PRIMARY KEY(DamageId)
GO

Create table DamagePlace
(
	[DamagePlaceId] int identity(1,1) NOT NULL,
	[LevelId] int NOT NULL,
	[SubLevelId] int NOT NULL,
	[ElementId] int NOT NULL,
	[DamageId] int NOT NULL
)
GO

ALTER TABLE DamagePlace
add constraint 
PK_DamagePlace_DamagePlaceId PRIMARY KEY(DamagePlaceId)
GO

ALTER TABLE DamagePlace
add constraint 
FK_DamagePlace_LevelId FOREIGN KEY(LevelId)
REFERENCES MainLevel(LevelId)
GO

ALTER TABLE DamagePlace
add constraint 
FK_DamagePlace_SubLevelId FOREIGN KEY(SubLevelId)
REFERENCES SubLevel(SubLevelId)
GO

ALTER TABLE DamagePlace
add constraint 
FK_DamagePlace_ElementId FOREIGN KEY(ElementId)
REFERENCES Element(ElementId)
GO

ALTER TABLE DamagePlace
add constraint 
FK_DamagePlace_DamageId FOREIGN KEY(DamageId)
REFERENCES Damage(DamageId)
GO