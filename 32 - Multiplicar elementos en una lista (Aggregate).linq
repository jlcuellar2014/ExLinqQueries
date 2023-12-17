<Query Kind="Statements" />

// Calcula el producto de todos los elementos en una lista de números.

int[] numeros = { 10, 5, 5, 8, 8, 15, 7, 12, 18, 6 };

// Sintaxis método
long resultado = numeros.Aggregate((long)1, (acumulador, valor) => acumulador * valor);

Console.WriteLine(resultado);

// Sumar todos los elementos de la lista
resultado = numeros.Aggregate(0, (acumulador, valor) => acumulador += valor);
Console.WriteLine(resultado);

// Sumar todos los elemento a un acumulado anterior
int saldoAnterio = 100;
resultado = numeros.Aggregate(saldoAnterio, (acumulador, valor) => acumulador += valor);
Console.WriteLine(resultado);