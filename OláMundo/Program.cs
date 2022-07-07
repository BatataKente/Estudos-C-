// See https://aka.ms/new-console-template for more information
using System;

//##### AULA 1 e 2

//namespace OlaMundo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int numero = 2;

//            string palavra = "oi";

//            Console.WriteLine(numero);

//            bool validade = true;
//            float secondNumber = 3;
//            double thirdNumber = 4;
//            decimal fourthNumber = 5;
//            char letra = 'A';

//Console.WriteLine("Olá, World!");
//Console.WriteLine("Hello, Mundo!");

//int number = 10;

//string hello = "Olá";
//string world = "Mundo";
//string space = " ";

//Console.WriteLine(hello + space + world);
//Console.WriteLine(number);
//        }
//    }
//}

//##### AULA 3

//namespace OlaMundo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string letras = "10";
//            string outrasLetras = "cd";
//            int numbero = 10;
//            double numerozao = 20.9;

//            DateTime data;

//            var palavra = "borboleta";

//            int numbro = numbero + int.Parse(letras);
//            int numeroNovo = (int)(numbero + numerozao);

//            Console.WriteLine(numeroNovo);
//        }
//    }
//}

//##### AULA 4

namespace OlaMundo
{
    internal class program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            do
            {
                Console.WriteLine("Qual é o seu veículo? Digite (C) para carro e (M) para moto.");
                string veiculo = Console.ReadLine();

                Console.WriteLine("Quantas horas você dedixará o seu veículo?");
                string horas = Console.ReadLine();

                //if (veiculo == "C" || veiculo == "c")
                //{
                //    valor = 15 * int.Parse(horas);
                //}
                //else if (veiculo == "M" || veiculo == "m")
                //{
                //    valor = 10 * Int16.Parse(horas);
                //}
                //else
                //{
                //    Console.WriteLine("Você digitou um valor inválido.\n");
                //}
                switch (veiculo)
                {
                    case "c":

                        valor = 15 * int.Parse(horas);

                    break; case "C":

                        valor = 15 * int.Parse(horas);

                    break; case "m":

                        valor = 10 * Int16.Parse(horas);

                    break; case "M":

                        valor = 10 * Int16.Parse(horas);

                    break; default:

                        Console.WriteLine("Você digitou um valor inválido.\n");

                    break;
                }
            }
            while (valor == 0);
            //if (veiculo == "M" || veiculo == "m")
            //{
            //    valor = 10 * Int32.Parse(horas);
            //}
            //else
            //{
            //    valor = 5 * int.Parse(horas);
            //}

            Console.WriteLine(valor);
        }
    }
}