	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where (Boxeadores.Rama = 'Varonil') and
	 (Boxeadores.Categoria = 1) and  
	 (Boxeadores.Division = 5)   and 
	 (Boxeadores.Municipio = 32)
	 order by Boxeadores.Nombre asc