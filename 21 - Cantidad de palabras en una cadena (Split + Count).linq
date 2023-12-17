<Query Kind="Statements" />

// Devuelve la cantidad de palabras en una cadena

string cadena = "cantidad de palabras en una  cadena";

string[] condiciones = {" ", "\t", "\r", "\n"};

// Sintaxis método
int cantidad = cadena
		.Split(condiciones, StringSplitOptions.RemoveEmptyEntries)
		.Count();

Console.WriteLine(cantidad);