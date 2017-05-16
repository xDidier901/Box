Select Categorias.Nombre as Categoria,
(SELECT COUNT(Divisiones.Nombre) from Divisiones where Categorias.Id_Categoria = Divisiones.Categoria) as Divisiones
 from Categorias  
