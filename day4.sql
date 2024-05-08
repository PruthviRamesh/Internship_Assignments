-------------------------1------------------------------
create schema Production;

create table Production.Quantity
(ProductId int primary key,
AvailableQuantity int,
Unitprice float,
Totalprice float);

create table Production.Sales
(ProductId int references Production.Quantity(ProductId),
ProductName varchar(100),
Quantity int,
Unitprice float,
Totalprice float,
DateOfSales date,
Discount float);

insert into Production.Quantity
values(1,50,10.0,500.0),
	  (2,10,20.0,200.0),
	  (3,4,200.0,800.0),
	  (4,10,5.0,50.0),
	  (5,30,10.0,300.0),
	  (6,2,500.0,1000.0),
	  (7,12,10.0,120.0),
	  (8,15,20.0,300.0),
	  (9,1,250.0,250.0),
	  (10,13,5.0,65.0);

select * from Production.Quantity;

insert into Production.Sales
values(1,'DairyMilk',40,10.0,390.0,'2024-03-20',10.0),
	  (2,'Lays',8,20.0,155.0,'2024-02-06',5.0),
	  (4,'Lollipop',10,5.0,45.0,'2024-05-01',5.0),
	  (1,'DairyMilk',10.0,10.0,100.0,'2024-04-01',0.0),
	  (6,'Shoes',1,500.0,480.0,'2024-02-29',20.0),
	  (5,'Pencil',5,10.0,50.0,'2024-04-01',0.0),
	  (9,'Phone Case',1,250.0,250.0,'2024-01-26',0.0),
	  (10,'Pen',13,0.5,60.0,'2024-02-15',5.0),
	  (2,'Lays',2,20.0,40.0,'2024-04-30',0.0),
	  (3,'T-shirt',4,200.0,750.0,'2024-02-20',50.0),
	  (5,'Pencil',20,10.0,198.0,'2024-01-21',2.0);

select * from Production.Sales;

select ProductId,ProductName,sum(Quantity) as sales from Production.Sales
group by ProductId,ProductName
order by sales desc 
offset 0 rows fetch next 1 rows only;

-----------------------------2-------------------------------------
create schema Sales;

create table Sales.Promotion
(PromotionId int primary key,
PromotionName varchar(100),
StartDate date,
EndDate date,
Discount float check(Discount>0));

insert into Sales.Promotion 
values(1,'New Year Sales','2023-12-25','2024-01-01',100.0),
	  (2,'Spring Sales','2024-01-20','2024-02-20',120.0),
	  (3,'Summer Sales','2024-03-20','2024-04-20',150.0),
	  (4,'Diwali Dhamaka','2024-08-08','2024-08-23',220.0),
	  (5,'Christmas Special','2024-12-20','2024-12-26',350.0);

select * from Sales.Promotion;

----------------------3--------------------------
create view VWUNIQUE_CUSTOMER
as
select CONVERT(date,OrderDate) [Date],AVG(TotalDue) [Average Purchase Amt],SUM(TotalDue) [Total Purchase Amt],Count(distinct CustomerId) [Customer Count]
from Sales.SalesOrderHeader
group by CONVERT(date,OrderDate);

select * from VWUNIQUE_CUSTOMER;

--------------------4---------------------------
create view VWSALES_AMT
as 
select SalesPersonId,CONCAT(p.FirstName,' ',p.MiddleName,' ',p.LastName) as [Name],AVG(soh.Totaldue) as [Average Purchase Amount],SUM(soh.TotalDue) as [Total Purchase Amount]
from Person.Person p join Sales.SalesOrderHeader soh on p.BusinessEntityID=soh.SalesPersonID 
group by CONCAT(FirstName,' ',MiddleName,' ',LastName),SalesPersonID;

select * from VWSALES_AMT;

---------------------------5--------------------------------
create table Production.ProductDetails
(ProductId int primary key,
ProductName varchar(100),
ProductNumber varchar(30),
AvailableQuantity int,
LocationId int);

create table Production.Location
(LocationId int primary key,
ProductId int references Production.ProductDetails(ProductId),
ProductName varchar(100),
ProductNumber varchar(30),
LocationName varchar(100));

insert into Production.ProductDetails 
values(1,'Laptop','P1',10,1),
	  (2,'Bicycle','P2',2,2);

insert into Production.Location
values (1,1,'Laptop','P1','New York'),
	   (2,2,'Bicycle','P2','Bangalore');

select * from Production.ProductDetails;
select * from Production.Location;

-----------------------6------------------------
create procedure SPEMP_DETAILS
as
begin
	select CONCAT(P.FirstName,' ',P.MiddleName,' ',P.LastName) as FullName,E.NationalIDNumber,E.JobTitle 
	from HumanResources.Employee E join Person.Person P on E.BusinessEntityID=P.BusinessEntityID;
end;

exec SPEMP_DETAILS;

----------------------7------------------------
create procedure SPCOMPARE_SALES
@BusinessEntityId int
as
begin
	select CONCAT(p..FirstName,' ',p.MiddleName,' ',p.LastName) [Name],p.BusinessEntityID,YEAR(soh.OrderDate) [Year],SUM(soh.TotalDue) AS TotalSales,sp.SalesQuota
	from Person.Person p join Sales.SalesOrderHeader soh on p.BusinessEntityID=soh.SalesPersonID 
	join Sales.SalesPerson sp on p.BusinessEntityID=sp.BusinessEntityID
	where p.BusinessEntityID = @BusinessEntityID
	group by CONCAT(FirstName,' ',MiddleName,' ',LastName),p.BusinessEntityID,YEAR(OrderDate),sp.SalesQuota
	order by YEAR(OrderDate);
end;

exec SPCOMPARE_SALES 282

---------------------8-----------------------------
create procedure SPPROD_QTY
as
begin
	select LocationID as LOCATION_ID,SUM(QUANTITY) as QUANTITY,DENSE_RANK() OVER(ORDER BY SUM(QUANTITY) DESC) as RANK 
	from Production.ProductInventory group by LocationID;
end;

exec SPPROD_QTY 10;

-----------------------9------------------------
create procedure SPTOP_EMP
as
begin
	select Top 10 CONCAT(p.FirstName,' ',p.MiddleName,' ',p.LastName) AS [NAME],e.RATE,DENSE_RANK() OVER(ORDER BY e.RATE DESC) RANK
	from HumanResources.EmployeePayHistory e join Person.Person p ON e.BusinessEntityID=p.BusinessEntityID;
end;

exec SPTOP_EMP
-------------------------------
create procedure SPTOP_EMP_SALES
as 
begin 
	select Top 10 CONCAT(p.FirstName,' ',p.MiddleName,' ',p.LastName) AS [NAME],SUM(e.TOTALDUE) as SALES,DENSE_RANK() OVER(ORDER BY SUM(e.TOTALDUE) DESC) RANK,e.SalesPersonID
	from Sales.SalesOrderHeader e join Person.Person p ON e.SalesPersonID=p.BusinessEntityID
	group by CONCAT(FirstName,' ',MiddleName,' ',LastName),SalesPersonID;
end;

exec SPTOP_EMP_SALES;

----------------------10------------------------
create procedure SPTOTAL_SALES
as 
begin
	select SUM(sod.OrderQty) as Total_Sales,YEAR(soh.OrderDate ) as Year
	from Sales.SalesOrderHeader soh join Sales.SalesOrderDetail sod on soh.SalesOrderID=sod.SalesOrderID
	group by YEAR(OrderDate);
end;

exec SPTOTAL_SALES;









