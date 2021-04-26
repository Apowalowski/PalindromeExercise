using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string myString )
        {
            return myString.SequenceEqual(myString.Reverse());
        }
    }
}
