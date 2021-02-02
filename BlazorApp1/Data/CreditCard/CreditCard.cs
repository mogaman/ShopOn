using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.CreditCard
{
    public class CreditCard
    {
        public int userID { get; set; }
        public long cardNumber { get; set; }
        public string cardName { get; set; }
        public int cardExpireMonth { get; set; }
        public int cardExpireYear { get; set; }
        public int cardCVV { get; set; }
    }
}
