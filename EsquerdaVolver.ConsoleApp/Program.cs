using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de comandos: ");
            int numeroDeComandos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os comandos: ");
            var comandos = Console.ReadLine().ToUpper();
            char[] serieDeComandos = comandos.ToCharArray();

            var bussola = 'N';
            
            for (int i = 0; i < serieDeComandos.Length; i++)
            {
                var instrucao = serieDeComandos[i];

                if (instrucao != 'D' && instrucao != 'E')
                {
                    Console.WriteLine("Instrução inválida");
                }
                                              
                if (instrucao  == 'D')
                {
                    if (bussola == 'N')
                    {
                        bussola = 'L';
                    }
                    else if (bussola == 'L')
                    {
                        bussola = 'S';
                    }
                    else if (bussola == 'S')
                    {
                        bussola = 'O';
                    }
                    else if (bussola == 'O')
                    {
                        bussola = 'N';
                    }
                }

                else if (instrucao == 'E')
                {
                    if (bussola == 'N')
                    {
                        bussola = 'O';
                    }
                    else if (bussola == 'O')
                    {
                        bussola = 'S';
                    }
                    else if (bussola == 'S')
                    {
                        bussola = 'L';
                    }
                    else if (bussola == 'L')
                    {
                        bussola = 'N';
                    }
                }
            }
            Console.WriteLine(bussola);
            Console.ReadLine();
        }
    }
}
