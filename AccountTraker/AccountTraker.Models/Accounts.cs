using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTraker.Models
{
    public class ScheduledPayment
    {
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string Schedule { get; set; }
        public string PayDay { get; set; }
        public int Ammount { get; set; }
    }

    public class Payment
    {
        public string Type { get; set; }
        public int Ammount { get; set; }
        public string Description { get; set; } 
    }

    public class PaymentDate
    {
        public string DateID { get; set; }
        public string PrevDate { get; set; }
        public string NextDate { get; set; }
        public string Date { get; set; }
        public int StartBalance { get; set; }
        public int EndBalance { get; set; }
        public List<Payment> Payments { get; set; }
    }

    public class Account
    {
        public string AccountName { get; set; }
        public List<ScheduledPayment> ScheduledPayments { get; set; }
        public List<PaymentDate> PaymentDates { get; set; }
    }

    public class AccountsJsonModel
    {
        public List<Account> Accounts { get; set; }
    }
}
