using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        private int _count;
        private int _number;

        public const int MaxNumberOfGuesses = 7;


        public void Initialize()
        {
            _count = 0;
        }

        public bool MakeGuess(int number)
        {
            return true;
        }

        public SecretNumber()
        {

        }
    }
}
