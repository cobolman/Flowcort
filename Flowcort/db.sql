PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [List] (
    [ListID] INTEGER PRIMARY KEY NOT NULL,
    [Name] nvarchar(50),
    [Type] char(1) DEFAULT 'C' NOT NULL CHECK ([Type] IN ('F', 'C', 'T')),
	[Version] nvarchar(12)
);
INSERT INTO "List" VALUES(1,'FSXSE A321','T', '1.0');
CREATE TABLE [Section] (
    [SectionID] INTEGER PRIMARY KEY NOT NULL,
    [ListID] int DEFAULT 1 NOT NULL,
    [Description] nvarchar(100) NOT NULL,
    FOREIGN KEY (ListID) REFERENCES List(ListID)
);
INSERT INTO "Section" VALUES(1,1,'Simulator Preparation');
INSERT INTO "Section" VALUES(2,1,'Cockpit Preparation');
CREATE TABLE [Item] (
    [ItemID] INTEGER PRIMARY KEY NOT NULL,
    [SectionID] int NOT NULL,
    [Location] nvarchar(50),
    [Area] nvarchar(50),
    [Part] nvarchar(50),
    [Action] nvarchar(50),
	[Value] nvarchar(50),
    [CoP] bit NOT NULL DEFAULT 0,
    [Turnaround] bit NOT NULL DEFAULT 0,
    [Image1] nvarchar(50),
    [Image2] nvarchar(50),
    [Image3] nvarchar(50),
    [Audio] nvarchar(50),
    [Video] nvarchar(250),
    [Remarks] nvarchar(500),
    FOREIGN KEY (SectionID) REFERENCES Section(SectionID)
);
INSERT INTO "Item" VALUES(1,1,'FSX',NULL,NULL,'START',0,0,'FSXSteamEdition',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(2,1,'FSX - Free Flight Options','Current Aircraft','Airbus A321','SELECT',0,0,'FreeFlight','CurrentAircraftAirbusA321',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(5,1,'FSX - Free Flight Options','Current Location','Plymouth','SELECT',0,0,'FreeFlight','CurrentLocationPlymouth',NULL,NULL,NULL,'This is another test remark of no significance whatsoever');
INSERT INTO "Item" VALUES(6,1,'FSX - Free Flight Options','Current Weather','Clear skies','SELECT',0,0,'FreeFlight','CurrentWeatherClearSkies',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(7,1,'FSX - Free Flight Options','Current Time and Season','Day','SELECT',0,0,'FreeFlight','CurrentTimeAndSeason',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(8,1,'FSX - Free Flight Options',NULL,'[Flight Planner ...]','PUSH',0,0,'FreeFlight','FlightPlanner',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(9,1,'FSX - Flight Planner','Choose departure Location','[Select...]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(10,1,'FSX - Flight Planner','By airport ID','EGHD','ENTER',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(11,1,'FSX - Flight Planner',NULL,'[OK]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(12,1,'FSX - Flight Planner','Choose destination','[Select...]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(13,1,'FSX - Flight Planner','Choose destination','[Select...]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(14,1,'FSX - Flight Planner','By airport ID','EGJJ','ENTER',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(18,1,'FSX - Flight Planner',NULL,'[OK]','SELECT',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(19,1,'FSX - Flight Planner','Choose flight plan type','IFR','SELECT',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(20,1,'FSX - Flight Planner','Choose routing','Low-altitude airways','SELECT',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(22,1,'FSX - Flight Planner','Generate flight plan','[Find Route]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(23,1,'FSX - Flight Planner','Flight Planner','[OK]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(24,1,'FSX - Flight Planner',NULL,'[Save]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(27,1,'FSX - Dialog','Do you want flight simulator to move ...','[Yes]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(28,1,'FSX - Flight Planner',NULL,'[FLY NOW!]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(29,1,'FSX - Main Menu','World -> Map',NULL,'SELECT',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(30,1,'FSX - Map','Destination',NULL,'SELECT',0,0,NULL,NULL,NULL,NULL,NULL,'Move your mouse pointer to the edges of the map and click to move the map until you have the destination centred');
INSERT INTO "Item" VALUES(33,1,'FSX - Map','Airport Icon',NULL,'CLICK',0,0,NULL,NULL,NULL,NULL,NULL,'Click on the airport icon to get facility information');
INSERT INTO "Item" VALUES(34,1,'FSX - Facility Information','Data','Runway, ILS ID, ILS Freq & ILSHdg','NOTE',0,0,NULL,NULL,NULL,NULL,NULL,'Rwy 8 : IJJ : 110.900 : 087 --- Rwy 26 : IDD : 110.300 : 267 ');
INSERT INTO "Item" VALUES(35,1,'FSX - Facility Information',NULL,'[OK]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(36,1,'FSX - Map',NULL,'[OK]','PUSH',0,0,NULL,NULL,NULL,NULL,NULL,NULL);
COMMIT;
