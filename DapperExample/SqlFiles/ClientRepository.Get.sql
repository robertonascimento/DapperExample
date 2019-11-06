SELECT 
		Identification,
		ShortName,
		Name
FROM Client
WHERE Identification  = @Identification or @Identification is null
	