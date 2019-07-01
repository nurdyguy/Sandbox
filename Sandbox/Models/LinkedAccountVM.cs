using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox.Models
{
    public class LinkedAccountVM
    {
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public VerificationStage VerificationStage { get; set; }

        public IEnumerable<RecurringTransferVM> RecurringTransfers { get; set; }
        public IEnumerable<TransferVM> Transfers { get; set; }
    }

    public class RecurringTransferVM
    {
        public TransferFrequence Frequency { get; set; }
        public string ExternalAccountName { get; set; }
        public string InternalAccountName { get; set; }
        public bool IsDebit { get; set; }
        public double Ammount { get; set; }
    }

    public class TransferVM
    {
        public DateTime TransferDate { get; set; }
        public string ExternalAccountName { get; set; }
        public string InternalAccountName { get; set; }
        public bool IsDebit { get; set; }
        public double Ammount { get; set; }
    }

    public enum VerificationStage
    {
        Verified = 0,
        InProcess = 1,
        Invalid = 2
    }

    public enum TransferFrequence
    {
        Daily = 0,
        Weekly = 1,
        Biweekly = 2,
        Monthly = 3,
        Bimonthly = 4,
        Quarterly = 5,
        Annually = 6
    }
}
