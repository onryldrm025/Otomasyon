CREATE TABLE [dbo].[Randevular] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [Adsoyad]  VARCHAR(20) NULL,
    [Telefon]  CHAR(15) NULL,
    [Salon]    VARCHAR(20) NULL,
    [Niteligi] VARCHAR(20) NULL,
    [Tarih]    VARCHAR(50)   NULL,
    [Ontarih]  VARCHAR(50)   NULL,
    [Missay]   VARCHAR(20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

