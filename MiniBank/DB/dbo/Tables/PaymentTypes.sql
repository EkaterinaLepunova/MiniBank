CREATE TABLE [dbo].[PaymentTypes] (
    [pt_paymentTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [pt_type]          VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_paymentTypes] PRIMARY KEY CLUSTERED ([pt_paymentTypeId] ASC)
);

