CREATE TABLE CustomerDatabase.dbo.Project(
	ProjectId int NOT NULL UNIQUE, 
	CustomerId int,
	Name varchar(255),
	Description varchar(255));

CREATE TABLE CustomerDatabase.dbo.Customer(
	CustomerId int NOT NULL UNIQUE, 
	Name varchar(255), 
	Address varchar(255));

