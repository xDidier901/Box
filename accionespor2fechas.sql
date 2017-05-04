CREATE PROCEDURE accionesPor2Fechas
	@fechaInicial datetime,
	@fechaFinal datetime
AS
	SELECT Acciones.Descripcion as Accion, Acciones.Fecha as Fecha from Acciones
	where Acciones.Fecha between @fechaInicial and @fechaFinal order by Acciones.Id_Accion asc



