using System;

namespace myFourthCSharpProgram
{
    class Program
    {
        //Formula : c/5 = (f-32)/9 [ where c = temperature in Celsius and f = temperature in Fahrenheit ]
        //Expected Output :
        //60°C is 140 °F
        //45°F is 7.222222222222222°C
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int widgetsSold = 7;
            //Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
            Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");


            firstName = "Bob";
            widgetsSold = 7;
            //Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
            Console.WriteLine($"Versión 1:{firstName} sold  ({widgetsSold} + 7)  widgets.");
            Console.WriteLine($"Versión 2:{firstName} sold  {(widgetsSold + 7)}  widgets.");
            Console.WriteLine($"Versión 3:{firstName} sold  {widgetsSold + 7}  widgets.");
            //Bob sold 14 widgets.

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            decimal celsius;
            //Formula : c/5 = (f-32)/9 [ where c = temperature in Celsius and f = temperature in Fahrenheit ]
            decimal fahrenheit = 94;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            celsius = fahrenheit - 32 * 5 / 9;

            Console.WriteLine($"{celsius}");

            int first = 7;
            int second = 5;
            decimal quotient2 = (decimal)first / (decimal)second;
            Console.WriteLine($"Con el CAST:{quotient2}");
            quotient2 = first / second;
            Console.WriteLine($"Sin el CAST:{quotient2}");
            quotient2 = first / (decimal)second;
            Console.WriteLine($"Con al menos una con el CAST:{quotient2}");

            Console.WriteLine($"Resto de dividir de 200 entre 5: {(200 % 5)}");
            Console.WriteLine($"Resto de dividir de 7   entre 5: {(7 % 5)}");

            /*
            El orden de operaion:
            Parentheses (paréntesis) (lo que se encuentra dentro del paréntesis se realiza primero)
            Exponents (exponentes)
            Multiplication (multiplicación) y Division (división) (de izquierda a derecha)
            Addition (suma) y Subtraction (resta) (de izquierda a derecha)
            */

            //SOlucion con CAST
            decimal exponente = 3;
            decimal Base = 2;
            Console.WriteLine("Con CAST {0}", System.Math.Pow((double)Base, (double)exponente));
            Console.WriteLine($"Con CAST {System.Math.Pow((double)Base, (double)exponente)}");
            //Con CAST:9
            //Cambiando el TIPO
            double exponente1 = 3;
            double Base1 = 2;
            Console.WriteLine($"Con double:{System.Math.Pow(Base1, exponente1)}");
            //Con double:9
            Console.WriteLine($"El valor de PI es:{System.Math.PI}");

            // Uso de +=
            int value = 0;
            value = value + 5;
            value += 5;

            // USOS DEL ++ antes y despues
            int edad = 0;
            edad = edad + 1;
            edad++;
            Console.WriteLine($"Valor de edad antes del ++: {edad++}");

            edad = 17;
            int mayoriaDeEdad = 0;
            //mayoriaDeEdad = edad++;
            //Estas lineas 90 y 91 serían equivalentes a la linea 88
            mayoriaDeEdad = edad;
            edad = edad + 1;
            Console.WriteLine($"Valor de mayoria de edad:{mayoriaDeEdad}");
            Console.WriteLine($"Valor de edad:{edad}");
            //Valor de edad despues del ++: 1 Muestra y despues suma ??? SI
            //edad = edad + 1;
            Console.WriteLine($"Valor de edad despues del ++: {++edad}");
            //Valor de edad despues del ++: 3 Suma y despues muestra ??? SI

            int anyo = 0;
            anyo = anyo + 1;
            Console.WriteLine($"Valor de año:{anyo}");
            int mes = 0;
            Console.WriteLine($"Valor de mes:{++mes}");

            // -= 
            int altura = 180; // en centimetros
            altura = altura -5;
            altura -= 5;

            // *=
            decimal ancho = 5; // en milimetros
            ancho = ancho * 5;
            ancho *= 5;

            // --
            int fondo = 20; // en centimetros
            fondo = fondo - 1;
            Console.WriteLine($"El valor de {fondo--}");
            //El valor de: 19
            Console.WriteLine($"El valor de {--fondo}"); ///???????
            //El valor de: 18 


        }
    }
}
