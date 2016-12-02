--THIS IS THE CREATION OF OUR DATABASE
DROP DATABASE NorthwestLabsDatabase;
GO
--We must drop it before we create it
CREATE DATABASE NorthwestLabsDatabase;
GO

USE NorthwestLabsDatabase;
GO

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Materials]


--This table will keep track of all materials associated with the 
-- tests

CREATE TABLE [Materials] (
  [MaterialsID] int,
  [MaterialName] VarChar(50),
  [MaterialType] VarChar(30),
  [Price] Decimal(7,2),
  PRIMARY KEY ([MaterialsID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Schedule_Test]

--This table will keep track of all schedule and the tests
CREATE TABLE [Schedule_Test] (
  [ScheduleID] int,
  [TestID] int,
  [Description] VarChar(50),
  [EstimatedEndDate] DateTIme,
  [TestType] VarChar(30),
  [ScheduledStart] DateTime
);


-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Schedule]

--This table will keep track of all schedule items
CREATE TABLE [Schedule] (
  [ScheduleID] int,
  [Description] VarChar(50),
  [Cost] Decimal(6,2),
  PRIMARY KEY ([ScheduleID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [WorkOrderDetails]
--This table will keep track of all work order details that are needed
CREATE TABLE [WorkOrderDetails] (
  [WorkOrderID ] int,
  [E,ployeeID] int,
  [AssayPrice] Decimal(6,2)
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [WorkOrder]
--This table will keep track of all Work Orders made by the sales peoples
CREATE TABLE [WorkOrder] (
  [WorkOrderID ] int,
  [UnadjustedPrice] Decimal(6,2),
  [CustomerDiscount] Decimal(6,2),
  [TotalPrice] Decimal(6,2),
  [QuotedPrice] Decimal(6,2),
  [CustomerID] int,
  PRIMARY KEY ([WorkOrderID ])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Compound]
--This table will keep track of all compound information
CREATE TABLE [Compound] (
  [LabTestNumber] int,
  [CompoundSequenceCode ] int,
  [CompoundName] VarChar(30),
  [Quantity ] int,
  [DateArrived] DateTime,
  [ReceivedBy] VarChar(30),
  [DueDate] datetime,
  [Appearance ] VarChar(100),
  [WeightByClient] Decimal(6,2),
  [ActualWeight] Decimal(6,2),
  [MolecularMass] Decimal(8,3),
  [MTD] Decimal(6,2),
  PRIMARY KEY ([LabTestNumber], [CompoundSequenceCode ])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Test Materials]
--This table will keep track of all test materials stuff
CREATE TABLE [Test Materials] (
  [TestID] int,
  [MaterialsID] int,
  [AmmountNeeded] Decimal(6,2)
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Employee]
--This table will keep track of all employee stuff that is good for HR people
CREATE TABLE [Employee] (
  [EmployeeID] int,
  [FirstName] VarChar(30),
  [LastName] VarChar(30),
  [Address1] NChar(11),
  [Address2] VarChar(30),
  [City] VarChar(30),
  [State] VarChar(30),
  [Zip] Int,
  [HourlyP] Decimal(7,2),
  [Salary] Decimal(7,2),
  [Phone] NChar(11),
  [Email] VarChar(50),
  [HireDate] DateTIme,
  [DateOFBirth] DateTime,
  PRIMARY KEY ([EmployeeID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Test]
--This table will keep track of all the testing needed for the Assay
CREATE TABLE [Test] (
  [TestID] int,
  [Desctiption] VarChar(100),
  [TestType] VarChar(20),
  [TestName] VarChar(30),
  PRIMARY KEY ([TestID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [AssayDetails]
--This table will keep track of all Details associated with the Assay things
CREATE TABLE [AssayDetails] (
  [AssayID] int,
  [TestID] int,
  [IsRequired] Bit,
  [Description] VarChar(30),
  [DataReportID] int
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [TestTubes]
--This table will keep track of all test tubes that we create for each of the tests
CREATE TABLE [TestTubes] (
  [MaterialID] int,
  [Description] VarChar(50),
  [Cost] Decimal(6,2),
  PRIMARY KEY ([MaterialID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [DataReport]
--This table will keep track of all DateReoprting that goes on in the process
CREATE TABLE [DataReport] (
  [DataReportingID] int,
  [AssayID] int,
  [TestID] int,
  [Comments] VarChar(200),
  [Results] VarChar(200),
  PRIMARY KEY ([DataReportingID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [DataSummary]
--This table will keep track of all DataSummary information
CREATE TABLE [DataSummary] (
  [DataSummaryID] int,
  [DataReportingID] int,
  [AnalyticSummary] VarChar(200),
  PRIMARY KEY ([DataSummaryID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Assay]
--This table will keep track of all the Assays stuff. This is better for all the tests that will be run
CREATE TABLE [Assay] (
  [AssayID] int,
  [AssayType] VarChar(20),
  [AssayNumber] Int,
  [Description] int,
  [WorkOrderID] int,
  [LTNumber] int,
  [SequenceCode] int,
  PRIMARY KEY ([AssayID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Customer]
--This table will keep track of all customer info
CREATE TABLE [Customer] (
  [CustomerID] int,
  [ContactName] VarChar(30),
  [OrganizationName ] VarChar(30),
  [CustEmail] VarChar(30),
  [Address1] Varchar(50),
  [Address2] Varchar(50),
  [City] Varchar(30),
  [State] Varchar(2),
  [Zip] int,
  [ContactPhone] NChar(11),
  PRIMARY KEY ([CustomerID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Payment]
--This table will keep track of all payment stuffs
CREATE TABLE [Payment] (
  [PaymentID] int,
  [PaymentMehtod] VarChar(10),
  [PaymentAmount] Decimal(7,2),
  [PaymentDate] DateTIme,
  [CustomerID] int,
  PRIMARY KEY ([PaymentID])
);


-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Discount]
--This table will keep track of all
CREATE TABLE [Discount] (
  [DiscountID] int,
  [DiscountAmount] Varchar,
  [DiscountApproval] bit,
  [PaymentID] int,
  PRIMARY KEY ([DiscountID])
);

-- DROP THIS BEFORE YOU CREATE IT PLEASE
DROP TABLE [Invoice]
--This table will keep track of all invoices and the customer info related to it
CREATE TABLE [Invoice] (
  [InvoiceID] int,
  [OrganizationName] Varchar(30),
  [DiscountApplied] bit,
  [Description] VarChar(100),
  [ContactName] VarChar(50),
  [DiscountID] int,
  [WorkOrderID] int,
  PRIMARY KEY ([InvoiceID])
);



--THis is the creation of all indexes that need to happen at the end of the statement. 
CREATE INDEX [FK] ON  [Invoice] ([DiscountID], [WorkOrderID]);

CREATE INDEX [PK/FK] ON  [Schedule_Test] ([ScheduleID], [TestID]);

CREATE INDEX [PK/FK] ON  [WorkOrderDetails] ([WorkOrderID ], [E,ployeeID]);

CREATE INDEX [FK] ON  [WorkOrder] ([CustomerID]);

CREATE INDEX [PK/FK] ON  [Test Materials] ([TestID], [MaterialsID]);

CREATE INDEX [PK/FK] ON  [AssayDetails] ([AssayID], [TestID]);

CREATE INDEX [FK] ON  [AssayDetails] ([DataReportID]);

CREATE INDEX [FK] ON  [DataReport] ([AssayID], [TestID]);

CREATE INDEX [FK] ON  [DataSummary] ([DataReportingID]);

CREATE INDEX [FK] ON  [Assay] ([WorkOrderID], [LTNumber], [SequenceCode]);

CREATE INDEX [FK] ON  [Payment] ([CustomerID]);

CREATE INDEX [FK] ON  [Discount] ([PaymentID]);



