PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [List] (
    [ListID] INTEGER PRIMARY KEY NOT NULL,
    [Name] nvarchar(50),
    [Type] char(1) DEFAULT 'C' NOT NULL CHECK ([Type] IN ('F', 'C', 'T')),
	[Version] nvarchar(12)
);
INSERT INTO "List" VALUES(1,'FSXSE A321','T','1.0');
CREATE TABLE [Section] (
    [SectionID] INTEGER PRIMARY KEY NOT NULL,
    [ListID] int DEFAULT 1 NOT NULL,
    [Description] nvarchar(100) NOT NULL,
    FOREIGN KEY (ListID) REFERENCES List(ListID)
);
INSERT INTO "Section" VALUES(1,1,'Simulator Preparation');
INSERT INTO "Section" VALUES(2,1,'Cockpit Preparation');
INSERT INTO "Section" VALUES(3,1,'Takeoff');
CREATE TABLE [Item] (
    [ItemID] INTEGER PRIMARY KEY NOT NULL,
    [SectionID] int NOT NULL,
	[Position] int NOT NULL,
    [Location] nvarchar(50),
    [Area] nvarchar(50),
    [Part] nvarchar(50),
    [Action] nvarchar(50),
	[ValToSet] nvarchar(50),
    [CoP] bit NOT NULL DEFAULT 0,
    [Turnaround] bit NOT NULL DEFAULT 0,
	[Event] bit NOT NULL DEFAULT 0,
	[Subsection] bit NOT NULL DEFAULT 0,
    [Image1] nvarchar(50),
    [Image2] nvarchar(50),
    [Image3] nvarchar(50),
    [Audio] nvarchar(50),
    [Video] nvarchar(250),
    [Remarks] nvarchar(500),
    FOREIGN KEY (SectionID) REFERENCES Section(SectionID)
);
INSERT INTO "Item" VALUES(1,1,10,'FSX',NULL,NULL,'START',NULL,0,0,0,0,'FSXSteamEdition','DestinationZoom',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(2,1,20,'FSX - Free Flight Options','Current Aircraft','Airbus A321','SELECT',NULL,0,0,0,0,'FreeFlight','CurrentAircraftAirbusA321',NULL,NULL,NULL,'I use the Orbit Airlines livery here but whatever you choose will work well in this tutorial');
INSERT INTO "Item" VALUES(5,1,30,'FSX - Free Flight Options','Current Location','Plymouth','SELECT',NULL,0,0,0,0,'FreeFlight','CurrentLocationPlymouth',NULL,NULL,NULL,'This is another test remark of no significance whatsoever');
INSERT INTO "Item" VALUES(6,1,40,'FSX - Free Flight Options','Current Weather','Clear skies','SELECT',NULL,0,0,0,0,'FreeFlight','CurrentWeatherClearSkies',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(7,1,50,'FSX - Free Flight Options','Current Time and Season','Day','SELECT',NULL,0,0,0,0,'FreeFlight','CurrentTimeAndSeason',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(8,1,60,'FSX - Free Flight Options',NULL,'[Flight Planner ...]','PUSH',NULL,0,0,0,0,'FreeFlight','FlightPlanner',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(9,1,70,'FSX - Flight Planner','Choose departure Location','[Select...]','PUSH',NULL,0,0,0,0,'','',NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(10,1,80,'FSX - Flight Planner','By airport ID','EGHD','ENTER',NULL,0,0,0,0,'ChooseDepartureLocation',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(11,1,90,'FSX - Flight Planner',NULL,'[OK]','PUSH',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(12,1,100,'FSX - Flight Planner','Choose destination','[Select...]','PUSH',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(14,1,110,'FSX - Flight Planner','By airport ID','EGJJ','ENTER',NULL,0,0,0,0,'ChooseDestination',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(18,1,120,'FSX - Flight Planner',NULL,'[OK]','SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(19,1,130,'FSX - Flight Planner','Choose flight plan type','IFR','SELECT',NULL,0,0,0,0,'ChooseFlightPlanType',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(20,1,140,'FSX - Flight Planner','Choose routing','Low-altitude airways','SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(22,1,150,'FSX - Flight Planner','Generate flight plan','[Find Route]','PUSH',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(23,1,160,'FSX - Flight Planner','Flight Planner','[OK]','PUSH',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(24,1,170,'FSX - Flight Planner',NULL,'[Save]','PUSH',NULL,0,0,0,0,'SaveFlightPlan',NULL,NULL,NULL,NULL,'We''ll accept the default route here');
INSERT INTO "Item" VALUES(27,1,180,'FSX - Dialog','Do you want flight simulator to move ...','[Yes]','PUSH',NULL,0,0,0,0,'DoYouWantFlightSimulator',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(28,1,190,'FSX - Flight Planner',NULL,'[FLY NOW!]','PUSH',NULL,0,0,0,0,'FreeFlight',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(29,1,200,'FSX - Main Menu','World -> Map',NULL,'SELECT',NULL,0,0,0,0,'EditTab',NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(30,1,210,'FSX - Map','Destination',NULL,'SELECT',NULL,0,0,0,0,'DestinationZoom',NULL,NULL,NULL,NULL,'Move your mouse pointer to the edges of the map and click to move the map until you have the destination centred');
INSERT INTO "Item" VALUES(33,1,220,'FSX - Map','Airport Icon',NULL,'CLICK',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Click on the airport icon to get facility information');
INSERT INTO "Item" VALUES(34,1,230,'FSX - Facility Information','Data','Runway, ILS ID, ILS Freq & ILSHdg','NOTE',NULL,0,0,0,0,'FacilityInformation',NULL,NULL,NULL,NULL,'Rwy 8 : IJJ : 110.900 : 087 --- Rwy 26 : IDD : 110.300 : 267 ');
INSERT INTO "Item" VALUES(35,1,240,'FSX - Facility Information',NULL,'[OK]','PUSH',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(36,1,250,'FSX - Map',NULL,'[OK]','PUSH',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(37,2,260,'FSX - Main Menu','Views -> Instrument Panel -> Radio Panel',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'The virtual cockpit for the A321 won''t allow you to tune the radio correctly, so we use the 2D version');
INSERT INTO "Item" VALUES(38,2,270,'Radio Panel','[Nav 1]',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(39,2,280,'Radio Panel','Tuning Dials',NULL,'ENTER',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'110.900. Use the large wheel to dial 110 and the smaller wheel to dial in the .900. This is the frequency for the instrument landing system at Jersey for runway 08');
INSERT INTO "Item" VALUES(40,2,290,'Radio Panel','Switch Frequency',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'This pushes the frequency we entered to be live (rather than standby)');
INSERT INTO "Item" VALUES(41,2,300,'Radio Panel','Tuning Dials',NULL,'ENTER',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'110.300. This is the frequency for the second ILS at Jersey for runway 26. Note that we don''t switch this over');
INSERT INTO "Item" VALUES(42,2,310,'Radio Panel','[Nav 2]',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Enter same frequencies as above but have 110.300 as the active frequency');
INSERT INTO "Item" VALUES(43,2,320,'Radio Panel',NULL,NULL,'RCLICK',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(44,2,330,'Radio Panel','[CALL]','Nav 1','SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'This is so we''ll hear the ILS transmission code when we get near Jersey');
INSERT INTO "Item" VALUES(45,2,340,'Popup Menu','Close Window',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(46,2,350,'MCP','Speed Dial',NULL,'SET',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'250 - Maximum permissible speed below 10,000 feet');
INSERT INTO "Item" VALUES(47,2,360,'MCP','Heading',NULL,'SET',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'306 - Runway heading at Plymouth');
INSERT INTO "Item" VALUES(48,2,370,'MCP','Course',NULL,'SET',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'86 - Runway heading at Jersey. Not strictly needed. It''s just a reminder for us.');
INSERT INTO "Item" VALUES(49,2,380,'Pedestal','Flaps',NULL,'SET',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'25% flaps. Click and drag until the tip reads 25%');
INSERT INTO "Item" VALUES(50,2,390,'FSX - Main Menu','Views -> Air Traffic',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Move the air traffic window to a place on the screen that suits you');
INSERT INTO "Item" VALUES(51,2,400,'Air Traffic Window','1 - Tune Plymouth Tower',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Click on the item');
INSERT INTO "Item" VALUES(52,2,410,'Air Traffic Window','1 - Request IFR Clearance',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Wait for the response from the tower. No need to set anything as departure frequency and squawk codes are automatically set for us');
INSERT INTO "Item" VALUES(53,2,420,'Air Traffic Window','1 - Read back (Acknowledge)  ...',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'This confirms to Air Traffic that we recorded the details correctly. Wait for response');
INSERT INTO "Item" VALUES(54,2,430,'Air Traffic Window','1 - Request Taxi IFR',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Wait for response');
INSERT INTO "Item" VALUES(55,2,440,'Air Traffic Window','1 - Acknowledge Taxi Clearance',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO "Item" VALUES(56,2,450,'Air Traffic Window','1 - Request Takeoff Clearance ...',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Wait for response');
INSERT INTO "Item" VALUES(57,2,460,'Air Traffic Window','1 - Acknowledge Takeoff Clearance ...',NULL,'SELECT',NULL,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'You should now see a message in the Air Traffic Window stating ''No messages to transmit to Plymouth Tower ...');
COMMIT;
