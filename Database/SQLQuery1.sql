
GO
create DATABASE CompanypSystem
ON (
	Name = CompanypSystem_data , 
	Filename = 'F:\Codes Ref\Workshop Full System\Database\CompanypSystem.mdf'
	)
LOG ON (
	Name = CompanypSystem_logs ,	
	Filename = 'F:\Codes Ref\Workshop Full System\Database\CompanypSystem.ldf'
	);
GO

create schema Persons
create schema Validation
create table Validation.Users(
	ID int identity (1,1),
	Username nvarchar(50) not null,
	Password nvarchar(50) not null,
	Status int not null,
	primary key (ID),
	unique (Password)
)

insert into Validation.Users (Username,Password,Status) Values('Ahmed Osama','303030',1),
('Osama Fawzy','202020',2) 


create table Persons.Customers(
	ID int identity (1,1),
	FName nvarchar(15) not null,
	LName nvarchar(15) not null,
	Mobile varchar(15) not null,
	Address nvarchar(25) null,
	Email varchar(25) null,
	Whatsapp varchar(15) null,
	Status int not null,
	OffersNum int not null,
	WorksNum int not null,
	IndextionsNum int not null,
	primary key(ID)
)

insert into Persons.Customers values(N'احمد', N'اسامة', '01222' , '1111' , '222', '222' , 0,0,0,0)

update Persons.Customers set Address = N'سسسس' where ID = 1

insert into Validation.Users values('Ahmed Osama','203040',1),('Osama Fawzy','102030',2)

create schema Prices

create table Prices.Glasses(
	ID int identity (1,1),
	Color varchar(20) not null,
	Price decimal not null,
	NetPrice decimal not null,
	Kind varchar(20) null,
	defaultColor int null,
	primary key(ID) 
)

EXEC sp_rename  'Prices.Glasses.defaultColor' , 'DefaultColor','COLUMN'

alter table Prices.Glasses
alter column Color nvarchar(20) not null

alter table Prices.Glasses
alter column Kind nvarchar(20) null

insert into Prices.Glasses values(N'عاكس بني',300,100,N'مصري',NULL),(N'شفاف',200,0,N'مصري',1)

UPDATE Prices.Glasses 
SET NetPrice = Price - (SELECT Price FROM Prices.Glasses WHERE DefaultColor = 1)

create schema Materials
create table Materials.Aluminum
(
	ID int identity (1,1),
	Number varchar(10) null,
	Section nvarchar(15) not null,
	Type nvarchar(15) not null,
	Category nvarchar(15) not null,
	Notes nvarchar(35) null,
	Status nvarchar(15) not null,
	LowWeight decimal not null,
	AvgWeight decimal not null,
	HighWeight decimal not null,
	Length decimal not null,
	primary key (ID),
	unique (Number)
)
alter table Prices.Glasses
add Deep int null

create table Materials.Accessories(
	ID int identity (1,1),
	Name nvarchar(35) not null ,
	Size float null,
	Category nvarchar(20) not null,
	Price float not null,
	Color nvarchar(10) null,
	LastEditDate Date default getdate(),
	 primary key(ID)
)

alter table Materials.Aluminum
alter column LowWeight float not null

alter table Materials.Aluminum
alter column AvgWeight float not null

alter table Materials.Aluminum
alter column HighWeight float not null

alter table Materials.Accessories
add Type nvarchar(20) null

alter table Materials.Accessories
add Status nvarchar(20) null

create table Materials.Boards(
	ID int identity(1,1),
	Name nvarchar(20) not null,
	Type nvarchar(20) not null,
	Color nvarchar(20) not null, 
	Height float not null,
	Width float not null,
	Deep float not null,
	FPrice float not null,
	MPrice float null,
	LastEditDate Date default GETDATE(),
	primary key(ID)
)