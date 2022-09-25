using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PottencialPratice.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser negativo");
                }
                else
                {
                    _nome = value;
                }


            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O Número tem que ser maior que 0");
                }
                else
                {
                    _idade = value;
                }

            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"{Nome}{Idade}");
        }
    }
}