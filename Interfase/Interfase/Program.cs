using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Program
    {
        static void Main(string[] args)
        {

            Operaciones Op = new Operaciones();
            Op.Pesos = 150;
            Op.Dolares = 300;
            Menu();


            void Menu()
            {
                Console.WriteLine("Bienvenido a la mejor calculadora del mundo");


                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1.-Dolares a Pesos\n2.-Pesos a Dolares\n3-Salir");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("El resultado de dolares a pesos es: " + Op.DolaresaPesos());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();

                        break;
                    case "2":
                        Console.WriteLine("El resultado de pesos a dolares: " + Op.PesosaDolres());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;


                    case "3":
                        Console.WriteLine("bye bye");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}
