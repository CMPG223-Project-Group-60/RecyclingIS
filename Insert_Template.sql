INSERT INTO STUDENT (L_Name, F_Name, Grade, Gender, DOB) VALUES
('Smith', 'John', 10, 1, '2008-05-12'),
('Brown', 'Alice', 9, 0, '2009-07-19'),
('Johnson', 'Michael', 11, 1, '2007-03-22'),
('Williams', 'Emma', 8, 0, '2010-11-05'),
('Jones', 'David', 12, 1, '2006-09-13'),
('Taylor', 'Sophia', 7, 0, '2011-01-25'),
('Anderson', 'James', 10, 1, '2008-02-14'),
('Thomas', 'Olivia', 9, 0, '2009-08-08'),
('Moore', 'Daniel', 11, 1, '2007-04-17'),
('Martin', 'Grace', 8, 0, '2010-12-03'),
('Lee', 'Ethan', 12, 1, '2006-05-29'),
('Clark', 'Ava', 7, 0, '2011-09-09'),
('Walker', 'Noah', 10, 1, '2008-10-30'),
('Hall', 'Mia', 9, 0, '2009-07-04'),
('Allen', 'Logan', 11, 1, '2007-06-15'),
('Young', 'Isabella', 8, 0, '2010-03-27'),
('Hernandez', 'Lucas', 12, 1, '2006-12-12'),
('King', 'Charlotte', 7, 0, '2011-05-20'),
('Wright', 'Benjamin', 10, 1, '2008-09-01'),
('Lopez', 'Amelia', 9, 0, '2009-02-18'),
('Hill', 'Jacob', 11, 1, '2007-01-11'),
('Scott', 'Harper', 8, 0, '2010-06-06'),
('Green', 'Elijah', 12, 1, '2006-07-07'),
('Adams', 'Evelyn', 7, 0, '2011-03-03'),
('Baker', 'Matthew', 10, 1, '2008-04-19'),
('Nelson', 'Abigail', 9, 0, '2009-09-22'),
('Carter', 'Samuel', 11, 1, '2007-05-01'),
('Mitchell', 'Ella', 8, 0, '2010-10-15'),
('Perez', 'Alexander', 12, 1, '2006-02-02'),
('Roberts', 'Scarlett', 7, 0, '2011-07-13'),
('Turner', 'Henry', 10, 1, '2008-06-09'),
('Phillips', 'Lily', 9, 0, '2009-12-25'),
('Campbell', 'Jackson', 11, 1, '2007-08-18'),
('Parker', 'Aria', 8, 0, '2010-11-27'),
('Evans', 'Owen', 12, 1, '2006-04-04'),
('Edwards', 'Zoe', 7, 0, '2011-10-23'),
('Collins', 'Luke', 10, 1, '2008-01-12'),
('Stewart', 'Layla', 9, 0, '2009-05-30'),
('Sanchez', 'Jack', 11, 1, '2007-09-07'),
('Morris', 'Chloe', 8, 0, '2010-08-21'),
('Rogers', 'Gabriel', 12, 1, '2006-03-14'),
('Reed', 'Victoria', 7, 0, '2011-12-01'),
('Cook', 'Mason', 10, 1, '2008-07-02'),
('Morgan', 'Penelope', 9, 0, '2009-11-16'),
('Bell', 'Carter', 11, 1, '2007-10-28'),
('Murphy', 'Riley', 8, 0, '2010-02-08'),
('Bailey', 'Wyatt', 12, 1, '2006-01-21'),
('Rivera', 'Nora', 7, 0, '2011-04-14'),
('Cooper', 'Isaac', 10, 1, '2008-09-19'),
('Richardson', 'Hannah', 9, 0, '2009-06-26');



INSERT INTO ITEM (Item_Name, Item_QtyOnHand) VALUES
('Plastic Bottles', 200),
('Aluminum Cans', 150),
('Paper Waste', 300),
('Glass Jars', 100);


INSERT INTO MERIT (Merit_Type, Points_Awarded) VALUES
(1, 10),   -- Participation
(2, 20),   -- Leadership
(3, 15),   -- Creativity
(4, 25);   -- Excellence


INSERT INTO RECYCLEPROJECT (Proj_Name, Proj_Description, Proj_Due) VALUES
('Clean Campus', 'Pick up litter and plastics', '2025-09-30'),
('Paper Drive', 'Collect waste paper for recycling', '2025-10-15'),
('Can Collection', 'Gather aluminum cans for funds', '2025-11-01'),
('Glass Awareness', 'Promote glass recycling', '2025-12-05');


INSERT INTO RECORDEDITEM (StudentID, ItemID, Date_Received, NumBags_Received) VALUES
(1, 1, '2025-08-01', 3),
(2, 2, '2025-08-02', 2),
(3, 3, '2025-08-03', 4),
(4, 4, '2025-08-04', 1),
(5, 1, '2025-08-05', 5),
(6, 2, '2025-08-06', 2),
(7, 3, '2025-08-07', 3),
(8, 4, '2025-08-08', 1),
(9, 1, '2025-08-09', 4),
(10, 2, '2025-08-10', 2);


INSERT INTO STUDENTMERIT (StudentID, MeritID, Date_Awarded) VALUES
(1, 1, '2025-08-05'),
(2, 2, '2025-08-06'),
(3, 3, '2025-08-07'),
(4, 4, '2025-08-08'),
(5, 1, '2025-08-09'),
(6, 2, '2025-08-10'),
(7, 3, '2025-08-11'),
(8, 4, '2025-08-12'),
(9, 1, '2025-08-13'),
(10, 2, '2025-08-14');


INSERT INTO STUDENTONPROJECT (ProjID, StudentID) VALUES
(1, 1),
(1, 2),
(1, 3),
(2, 4),
(2, 5),
(2, 6),
(3, 7),
(3, 8),
(3, 9),
(4, 10),
(4, 11),
(4, 12);
