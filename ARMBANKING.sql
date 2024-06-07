CREATE TABLE Membre(
   Membre_id INT,
   [Name] VARCHAR(50) NOT NULL,
   FirstName VARCHAR(50) NOT NULL,
   Birth_Date DATE NOT NULL,
   PRIMARY KEY(Membre_id)
)

CREATE TABLE Banque(
   [Name] VARCHAR(50),
   Courant_Number VARCHAR(50) NOT NULL,
   PRIMARY KEY([Name])
)

CREATE TABLE Compte 
(
   [Number] VARCHAR(50),
   Solde DECIMAL (15,2),
   Holder INT FOREIGN KEY REFERENCES Membre(Membre_id),
   Bank_Name VARCHAR(50) FOREIGN KEY REFERENCES Banque([Name]),
   UNIQUE ([Number]),
   CONSTRAINT PK_compte PRIMARY KEY ([Number])
)

CREATE TABLE Courant(
   [Number] VARCHAR(50) FOREIGN KEY REFERENCES Compte([Number]),
   Credit_Ligne DECIMAL(7,2) NOT NULL
)

CREATE TABLE Epargne 
(
   [Number] VARCHAR(50) FOREIGN KEY REFERENCES Compte([Number]),
   Last_withdrawal DATETIME NOT NULL
)

