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
            Random temp = new Random();
            _number = temp.Next(1, 101);

            _count = 0;
        }

        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == _number)
            {
                Console.WriteLine("Rätt!");
                return true;
            }
            else if (number < _number)
            {
                Console.WriteLine("För litet!");
                _count++;
                return false;
            }
            else if (number > _number)
            {
                Console.WriteLine("För stort!");
                _count++;
                return false;
            }
            return false; 
            
        }
        public SecretNumber()
        {
            Initialize();
        }
    }
}
