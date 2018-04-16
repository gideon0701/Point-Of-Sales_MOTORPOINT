--Point of Sales System Database Scripts
--DB init: 5-Apr-2018

CREATE DATABASE POS_DEV;

USE POS_DEV;  
GO  
PRINT '--BEGIN T-SQL--'

PRINT '--CREATE TABLES--'
CREATE TABLE [dbo.user]
   ([id] int PRIMARY KEY NOT NULL,  
    [name] varchar(250) NOT NULL,  
    [username] varchar(50) NOT NULL,
	[userPassword] varchar(50) NOT NULL,
	[designation] varchar(50) NOT NULL,
	[contact] varchar(50) NOT NULL,
	[email] varchar(50) NOT NULL,
	[birthdate] int NOT NULL,
	[contactNum] varchar(50) NOT NULL,
	[age] int NOT NULL,
	[emergencyContact] varchar(100)NULL,
	[emergencycontactNum] varchar(50) NULL,
	[userImage] varchar(50) NULL;
	)  
GO

CREATE TABLE [dbo.product] 
   ([id] int PRIMARY KEY NOT NULL,  
    [PricePerUnit] double NOT NULL,  
    [quantity] double NOT NULL,
	[isAvailable] int NOT NULL,
	[productCategory] varchar(100) NULL  ;  
	)  
GO  

CREATE TABLE [dbo.salesTransaction] 
   ([id] int PRIMARY KEY NOT NULL,
    [salesType] varchar (50) NOT NULL, 
    [transactionDate] double NOT NULL,  
    [subtotal_amount] double NOT NULL,
	[taxableAmount] double NOT NULL,
	[totalPrice] double NOT NULL,
	[discount] double NULL,
	[amountPaid] double NOT NULL;  
	)  
GO  

CREATE TABLE [dbo.itemsSold] 
   ([id] int PRIMARY KEY NOT NULL,  
    [salesID] int FOREIGN KEY NOT NULL,  
    [productID] int FOREIGN KEY NOT NULL,
	[quantitySold] int NOT NULL,
	[unitPrice] double NOT NULL,
	[transactionDate] double NOT NULL
	[productCategory] varchar(100) NULL;    
	)
GO