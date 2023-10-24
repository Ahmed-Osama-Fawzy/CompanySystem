
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

create schema Materials

create table Materials.Glasses(
	ID int identity (1,1),
	Color varchar(20) not null,
	Price decimal not null,
	NetPrice decimal not null,
	Kind varchar(20) null,
	defaultColor int null,
	primary key(ID) 
)

EXEC sp_rename  'Materials.Glasses.defaultColor' , 'DefaultColor','COLUMN'

alter table Materials.Glasses
alter column Color nvarchar(20) not null

alter table Materials.Glasses
alter column Kind nvarchar(20) null

insert into Materials.Glasses values(N'عاكس بني',300,100,N'مصري',NULL),(N'شفاف',200,0,N'مصري',1)

UPDATE Materials.Glasses 
SET NetPrice = Price - (SELECT Price FROM Materials.Glasses WHERE DefaultColor = 1)


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

alter table Materials.Aluminum
alter column Length float not null

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

select * from Materials.Boards

create table Materials.Types(
	Category nvarchar(30) not null,
	Value nvarchar(30) not null
)
select Value from Materials.Types WHERE Category = 'قسم اكسسوارات' 

delete from Materials.Types




EXEC sp_rename  'Materials.Aluminum.NCategory' , 'Category','COLUMN'

EXEC sp_rename  'Materials.Aluminum.Category' , 'Section','COLUMN'

EXEC sp_rename  'Materials.Aluminum.Status' , 'Type','COLUMN'

EXEC sp_rename  'Materials.Aluminum.NType' , 'Type','COLUMN'

EXEC sp_rename  'Materials.Aluminum.Notes' , 'Description','COLUMN'


EXEC sp_rename  'Materials.Accessories.Type' , 'Section','COLUMN'


EXEC sp_rename  'Materials.Accessories.Status' , 'Description','COLUMN'

alter table Materials.Accessories
add Type nvarchar(35) null

delete from Materials.Types where  Value = N'بي اس صغير'

CREATE TABLE my_table (
    col1 INT,
    col2 INT,
    col3 INT default 1,
);

drop table my_table

create schema Discounts

create table Discounts.MainTable(
	ID int identity(1,1),
	Caterogy nvarchar(25) not null,
	Section nvarchar(25) not null,
	Type nvarchar(25) null,
	Description nvarchar(25) null,
	Title nvarchar(25) not null,
	Height float not null,
	Width float not null,
	primary key(ID)
)
alter table Discounts.MainTable
drop column TNumber

alter table Discounts.Aluminum
add Title varchar(10)


alter table Discounts.Aluminum
add TNumber varchar(10) foreign key references Materials.Aluminum (Number) 

create table Discounts.Aluminum(
	DiscountID int,
	Title nvarchar(20) not null,
	AluminumID int not null,
	Height float not null,
	HNumber int not null,
	AddingHeight float not null,
	Width float not null,
	WNumber int not null,
	AddingWidth float not null,
	Length float not null,
	LowWeight float not null,
	AvgWeight float not null,
	HighWeight float not null,
	foreign key (DiscountID) references Discounts.MainTable (ID),
	foreign key (AluminumID) references Materials.Aluminum (ID)
)

create table Discounts.Accessories(
	DiscountID int,
	Name nvarchar(25) not null,
	Amount float not null,
	Color float not null,
	AccessorieID int,
	TotalPrice float not null,
	foreign key (DiscountID) references Discounts.MainTable (ID),
	foreign key (AccessorieID) references Materials.Accessories (ID)
)



create table Discounts.Glasses(
	DiscountID int,
	Name nvarchar(25) not null,
	Height float not null,
	Width float not null,
	Area float not null,
	Number int not null,
	GlassID int,
	TotalPrice float not null,
	foreign key (DiscountID) references Discounts.MainTable (ID),
	foreign key (GlassID) references Materials.Glasses (ID)
)


alter table Discounts.Aluminum
add TotalPrice float not null

alter table Discounts.Accessorie
add TotalPrice float not null

alter table Discounts.Aluminum
add RollsNumber int not null

alter table Discounts.Glasses
add TotalPrice float not null

alter table Discounts.Aluminum
add AddingHeight float not null default null;

alter table Discounts.Aluminum
add AddingWidth float not null default null;

UPDATE Discounts.Aluminum
SET AddingHeight = 0;

UPDATE Discounts.Aluminum
SET AddingWidth = 0;

delete from Discounts.Aluminum

alter table Discounts.Aluminum
alter column Title nvarchar(15) not null

CREATE TABLE mytable (
    id INT PRIMARY KEY IDENTITY(1,1),
    attribute1 INT,
    attribute2 AS (attribute1 * 2) PERSISTED,
	attribute3 AS (attribute1* 2) PERSISTED
);

insert into mytable(attribute1) values(10)

select * from mytable

update mytable set attribute1 = 20 where attribute1 =10

drop table mytable