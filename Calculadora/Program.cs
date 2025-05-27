// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora calc = new Calculadora();

calc.Sumar(10);
Console.WriteLine("El valor actual de la calculadora es: " + calc.Resultado);

calc.Restar(5);
Console.WriteLine("El valor actual de la calculadora es: " + calc.Resultado);

calc.Multiplicar(6);
Console.WriteLine("El valor actual de la calculadora es: " + calc.Resultado);

double num = 3;
if(num != 0)
{
    calc.Dividir(num);
    Console.WriteLine("El valor actual de la calculadora es: " + calc.Resultado);
}

calc.Limpiar();
Console.WriteLine("El valor actual de la calculadora es: " + calc.Resultado);
