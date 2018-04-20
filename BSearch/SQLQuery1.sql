Select Distinct [Name], [Position] from [Employed] where [Departament_Id] = 1 order by [Name] 

SELECT DISTINCT a.[Name], b.[Position]
FROM (SELECT [Name] FROM [Employed] where [Departament_Id] = 1) AS a  CROSS JOIN (SELECT [Position] FROM [Employed]  where [Departament_Id] = 1) AS b;
Select a.[Name], a.[Salary] from [Employed] as a where a.[Salary] >= 2 * (select AVG(g.[Salary]) from [Employed] as g where g.Chief_Id = a.Id)