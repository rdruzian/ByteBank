﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteExcepetion : Exception
    {
        public SaldoInsuficienteExcepetion()  { }
        public SaldoInsuficienteExcepetion(string message) : base(message) { }
    }
}
