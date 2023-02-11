using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab02
{
    [Serializable]
    public abstract class IAccount
    {
        public long Id { get; set; }
        public string TypeOfDeposit { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpeningDate { get; set; }
        public bool SmsAlerts { get; set; }
    }
    [Serializable]
    public class Account : IAccount 
    {
        
    }

}
