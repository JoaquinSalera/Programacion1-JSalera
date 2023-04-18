// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Ingresa la clave");
string? clave = Console.ReadLine();
while (clave != "667788")
{
    Console.WriteLine("esa no es la clave correcta ");
    clave = Console.ReadLine();

}
Console.WriteLine("Perfecto, ahora necesito que ingreses numeros: ");
string? numero = Console.ReadLine();
int numeroa = int.Parse(numero);
int cont = 0;
int suma = 0;
while (numeroa < 0)
{
    suma = numeroa + suma;
    cont = cont + 1;
    Console.WriteLine("ingrese otro numero");
    numero = Console.ReadLine();
    numeroa = int.Parse(numero);
    
}
int prom = suma / cont;
Console.WriteLine("El promedio de los numeros que te pedimos es ; " +  prom);

Console.WriteLine("Perfecto, ahora necesito que sigas ingresando numeros: ");
string? numero2 = Console.ReadLine();
int numerob = int.Parse(numero2);
int suma1 = 0;
int cont1= 0;

while (numerob < 100) 
{
    suma1 = numerob + suma1;
    cont1 = cont1 + 1;
    Console.WriteLine("ingrese otro numero");
    numero2 = Console.ReadLine();
    numerob = int.Parse(numero2);
    
}

int prom1 = suma1 / cont1;
Console.WriteLine("el promedio de los numeros solicitados es ;  " + prom1);


