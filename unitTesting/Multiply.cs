using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting.Implementation
{
    public class Multiply
    {
        private List<int> _answers = new List<int>();
        
        public int MultiplyIntegers(int firstNumber, int secondNumber)
        {
            var answer = firstNumber * secondNumber;
            _answers.Add(answer);
            return answer;
        }

        public List<int> Answers()
        {
            return _answers;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
