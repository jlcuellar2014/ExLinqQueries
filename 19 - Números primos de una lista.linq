<Query Kind="Statements" />

// Obtiene todos los números primos de una lista
/*
	Un número primo es un número natural mayor que 1 que no tiene divisores positivos distintos de 1 y él mismo. 
	En otras palabras, un número primo es un número entero que solo puede dividirse de manera exacta por 1 y por sí mismo.

	Por ejemplo:

	2 es un número primo porque solo tiene dos divisores: 1 y 2.
	3 es un número primo porque solo tiene dos divisores: 1 y 3.
	4 no es un número primo porque tiene más de dos divisores (1, 2, y 4).
	5 es un número primo porque solo tiene dos divisores: 1 y 5.
	Y así sucesivamente.
*/

int[] numeros = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 3, 5, 66, 7, 98, 55, 332, 22, 887, 654, 33 };

// Sintaxis consulta
IEnumerable<int> primos = from n in numeros where EsPrimo(n) select n;
PrintLista(primos);

// Sintaxis método
primos = numeros.Where(n => EsPrimo(n));
PrintLista(primos);

// Función para evaluar números primos
static bool EsPrimo(int numero)
{
    if (numero < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
            return false;
    }

    return true;
}

// método auxiliar para imprimir los resultados
void PrintLista(IEnumerable lista)
{
	Console.WriteLine("------------------------");
	foreach(var v in lista){
		Console.WriteLine(v);
	}
}
