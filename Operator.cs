using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._13_
{
    internal class Operator
    {
        int operandus1, operandus2;
        string opertaor;

        public Operator(int operandus1, int operandus2, string opertaor)
        {
            this.operandus1 = operandus1;
            this.operandus2 = operandus2;
            this.opertaor = opertaor;
        }

        public int Operandus1 { get => operandus1; set => operandus1 = value; }
        public int Operandus2 { get => operandus2; set => operandus2 = value; }
        public string Opertaor { get => opertaor; set => opertaor = value; }

        
    }
}
