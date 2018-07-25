CREATE TABLE [dbo].[DocReg] (
    [Name]        VARCHAR (50)  NULL,
    [UserName]    VARCHAR (50)  NOT NULL,
    [Password]    VARCHAR (50)  NULL,
    [PhoneNumber] VARCHAR (50)  NULL,
    [Category]    VARCHAR (50)  NULL,
    [Area]        VARCHAR (100) NULL,
    [Chamber]     VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([UserName] ASC)
);

