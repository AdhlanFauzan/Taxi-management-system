USE TaxiManagementSystem;

INSERT INTO dbo.Car(LicensePlate, Model, Mileage, [State])
	VALUES
		('AA 3245 AK', 'BMW M5', 30000,'Good'),
		('AB 1295 EO', 'Lada Priora', 63512,'Not bad'),
		('BC 1155 AD', 'Kia Kid', 7500,'Good'),
		('BC 8877 BK', 'Infinity A5', 18345,'Very good'),
		('BC 4275 LM', 'Lada 1510', 112000,'Very bad');
 
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1111,'Lviv','Gorodok', 33, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1111,'Lviv, Prumiskuy vokzal','Lviv, Pasichna', 15, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1112, 'Lviv, Prumiskuy vokzal', 'Lviv, Universutetska', 7, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1113, 'Lviv, Prumiskuy vokzal', 'Sudova vushnya, ', 65, '2016-10-15');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1114, 'Gorodok, Pidgirya', 'Gorodok, Pidgay', 5, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1115, 'Lviv, Zelena', 'Lviv, Kn. Olgu', 12, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1114, 'Lviv, Prumiskuy vokzal', 'Lviv, Suhiv', 22, '2016-10-15');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1115, 'Lviv, Gorodotska 5', 'Grubovuchi', 27, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1113, 'Lviv, Prumiskuy vokzal', 'Lviv, Konopnutsa', 18, '2016-10-14');
INSERT INTO dbo.[Call] (CarId, DeparturePlace, ArrivalPlace, Distance, [Date])
	VALUES (1112, 'Lviv, Piccaso club', 'Lviv, LNU-Hostel', 7, '2016-10-14');
			
INSERT INTO dbo.Employee(CarId, FirstName, LastName, Age, Gender)
	VALUES  
		(1111, 'Roman','Zaiats', 18, 'M'),
		(1112, 'Max','Zaiats', 22, 'M'),
		(1113, 'Oksana','Petrenko', 38, 'F'),
		(1114, 'Petro', 'Ivanskuy', 49, 'M'),
		(1115, 'Muron', 'Taksichenko', 57, 'M'),
		(1112, 'Roma','Vehun', 22, 'F');

-- This is commerсial program so all users accaunt are given to dispatchers by a company
INSERT INTO dbo.[User] (FirstName, LastName, [Login], [Password])
	VALUES 
		('Maruna', 'Ivanivna', 'marunka66', dbo.MD5('1234554321')),
		('Natalia','Fedorenko','nata1212', dbo.MD5('1q2w3e4r')),
		('Reviewer','Emap','reviewer', dbo.MD5('LvivEpam'));
