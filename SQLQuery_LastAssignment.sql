USE [DEV310DB]
GO

--Remove all data from the tables and reset the idendity
DELETE FROM [dbo].[SalesTransaction]
DBCC CHECKIDENT ('SalesTransaction', RESEED, 0);

DELETE FROM [dbo].[Products]
DBCC CHECKIDENT ('products', RESEED, 0);

DELETE FROM [dbo].[Person]
DBCC CHECKIDENT ('Person', RESEED, 0);


--Populate some data in the tables

INSERT INTO [dbo].[Person]([name],[email],[phone])VALUES
			('John Doe', 'john.doe@example.com', '555-1234'),
			('Jane Smith', 'jane.smith@example.com', '555-5678'),
			('Alice Johnson', 'alice.johnson@example.com', '555-9012'),
			('Bob Williams', 'bob.williams@example.com', '555-3456'),
			('Charlie Brown', 'charlie.brown@example.com', '555-7890'),
			('Diana Prince', 'diana.prince@example.com', '555-2345'),
			('Ethan Hunt', 'ethan.hunt@example.com', '555-6789'),
			('Fiona Davis', 'fiona.davis@example.com', '555-0123'),
			('George Miller', 'george.miller@example.com', '555-4567'),
			('Hannah Scott', 'hannah.scott@example.com', '555-8901');

INSERT INTO [dbo].[Products]([Name],[Description],[Price],[InventoryAmount])
     VALUES
		('Laptop', '15-inch gaming laptop', 1299.99, 50),
		('Smartphone', '5G smartphone, 128GB', 799.99, 100),  
		('Wireless Headphones', 'Noise-canceling headphones', 199.99, 200),  
		('Smartwatch', 'Fitness tracking watch', 149.99, 75),  
		('Gaming Console', 'Next-gen 4K console', 499.99, 30),  
		('Bluetooth Speaker', 'Portable speaker, deep bass', 89.99, 150),  
		('4K TV', '55-inch Ultra HD TV', 699.99, 40),  
		('Mechanical Keyboard', 'RGB mechanical keyboard', 129.99, 120),  
		('External Hard Drive', '2TB USB 3.0 drive', 79.99, 80),  
		('Drone', '4K camera drone', 899.99, 20);  

-- check if the tables got pupulate propertly. SalesTransaction should be empty
select * from Person
select * from Products
select * from SalesTransaction