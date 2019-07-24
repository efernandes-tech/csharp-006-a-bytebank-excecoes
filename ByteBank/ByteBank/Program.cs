using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ContaCorrente conta = new ContaCorrente(867, 86712540);

            // conta.Agencia = 867;
            conta.Numero = 86712540;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();*/

            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine("Exceção tratada.");
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
