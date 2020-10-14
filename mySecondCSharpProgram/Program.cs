//using System;

namespace mySecondCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Bob";
            var unValor = 23;
            var otroValor = "MensajeNuevo";
            var usoInvalidoDeVar = 45.4m;
            int tres = 3;
            decimal temperatura = 34.4m;
            System.Console.Write("Hello,\n");

            System.Console.Write(nombre);
            System.Console.Write("! You have ");
            System.Console.Write(tres);
            System.Console.Write("\t in your inbox. The temperatura is ");
            System.Console.Write(temperatura);
            System.Console.Write(" \"celsius\".");
            System.Console.Write(unValor);
            System.Console.Write(otroValor);
            System.Console.Write(usoInvalidoDeVar);
            System.Console.WriteLine("c:\\source\\repos");
            System.Console.WriteLine(@"c:\source\repos");
            System.Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
        }
    }
}
