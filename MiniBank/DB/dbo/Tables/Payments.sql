CREATE TABLE [dbo].[Payments] (
    [p_paymentId]      INT      IDENTITY (1, 1) NOT NULL,
    [pt_paymentTypeId] INT      NOT NULL,
    [u_userId]         INT      NOT NULL,
    [p_payment]        MONEY    NOT NULL,
    [p_date]           DATETIME NOT NULL,
    CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([p_paymentId] ASC),
    CONSTRAINT [FK_Payments_PaymentTypes] FOREIGN KEY ([pt_paymentTypeId]) REFERENCES [dbo].[PaymentTypes] ([pt_paymentTypeId]),
    CONSTRAINT [FK_Payments_Users] FOREIGN KEY ([u_userId]) REFERENCES [dbo].[Users] ([u_userId])
);



