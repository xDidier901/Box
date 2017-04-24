CREATE PROCEDURE reporteBoxeadores
	@Rama varchar(10),
	@categoria int,
	@division int,
	@municipio int
AS
	SELECT Boxeadores.Nombre, Boxeadores.Rama, Boxeadores.FechaNacimiento,
	Categorias.Nombre as Categoria, Divisiones.Nombre as Division, Municipios.Nombre as Municipio from Boxeadores
	inner join Categorias
	on Boxeadores.Categoria = Categorias.Id_Categoria
	inner join Divisiones
	on Boxeadores.Division = Divisiones.Id_Division
	inner join Municipios
	on Boxeadores.Municipio = Municipios.Id_Municipio
	where (Boxeadores.Rama = @rama) and
	 (Boxeadores.Categoria = @categoria) and  
	 (Boxeadores.Division = @division)   and 
	 (Boxeadores.Municipio = @municipio)
	
	