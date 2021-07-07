using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteExcepetion : OperacaoFinanceiraException
    {
        public SaldoInsuficienteExcepetion()  { }
        public SaldoInsuficienteExcepetion(string message) : base(message) { }
        public SaldoInsuficienteExcepetion(string message, Exception excecaoInterna) : base(message, excecaoInterna) { }
    }
}
