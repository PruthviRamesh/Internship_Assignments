--------1---------
select sum(TotalDue) as TotalSales,SalesPersonID from Sales.SalesOrderHeader where OrderDate between '2011-06-12' and '2014-06-12' group by SalesPersonID;
------------------------------------------
select sum(TotalDue) as TotalSales,OrderDate,SalesPersonID from Sales.SalesOrderHeader group by SalesPersonID,OrderDate;

--------2----------
select SalesPersonID,TotalDue from Sales.SalesOrderHeader where TotalDue=(select max(TotalDue) from Sales.SalesOrderHeader);
--------------------------------------------
select top 1 SalesPersonID,max(TotalDue) from Sales.SalesOrderHeader group by SalesPersonID order by max(TotalDue) desc;

--------3-------------
select MONTH(OrderDate) as Month,max(TotalDue) from Sales.SalesOrderHeader  group by MONTH(OrderDate) 
order by max(TotalDue) desc offset 0 rows fetch next 1 rows only;

--------4--------------
select count(BusinessEntityID) as CandidatesReceviedJob from HumanResources.JobCandidate where BusinessEntityID is not null;

--------5-----------
select productId,name from Production.Product where FinishedGoodsFlag=1;

--------6------------
select count(SalesOrderID) as No_of_Orders,ProductID from Sales.SalesOrderDetail group by ProductID;

--------7------------
select CONCAT(firstname,' ',LastName) from Person.Person;

--------8------------
select ContactTypeID,Name from Person.ContactType where name like '%Manager' order by name desc;

--------9------------
select a.PostalCode,p.FirstName,p.LastName,s.SalesYTD 
from Person.Person as p join Person.BusinessEntityAddress as ba on ba.BusinessEntityID=p.BusinessEntityID join
Sales.SalesPerson as s on s.BusinessEntityID=ba.BusinessEntityID 
join Person.Address as a on a.AddressID=p.BusinessEntityID 
where s.TerritoryID is not null and SalesYTD!=0 
order by a.PostalCode,s.SalesYTD desc;

--------10-----------
select Convert(date,RateChangedate) as RateChangeDate,Rate*40 as WeeklySalary,CONCAT(p.FirstName,' ',p.MiddleName,' ',p.LastName) as fullname 
from HumanResources.EmployeePayHistory as e join Person.Person p on e.BusinessEntityID=p.BusinessEntityID 
order by fullname;

select count(BusinessEntityID) as CandidatesReceviedJob from HumanResources.JobCandidate where BusinessEntityID is not null;

--------11-----------
select s.SalesOrderID,s.ProductID, p.Name,s.OrderQty,min(OrderQty) as Min,sum(OrderQty) as Sum,max(OrderQty) as Max,avg(Orderqty) as Avg,count(OrderQty) as Count 
from Sales.SalesOrderDetail as s join Production.Product as p on s.ProductID=p.ProductID 
where SalesOrderID in (43659,43664) 
group by s.SalesOrderID,s.ProductID, p.Name,s.OrderQty;

select min(OrderQty) as Min,sum(OrderQty) as Sum,max(OrderQty) as Max,avg(Orderqty) as Avg,count(OrderQty) as Count 
from Sales.SalesOrderDetail as s join Production.Product as p on s.ProductID=p.ProductID 
where SalesOrderID in (43659,43664) ;

select sum(OrderQty) as orders,ProductID from sales.SalesOrderDetail group by ProductID;

--------12-----------
select p.Name, sod.SalesOrderID from Production.Product as p  
left join Sales.SalesOrderDetail as sod  
on p.ProductID = sod.ProductID  
order by p.Name ;

--------13------------
select p.Name,s.SalesOrderID from Production.Product as p full join Sales.SalesOrderDetail as s on p.ProductID=s.ProductID;

--------14------------
select sum(TotalDue) as TotalCost,SalesOrderID from Sales.SalesOrderHeader group by SalesOrderID having sum(TotalDue)>100000;
-------------------------------
select sum(LineTotal) as TotalCost,SalesOrderID from sales.SalesOrderDetail group by SalesOrderID having sum(LineTotal)>100000;

--------15-----------
select * from sales.SalesOrderDetail as s1 join Sales.SalesOrderHeader as s2 on s1.SalesOrderID=s2.SalesOrderID 
where (s1.OrderQty>5 or s1.UnitPriceDiscount<1000) and s2.TotalDue>100;

--------16-----------
select max(rate) as MinSalary,min(rate) as MaxSalary,avg(rate) as AvgSalary,count(dh.BusinessEntityID) as No_Of_Emp,dh.DepartmentID,d.Name 
from HumanResources.EmployeePayHistory p join HumanResources.EmployeeDepartmentHistory dh on p.BusinessEntityID=dh.BusinessEntityID 
join HumanResources.Department as d on dh.DepartmentID=d.DepartmentID 
group by dh.DepartmentID,d.name;

-------17------------
select FirstName,LastName,VacationHours,SickLeaveHours,(VacationHours+SickLeaveHours) as TotalHoursAwayFromWork
from HumanResources.Employee as e join Person.Person as p on e.BusinessEntityID=p.BusinessEntityID order by TotalHoursAwayFromWork;

-------18-------------
select count(e.BusinessEntityID) as Count_of_emp ,d.name,e.JobTitle
from HumanResources.Employee as e join HumanResources.EmployeeDepartmentHistory as h on e.BusinessEntityID=h.BusinessEntityID 
join HumanResources.Department as d on d.DepartmentID=h.DepartmentID where h.DepartmentID=12 or h.DepartmentID=14 group by name,JobTitle;

-------19-------------
select h.SalesOrderID,  c.PersonID, c.CustomerID, h.SubTotal, month(OrderDate) as Month, h.OrderDate, d.LineTotal,sum(Totaldue) over(order by orderdate) as t
from Sales.SalesOrderHeader as h join Sales.SalesOrderDetail as d on h.SalesOrderID = d.SalesOrderID
join Sales.Customer c on h.CustomerID = c.CustomerID WHERE OrderDate >= '2011-12-01';

-------20--------------
select distinct concat(pp.FirstName,' ',pp.MiddleName,' ',pp.LastName) as FullName
from Person.Person pp join Sales.SalesOrderHeader as soh on pp.BusinessEntityID=soh.SalesPersonID 
join sales.SalesOrderDetail as sod on sod.SalesOrderID=soh.SalesOrderID 
join Production.Product as p on p.ProductID=sod.ProductID where ProductNumber='BK-M68B-42';

-------21--------------
select ProductModelID,max(ListPrice) as MaxListPrice,2*avg(ListPrice) as AvgListPrice from Production.Product 
group by ProductModelID having max(ListPrice)>2*avg(ListPrice);