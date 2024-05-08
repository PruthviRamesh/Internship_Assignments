--------------------------1------------------------
CREATE FUNCTION fn_ProductDetails()
RETURNS table
AS
	return(Select * from Production.Product where Year(SellStartDate) between 2010 and 2013);

SELECT * FROM fn_ProductDetails();

-------------------------2--------------------------
ALTER FUNCTION fn_TotalQty(@PID int)
RETURNS table
AS
	return(select SUM(sod.OrderQty) as [Total Quantity],p.ProductID,p.Name 
		   from Production.Product p Join Sales.SalesOrderDetail sod on p.ProductID=sod.ProductID
		   where p.ProductID=@PID
		   group by p.ProductID,p.Name);

SELECT * FROM fn_TotalQty(762);

----------------------3-----------------------
CREATE TRIGGER tr_RestrictDeletionOfData
ON Production.Location
INSTEAD OF DELETE
AS
BEGIN
	ROLLBACK TRANSACTION
	PRINT 'CANNOT DELETE'
END;
	
DELETE FROM Production.Location WHERE LocationId=1;

---------------------4------------------------
CREATE TRIGGER tr_RestrictDML_Operations
ON Sales.Promotion
INSTEAD OF INSERT,UPDATE,DELETE
AS
BEGIN
	Declare @ParticularDate date
	set @ParticularDate='2024-05-08'
	if(CONVERT(date,GETDATE())=@ParticularDate)
		raiserror('DML Operations are restricted today',16,1)
	rollback transaction
END

DELETE SALES.Promotion WHERE PromotionId=1;
INSERT INTO SALES.Promotion VALUES(6,'ABC','2023-09-07','2024-10-23',200.0);
UPDATE SALES.Promotion SET PromotionName='ABC' WHERE PromotionId=1;

---------------------6-----------------------
CREATE TRIGGER tr_RestrictAddingTablesToDatabase
ON DATABASE
FOR CREATE_TABLE
AS 
BEGIN
	raiserror('Cannot add table to this database',16,1)
	rollback transaction
END;

CREATE TABLE DEMO
(NAME VARCHAR(20));

---------------------7------------------------
CREATE VIEW vw_Quantity_Sales
AS
	Select q.ProductId,q.AvailableQuantity,s.ProductName,q.Unitprice,s.Totalprice 
	from Production.Quantity q join Production.Sales s on q.ProductId=s.ProductId;

CREATE TRIGGER tr_RaiseError
ON vw_Quantity_Sales
INSTEAD OF UPDATE
AS
BEGIN
	Raiserror('Cannot Update Views that is based on multiple table',16,1)
END;

UPDATE vw_Quantity_Sales SET PRODUCTNAME='CYCLE' WHERE PRODUCTID=1;

SELECT * FROM vw_Quantity_Sales;
SELECT * FROM Production.Sales;
SELECT * FROM Production.Quantity;
