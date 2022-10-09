using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Classe
    {
        private int Numero;
        public Classe()
        {
            Numero = 0;
        }
        public int getNumero()
        {
            return Numero;
        }
        public void setNumero(int n)
        {
            Numero = n;    
        }
    }
}
