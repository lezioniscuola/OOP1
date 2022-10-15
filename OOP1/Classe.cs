using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Classe
    {
        //attributi
        private int Numero;
        //property
        public int numero
        {
            get { return Numero; }
            set { Numero = value; }

        }
        //costruttori
        public Classe()
        {
            Numero = 0;
        }
        //metodi accessor
        /*public int getNumero()
        {
            return Numero;
        }
        public void setNumero(int n)
        {
            Numero = n;    
        }
        */
    }
}
