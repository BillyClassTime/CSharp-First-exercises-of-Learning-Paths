using System;
using System.Collections.Generic;
#pragma warning disable 219
//Program.cs(314,17): warning CS0219: The variable 'discountPercentage' is assigned but its value is never used [D:\BMV\20483C\Mod 1-4\Ejercicios-1\Ejercicios-1.csproj]

namespace Dias.General
{
    public class Igual
    {

    }

    class Program
    {
        private KeyValuePair<string, Action>[] examples;

        private string msg = null;

        Program()
        {
            examples = new KeyValuePair<string, Action>[] {
            new KeyValuePair<string, Action>("Dia Uno: Introduccion - Cadenas y metodos", new Dias.Uno.Ejercicios().introClasesNet),
            new KeyValuePair<string, Action>("Dia Uno: Uso IF else anidados ", new Dias.Uno.Ejercicios().juegoConIfsSinOperadoresLogicos),
            new KeyValuePair<string, Action>("Dia Uno: Uso IF else anidados operadores lógicos ", new Dias.Uno.Ejercicios().juegoConIfConOperadoresLogicos),
            new KeyValuePair<string, Action>("Dia Uno: Ambito de variables ", new Dias.Uno.Ejercicios().ejerciciosConAmbitoDeVariables),
            new KeyValuePair<string, Action>("Dia Uno: Ambito de variables segun JJ ", new Dias.Uno.Ejercicios().ejercicioAmbitoVariabalesVersionJJ),
            new KeyValuePair<string, Action>("Dia Dos: Uso de ElseIf ", new Dias.Dos.Ejercicios().controlExpiracionSubscripciones),
            new KeyValuePair<string, Action>("Dia Dos: Matricies ", new Dias.Dos.Ejercicios().iniciandoConMatricesArrays),
            new KeyValuePair<string, Action>("Dia Dos: Uso de los comentarios ", new Dias.Dos.Ejercicios().usoDeLosComentarios),
            new KeyValuePair<string, Action>("Dia Dos: Preliminar de igualdades ", new Dias.Dos.Ejercicios().preliminaresDeIgualdades),
            new KeyValuePair<string, Action>("Dia Dos: Comparaciones de cadenas ", new Dias.Dos.Ejercicios().masSobreComparacionesDeCadenas),
            new KeyValuePair<string, Action>("Dia Dos: Uso del operador ternario (Version Justo) ", new Dias.Dos.Ejercicios().permisosAccesoVersionJusto),
            new KeyValuePair<string, Action>("Dia Dos: Uso del operador ternario (Version Carola) ", new Dias.Dos.Ejercicios().permisosAccesoVersionCarola),
            new KeyValuePair<string, Action>("Dia Tres: PintarH ", new Dias.Tres.Ejercicios().pintarH),
            new KeyValuePair<string, Action>("Dia Tres: Pintar Q y M ", new Dias.Tres.Ejercicios().pintarQYoM),
            new KeyValuePair<string, Action>("Dia Tres: Pintar Ñ e Y ", new Dias.Tres.Ejercicios().PintarLetrasEnyeseYs),
            new KeyValuePair<string, Action>("Dia Cuatro: Switch Case (Expression) ", new Dias.Cuatro.Ejercicios().swithCaseExpression),
            new KeyValuePair<string, Action>("Dia Cuatro: Switch Case (Expression CSharp 8) ", new Dias.Cuatro.Ejercicios().swithCaseExpressionNewCSharp8),
            new KeyValuePair<string, Action>("Dia Cuatro: Mínimo y maximos de Tipos entero con y sin signo ", new Dias.Cuatro.Ejercicios().MinimoMaximodeTiposConOSinSigno),
            new KeyValuePair<string, Action>("Dia Cuatro: Mínimo y maximos de Tipos punto flotante con y sin signo ) ", new Dias.Cuatro.Ejercicios().MinimoMaximoTiposPuntoFlotante),
            new KeyValuePair<string, Action>("Dia Cuatro: Menú y uso del Loop, Switch y metodos ", new Dias.Cuatro.Ejercicios().MenuDeEntradaLlamandoMetodos),
            new KeyValuePair<string, Action>("Dia Cinco: Convertir cadenas a números ", new Dias.Cinco.Ejercicios().ConvertirCadenasToStringYNumero),
            new KeyValuePair<string, Action>("Dia Cinco: Convertir enteros a decimal ", new Dias.Cinco.Ejercicios().ConvertirIntToDecimal),
            new KeyValuePair<string, Action>("Dia Cinco: Convertir string a enteros TryParse ", new Dias.Cinco.Ejercicios().ConvertirStringToIntControlError),
            new KeyValuePair<string, Action>("Dia Cinco: Desafio conversion Tipos ", new Dias.Cinco.Ejercicios().DesafioConversionTipo),
            new KeyValuePair<string, Action>("Dia Cinco: Desafio conversion Tipos II ", new Dias.Cinco.Ejercicios().DesafioConversionTipoII),
            new KeyValuePair<string, Action>("Dia Cinco: Crear una matriz y ordenarla ", new Dias.Cinco.Ejercicios().CrearMatricesYOrdenarlas),
            new KeyValuePair<string, Action>("Dia Cinco: Crear una matriz y ordenarla de revés ", new Dias.Cinco.Ejercicios().CrearMatricesYOrdenarlasDereves),
            new KeyValuePair<string, Action>("Dia Cinco: Quitar elementos de una matriz ", new Dias.Cinco.Ejercicios().QuitarElementosDeUnaMatriz),
            new KeyValuePair<string, Action>("Dia Cinco: Añadir elementos a una matriz ", new Dias.Cinco.Ejercicios().AnyadirElementosAUnaMatriz),
            new KeyValuePair<string, Action>("Dia Cinco: Ordenacion Matrices cambio de tamaño y otro ", new Dias.Cinco.Ejercicios().MasOrdenacionesCambiarTamanyoYConversionesDeMatrices),
            new KeyValuePair<string, Action>("Dia Cinco: Dividir y unir matrices ", new Dias.Cinco.Ejercicios().DividirYUnirMatrices),
            new KeyValuePair<string, Action>("Dia Cinco: Desafio Inversion de palabras ", new Dias.Cinco.Ejercicios().DesafioInversionPalabras),
            new KeyValuePair<string, Action>("Dia Cinco: Desafio busqueda patrón matriz ", new Dias.Cinco.Ejercicios().DesafioBusquedaPatronMatriz),
            new KeyValuePair<string, Action>("Dia Cinco: Uso de IndexOF y LastIndexOf ", new Dias.Cinco.Ejercicios().UsodeIndexOfIndexAnyLastIndexOF),
            new KeyValuePair<string, Action>("Dia Cinco: Uso de Remove y Replace ", new Dias.Cinco.Ejercicios().UsoDeRemoveYReplace),
            new KeyValuePair<string, Action>("Dia Cinco: Desafio extraer datos y reemplazarlos ", new Dias.Cinco.Ejercicios().DesafioExtraerDatosReemplazarlosYQuitarlosDeUnaCadenaDeEntrada),
            new KeyValuePair<string, Action>("Dia Cinco: Aplicacion formato de cadenas ", new Dias.Cinco.Ejercicios().AplicacionFormatoCadena),
            new KeyValuePair<string, Action>("Dia Cinco: Relleno y alineación de cadenas ", new Dias.Cinco.Ejercicios().RellenoYAliniacion),
            new KeyValuePair<string, Action>("Dia Cinco: Desafio Formato de datos alfanuméricos ", new Dias.Cinco.Ejercicios().DesafioFormatoDatosAlfanumericos),
            };
        }

        static void Main(string[] args)
        {
            int colorBCK = (int)Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            do
            {
                Program op = new Program();
                var choice = op.GetSelection(op.msg);
                bool success = Int32.TryParse(choice, out var nChoice);
                op.msg = String.Empty;

                if (!success)
                {
                    op.msg = $"'{choice}' no es un número entre 0 y {op.examples.Length}.";
                }
                else
                {
                    if (nChoice == 0)
                    {
                        Console.ForegroundColor = (ConsoleColor)colorBCK;
                        return;
                    }
                    else if (nChoice < 0 || nChoice > op.examples.Length)
                    {
                        op.msg = $"Debe elegir un número entre 0 y {op.examples.Length}.";
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(op.examples[--nChoice].Key.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        op.examples[--nChoice].Value();
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("\nPresione cualquier tecla par continuar...");
                        Console.ReadKey(false);
                    }
                }
            } while (true);
        }
        private string GetSelection(string msg)
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < examples.Length; i++)
            {
                Console.WriteLine($"{i + 1,2}-{examples[i].Key}");
            }

            if (!String.IsNullOrEmpty(msg))
                Console.WriteLine($"\n** {msg} **\n");

            Console.Write("\nEscoja un Número de ejemplo, y presione <Enter>. O, elija 0 para salir. ");
            var choice = Console.ReadLine();

            return choice;
        }

    }
}
namespace Dias.Uno
{
    class Ejercicios
    {
        //static void introClasesNet()
        public void introClasesNet()
        {
            //string
            System.String nombre = "Miguel";
            System.String apellido = "Rodriguez";
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            //??? int????
            sbyte mes = 1;
            Console.WriteLine($"Este es el mes:{mes}");

            //System.Int32 fondo = 0;
            //int altura = 0;

            Random dice = new Random();
            //roll = dice.Next();        //
            //roll = dice.Next(2);       //
            //roll = dice.Next(2, 100);  //
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            // Genera un error pues no se puede llamar a un metodo que no sea static.
            //roll = Random.Next(); // An object reference is required for the non-static field, method, or 
            // property 'Random.Next()' [Ejercicios-1]",

            //Program.conversorTemperatura(1,32m);
            //Program.conversorTemperatura(32m,1);
            Dias.Uno.Ejercicios cualquierNombre = new Dias.Uno.Ejercicios();
            cualquierNombre.conversorTemperatura(1, 32m);
            cualquierNombre.conversorTemperatura(32m, 1);
            cualquierNombre.conversorTemperatura();

        }
        // C = F -32 * (5/9)
        decimal conversorTemperatura(byte tipoTemperatura, decimal farentheit)
        {
            decimal celsius = (farentheit - 32) * (5m / 9);

            return celsius;
        }
        string conversorTemperatura(decimal celsius, byte tipoTemperatura)
        {
            //decimal celsius = 0;
            string otroCelsius = "";
            return otroCelsius;
        }
        void conversorTemperatura()
        {

        }

        /*int conversorTemperatura() {
            return 1;
        }*/

        public void juegoConIfsSinOperadoresLogicos()
        {

            byte lanzamientoUno;
            byte lanzamientoDos;
            byte lanzamientoTres;

            Random lanzamientoDato = new Random();

            lanzamientoUno = (byte)lanzamientoDato.Next(1, 7);
            lanzamientoDos = (byte)lanzamientoDato.Next(1, 7);
            lanzamientoTres = (byte)lanzamientoDato.Next(1, 7);
            Console.WriteLine($"Lanzamiento datos 1:{lanzamientoUno}, datos 2:{lanzamientoDos} y dado 3:{lanzamientoTres}");

            byte puntosExtras = 0;

            byte sumaDeLosTresDados = (byte)(lanzamientoUno + lanzamientoDos + lanzamientoTres);

            if (lanzamientoUno == lanzamientoDos)
            {
                if (lanzamientoTres == lanzamientoUno)
                {
                    puntosExtras = 6;
                }
                else
                {
                    puntosExtras = 2;
                }
            }
            else if (lanzamientoUno == lanzamientoTres)
            {
                puntosExtras = 2;
            }
            else if (lanzamientoDos == lanzamientoTres)
            {
                puntosExtras = 2;
            }
            else // OJO
            {
                puntosExtras = 0;
            }

            if ((puntosExtras + sumaDeLosTresDados) >= 15)
                Console.WriteLine("Usted ha ganado!!!!");
            else
                Console.WriteLine("Lo siento, no ha ganado :(");
        }
        public void juegoConIfConOperadoresLogicos()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose. :(");
            }
        }

        public void ejerciciosConAmbitoDeVariables()
        {
            byte edad = default;
            bool senior = false;
            bool flag = default;
            int antiguedad = default;

            Console.WriteLine(flag ? "true" : "false");
            if (edad > 43)
            {
                //bool senior = true;
                if (antiguedad > 10)
                    Console.WriteLine("Bono por antiguedad");
                else
                    Console.WriteLine("Sin Bono por antiguedad");
                //   return;
                //}
                Console.WriteLine(senior ? "Nivel Senior" : "nivel Junior");
            }
            Console.WriteLine(senior ? "Nivel Senior" : "nivel Junior");
            Console.WriteLine(edad);
            double[] numeros = new double[10];
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
            }
            //Console.WriteLine(numeros.Sum());
        }

        public void ejercicioAmbitoVariabalesVersionJJ()
        {
            int i = 0;
            ConsoleKeyInfo opcion = default;
            double[] numeros = new double[10];
            double result = default;
            do
            {
                Console.WriteLine("Enter the number: ");
                numeros[i++] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Desea salir(Y/N): ");
                opcion = Console.ReadKey();
            } while ((i < 10) && (opcion.Key == ConsoleKey.N));
            Console.Write($"The average of:");
            for (int a = 0; a < i; a++)
            {
                result += numeros[a];
                Console.Write($"{numeros[a]}​​​​, ");
            }
            result = result / i;
            Console.WriteLine($" :{result}​​​​");
        }

        public void ejercicioAmbitoVariablesVersionJR()
        {

        }
    }
}
namespace Dias.Dos
{
    class Ejercicios
    {
        #region Segundo Dia de Codigo         
        public void controlExpiracionSubscripciones()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;
            Console.WriteLine($"Los dias de la expiración:{daysUntilExpiration}");
            // Regla 4: daysUntilExpiration=0
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            // Regla 3: daysUntilExpiration=1
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine($"Your subscription expires within a day!");
            }
            // Regla 2: daysUntilExpiration<=5
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            }
            // Regla 1: daysUntilExpiration<=10
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }
            if (discountPercentage > 0)
                Console.WriteLine($"Renew now and save {discountPercentage} %!");
            // Regla 5: daysUntilExpiration>10
        }

        public void controlExpiracionSubscripciones(bool flag)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 4;
            daysUntilExpiration = 1;
            // Your code goes here
            if (daysUntilExpiration == 0)
                Console.WriteLine("Your subscription has expired.");
            else if (daysUntilExpiration == 1)
                Console.WriteLine($"Your subscription expires within a day! \n Renew now and save {discountPercentage = 20}%!");
            else if (daysUntilExpiration <= 5)
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration}​​​​​ days. \n Renew now and save {discountPercentage = 10}​​​​​%!");
            else if (daysUntilExpiration <= 10)
                Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        public void iniciandoConMatricesArrays()
        {
            //string ninyo_variable = "Luis";
            string[] ninyos = new string[3];

            ninyos[0] = "Juan Jo";
            ninyos[1] = "Luis Mi";
            ninyos[2] = "Javier";

            int[] numeros = new int[4];
            numeros[0] = 5;
            numeros[1] = 7;
            numeros[2] = 8;
            numeros[3] = 3;

            //numeros[20]=34;

            decimal[] valores = new decimal[10];
            for (var j = 0; j < 10; j++)
            {
                valores[j] = j;
            }

            foreach (var ninyo in ninyos)
            {
                Console.WriteLine($"El niño:{ninyo}");
            }
            foreach (var valor in valores)
            {
                Console.WriteLine($"El valor:{valor}");
            }

            Console.WriteLine($"El valor del Array Valores en 5:{valores[4]}");

            // Segundos Arrays

            string[] fraudulentPassOrderIDs = new string[3];

            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            fraudulentPassOrderIDs[0] = "C789";
            fraudulentPassOrderIDs[1] = "B456";
            fraudulentPassOrderIDs[2] = "A123";
            foreach (var fraudulentPassOrderID in fraudulentPassOrderIDs)
            {
                Console.WriteLine($"Valores:{fraudulentPassOrderID}");
            }
            foreach (var fraudulentOrderID in fraudulentOrderIDs)
            {
                Console.WriteLine($"Los items:{fraudulentOrderID}");
            }
            // Tengo las posiciones del Array 
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            // Mas ejercicios con arrays
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                Console.WriteLine($"Bin {++bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"Suma final total:{sum}");

        }

        public void usoDeLosComentarios()
        {
            // Loop through each blank orderID
            // Get a random value that equates to ASCII letters A through E
            // Convert the random value into a char, then a string
            // Create a random number, padd with zeroes
            // Combine the prefix and suffix together, then assign to current OrderID

            Random random = new Random();
            string[] orderIDs = new string[5];
            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");
                // TODO: Aqui qudamos ...
                orderIDs[i] = prefix + suffix;
            }
            // Print out each orderID
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
        }

        public void preliminaresDeIgualdades()
        {
            string nombre = "Miguel";
            int edad = 45;
            int jubilacion = 65;
            //sbyte flag = 0;  // Ningun tipo de datos entero se puede convertir a bool ejem if(flag) NO COMPILA

            if (nombre.StartsWith("M"))
            {

            }

            Console.WriteLine(edad > 45);
            if (edad > 45)
            {

            }

            if (!((edad + 25) == jubilacion))
            {
                Console.WriteLine("Si");
            }
            else
                Console.WriteLine("No");


            Console.WriteLine(!((edad + 25) == jubilacion));

        }

        public void masSobreComparacionesDeCadenas()
        {
            string value1 = " a";
            string value2 = "A ";

            Console.WriteLine(value1);
            Console.WriteLine(value1.Trim());

            Console.WriteLine($"\"{value2}\"");
            Console.WriteLine($"\"{value2.Trim()}\"");

            if (value1 == value2)
            {

                Console.WriteLine("SI");
            }
            else
                Console.WriteLine("NO");

            if (value1.Trim().ToLower() == value2.Trim().ToLower())
            {
                Console.WriteLine("2-SI");
            }
            else
                Console.WriteLine("2-NO");
        }

        public void permisosAccesoVersionJusto()
        {
            string permission = "Adm--in|Man--ager";
            int level = 43;
            bool isAdmin = permission.Contains("Admin");
            bool isManager = permission.Contains("Manager");
            Console.WriteLine(
             isAdmin && level <= 55 ? "Welcome, Admin user."
             : isAdmin ? "Welcome, Super Admin user."
             : isManager && level < 20 ? "You do not have sufficient privileges."
             : isManager ? "Contact an Admin for access."
             : "You do not have sufficient privileges."
            );
        }

        public void permisosAccesoVersionCarola()
        {
            string permission = "Admin";
            //string permission = "Mana";
            int level = 56;
            Console.WriteLine(permission.Contains("Admin"));
            Console.WriteLine(permission.Contains("Manager"));
            bool admin = permission.Contains("Admin");
            bool manager = permission.Contains("Manager");
            Console.WriteLine(
            (level > 55 && admin) ? "Welcome, Super Admin user."
            : (level <= 55 && admin) ? "Welcome, Admin user."
            : (level > 20 && manager) ? "Contact an Admin for access."
            : (level < 20 && manager) ? "You do not have sufficient privileges."
            : "You do not have sufficient privileges.");
        }

        void example()
        {
            //List<int> numeros = new List<int>();

            int[] numbers = { 2, 3, 4, 5 };
            //var maximumSquare = numbers.Max(x => x * x);
            //Console.WriteLine(maximumSquare);
            // Console.WriteLine(numbers.Max());

        }
        #endregion
    }
}
namespace Dias.Tres
{
    class Ejercicios
    {

        // Pinta la letra H y la devuelve en un array
        // Asignado a Laura
        public void pintarH()
        {

            int length = 7;
            string asterisco = "*";
            string espacio = " ";
            Console.WriteLine("LETRA H:");
            for (int row = 0; row < length; row++)
            {
                for (int column = 0; column < length; column++)
                {
                    Console.Write(
                        row == 3 ||
                        column == 0 ||
                        column == 6
                        ? asterisco : espacio);
                }
                Console.WriteLine(" ");
            }
        }
        // pintar la letra Q y M y devuelve los arrays
        // Asignado a Justo
        #region Ejercicio Q y M

        public void pintarQYoM()
        {
            char[,] letra = genera('Q');
            imprime(letra);
            Console.WriteLine("\n");
            letra = genera('M');
            imprime(letra);
        }
        public static char[,] genera(char letra)
        {
            char[,] matr = new char[7, 7];
            switch (letra)
            {
                case 'Q':
                    matr = new char[7, 7] {  {' ','*','*','*','*','*',' '},
                                            {'*',' ',' ',' ',' ',' ','*'},
                                            {'*',' ',' ',' ',' ',' ','*'},
                                            {'*',' ',' ',' ',' ',' ','*'},
                                            {'*',' ',' ',' ',' ',' ','*'},
                                            {'*',' ',' ',' ',' ','*',' '},
                                            {' ','*','*','*','*',' ','*'}
                    };
                    break;
                case 'M':
                    matr = new char[7, 7] {  {'*',' ',' ',' ',' ',' ','*'},
                                            {'*','*',' ',' ',' ','*','*'},
                                            {'*',' ','*',' ','*',' ','*'},
                                            {'*',' ',' ','*',' ',' ','*'},
                                            {'*',' ',' ',' ',' ',' ','*'},
                                            {'*',' ',' ',' ',' ',' ','*'},
                                            {'*',' ',' ',' ',' ',' ','*'}
                    };
                    break;
                    // default:

            }
            return matr;
        }

        public void PintarLetrasEnyeseYs()
        {
            MatrizLetra letraÑ = new MatrizLetra('Ñ');
            MatrizLetra letraY = new MatrizLetra('Y');
            letraÑ.pintar();
            letraY.pintar();
            //Console.ReadKey();
        }

        static public void imprime(char[,] matr)
        {
            for (int fila = 0; fila < 7; fila++)
            {
                for (int colu = 0; colu < 7; colu++)
                {
                    Console.Write(matr[fila, colu]);
                }
                Console.WriteLine("");
            }
        }

        #endregion

    }
    public class MatrizLetra
    {
        private char letra { get; set; }
        private char[,] matriz { get; set; }

        public MatrizLetra(char letra)
        {
            this.letra = letra;
            matriz = new char[7, 7];
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    matriz[i, j] = ' ';


            switch (letra)
            {
                case 'Ñ':
                    crearenne(); break;
                case 'Y':
                    creary(); break;
            }
        }

        public void crearenne()
        {

            for (int i = 0; i < 7; i++)
            {
                matriz[0, i] = '*';
            }
            for (int i = 2; i < 7; i++)
            {
                matriz[i, 0] = '*';
                matriz[i, 6] = '*';
            }
            matriz[2, 1] = '*';
            matriz[3, 2] = '*';
            matriz[4, 3] = '*';
            matriz[5, 4] = '*';
            matriz[6, 5] = '*';
        }


        public void creary()
        {

            matriz[0, 0] = '*';
            matriz[1, 1] = '*';
            matriz[2, 2] = '*';
            matriz[3, 3] = '*';
            matriz[2, 4] = '*';
            matriz[1, 5] = '*';
            matriz[0, 6] = '*';
            for (int i = 3; i < 7; i++)
                matriz[i, 3] = '*';


        }

        public void pintar()
        {

            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                    Console.Write(matriz[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine($"esto es una letra {this.letra}");
        }


    }
}
namespace Dias.Cuatro
{
    public class Ejercicios
    {
        public void MenuDeEntradaLlamandoMetodos()
        {

            int nivel = 100;
            do
            {
                nivel = lecturaNumeroEnteroTeclado("Entre el número de nivel del empleado: 0 para salir", true);
                new Dias.Cuatro.Ejercicios().switchcase(nivel);

            } while (nivel != 0);

        }

        public int NingunaOpcion()
        {
            Console.WriteLine("No ha puesto ninguna opcion...Pres. cualquier tecla para continuar");
            Console.ReadKey();
            return default;
        }

        public int switchcase(int employeeLevel)
        {
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
            return default;
        }

        public void swithCaseExpression()
        {
            char opcion = default;
            do
            {
                Console.Write("Entre una opción, N para salir:");
                ConsoleKeyInfo lectura = Console.ReadKey();
                opcion = Convert.ToChar(lectura.KeyChar);
                var resultado = opcion switch
                {
                    '1' => "Case 1",
                    '2' => "Case 2",
                    '3' => "Case 3",
                    _ => "Ninguna opción"
                };
                Console.WriteLine(resultado);

            } while (opcion != 'N');
            int a = 128;
            //opcion = 'b';
            try
            {
                string otroValor = "billy";
                a = Convert.ToInt32(otroValor);
                Console.WriteLine($"Valor de a:{a}");

            }
            catch (System.Exception)
            {

                Console.WriteLine("Excepcion controlada usando Convert.ToInt32()");
            }


        }

        public void swithCaseExpressionNewCSharp8()
        {
            var (a, b, option) = (10, 5, "+");

            Console.WriteLine($"El valor de a:{a}");
            Console.WriteLine($"El valor de b:{b}");
            Console.WriteLine($"El valor de option:{option}");

            // Switch expressoin
            var valores = option switch
            {
                "+" => a + b,
                "-" => a - b,
                _ => a * b
            };
            Console.WriteLine($"El resultado en valores después del switch:{valores}");

        }
        public void switchCaseExpressionWhen()
        {

        }
        public char lecturaUnValorTeclado(string mensaje)
        {
            char lectura = default;
            Console.Write(mensaje);
            ConsoleKeyInfo lecturaTeclado = Console.ReadKey();
            lectura = Convert.ToChar(lecturaTeclado.KeyChar);
            return lectura;
        }
        public string lecturaTeclado(string mensaje)
        {
            string lectura = default;
            Console.Write(mensaje);
            lectura = Console.ReadLine();
            return lectura;
        }

        public int lecturaNumeroEnteroTeclado(string mensaje, out bool validacion, bool alerta)
        {
            string lectura = default;
            int numero = default;
            bool resultado = default;

            Console.WriteLine(mensaje);
            lectura = Console.ReadLine();
            resultado = Int32.TryParse(lectura, out numero);
            if (!resultado && alerta)
            {
                Console.WriteLine("Valor no númerico");
            }
            validacion = resultado;
            return numero;
        }
        public int lecturaNumeroEnteroTeclado(string mensaje, bool bucle)
        {
            int numero = default;
            bool validacion = default;
            do
            {
                numero = lecturaNumeroEnteroTeclado(mensaje, out validacion, false);
            } while (!validacion && bucle);
            return numero;
        }
        public void MinimoMaximodeTiposConOSinSigno()
        {
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
        }

        public void MinimoMaximoTiposPuntoFlotante()
        {
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }

        public void TiposDeReferenciaYValor()
        {
            // Elección del tipo de datos correcto en el código de C#
            System.String fullString = new System.String("Hello World!");
            Console.WriteLine(fullString);
            int[] numeros = { 3, 3, 3 };
            int otroValor = 98;

            Console.WriteLine("Valores del array antes de la llamada por referencia");
            Array.ForEach(numeros, numero => Console.Write(numero));

            PasodeVariable(numeros, out otroValor);
            Console.WriteLine();
            Console.WriteLine("Valores del array despues de la llamada por referencia");
            Array.ForEach(numeros, numero =>
            {
                Console.WriteLine(numero);
                Console.WriteLine(otroValor);
            }
            );

            Console.WriteLine("Valores del array despues de la llamada por referencia uso con delegados");
            Array.ForEach(numeros, (delegate (int numero) { Console.WriteLine(numero); }));
        }
        void PasodeVariable(int[] dataParameter, out int otroParametro)
        {
            dataParameter[1] = 0;
            otroParametro = 0;
        }
    }

}
namespace Dias.Cinco
{
    public class Ejercicios
    {
        public void ConvertirCadenasToStringYNumero()
        {
            int first = 5;
            int second = 7;
            string message = $"({first.ToString()}  {second.ToString()}";
            Console.WriteLine(message);

            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);
        }

        public void ConvertirIntToDecimal()
        {
            int value = (int)1.5m;  // casting truncates
            Console.WriteLine(value);

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);

            value2 = Convert.ToInt32(1.4m);     // converting round down
            Console.WriteLine(value2);
        }

        public void ConvertirStringToIntControlError()
        {
            string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            // Since it is defined outside of the if statement, 
            // it can be accessed later in your code.
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");
        }

        public void DesafioConversionTipo()
        {
            //Data una matrix "12.3", "45", "ABC", "11", "DEF",
            //Agregue el código necesario para implementar las siguientes reglas de negocio:
            //Reglas de negocio:
            //Regla 1: si el valor es alfanumérico, concaténelo para formar un mensaje.
            //Regla 2: si el valor es numérico, súmelo al total.
            //Regla 3: asegúrese de que el resultado coincide con la siguiente salida:
            //Message: ABCDEF
            //Total: 68.3

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }

        public void DesafioConversionTipoII()
        {
            // Dado los siguientes valores
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;
            // Al ejecutar el código deberá ver los siguientes resultados:
            // Divide value1 by value2, display the result as an int: 1
            // Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
            // Divide value3 by value1, display the result as a float: 0.3583333

            // Your code here to set result1
            int result1 = (int)((decimal)value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }

        public void CrearMatricesYOrdenarlas()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));
            /*foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }*/
        }

        public void CrearMatricesYOrdenarlasDereves()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));
            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));
        }

        public void QuitarElementosDeUnaMatriz()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");
            Console.WriteLine($"Before: {(pallets[0] == null ? "En blanco" : pallets[0].ToLower())}");
            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"After: {(pallets[0] == null ? "En blanco" : pallets[0].ToLower())}");
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));
        }

        public void AnyadirElementosAUnaMatriz()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));

            Console.WriteLine($"Updating Positions 1 and 23 ... and listing, count: {pallets.Length}");
            pallets[0] = "C00";
            pallets[1] = "CAA";
            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));

            Console.WriteLine("Decresing ...");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            Array.ForEach(pallets, pallet => Console.WriteLine($"-- {pallet}"));

        }

        public void MasOrdenacionesCambiarTamanyoYConversionesDeMatrices()
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Console.WriteLine("El valor de valueArray");
            Array.ForEach(valueArray, value1 => Console.Write(value1));
            Array.Reverse(valueArray);
            Console.WriteLine();
            Console.WriteLine("Despues de darle la vuelta:");
            Console.WriteLine(valueArray);
            Array.Resize(ref valueArray, 8);
            valueArray[6] = 'W';
            valueArray[7] = 'P';
            Array.Sort(valueArray);
            Console.WriteLine("Despues del Resize y de insertar 2 posiciones y un sort:");
            Console.WriteLine(valueArray);

            char[] valueReverse = value.ToCharArray();
            Array.Reverse(valueReverse);
            Console.WriteLine("Despues de volver a reves el valueReverse:");
            Array.ForEach(valueReverse, valueR => Console.Write(valueR));
            Console.WriteLine();
            Console.WriteLine($"El valor de value:{value}");
            value = String.Empty;
            Array.ForEach(valueReverse, valueR => value += valueR);
            Console.WriteLine($"El valor de value, después del revés:{value}");

            Console.WriteLine("\nnuevo a partir de una nueva variable tipo string: Resultado");
            string result = new string(valueArray);
            Console.WriteLine(result);
        }

        public void DividirYUnirMatrices()
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Console.WriteLine("El valor de valueArray");
            Array.ForEach(valueArray, value1 => Console.Write(value1));
            Array.Reverse(valueArray);

            Console.WriteLine("\nnuevo a partir de una nueva variable tipo string: result");
            string result = new string(valueArray);
            Console.WriteLine(result);
            // Imprime la cadena separada por comas!!
            result = String.Join(",", valueArray);
            Console.WriteLine("El contenido de la variable result separado por comas:", result);

            string[] items = result.Split(',');
            Array.ForEach(items, item => Console.WriteLine(item));
        }

        public void DesafioInversionPalabras()
        {
            //Invertir cada palabra de un mensaje
            string pangram = "The quick brown fox jumps over the lazy dog";
            // Resultado: 
            // ehT kciuq nworb xof spmuj revo eht yzal god

            string[] palabras = pangram.Split(' ');
            Array.ForEach(palabras, palabra =>
            {
                Console.Write(" ");
                char[] palinv = palabra.ToCharArray();
                Array.Reverse(palinv);
                Array.ForEach(palinv, pal => Console.Write(pal));
            });

        }

        public void DesafioBusquedaPatronMatriz()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            // Your code here
            Array.ForEach(orderStream.Split(','), order =>
            {
                if (order.StartsWith("B"))
                    Console.WriteLine(order);
            });
        }

        public void UsodeIndexOfIndexAnyLastIndexOF()
        {
            //Escritura de código para buscar un paréntesis de apertura y cierre insertado en una cadena
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            //Adición de código para recuperar el valor entre dos caracteres de paréntesis
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition + 1, length - 1));

            //Actualización del código para modificar la posición inicial de la subcadena
            openingPosition += 1;

            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            //Buscando entre tags IndexOf
            message = "What is the value <span>between the tags</span>?";
            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            openingPosition = message.IndexOf(openSpan);
            closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            //Recuperar la última repetición de una subcadena LastIndexOf
            message = "(What if) I am (only interested) in the last (set of parentheses)?";
            openingPosition = message.LastIndexOf('(');

            openingPosition += 1;
            closingPosition = message.LastIndexOf(')');
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            //Recuperar cualquier valor entre uno o más conjuntos de paréntesis en una cadena
            message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                closingPosition = message.IndexOf(')');
                length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note how we use the overload of Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }

            // Trabajar con distintos tipos de conjuntos de símbolos
            message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters 
            // we want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // We'll use a slightly different technique for iterating through the 
            // characters in the string.  This time, we'll use the closing position
            // of the previous iteration as the starting index for the next open
            // symbol.  So, we need to initialize the closingPosition variable
            // to zero:

            closingPosition = 0;

            while (true)
            {
                openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now we must find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // Finally, use the techniques we've already learned to display the sub-string:

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));
            }


        }

        public void UsoDeRemoveYReplace()
        {
            //Quitar caracteres en ubicaciones específicas de una cadena
            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 19);
            Console.WriteLine(updatedData);

            //Quitar caracteres, independientemente de dónde aparezcan en una cadena
            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);

        }

        public void DesafioExtraerDatosReemplazarlosYQuitarlosDeUnaCadenaDeEntrada()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = string.Empty;
            string output = string.Empty;

            // Your work here
            // Primer resultado:
            //Quantity: 5000
            //Mensaje:<div><h2>Widgets &trade;</h2><span>5000</span></div>
            //Output:      <h2>Widgets &reg;  </h2><span>5000</span>
            quantity = "5000";
            output = input.Replace("div", string.Empty);

            output = output.Replace("<>", string.Empty);
            output = output.Replace("</>", string.Empty);
            output = output.Replace("&trade", "&reg");

            Console.WriteLine(quantity);
            Console.WriteLine(output);

        }

        public void AplicacionFormatoCadena()
        {
            string first = "Hello";
            string second = "World";
            //Formato compuesto: 
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}!", first, second));
            //Formato con interpolación de cadenas s
            Console.WriteLine($"{first} {second}!");

            //Aplicación de formato a valores de moneda
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");
            //Formato de separador de decimales
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");
            Console.WriteLine($"Measurement: {measurement:N4} units");
            //Formato de porcentaje
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");

            // Representación del número de factura mediante la interpolación de cadenas
            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");

            //Representación de la medida del producto en miligramos
            Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");

            //Subtotal que se cobrará al cliente con formato de moneda
            Console.WriteLine($"     Sub Total: {subtotal:C}");

            //Representación del impuesto aplicado a la venta con formato de porcentaje
            Console.WriteLine($"           Tax: {taxPercentage:P2}");

            //Finalización del recibo con el importe total debido con formato de moneda.
            Console.WriteLine($"     Total Due: {total:C}");

        }

        public void RellenoYAliniacion()
        {
            // Metodos auxiliares del tipo String:
            // Métodos que agregan espacios en blanco para fines de formato (PadLeft(), PadRight())
            // Métodos que comparan dos cadenas o facilitan la comparación (Trim(), TrimStart(), TrimEnd(), GetHashcode(), la propiedad Length)
            // Métodos que ayudan a determinar lo que está dentro de una cadena, o incluso a recuperar solo una parte de la cadena (Contains(), StartsWith(), EndsWith(), Substring())
            // Métodos que cambian el contenido de la cadena mediante el reemplazo, la inserción o la eliminación de elementos (Replace(), Insert(), Remove())
            // Métodos que convierten una cadena en una matriz de cadenas o caracteres (Split(), ToCharArray())

            string input = "Pad this";
            //Espcios a la izquierda
            Console.WriteLine($"\"{input.PadLeft(12)}\"");
            //Espacios a la derecha
            Console.WriteLine($"\"{input.PadRight(12)}\"");

            // Relleno de caracteres a la izquierda y a la derecha
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            // Adición de OrderId a la salida
            Console.WriteLine(new String('*', 80));
            Console.WriteLine("1234567890123456789012345678901234567890");
            string paymentId = "769";
            var formattedLine = paymentId.PadRight(6);
            Console.WriteLine(formattedLine);
            //Adición del nombre del beneficiario a la salida
            string payeeName = "Mr. Stephen Ortega";
            formattedLine += payeeName.PadRight(24);
            Console.WriteLine(formattedLine);

            //Adición del importe del pago a la salida
            string paymentAmount = "$5,000.00";
            formattedLine += paymentAmount.PadLeft(10);
            Console.WriteLine(formattedLine);

        }

        public void DesafioFormatoDatosAlfanumericos()
        {
            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            Console.WriteLine($"Dear {customerName},\n");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
            Console.WriteLine($"\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P}.");
            Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:p}.Given your current volume, your potential profit would be {newProfit:C}.");
            Console.WriteLine("Here's a quick comparison:\n");
            string comparrisonMessage = "";

            // Your logic here
            comparrisonMessage = $"\n{currentProduct.PadRight(20)} {currentReturn:P}\t{currentProfit:C}";
            comparrisonMessage += $"\n{newProduct.PadRight(20)} {newReturn:p}\t{newProfit:C}";


            Console.WriteLine(comparrisonMessage);
        }

    }

}
static class ejercicioStatic
{
    public static void primero()
    {

    }
    static void segundo()
    {

    }
}

public class Igual
{

}
