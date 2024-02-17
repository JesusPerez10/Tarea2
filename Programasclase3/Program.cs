using System;

class Program
{
    static void Main(string[] args)
    {

        int numero = int.Parse("0");
        if (numero<0)
        {
         Console.WriteLine("El numero es negativo");
        }
        else if (numero > 0)
        {
        Console.WriteLine("El numero es positivo");
        }
        else
        {
       Console.WriteLine("El numero es cero");
        }

         int edad = int.Parse("18");
        if (edad >= 18)
        {
          Console.WriteLine("entre");
        }
        else
        {
        Console.WriteLine("NO PUEDO ENTRAR");
        }  

         Console.WriteLine("ingrese su año de nacimiento");
         int año = int.Parse(Console.ReadLine());
         if (año >= 1928 && año <= 1945)
        {
        Console.WriteLine("Usted pertenece a la generacion sileciosa");

        }
         else if(año >=1946 && año <=1964)
         {
        Console.WriteLine("Usted pertenece a la generacion de los baby boomer");
        }
        else if (año >= 1965 && año <= 1980)
        {
        Console.WriteLine("Usted pertenece a la generacion X");
        }
        else if (año >= 1981 && año <= 1996)
        {
         Console.WriteLine("Usted pertenece a la generacion de los millenial");
        }
         else if (año >= 1997 && año <= 2012)
        {
        Console.WriteLine("Usted pertenece a la generacion Z");
        }
        else if (año >= 2013)
        {
        Console.WriteLine("Usted pertenece a la generacion Alfa");
        }
        else
        {
        Console.WriteLine("Año invalido");
        }

        Console.WriteLine("Ingrese su año de nacimiento");
        int año = int.Parse(Console.ReadLine());
        switch (año)
        {
        case >= 1928 and <= 1945:
         Console.WriteLine("Usted pertenece a la generacion sileciosa");
        break;

         case >= 1946 and <= 1964:
         Console.WriteLine("Usted pertenece a la generacion de los baby boomer");
         break;

         case >= 1965 and <= 1980:
        Console.WriteLine("Usted pertenece a la generacion X");
        break;
         case >= 1981 and <= 1996:
        Console.WriteLine("Usted pertenece a la generacion de los millenial");
        break;

         case >= 1997 and <= 2012:
         Console.WriteLine("Usted pertenece a la generacion Z");
        break;

         case >= 2013:
         Console.WriteLine("Usted pertenece a la generacion Alfa");
        break;

        default: 
        Console.WriteLine("el ao es año invalido");
        break;
         } 


        string nombre, pais;
        int edad;
        char genero;

        Console.WriteLine("Ingrese nombre");
        nombre = Console.ReadLine().ToUpper();

        Console.WriteLine("Ingrese pais");
        pais = Console.ReadLine();

        Console.WriteLine("Ingrese edad");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese genero: (m o f)");
        genero = char.Parse(Console.ReadLine().ToUpper());

        if (!nombre.StartsWith("A") && (edad >= 18 || genero == 'F')
        && (pais == "GUATEMALA "||  pais == "MEXICO"))
        {
            Console.WriteLine("Ud. cumple con los requisitos");
        }
        else
        {
            Console.WriteLine("No admitido");
        }
    }
}



