USE [LoanDeskDB];
GO

IF COL_LENGTH('dbo.Loans', 'LostQuantity') IS NULL
BEGIN
    ALTER TABLE dbo.Loans ADD LostQuantity INT NOT NULL
        CONSTRAINT DF_Loans_LostQuantity DEFAULT (0);
END
GO

IF COL_LENGTH('dbo.Loans', 'ReplacementFee') IS NULL
BEGIN
    ALTER TABLE dbo.Loans ADD ReplacementFee DECIMAL(18, 6) NOT NULL
        CONSTRAINT DF_Loans_ReplacementFee DEFAULT (0);
END
GO

IF COL_LENGTH('dbo.Loans', 'ReplacementPaid') IS NULL
BEGIN
    ALTER TABLE dbo.Loans ADD ReplacementPaid BIT NULL;
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Loans_LostQuantity')
    ALTER TABLE dbo.Loans WITH CHECK ADD CONSTRAINT CK_Loans_LostQuantity
        CHECK (LostQuantity >= 0 AND LostQuantity <= Quantity);
GO

IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Loans_ReplacementFee_ReplacementPaid')
    ALTER TABLE dbo.Loans WITH CHECK ADD CONSTRAINT CK_Loans_ReplacementFee_ReplacementPaid
        CHECK ((ReplacementFee = 0 AND ReplacementPaid IS NULL)
            OR (ReplacementFee > 0 AND ReplacementPaid IN (0, 1)));
GO
