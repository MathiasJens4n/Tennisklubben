using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Tennisklubben
{
    public class Validator
    {
        string creditCard;
        char lastNumber;
        public void ValidateCreditCard(string creditCard)
        {
            this.creditCard = creditCard;

            GetLastNumber();

            RemoveLastNumber();

            ReverseNumber();
        }
        private void GetLastNumber()
        {
            lastNumber = creditCard[creditCard.Length - 1];
            
        }
        private void RemoveLastNumber()
        {
            creditCard = creditCard.Remove(creditCard.Length - 1);
            
        }
        private void ReverseNumber()
        {
            char[] charArray = creditCard.ToCharArray();
            Array.Reverse(charArray);
            creditCard = charArray.ToString();
        }
    }
}