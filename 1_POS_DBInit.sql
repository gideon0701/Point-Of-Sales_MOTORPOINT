--Point of Sales System Database Scripts
--DB init: 5-Apr-2018

CREATE DATABASE POS_DEV;

USE myhealthDb;  
GO  
PRINT '--BEGIN T-SQL--'

PRINT '--CREATE TABLES--'
CREATE TABLE [dbo.user]
   (id int PRIMARY KEY NOT NULL,  
    position_name varchar(250) NOT NULL,  
    keyword varchar(250) NOT NULL)  
GO

CREATE TABLE dbo.attr_HMO  
   (id int PRIMARY KEY NOT NULL,  
    benefits varchar(250) NOT NULL,  
    status varchar(250) NOT NULL  
	)  
GO  