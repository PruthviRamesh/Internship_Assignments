------------------1------------------------------------
CREATE TABLE STUDENTS
(STUDID INT PRIMARY KEY,
STUDNAME VARCHAR(20) NOT NULL,
STUAGE INT CHECK(STUAGE>=18),
STUADDRESS VARCHAR(50) NOT NULL);

INSERT INTO STUDENTS VALUES(101,'SMITH','20','BANGALORE');
INSERT INTO STUDENTS VALUES(102,'JOHN','20','MANGALORE');
INSERT INTO STUDENTS VALUES(103,'WARD','18','BANGALORE');

SELECT * FROM STUDENTS;

------------------2------------------------------------
CREATE TABLE SALES
(SALES_ID INT PRIMARY KEY,
CUS_ID INT,
CUS_NAME VARCHAR(20),
LOC VARCHAR(20),
COMMISSION DECIMAL(10,4),
TOTAL_SALES DECIMAL(10,4),
CONSTRAINT CK_COMMISSION CHECK ((LOC='LONDON' AND COMMISSION>1000) OR (LOC='US' AND COMMISSION<1000))
);

INSERT INTO SALES VALUES(1,1,'JOHN','LONDON',1003.9,20000);
INSERT INTO SALES VALUES(2,2,'SMITH','US',20.9,35000);
INSERT INTO SALES VALUES(3,3,'WARD','US',20.9,35000.98765);

SELECT * FROM SALES;

------------------3----------------------------
SELECT P.ProductID,Name,RATING FROM Production.Product P JOIN Production.ProductReview R ON P.ProductID=R.ProductID 
WHERE RATING=(SELECT MAX(RATING) FROM Production.ProductReview);

SELECT * FROM Production.Product P JOIN Production.ProductReview R ON P.ProductID=R.ProductID ;
------------------4----------------------------
SELECT P.OrderDate,S.CustomerID,MAX(P.TOTALDUE) AS Highest_Purchase_Amt 
FROM Purchasing.PurchaseOrderHeader P JOIN Sales.SalesOrderHeader S ON P.OrderDate=S.OrderDate 
GROUP BY P.OrderDate,S.CustomerID
ORDER BY S.CustomerID;

------------------5------------------------------
SELECT EmployeeID,OrderDate,VendorID,CONCAT(FirstName,' ',LastName,' ',MiddleName) FullName ,MAX(TotalDue) AS [Highest Due Amount]
FROM Person.Person P JOIN Purchasing.PurchaseOrderHeader O ON P.BusinessEntityID=O.EmployeeID
GROUP BY EmployeeID,OrderDate,VendorID,CONCAT(FirstName,' ',LastName,' ',MiddleName)
ORDER BY EmployeeID;

SELECT DISTINCT h.EmployeeID,CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS FullName,
FIRST_VALUE(h.OrderDate) OVER (PARTITION BY h.EmployeeID ORDER BY h.TotalDue DESC) AS OrderDate,
FIRST_VALUE(h.VendorID) OVER (PARTITION BY h.EmployeeID ORDER BY h.TotalDue DESC) AS VendorID,
FIRST_VALUE(TotalDue) OVER (PARTITION BY h.EmployeeID ORDER BY h.TotalDue DESC) AS [Highest Due Amount]
FROM Person.Person AS p JOIN Purchasing.PurchaseOrderHeader AS h ON p.BusinessEntityID = h.EmployeeID
ORDER BY EmployeeID;

SELECT EmployeeID,FullName,OrderDate,VendorID,TotalDue
FROM (SELECT h.EmployeeID,CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS FullName,h.TotalDue,h.OrderDate,h.VendorID,
ROW_NUMBER() OVER (PARTITION BY h.EmployeeID ORDER BY h.TotalDue DESC) AS row
FROM Person.Person AS p JOIN Purchasing.PurchaseOrderHeader AS h ON p.BusinessEntityID = h.EmployeeID) S
WHERE row = 1
ORDER BY EMPLOYEEID; 

SELECT EmployeeID,OrderDate,VendorID,CONCAT(FirstName,' ',LastName,' ',MiddleName) FullName ,TotalDue
FROM Person.Person P JOIN Purchasing.PurchaseOrderHeader O ON P.BusinessEntityID=O.EmployeeID
WHERE TotalDue IN(SELECT MAX(TotalDue) FROM Purchasing.PurchaseOrderHeader GROUP BY EmployeeID)
ORDER BY EmployeeID,TotalDue DESC;














