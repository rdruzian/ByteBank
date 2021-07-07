using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Metodo();
                ContaCorrente conta = new ContaCorrente(1, 1);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stack de erro");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }

            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);

                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensagem de erro interna do .Net");
                Console.WriteLine(e.Message);
                Console.WriteLine("Stack de erro");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por 0!");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor = " + divisor);
                // throw retorna a exceção para frente, indicando que houve um exceção, não sendo necessário criar código de erro
                throw;
            }
        }
    }
}
