<Query Kind="Statements" />

// Convierte una lista de cadenas a un solo string separado por comas

string[] nombres = { "Juan", "María", "Carlos", "Ana", "Pedro", "Laura", "Andrés", "Isabel", "Martín", "Elena", "Ricardo", "Sofía", "Luis", "Julia", "Miguel", "Valeria", "Fernando", "Camila", "Diego", "Daniela" };

// Sintaxis método
string cadena = string.Join(", ", nombres);

Console.WriteLine(cadena);

int[] numeros = new int[]{ 11, 42, 63, 48, 4, 8, 9, 55, 6, 7, 8, 9, 0, 12, 3, 5, 66 };

cadena = string.Join(", ", (from n in numeros select n.ToString()));
Console.WriteLine(cadena);