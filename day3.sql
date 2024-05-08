---------------1--------------------
select ProductId,Name,TotalQty,ROW_NUMBER() over(order by TotalQty desc) as Rank from
(select p.ProductID,Name,sum(OrderQty) as TotalQty from Production.Product p join Sales.SalesOrderDetail t on p.ProductID=t.ProductID
group by p.ProductID,Name) as HighestQty;

---------------2---------------------
select CONCAT(FirstName,' ',MiddleName,' ',LastName) Name,ROW_NUMBER() over(order by SalesYTD desc) as Ranking,SalesYTD 
from Sales.SalesPerson sp join Person.Person p on sp.BusinessEntityID=p.BusinessEntityID;

select * from Sales.SalesPerson sp join Person.Person p on sp.BusinessEntityID=p.BusinessEntityID;

---------------3---------------------
select CONCAT(FirstName,' ',MiddleName,' ',LastName) as Name,JobTitle,VacationHours 
from HumanResources.Employee e join Person.Person p on e.BusinessEntityID=p.BusinessEntityID
where VacationHours=(select max(VacationHours) from HumanResources.Employee);

---------------4----------------------
select CONCAT(FirstName,' ',MiddleName,' ',LastName) as Name,st.SalesYTD,st.SalesLastYear,sh.TerritoryID,name,
LEAD(SalesYTD,1,0) over(order by salesYTD desc) as SalesYTD_of_next_Person,
LAG(SalesLastYear,1,0) over(order by SalesLastYear desc) as SalestLastYear_of_previous_person
from Person.Person p join Sales.SalesTerritoryHistory sh on p.BusinessEntityID=sh.BusinessEntityID 
join Sales.SalesTerritory st on sh.TerritoryID=st.TerritoryID;

---------------5-----------------------
select * from (Select p.ProductID, p.Name,p.Color,sod.OrderQty from Production.Product p join Sales.SalesOrderDetail sod ON p.ProductID = sod.ProductID) as Sales
pivot
(   sum(OrderQty)
    for Color 
	in ([Black], [Blue], [Grey], [Multi], [Red], [Silver], [Silver/Black], [White], [Yellow], [No Color]) 
) as piv;

---------------6---------------------
select * from
(select p.Name,p.ProductID,YEAR(h.orderDate) [year],OrderQty from Production.Product p 
join sales.SalesOrderDetail d on p.ProductID=d.ProductID join Sales.SalesOrderHeader h on h.SalesOrderID=d.SalesOrderID) as products
pivot(
	sum(orderQty)
	for [year]
	in([2011],[2012],[2013],[2014])
)as piv;

----------------------------------
select CONCAT(FirstName,' ',MiddleName,' ',LastName) as Name,st.SalesYTD,st.SalesLastYear,
case 
	when SalesYTD<SalesLastYear then 'Bad Performace'
	else 'Good Performace'
	end as status
from Person.Person p join Sales.SalesTerritoryHistory sh on p.BusinessEntityID=sh.BusinessEntityID 
join Sales.SalesTerritory st on sh.TerritoryID=st.TerritoryID;

----------------------------------
select CONCAT(FirstName,' ',MiddleName,' ',LastName) as Name,salesytd,Rank() over(order by salesYtd) as Rank,
case 
	when salesYtd>=LEAD(Salesytd,1,0) over(order by salesYtd asc) then 'good performance'
	else 'Average performance'
	end as status
from Person.Person p join Sales.SalesTerritoryHistory sh on p.BusinessEntityID=sh.BusinessEntityID 
join Sales.SalesTerritory st on sh.TerritoryID=st.TerritoryID;
