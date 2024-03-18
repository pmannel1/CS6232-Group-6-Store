-- SQL Server script

-- Drop and recreate the database
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'cs6232-6')
BEGIN
    DROP DATABASE [cs6232-6];
END
CREATE DATABASE [cs6232-6];
GO

USE [cs6232-6];
GO

-- Table employees
IF OBJECT_ID('employees', 'U') IS NOT NULL
    DROP TABLE employees;
GO

CREATE TABLE employees (
    id INT IDENTITY(1,1) PRIMARY KEY,
    lastName NVARCHAR(255) NOT NULL,
    firstName NVARCHAR(255) NOT NULL,
    sex NVARCHAR(50) CHECK (sex IN ('M', 'F', 'Other')) NOT NULL,
    dob DATETIME2 NOT NULL,
    street NVARCHAR(255) NOT NULL,
    city NVARCHAR(255) NOT NULL,
    state NVARCHAR(255) NOT NULL,
    zipCode NVARCHAR(255) NOT NULL,
    country NVARCHAR(255) NOT NULL,
    contactPhone NVARCHAR(255) NOT NULL,
    password NVARCHAR(255) NOT NULL
);
GO

-- Table furniture
IF OBJECT_ID('furniture', 'U') IS NOT NULL
    DROP TABLE furniture;
GO

CREATE TABLE furniture (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    description NVARCHAR(255) NOT NULL,
    styleName NVARCHAR(255) NOT NULL,
    categoryName NVARCHAR(255) NOT NULL,
    rentalRate DECIMAL(10,2) NOT NULL,
    instockNumber INT NOT NULL
);
GO

-- Table members
IF OBJECT_ID('members', 'U') IS NOT NULL
    DROP TABLE members;
GO

CREATE TABLE members (
    id INT IDENTITY(1,1) PRIMARY KEY,
    lastName NVARCHAR(255) NOT NULL,
    firstName NVARCHAR(255) NOT NULL,
    sex NVARCHAR(50) CHECK (sex IN ('M', 'F', 'Other')) NOT NULL,
    dob DATETIME2 NOT NULL,
    street NVARCHAR(255) NOT NULL,
    city NVARCHAR(255) NOT NULL,
    state NVARCHAR(255) NOT NULL,
    zipCode NVARCHAR(255) NOT NULL,
    country NVARCHAR(255) NOT NULL,
    contactPhone NVARCHAR(255) NOT NULL,
    password NVARCHAR(255) NOT NULL
);
GO

-- Table rental_transactions
IF OBJECT_ID('rental_transactions', 'U') IS NOT NULL
    DROP TABLE rental_transactions;
GO

CREATE TABLE rental_transactions (
    id INT IDENTITY(1,1) PRIMARY KEY,
    employeeId INT NOT NULL,
    memberId INT NOT NULL,
    rentalDate DATETIME2 NOT NULL,
    dueDate DATETIME2 NOT NULL,
    FOREIGN KEY (employeeId) REFERENCES employees(id),
    FOREIGN KEY (memberId) REFERENCES members(id)
);
GO

-- Table rental_items
IF OBJECT_ID('rental_items', 'U') IS NOT NULL
    DROP TABLE rental_items;
GO

CREATE TABLE rental_items (
    id INT IDENTITY(1,1) PRIMARY KEY,
    transactionId INT NOT NULL,
    furnitureId INT NOT NULL,
    quantity INT NOT NULL,
    quantityReturned INT DEFAULT 0,
    FOREIGN KEY (transactionId) REFERENCES rental_transactions(id),
    FOREIGN KEY (furnitureId) REFERENCES furniture(id)
);
GO

-- Table return_transactions
IF OBJECT_ID('return_transactions', 'U') IS NOT NULL
    DROP TABLE return_transactions;
GO

CREATE TABLE return_transactions (
    id INT IDENTITY(1,1) PRIMARY KEY,
    employeeId INT NOT NULL,
    memberId INT NOT NULL,
    returnDate DATETIME2 NOT NULL,
    refund DECIMAL(10,2) NULL,
    fine DECIMAL(10,2) NULL,
    FOREIGN KEY (employeeId) REFERENCES employees(id),
    FOREIGN KEY (memberId) REFERENCES members(id)
);
GO

-- Table return_items
IF OBJECT_ID('return_items', 'U') IS NOT NULL
    DROP TABLE return_items;
GO

CREATE TABLE return_items (
    id INT IDENTITY(1,1) PRIMARY KEY,
    returnId INT NOT NULL,
    rentalItemId INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (returnId) REFERENCES return_transactions(id),
    FOREIGN KEY (rentalItemId) REFERENCES rental_items(id)
);
GO

-- Table styles
IF OBJECT_ID('styles', 'U') IS NOT NULL
    DROP TABLE styles;
GO

CREATE TABLE styles (
    name NVARCHAR(255) PRIMARY KEY
);
GO

-- Table categories
IF OBJECT_ID('categories', 'U') IS NOT NULL
    DROP TABLE categories;
GO

CREATE TABLE categories (
    name NVARCHAR(255) PRIMARY KEY
);
GO

-- Create the 'states' table
IF OBJECT_ID('states', 'U') IS NOT NULL
    DROP TABLE states;
GO

CREATE TABLE states (
    stateAbbreviation CHAR(2) PRIMARY KEY
);
GO

-- Insert abbreviated state names into the 'states' table
INSERT INTO states (stateAbbreviation) VALUES
('AL'), ('AK'), ('AZ'), ('AR'), ('CA'),
('CO'), ('CT'), ('DE'), ('FL'), ('GA'),
('HI'), ('ID'), ('IL'), ('IN'), ('IA'),
('KS'), ('KY'), ('LA'), ('ME'), ('MD'),
('MA'), ('MI'), ('MN'), ('MS'), ('MO'),
('MT'), ('NE'), ('NV'), ('NH'), ('NJ'),
('NM'), ('NY'), ('NC'), ('ND'), ('OH'),
('OK'), ('OR'), ('PA'), ('RI'), ('SC'),
('SD'), ('TN'), ('TX'), ('UT'), ('VT'),
('VA'), ('WA'), ('WV'), ('WI'), ('WY');
GO

-- Inserting sample data into the 'styles' table
INSERT INTO styles (name) VALUES ('Modern'), ('Classic'), ('Vintage');
GO

-- Inserting sample data into the 'categories' table
INSERT INTO categories (name) VALUES ('Sofa'), ('Chair'), ('Table'), ('Bed');
GO

-- Inserting sample data into the 'employees' table
INSERT INTO employees (lastName, firstName, sex, dob, street, city, state, zipCode, country, contactPhone, password) 
VALUES 
('Smith', 'John', 'M', '1980-06-15', '123 Maple St', 'Anytown', 'CA', '90001', 'USA', '1235551234', 'pass123'),
('Doe', 'Jane', 'F', '1985-07-20', '456 Oak Ave', 'Othertown', 'NY', '10001', 'USA', '1235555678', 'pass456');
GO

-- Inserting sample data into the 'members' table
INSERT INTO members (lastName, firstName, sex, dob, street, city, state, zipCode, country, contactPhone, password) 
VALUES 
('Johnson', 'Bill', 'M', '1990-08-30', '789 Pine Rd', 'Sometown', 'TX', '75001', 'USA', '1235559012', 'pw123'),
('Williams', 'Sara', 'F', '1992-09-25', '321 Birch Blvd', 'Newcity', 'FL', '32001', 'USA', '1235553456', 'pw456');
GO

-- Inserting sample data into the 'furniture' table
INSERT INTO furniture (name, description, styleName, categoryName, rentalRate, instockNumber) 
VALUES 
('Sofa 1', 'Comfortable three-seater sofa', 'Modern', 'Sofa', 19.99, 10),
('Chair 1', 'Ergonomic office chair', 'Classic', 'Chair', 9.99, 15),
('Table 1', 'Sturdy wooden dining table', 'Vintage', 'Table', 29.99, 5);
GO

-- Inserting sample data into the 'rental_transactions' table
INSERT INTO rental_transactions (employeeId, memberId, rentalDate, dueDate) 
VALUES 
(1, 1, '2023-01-01 10:00:00', '2023-01-15 10:00:00'),
(2, 2, '2023-01-02 11:00:00', '2023-01-16 11:00:00');
GO

-- Inserting sample data into the 'rental_items' table
INSERT INTO rental_items (transactionId, furnitureId, quantity, quantityReturned) 
VALUES 
(1, 1, 2, 0),
(2, 2, 1, 0);
GO

-- Inserting sample data into the 'return_transactions' table
INSERT INTO return_transactions (employeeId, memberId, returnDate, refund, fine) 
VALUES 
(1, 1, '2023-01-15 11:00:00', 10.00, 0.00),
(2, 2, '2023-01-16 12:00:00', 5.00, 2.00);
GO

-- Inserting sample data into the 'return_items' table
INSERT INTO return_items (returnId, rentalItemId, quantity) 
VALUES 
(1, 1, 2),
(2, 2, 1);
GO
