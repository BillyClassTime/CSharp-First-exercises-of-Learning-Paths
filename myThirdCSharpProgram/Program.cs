using System;

namespace myThirdCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Billy";
            String lastName = "Vanegas";
            string projectName = "First-Project";
            var resultadosAConcatenar = $"Estos es el nombre:{firstName} y el apellido {lastName}";


            Console.WriteLine(firstName, lastName);                                            // No concatena
            Console.WriteLine("Nombre:", firstName, " Apellido", lastName);                      // No concatena
            Console.WriteLine("Estos es el nombre {0} y el apellido {1}", firstName, lastName); //Si concatena
            Console.WriteLine(firstName + lastName);                   //Funciona pero es una TERRIBLE practica
            Console.WriteLine("Estos es el nombre:{0}", firstName, " y el apellido {0}", lastName); //JJ
            Console.WriteLine("Estos es el nombre:{0}{1} {2}", firstName, " y el apellido ", lastName); //Justo
            Console.WriteLine($"Estos es el nombre:{firstName} y el apellido {lastName}");
            Console.WriteLine(resultadosAConcatenar);
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            Console.WriteLine($@"View English output:
                    c:\Exercise\{projectName}\data.txt

                    {russianMessage}:
                    c:\Exercise\{projectName}\ru-RU\data.txt");
        }
    }
}
