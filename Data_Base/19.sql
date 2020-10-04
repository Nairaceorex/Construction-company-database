CREATE TABLE Positions
(
  Job_title VARCHAR NOT NULL,
  Salary INT NOT NULL,
  Duties VARCHAR NOT NULL,
  Requirements VARCHAR NOT NULL,
  ID_Position INT NOT NULL,
  PRIMARY KEY (ID_Position)
);

CREATE TABLE Types_of_jobs
(
  ID_Type INT NOT NULL,
  _Name VARCHAR NOT NULL,
  _Description VARCHAR NOT NULL,
  Price_of_work INT NOT NULL,
  PRIMARY KEY (ID_Type)
);

CREATE TABLE Materials
(
  ID_Material INT NOT NULL,
  ID_Type INT NOT NULL,
  ID_Materials_2ID_Type INT NOT NULL,
  ID_Materials_3ID_Type INT NOT NULL,
  PRIMARY KEY (ID_Material),
  FOREIGN KEY (ID_Type) REFERENCES Types_of_jobs(ID_Type),
  FOREIGN KEY (ID_Materials_2ID_Type) REFERENCES Types_of_jobs(ID_Type),
  FOREIGN KEY (ID_Materials_3ID_Type) REFERENCES Types_of_jobs(ID_Type)
);

CREATE TABLE Customers
(
  ID_Customer INT NOT NULL,
  Address VARCHAR NOT NULL,
  Full_Name VARCHAR NOT NULL,
  Phone INT NOT NULL,
  Passport_data INT NOT NULL,
  PRIMARY KEY (ID_Customer)
);

CREATE TABLE Staff
(
  Full_Name VARCHAR NOT NULL,
  Age INT NOT NULL,
  Sex VARCHAR NOT NULL,
  Address VARCHAR NOT NULL,
  Phone INT NOT NULL,
  Passport_data INT NOT NULL,
  ID_Employee INT NOT NULL,
  ID_Position INT,
  ID_Brigade INT NOT NULL,
  PRIMARY KEY (ID_Employee),
  FOREIGN KEY (ID_Position) REFERENCES Positions(ID_Position),
  FOREIGN KEY (ID_Brigade) REFERENCES Brigades(ID_Brigade)
);

CREATE TABLE Brigades
(
  ID_Brigade INT NOT NULL,
  ID_Employee INT NOT NULL,
  ID_Employee_3ID_Employee INT NOT NULL,
  PRIMARY KEY (ID_Brigade),
  FOREIGN KEY (ID_Employee) REFERENCES Staff(ID_Employee),
  FOREIGN KEY (ID_Employee_3ID_Employee) REFERENCES Staff(ID_Employee)
);

CREATE TABLE Orders
(
  Start_date DATE NOT NULL,
  Cost INT NOT NULL,
  About_payment VARCHAR NOT NULL,
  Completion_mark VARCHAR NOT NULL,
  Expiration_date DATE NOT NULL,
  ID_Order INT NOT NULL,
  ID_Customer_ INT NOT NULL,
  ID_Brigade INT,
  ID_Type INT NOT NULL,
  PRIMARY KEY (ID_Order),
  FOREIGN KEY (ID_Customer_) REFERENCES Customers(ID_Customer),
  FOREIGN KEY (ID_Brigade) REFERENCES Brigades(ID_Brigade),
  FOREIGN KEY (ID_Type) REFERENCES Types_of_jobs(ID_Type)
);