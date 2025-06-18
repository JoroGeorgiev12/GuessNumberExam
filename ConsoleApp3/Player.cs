using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Player
    {
        public int AttemptsLeft { get; private set; } = 5;

        public void ReduceAttempts()
        {
            AttemptsLeft--;
        }

        public bool HasAttempts()
        {
            return AttemptsLeft > 0;
        }
    }

}
