USE [MyAppDb]
GO

/****** Object: Table [dbo].[Concert] Script Date: 6/21/2020 6:05:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Concert] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [Price]      BIGINT           NOT NULL,
    [LocationId] UNIQUEIDENTIFIER NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Concert_LocationId]
    ON [dbo].[Concert]([LocationId] ASC);


GO
ALTER TABLE [dbo].[Concert]
    ADD CONSTRAINT [PK_Concert] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Concert]
    ADD CONSTRAINT [FK_Concert_Locations_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [dbo].[Locations] ([Id]) ON DELETE CASCADE;


Insert into  [dbo].[Concerts] (Id, Price, LocationId) values ('4880919e-ab87-4f3b-aac3-d12513a40104', '100', 'bf6d2c0e-b636-4f51-95ff-aab3406427c8');
Insert into  [dbo].[Concerts] (Id, Price, LocationId) values ('4880919e-ab87-4f3b-aac3-d12513a40105', '700', 'bf6d2c0e-b636-4f51-94ff-aab3406427c8');
Insert into  [dbo].[Concerts] (Id, Price, LocationId) values ('4880919e-ab87-4f3b-aac3-d12513a40103', '500', 'bf6d2c0e-b636-4f51-95ff-aab3406427c8');

Insert into [dbo].[ConcertSinger] (Id, ConcertId, SingerId) values ('00674350-9fe7-4bf1-9dd7-76bfbc68404c', '4880919e-ab87-4f3b-aac3-d12513a40104','5880919e-ab87-4f3b-aac3-d12513a40103' );
Insert into [dbo].[ConcertSinger] (Id, ConcertId, SingerId) values ('10674350-9fe7-4bf1-9dd7-76bfbc68404c','4880919e-ab87-4f3b-aac3-d12513a40104','1880919e-ab87-4f3b-aac3-d12513a40103' );
Insert into [dbo].[ConcertSinger] (Id, ConcertId, SingerId) values ('20674350-9fe7-4bf1-9dd7-76bfbc68404c','4880919e-ab87-4f3b-aac3-d12513a40105','1880919e-ab67-4f3b-aac3-d12513a40103' );
Insert into [dbo].[ConcertSinger] (Id, ConcertId, SingerId) values ('30674350-9fe7-4bf1-9dd7-76bfbc68404c','4880919e-ab87-4f3b-aac3-d12513a40105','5880919e-ab87-4f3b-aac3-d12513a40103' );
Insert into [dbo].[ConcertSinger] (Id, ConcertId, SingerId) values ('40674350-9fe7-4bf1-9dd7-76bfbc68404c', '4880919e-ab87-4f3b-aac3-d12513a40103','5880919e-ab87-4f3b-aac3-d12513a40103' );


Insert into  [dbo].[Singers] (Id, Name, MusicType) values ('5880919e-ab87-4f3b-aac3-d12513a40103', 'Rihanna', 'Rock');
Insert into  [dbo].[Singers] (Id, Name, MusicType) values ('1880919e-ab87-4f3b-aac3-d12513a40103', 'The weekend', 'Pop');
Insert into  [dbo].[Singers] (Id, Name, MusicType) values ('1880919e-ab67-4f3b-aac3-d12513a40103', 'Andra', 'Pop');


Insert into [dbo].[Locations] (Id, Country, County, Name, Street) values ('bf6d2c0e-b636-4f51-94ff-aab3406427c8', 'Roamania', 'Bucuresti', 'Bucuresti', 'Strada');
Insert into [dbo].[Locations] (Id, Country, County, Name, Street) values ('bf6d2c0e-b636-4f51-95ff-aab3406427c8', 'Roamania', 'Iasi', 'Iasi', 'Strada');
  select * from Concerts