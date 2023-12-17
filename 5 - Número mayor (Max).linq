<Query Kind="Statements" />

// Encuentra el número máximo en una lista de enteros
int[] numeros = new int[]{1,2,3,4,5,6,7,8,9,0,12,3,5,66,7,98,55,332,22,887,654,33};

// Sintaxis función
int maximo = (from n in numeros select n).Max();
Console.WriteLine(maximo);

// Sintaxis método
maximo = numeros.Max();
Console.WriteLine(maximo);

maximo = numeros.Where(n => n < 500).Max();
Console.WriteLine(maximo);