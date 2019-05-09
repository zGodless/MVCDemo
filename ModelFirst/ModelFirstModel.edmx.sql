
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2019 22:29:43
-- Generated from EDMX file: D:\MVC学习\Project\MVCDemo\ModelFirst\ModelFirstModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MVCTest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer] DROP CONSTRAINT [FK_CustomerProduct];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[ProductSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customer'
CREATE TABLE [dbo].[Customer] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(32)  NOT NULL,
    [Telephone] nvarchar(11)  NOT NULL,
    [CompanyName] nvarchar(50)  NOT NULL,
    [Age] nvarchar(3)  NOT NULL,
    [Product_ID] int  NOT NULL
);
GO

-- Creating table 'ProductSet'
CREATE TABLE [dbo].[ProductSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [PK_Customer]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [PK_ProductSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Product_ID] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [FK_CustomerProduct]
    FOREIGN KEY ([Product_ID])
    REFERENCES [dbo].[ProductSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerProduct'
CREATE INDEX [IX_FK_CustomerProduct]
ON [dbo].[Customer]
    ([Product_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------