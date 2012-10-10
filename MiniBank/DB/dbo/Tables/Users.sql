CREATE TABLE [dbo].[Users] (
    [u_userId]      INT           IDENTITY (1, 1) NOT NULL,
    [ut_userTypeId] INT           NOT NULL,
    [u_login]       VARCHAR (255) NOT NULL,
    [u_password]    VARCHAR (255) NOT NULL,
    [u_firstName]   VARCHAR (255) NOT NULL,
    [u_lastName]    VARCHAR (255) NULL,
    CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED ([u_userId] ASC),
    CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY ([ut_userTypeId]) REFERENCES [dbo].[UserTypes] ([ut_userTypeId])
);



