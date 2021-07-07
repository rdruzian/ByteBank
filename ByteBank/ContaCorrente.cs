// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                // Criando uma exceção nova
                // throw new ArgumentException("Agênci e número devem ser maior que 0");
                // Criando uma exceção de argumento, com isso fica mais claro que o problema é com o argumento passado
                throw new ArgumentException("Agência deve ser maior que 0.", nameof(agencia));
            }
            if (numero <= 0)
            {
                // Criando uma exceção nova
                // throw new ArgumentException("Agênci e número devem ser maior que 0");
                // Criando uma exceção de argumento, com isso fica mais claro que o problema é com o argumento passado
                // Adicionado o valor de ParamName, deixando mais simples de identifcar qual o arqgumento está com problema
                throw new ArgumentException("Número deve ser maior que 0.", nameof(agencia));
            }
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteExcepetion();
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            this.Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
