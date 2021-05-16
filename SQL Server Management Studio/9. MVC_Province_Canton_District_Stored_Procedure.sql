CREATE PROCEDURE GetCantonsByIdProvince (@Id INT) 
AS 
  BEGIN 
      SELECT Id,Name
	  FROM Canton
	  WHERE ProvinceId = @Id
  END

  CREATE PROCEDURE GetDistrictsByIdCanton (@Id INT) 
AS 
  BEGIN 
      SELECT Id, Name
	  FROM District
	  WHERE CantonId = @Id
  END

  CREATE PROCEDURE GetProvinces
AS 
  BEGIN 
      SELECT Id,Name
	  FROM Province
  END