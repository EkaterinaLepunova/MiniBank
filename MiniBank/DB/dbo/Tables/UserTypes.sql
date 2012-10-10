CREATE TABLE [dbo].[UserTypes] (
    [ut_userTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [ut_type]       VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_userTypes] PRIMARY KEY CLUSTERED ([ut_userTypeId] ASC)
);

