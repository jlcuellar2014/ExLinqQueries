<Query Kind="Statements" />

// Agrupa una lista de estudiantes por su edad

List<(string Nombre, int Edad, string Nacionalidad)> estudiantes = new List<(string, int, string)>
{
    ("Juan", 20, "Mexicana"),
    ("Ana", 22, "Española"),
    ("Carlos", 20, "Mexicana"),
    ("María", 18, "Colombiana"),
    ("Pedro", 22, "Argentina"),
    ("Laura", 20, "Mexicana"),
    ("Andrés", 18, "Colombiana"),
    ("Isabel", 22, "Española"),
    ("Martín", 18, "Colombiana"),
    ("Elena", 20, "Mexicana"),
    ("Ricardo", 22, "Argentina"),
    ("Sofía", 18, "Colombiana"),
    ("Luis", 20, "Mexicana"),
    ("Julia", 22, "Española"),
    ("Miguel", 20, "Mexicana"),
};
		
// Sintaxis funcion
IEnumerable estudiantesAgrupados = from e in estudiantes group e by e.Edad;

PrintLista(estudiantesAgrupados);

// Sintaxis método
estudiantesAgrupados = estudiantes.GroupBy(e => e.Edad);
PrintLista(estudiantesAgrupados);

// GroupBy por más de una columna
estudiantesAgrupados = estudiantes
							.GroupBy(e => new {Edad = e.Edad, Nacionalidad  = e.Nacionalidad})
							.Select(g => new {
								Edad = g.Key.Edad, 
								Nacionalidad  = g.Key.Nacionalidad,
								Estudiantes = g.Select(e => e.Nombre).ToList()
							});
PrintLista(estudiantesAgrupados);


										
// Método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}