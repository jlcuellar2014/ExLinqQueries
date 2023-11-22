<Query Kind="Statements" />

// Encuentra los elementos que tienen el mismo número de vocales y consonantes
string[] nombres = { "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };
string vocales = "aeiou";

// Sintaxis consulta

var r = from nombre in nombres 
			where nombre.Count(caracter => vocales.Contains(caracter, StringComparison.OrdinalIgnoreCase)) == 
			nombre.Length / 2
		select nombre;
		
Console.WriteLine(r);

// Sintaxis método
r = nombres.Where(nombre => nombre.Count(caracter => vocales.Contains(caracter, StringComparison.OrdinalIgnoreCase)) 
							== nombre.Length / 2);

Console.WriteLine(r);